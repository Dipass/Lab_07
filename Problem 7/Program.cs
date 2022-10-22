using System;

namespace Problem_7
{ 
    class Program
    {
        static void Main()
        {
            Food foodbuy = new Food();
            string Info;
            Console.WriteLine($"If you are a person, enter: Name, age, ID \n" +
                $"If you are a robot, enter: Model, ID");
            Info = Console.ReadLine();
            string[] information = Info.Split(' ');

            while (Info != "End")
            {
                foodbuy.People_Pet_Robot(Info);
                Console.WriteLine($"If you are a person, enter: Name, age, ID \n" +
                $"If you are a robot, enter: Model, ID \n" +
                $"If there is no one else, enter End");
                Info = Console.ReadLine();
            }
            Console.WriteLine();
            foodbuy.BuyFood();


            Console.ReadLine();
        }
    }

}