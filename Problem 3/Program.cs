using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari = new Ferrari();
            Console.WriteLine("Enter Name driver:");
            ferrari.Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(ferrari.Information_car());
        }
    }
}
