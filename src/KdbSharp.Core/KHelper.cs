using System;
using System.Collections.Generic;
using System.Text;

namespace KdbSharp.Core
{
    public static class KHelper
    {
        public const long TicksPerDay = 864_000_000_000L;
        public const int DaysFromEraToMillenium = 730119;
        public const long TicksFromEraToMillenium = TicksPerDay * DaysFromEraToMillenium;
        public const string EndOfText = "\x3";
        public const int DefaultMaxBufferSize = 65536;

        public static readonly byte[] SequentialGuidIndex = { 3, 2, 1, 0, 5, 4, 7, 6, 8, 9, 10, 11, 12, 13, 14, 15 };

        public static readonly Encoding AsciiEncoding = Encoding.ASCII;

        public static readonly DateTime MinimumDateTime = DateTime.MinValue.AddTicks(1);
        public static readonly DateTime MaximumDateTime = DateTime.MaxValue;
    }
}
