// From https://github.com/berichan/PLAWarper
// AGPL-3.0 License

using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using static SysBot.Base.SwitchOffsetType;

namespace SysBot.Base
{
    /// <summary>
    /// Connection to a Nintendo Switch hosting the sys-module via a socket (WiFi).
    /// </summary>
    /// <remarks>
    /// Interactions are performed asynchronously.
    /// </remarks>
    public sealed class SwitchSocketAsync : SwitchSocket, ISwitchConnectionAsync, IAsyncConnection
    {
        public SwitchSocketAsync(IWirelessConnectionConfig cfg) : base(cfg) { }

        public override void Connect(string ip)
        {
            if (Connected)
            {
                return;
            }

            Connection.Connect(ip, 6000);
            Connected = true;
            Label = Name;
        }

        public override void Disconnect()
        {
            Connection.Shutdown(SocketShutdown.Both);
            Connection.BeginDisconnect(true, DisconnectCallback, Connection);
            Connected = false;
            InitializeSocket();
        }


        public void ConnectCallback(IAsyncResult ar)
        {
            // Complete the connection request.
            Socket client = (Socket)ar.AsyncState;
            client.EndConnect(ar);

            // Signal that the connection is complete.
        }


        public void DisconnectCallback(IAsyncResult ar)
        {
            // Complete the disconnect request.
            Socket client = (Socket)ar.AsyncState;
            client.EndDisconnect(ar);

            // Signal that the disconnect is complete.
        }

        private int Read(byte[] buffer)
        {
            int br = Connection.Receive(buffer, 0, 1, SocketFlags.None);
            while (buffer[br - 1] != (byte)'\n')
                br += Connection.Receive(buffer, br, 1, SocketFlags.None);
            return br;
        }

        /// <summary> Only call this if you are sending small commands. </summary>
        public async Task<int> SendAsync(byte[] buffer, CancellationToken token) => await Task.Run(() => Connection.Send(buffer), token).ConfigureAwait(false);

        private async Task<byte[]> ReadBytesFromCmdAsync(byte[] cmd, int length, CancellationToken token)
        {
            await SendAsync(cmd, token).ConfigureAwait(false);

            var buffer = new byte[(length * 2) + 1];
            var _ = Read(buffer);
            return Decoder.ConvertHexByteStringToBytes(buffer);
        }

        public async Task<byte[]> ReadBytesAsync(uint offset, int length, CancellationToken token) => await Read(offset, length, Heap, token).ConfigureAwait(false);
        public async Task<byte[]> ReadBytesMainAsync(ulong offset, int length, CancellationToken token) => await Read(offset, length, Main, token).ConfigureAwait(false);
        public async Task<byte[]> ReadBytesAbsoluteAsync(ulong offset, int length, CancellationToken token) => await Read(offset, length, Absolute, token).ConfigureAwait(false);

        private async Task<byte[]> Read(ulong offset, int length, SwitchOffsetType type, CancellationToken token)
        {
            var method = type.GetReadMethod();
            if (length <= MaximumTransferSize)
            {
                var cmd = method(offset, length);
                return await ReadBytesFromCmdAsync(cmd, length, token).ConfigureAwait(false);
            }

            byte[] result = new byte[length];
            for (int i = 0; i < length; i += MaximumTransferSize)
            {
                int len = MaximumTransferSize;
                int delta = length - i;
                if (delta < MaximumTransferSize)
                    len = delta;

                var cmd = method(offset + (uint)i, len);
                var bytes = await ReadBytesFromCmdAsync(cmd, len, token).ConfigureAwait(false);
                bytes.CopyTo(result, i);
                await Task.Delay((MaximumTransferSize / DelayFactor) + BaseDelay, token).ConfigureAwait(false);
            }
            return result;
        }

        public async Task<byte[]> ReadRaw(byte[] command, int length, CancellationToken token)
        {
            await SendAsync(command, token).ConfigureAwait(false);
            var buffer = new byte[length];
            var _ = Read(buffer);
            return buffer;
        }

        public async Task SendRaw(byte[] command, CancellationToken token)
        {
            await SendAsync(command, token).ConfigureAwait(false);
        }

        public override void Reset()
        {
            throw new NotImplementedException();
        }

        public Task<ulong> GetMainNsoBaseAsync(CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<ulong> GetHeapBaseAsync(CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetTitleID(CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> PointerPeek(int size, IEnumerable<long> jumps, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task PointerPoke(byte[] data, IEnumerable<long> jumps, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<ulong> PointerAll(IEnumerable<long> jumps, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<ulong> PointerRelative(IEnumerable<long> jumps, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task<byte[]> ISwitchConnectionAsync.ReadBytesMultiAsync(IReadOnlyDictionary<ulong, int> offsetSize, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task<byte[]> ISwitchConnectionAsync.ReadBytesAbsoluteMultiAsync(IReadOnlyDictionary<ulong, int> offsetSize, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task<byte[]> ISwitchConnectionAsync.ReadBytesMainMultiAsync(IReadOnlyDictionary<ulong, int> offsetSize, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task ISwitchConnectionAsync.WriteBytesMainAsync(byte[] data, ulong offset, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task ISwitchConnectionAsync.WriteBytesAbsoluteAsync(byte[] data, ulong offset, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        Task IConsoleConnectionAsync.WriteBytesAsync(byte[] data, uint offset, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}