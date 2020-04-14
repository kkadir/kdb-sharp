using System;
using System.Collections.Generic;
using System.Text;

namespace KdbSharp.Core.Type
{
    /// <summary>
    /// Implements KDB+/Q data types.
    /// <para>See https://code.kx.com/q/basics/datatypes/ </para>
    /// <para>See https://code.kx.com/q/interfaces/capiref/ </para>
    /// <para>
    /// Please note that not all data types are included as this library intends to communicate with a server at
    /// highest-level possible.
    /// </para>
    /// </summary>
    public static class KType
    {
        public const int KError = -128;

        public const int KBool = -1;
        public const int KGuid = -2;
        public const int KByte = -4;
        public const int KShort = -5;
        public const int KInt = -6;
        public const int KLong = -7;
        public const int KReal = -8;
        public const int KFloat = -9;
        public const int KChar = -10;
        public const int KSymbol = -11;
        public const int KTimeStamp = -12;
        public const int KMonth = -13;
        public const int KDate = -14;
        public const int KDateTime = -15;
        public const int KTimeSpan = -16;
        public const int KMinute = -17;
        public const int KSecond = -18;
        public const int KTime = -19;

        public const int KList = 0;
        public const int KBoolList = 1;
        public const int KGuidList = 2;
        public const int KByteList = 4;
        public const int KShortList = 5;
        public const int KIntList = 6;
        public const int KLongList = 7;
        public const int KRealList = 8;
        public const int KFloatList = 9;
        public const int KCharList = 10;
        public const int KSymbolList = 11;
        public const int KTimeStampList = 12;
        public const int KMonthList = 13;
        public const int KDateList = 14;
        public const int KDateTimeList = 15;
        public const int KTimeSpanList = 16;
        public const int KMinuteList = 17;
        public const int KSecondList = 18;
        public const int KTimeList = 19;

        public const int KTable = 98;
        public const int KDictionary = 99;

        public const int KUnaryPrimitive = 101;
    }
}
