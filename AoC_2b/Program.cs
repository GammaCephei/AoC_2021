using System;
using System.IO;

namespace AoC_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int horiz = 0, aim = 0, vert = 0;
            foreach (var line in File.ReadLines(@"./input.txt"))
            {
                var instructions = line.Split(" ");
                var direction = instructions[0];
                int amount = Int32.Parse(instructions[1]);
                switch (direction)
                {
                    case "forward":
                        horiz += amount;
                        vert += amount * aim; 
                        break;
                    case "up":
                        aim -= amount;
                        break;
                    case "down":
                        aim += amount;
                        break;
                }
                
            }
            Console.WriteLine($"{horiz}, {vert}, {horiz*vert}");
        }
    }
}