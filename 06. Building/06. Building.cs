﻿namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloors = int.Parse(Console.ReadLine());
            int numberOfRooms = int.Parse(Console.ReadLine());

            for (int i = numberOfFloors; i > 0; i--)
            {
                for (int j = 0; j < numberOfRooms; j++)
                {
                    if (numberOfFloors == 1 && numberOfRooms == 1)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i == numberOfFloors)
                    { Console.Write($"L{i}{j} "); }
                    else if (i % 2 == 0)
                    { Console.Write($"O{i}{j} "); }
                    else
                    {
                        Console.Write($"A{i}{j} ");


                    }
                }
                Console.WriteLine();

            }
        }
    }
}