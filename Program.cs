using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgressBar
{
    internal class Program
    {
        static void Main()
        {
            int totalLength = 50;

            int totalTime = 5000;

            int stepTime = totalTime / totalLength;

            for (int i = 0; i <= totalLength; i++)
            {
                int progressPercentage = (i * 100) / totalLength;

                Console.Write("\r[");
                Console.Write(new string('#', i));
                Console.Write(new string('-', totalLength - i));
                Console.Write($"] {progressPercentage}%");

                Thread.Sleep(stepTime);
            }

            Console.WriteLine();
            Console.WriteLine("İşlem tamamlandı!");
        }
    }
}
