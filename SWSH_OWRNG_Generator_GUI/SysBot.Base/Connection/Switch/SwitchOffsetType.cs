﻿using System;

namespace SysBot.Base
{
    /// <summary>
    /// Different offset types that can be pointed to for read/write requests.
    /// </summary>
    public enum SwitchOffsetType
    {
        /// <summary>
        /// Heap base offset
        /// </summary>
        Heap,

        /// <summary>
        /// Main NSO base offset
        /// </summary>
        Main,

        /// <summary>
        /// Raw offset (arbitrary)
        /// </summary>
        Absolute,
    }

    public static class SwitchOffsetTypeExtensions
    {
        /// <summary>
        /// Gets the Peek command encoder for the input <see cref="SwitchOffsetType"/>
        /// </summary>
        /// <param name="type">Offset type</param>
        /// <param name="crlf">Protocol uses CRLF to terminate messages?</param>
        public static Func<ulong, int, byte[]> GetReadMethod(this SwitchOffsetType type, bool crlf = true) => type switch
        {
            SwitchOffsetType.Heap => (o, c) => SwitchCommand.Peek((uint)o, c, crlf),
            SwitchOffsetType.Main => (o, c) => SwitchCommand.PeekMain(o, c, crlf),
            SwitchOffsetType.Absolute => (o, c) => SwitchCommand.PeekAbsolute(o, c, crlf),
            _ => throw new IndexOutOfRangeException("Invalid offset type."),
        };
    }
}
