using System;
using System.IO;
using System.Collections.Generic;
namespace AoC_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = File.ReadAllLines(@"./input.txt");
            var inputText = new List<string>(inputFile);
            List<int> inputNums = inputText.ConvertAll(str => Int32.Parse(str));
            int currentMaxSum, currentSum, nextSum, incCounter = 0;
            for (int i = 0, m = inputNums.Count-4; i <= m; i++)
            {
                currentSum = inputNums[i] + inputNums[i + 1] + inputNums[i + 2];
                nextSum = inputNums[i+1] + inputNums[i + 2] + inputNums[i + 3];
                if (nextSum > currentSum) incCounter++;
                currentMaxSum = Math.Max(nextSum, currentSum);
            }

            Console.WriteLine(incCounter);
        }
    }
}