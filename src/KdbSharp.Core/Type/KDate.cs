using System;
using System.Globalization;

namespace KdbSharp.Core.Type
{
    public struct KDate : ITemporalData<KDate, int>
    {
        private const string TemporalFormat = "yyyy.MM.dd";

        public KDate(int value)
        {

        }

        public KDate(DateTime temporalValue)
        {

        }

        public KDate(string literal)
        {
            if (DateTime.TryParseExact(
                literal,
                TemporalFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var dateTime))
            {
                new KDate(dateTime);
            }

            new KDate(DateTime.MinValue);
        }

        private KDate(long ticks)
        {

        }

        public DateTime TemporalValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public DateTime ToDateTime()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        public string ToString(string format)
        {
            return ToString(format, CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return ToString(TemporalFormat);
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(KDate left, KDate right) => left.Equals(right);

        public static bool operator !=(KDate left, KDate right) => !(left == right);

        public static bool operator <(KDate left, KDate right) => left.CompareTo(right) < 0;

        public static bool operator <=(KDate left, KDate right) => left.CompareTo(right) <= 0;

        public static bool operator >(KDate left, KDate right) => left.CompareTo(right) > 0;

        public static bool operator >=(KDate left, KDate right) => left.CompareTo(right) >= 0;

        public static implicit operator string(KDate value) => value.ToString();

        public static implicit operator DateTime(KDate value) => value.TemporalValue;

        public static implicit operator int(KDate value) => value.Value;

        public static explicit operator KDate(string value) => new KDate(value);

        public static explicit operator KDate(DateTime value) => new KDate(value);

        public static explicit operator KDate(int value) => new KDate(value);
    }
}
