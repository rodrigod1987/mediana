using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediana
{
    /// <summary>
    /// MedianCalculator shows the median number in a set
    /// </summary>
    public class MedianCalculator : IMedianCalculator
    {
        public MedianCalculator(IList<long> numbers)
        {
            Numbers = numbers;
        }

        /// <summary>
        /// The numbers used to create this instance.
        /// </summary>
        public IList<long> Numbers { get; private set; }

        public void Dispose()
        {
        }

        /// <summary>
        /// Calculates find and calculate the median of set.
        /// </summary>
        /// <returns>Median</returns>
        public decimal FindMedian()
        {
            var sorted = Sort();
            var total = sorted.Count;
            var division = sorted.Count / 2;
            var meadle = (int)division;

            var isOdd = total % 2 != 0;
            if (isOdd)
            {
                return sorted[meadle];
            }

            decimal sum = sorted[meadle] + sorted[meadle - 1];
            return sum / 2;
        }

        /// <summary>
        /// The string that represents the set separetad by a comma
        /// </summary>
        /// <returns></returns>
        public string ShowNumbers()
        {
            return string.Join(',', Sort());
        }

        private IList<long> Sort()
        {
            var list = Numbers.ToList();
            list.Sort();
            return list;
        }
    }
}
