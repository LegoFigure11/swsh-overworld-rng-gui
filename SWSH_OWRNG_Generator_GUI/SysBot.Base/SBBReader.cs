using SysBot.Base;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using static SysBot.Base.SwitchOffsetType;

namespace SWSH_OWRNG_Generator_GUI
{
    public class SBBReader
    {
        public Socket Connection = new(SocketType.Stream, ProtocolType.Tcp);
        public bool Connected { get; private set; }
        public int MaximumTransferSize { get; set; } = 0x1C0;
        public int BaseDelay { get; set; } = 64;
        public int DelayFactor { get; set; } = 256;

        private int Read(byte[] buffer)
        {
            int br = MainWindow.Connection.Receive(buffer, 0, 1, SocketFlags.None);
            while (buffer[br - 1] != (byte)'\n')
                br += MainWindow.Connection.Receive(buffer, br, 1, SocketFlags.None);
            return br;
        }

        public async Task<int> SendAsync(byte[] buffer) => await Task.Run(() => MainWindow.Connection.Send(buffer)).ConfigureAwait(false);

        private async Task<byte[]> ReadBytesFromCmdAsync(byte[] cmd, int length)
        {
            await SendAsync(cmd).ConfigureAwait(false);

            var buffer = new byte[(length * 2) + 1];
            var _ = Read(buffer);
            return SysBot.Base.Decoder.ConvertHexByteStringToBytes(buffer);
        }
        public async Task<byte[]> ReadBytesAsync(uint offset, int length) => await Read(offset, length, Heap).ConfigureAwait(false);
        public async Task<byte[]> ReadBytesMainAsync(ulong offset, int length) => await Read(offset, length, Main).ConfigureAwait(false);
        public async Task<byte[]> ReadBytesAbsoluteAsync(ulong offset, int length) => await Read(offset, length, Absolute).ConfigureAwait(false);

        private async Task<byte[]> Read(ulong offset, int length, SwitchOffsetType type)
        {
            var method = type.GetReadMethod();
            if (length <= MaximumTransferSize)
            {
                var cmd = method(offset, length);
                return await ReadBytesFromCmdAsync(cmd, length).ConfigureAwait(false);
            }

            byte[] result = new byte[length];
            for (int i = 0; i < length; i += MaximumTransferSize)
            {
                int len = MaximumTransferSize;
                int delta = length - i;
                if (delta < MaximumTransferSize)
                    len = delta;

                var cmd = method(offset + (uint)i, len);
                var bytes = await ReadBytesFromCmdAsync(cmd, len).ConfigureAwait(false);
                bytes.CopyTo(result, i);
                await Task.Delay((MaximumTransferSize / DelayFactor) + BaseDelay).ConfigureAwait(false);
            }
            return result;
        }

        public async Task<byte[]> ReadRaw(byte[] command, int length)
        {
            await SendAsync(command).ConfigureAwait(false);
            var buffer = new byte[length];
            var _ = Read(buffer);
            return buffer;
        }

        public async Task SendRaw(byte[] command)
        {
            await SendAsync(command).ConfigureAwait(false);
        }

        /// <inheritdoc cref="ReadUntilChanged(ulong,byte[],int,int,bool,bool,CancellationToken)"/>
        public async Task<bool> ReadUntilChanged(uint offset, byte[] comparison, int waitms, int waitInterval, bool match) =>
            await ReadUntilChanged(offset, comparison, waitms, waitInterval, match, false).ConfigureAwait(false);

        /// <summary>
        /// Reads an offset until it changes to either match or differ from the comparison value.
        /// </summary>
        /// <returns>If <see cref="match"/> is set to true, then the function returns true when the offset matches the given value.<br>Otherwise, it returns true when the offset no longer matches the given value.</br></returns>
        public async Task<bool> ReadUntilChanged(ulong offset, byte[] comparison, int waitms, int waitInterval, bool match, bool absolute)
        {
            var sw = new Stopwatch();
            sw.Start();
            do
            {
                var task = absolute
                    ? ReadBytesAbsoluteAsync(offset, comparison.Length)
                    : ReadBytesAsync((uint)offset, comparison.Length);
                var result = await task.ConfigureAwait(false);
                if (match == result.SequenceEqual(comparison))
                    return true;

                await Task.Delay(waitInterval).ConfigureAwait(false);
            } while (sw.ElapsedMilliseconds < waitms);
            return false;
        }
    }
}
