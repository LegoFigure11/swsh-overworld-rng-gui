using System;
using System.Threading;
using static SysBot.Base.SwitchOffsetType;

namespace SysBot.Base
{
    /// <summary>
    /// Connection to a Nintendo Switch hosting the sys-module via a socket (WiFi).
    /// </summary>
    /// <remarks>
    /// Interactions are performed synchronously.
    /// </remarks>
    public sealed class SwitchSocketSync : SwitchSocket, ISwitchConnectionSync
    {
        public SwitchSocketSync(IWirelessConnectionConfig cfg) : base(cfg) { }

        public override void Connect(string ip)
        {
            Connection.Connect(ip, Info.Port);
            Connected = true;
        }

        public override void Reset()
        {
            Disconnect();
        }

        public override void Disconnect()
        {
            Connection.Disconnect(false);
            Connected = false;
        }

        private int Read(byte[] buffer) => Connection.Receive(buffer);
        public int Send(byte[] buffer) => Connection.Send(buffer);

        private byte[] ReadResponse(int length)
        {
            // give it time to push data back
            Thread.Sleep((MaximumTransferSize / DelayFactor) + BaseDelay);
            var buffer = new byte[(length * 2) + 1];
            var _ = Read(buffer);
            return Decoder.ConvertHexByteStringToBytes(buffer);
        }

        public byte[] ReadBytes(uint offset, int length) => Read(offset, length, Heap);
        public byte[] ReadBytesMain(ulong offset, int length) => Read(offset, length, Main);
        public byte[] ReadBytesAbsolute(ulong offset, int length) => Read(offset, length, Absolute);

        private byte[] Read(ulong offset, int length, SwitchOffsetType type)
        {
            var method = type.GetReadMethod();
            if (length <= MaximumTransferSize)
            {
                var cmd = method(offset, length);
                Send(cmd);
                return ReadResponse(length);
            }

            byte[] result = new byte[length];
            for (int i = 0; i < length; i += MaximumTransferSize)
            {
                int len = MaximumTransferSize;
                int delta = length - i;
                if (delta < MaximumTransferSize)
                    len = delta;

                var cmd = method(offset + (uint)i, len);
                Send(cmd);
                var bytes = ReadResponse(len);
                bytes.CopyTo(result, i);
            }
            return result;
        }

        ulong ISwitchConnectionSync.GetMainNsoBase()
        {
            throw new NotImplementedException();
        }

        ulong ISwitchConnectionSync.GetHeapBase()
        {
            throw new NotImplementedException();
        }

        void ISwitchConnectionSync.WriteBytesMain(byte[] data, ulong offset)
        {
            throw new NotImplementedException();
        }

        void ISwitchConnectionSync.WriteBytesAbsolute(byte[] data, ulong offset)
        {
            throw new NotImplementedException();
        }

        void IConsoleConnectionSync.WriteBytes(byte[] data, uint offset)
        {
            throw new NotImplementedException();
        }
    }
}
