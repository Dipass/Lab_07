using System;

class Birtday
{
    List<ICheckRobot> robots = new List<ICheckRobot>();
    List<ICheckPeople> people = new List<ICheckPeople>();
    List<ICheckPet> pet = new List<ICheckPet>();

    public void People_Pet_Robot(string enter)
    {
        string[] data = enter.Split(' ','/');
        if(data.Length == 2)
        {
            robots.Add(new Robot(data[0],data[1]));
        }
        if (data.Length == 4)
        {
            pet.Add(new Pet(data[0],Convert.ToInt32( data[1]), Convert.ToInt32(data[2]), Convert.ToInt32(data[3])));
        }
        else if (data.Length == 6)
        {
            people.Add(new People(data[0], Convert.ToInt32(data[1]), data[2], Convert.ToInt32(data[3]), Convert.ToInt32(data[4]), Convert.ToInt32(data[5])));
        }

    }

    public void BirthdayOutput()
    {

        foreach (ICheckPeople peoples in people)
        {
            Console.WriteLine($"People birthday: {peoples.Day}/{peoples.Month}/{peoples.Year} \n");
            
        }

        foreach (ICheckPet pets in pet)
        {
            Console.WriteLine($"People birthday: {pets.Day}/{pets.Month}/{pets.Year} \n");
        }
    }
}