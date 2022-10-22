using System;

class Control
{
    List<ICheckPeople> people = new List<ICheckPeople>();
    List<ICheckRobot> robots = new List<ICheckRobot>();


    public void PeopleandRobot(string enter)
    {
        string[] data = enter.Split(' ');
        if(data.Length > 1 && data.Length < 3)
        {
            robots.Add(new Robot(data[0], data[1]));
        }
        else if (data.Length >1 && data.Length < 4 )
        {
            people.Add(new People(data[0], Convert.ToInt32(data[1]), data[2]));
        }

    }

    public void ControlPoint()
    {
        foreach(ICheckPeople peoples in people)
        {
            int sum = 0;
            string ID;
            ID = peoples.Id;
            int index = ID.LastIndexOf("000");
            if(ID != null && index == -1)
            {
                Console.WriteLine($"People Id: {peoples.Id}\n");
            }
            else
            {
                Console.WriteLine("This people must be detained \n");
            }

        }

        foreach(ICheckRobot robot in robots)
        {
            string ID;
            ID = robot.Id;
            int index = ID.LastIndexOf("000");
            if(ID != null && (index == -1))
            {
                Console.WriteLine($"Robot Id: {robot.Id} \n");
            }
            else
            {
                Console.WriteLine("This robot must be detained \n");
            }
        }
    }
}