using System;

namespace Problem_6
{
    
    class Program
    { 
        static void Main()
        {
            Birtday birtday = new Birtday();
            string info;
            Console.WriteLine($"If you are a person, enter: Name, age, ID , (Day/Month/Year) when you were born\n" +
            $"If you have a pet, enter: Pet's name, (Day/Month/Year) when it was born \n"+
            $"If you are a robot, enter: Model, ID");
            info = Console.ReadLine();

            while(info != "End")
            {
                birtday.People_Pet_Robot(info);
                Console.WriteLine($"If you are a person, enter: Name, age, ID , (Day/Month/Year) when you were born \n" +
                $"If you have a pet, enter: Pet's name, (Day/Month/Year) when it was born \n" +
                $"If you are a robot, enter: Model, ID \n" +
                $"If there is no one else, enter End");
                info = Console.ReadLine();
            }

            birtday.BirthdayOutput();

            Console.ReadLine();
        }
    }
}

