﻿// From https://github.com/berichan/PLAWarper
// AGPL-3.0 License

using System;

namespace SysBot.Base
{
    public static class ArrayUtil
    {
        public static byte[] SliceSafe(this byte[] src, int offset, int length)
        {
            var delta = src.Length - offset;
            if (delta < length)
                length = delta;

            byte[] data = new byte[length];
            Buffer.BlockCopy(src, offset, data, 0, data.Length);
            return data;
        }
    }
}
