using System;
using System.IO;

namespace AoC_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentLine = 0, currentMax = 0, increasedCounter  = 0;
            foreach (var n in File.ReadLines(@"../../../input.txt"))
            {
                int currentNum = Int32.Parse(n);
                if (currentLine++ == 0)
                {
                    currentMax = currentNum;
                    continue;
                }

                if (currentNum > currentMax) increasedCounter++;
                currentMax = currentNum;
            }
            Console.Write($"Increased Count:{increasedCounter}");
        }
    }
}