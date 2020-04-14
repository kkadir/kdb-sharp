using System;

namespace KdbSharp.Core.Type
{
    public interface ITemporalData<T,TUnderlying> : IComparable, IFormattable
        where T: struct, ITemporalData<T, TUnderlying>
    {
        DateTime TemporalValue { get; set; }

        TUnderlying Value { get; set; }
    }
}
