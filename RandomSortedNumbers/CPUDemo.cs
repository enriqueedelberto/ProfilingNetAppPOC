using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSortedNumbers
{
    public class CPUDemo
    {
        static async Task Main(string[] args)
        {
            Task[] timers = new Task[10];
            for (int i = 0; i < timers.Length; i++)
            {
                int j = i;
                timers[j] = Task.Run(() => BadTimer(j+1));
            }
            foreach (Task task in timers)
            {
                task.Start();
            }
            await Task.WhenAll(timers);
            Console.WriteLine("Timer has finished");

        }

        private static void BadTimer(int seconds)
        {
            Console.WriteLine("Timer for {0} seconds started", seconds);
            TimeSpan AmountOfTime = new TimeSpan(0, 0, seconds);
            DateTime startTime = DateTime.Now;
            DateTime nowTime = DateTime.Now;

            while (nowTime - startTime <AmountOfTime)
            {
                nowTime = DateTime.Now;
            }
            Console.WriteLine("Timer for {0} seconds ended", seconds);
        }

        private static void BadTimerAsync(int seconds)
        {

        }
    }
}
