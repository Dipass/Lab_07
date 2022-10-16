using System;

namespace Lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: \n");
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name,age);
            Console.WriteLine("People:");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            Console.ReadLine();
        }
    }
}
