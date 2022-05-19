using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediana
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<long> list = CreateList();
            using (IMedianCalculator median = new MedianCalculator(list))
            {
                Console.WriteLine($"Numeros: {median.ShowNumbers()}");
                Console.WriteLine($"Mediana: {median.FindMedian()}");
            }

            IList<long> oddList = CreateOddList();
            using (IMedianCalculator oddMedian = new MedianCalculator(oddList))
            {
                Console.WriteLine($"Numeros: {oddMedian.ShowNumbers()}");
                Console.WriteLine($"Mediana: {oddMedian.FindMedian()}");
            }

            Console.ReadLine();
        }

        private static IList<long> CreateOddList()
        {
            return new List<long>
            {
                1,2,3,4,5
            };
        }

        private static IList<long> CreateList()
        {
            return new List<long>
            {
                1,2,3,4,5,6
            };
        }
    }
}
