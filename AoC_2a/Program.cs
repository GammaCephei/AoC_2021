using System;
using System.IO;

namespace AoC_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int horiz = 0, vert = 0;
            foreach (var line in File.ReadLines(@"../../../input.txt"))
            {
                var instructions = line.Split(" ");
                var direction = instructions[0];
                int amount = Int32.Parse(instructions[1]);
                switch (direction)
                {
                    case "forward":
                        horiz += amount;
                        break;
                    case "up":
                        vert -= amount;
                        break;
                    case "down":
                        vert += amount;
                        break;
                }
                
            }
            Console.WriteLine($"{horiz}, {vert}, {horiz*vert}");
        }
    }
}