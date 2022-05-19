using System;
using System.Collections.Generic;

namespace Mediana
{
    public interface IMedianCalculator : IDisposable
    {
        IList<long> Numbers { get; }

        decimal FindMedian();

        string ShowNumbers();
    }
}