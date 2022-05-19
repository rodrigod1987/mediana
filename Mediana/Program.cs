using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediana
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<long> list = CreateList(6);
            using (IMedianCalculator median = new MedianCalculator(list))
            {
                Console.WriteLine($"Numeros: {median.ShowNumbers()}");
                Console.WriteLine($"Mediana: {median.FindMedian()}");
            }

            IList<long> oddList = CreateList(5);
            using (IMedianCalculator oddMedian = new MedianCalculator(oddList))
            {
                Console.WriteLine($"Numeros: {oddMedian.ShowNumbers()}");
                Console.WriteLine($"Mediana: {oddMedian.FindMedian()}");
            }

            Console.ReadLine();
        }

        private static IList<long> CreateList(int size)
        {
            var list = new List<long>();
            var random = new Random(size);

            for (var i = 0; i < size; i++)
            {
                list.Add(random.Next());
            }

            return list;
        }
    }
}
