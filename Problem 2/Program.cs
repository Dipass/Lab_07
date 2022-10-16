using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Id: ");
            string Id = Console.ReadLine();
            Console.WriteLine("Enter birthday: ");
            string birthday = Console.ReadLine(); 

            IIDentifiable identifiable = new Citizen(Name,Age,Id,birthday);
            IBirthable birthable = new Citizen(Name, Age, Id, birthday);

            Console.WriteLine();
            Console.WriteLine("Output Id and Birthday: ");
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthday);
        }
    }
}
