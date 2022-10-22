using System;



class Program
{
    
    static void Main()
    {
        Control controlpoint = new Control();
        string Info;
        Console.WriteLine($"If you are a person, enter: Name, age, ID \n"+
            $"If you are a robot, enter: Model, ID");
        Info = Console.ReadLine();

        while(Info != "End")
        {
            controlpoint.PeopleandRobot(Info);
            Console.WriteLine($"If you are a person, enter: Name, age, ID \n" +
            $"If you are a robot, enter: Model, ID \n" +
            $"If there is no one else, enter End");
            Info= Console.ReadLine();
        }
        Console.WriteLine();
        controlpoint.ControlPoint();

        Console.ReadLine();
    }
}
