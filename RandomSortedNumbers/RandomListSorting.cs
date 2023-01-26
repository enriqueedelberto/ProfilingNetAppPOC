using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomSortedNumbers;
using System.Diagnostics;

namespace RandomSortedNumbers
{
    public class RandomListSorting
    {
        private static List<long> CreateRandomNumbers()
        {
            var random = new Random(0);
            var list = new List<long>();

            for (long i = 0; i < 100000000; i++)
            {
                list.Add(random.Next());
            }

            return list;
        }

        public static void ShowProfiling()
        {
            Console.WriteLine("Hello, World!");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            List<long> list =  CreateRandomNumbers();

            TimeSpan createTime = stopwatch.Elapsed;
            stopwatch.Restart();
            list.Sort();

            TimeSpan sortTime = stopwatch.Elapsed;

            double totalTimeTicks = (createTime + sortTime).Ticks;

            Console.WriteLine("CreateList: {0}, {1:P}", createTime, createTime.Ticks / totalTimeTicks);
            Console.WriteLine("Sort:       {0}, {1:P}", sortTime, sortTime.Ticks / totalTimeTicks);
        }
    }


}
