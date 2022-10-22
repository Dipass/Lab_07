using System;

class Food : IBuyer
{
    List<ICheckPeople> peoples = new List<ICheckPeople>();
    List<ICheckRebel> rebels = new List<ICheckRebel>();
    public int FoodPeople = 0;
    public int FoodRebet = 0;

    public void People_Pet_Robot(string enter)
    {
        string[] data = enter.Split(' ', '/');
        if (data.Length == 3)
        {
            rebels.Add(new Rebel(data[0], Convert.ToInt32(data[1]), data[2]));
            FoodRebet +=10;
        }
        else if (data.Length == 6)
        {
            peoples.Add(new People(data[0], Convert.ToInt32(data[1]), data[2], Convert.ToInt32(data[3]), Convert.ToInt32(data[4]), Convert.ToInt32(data[5])));
            FoodPeople +=5;
        }
    }

    public void BuyFood()
    {
        int AllSum = 0;
        bool compare1,compare2;
        int sum = 0;
        int SumFood = FoodPeople+FoodRebet;
        foreach(ICheckPeople people in peoples)
        {
            foreach(ICheckRebel rebel in rebels)
            {
                //compare1 = people.Name.Equals(rebel.Name);
                //compare2 = rebel.Name.Equals(people.Name);
                AllSum = FoodPeople + FoodRebet;

                if(people.Name == rebel.Name)
                {
                    AllSum -= 5;
                }
                else if(rebel.Name == people.Name)
                {
                    AllSum -= 10;
                }
                //Console.WriteLine("It's compare Food " + AllSum + "\n");
            }
        }
        Console.WriteLine("It's compare Food " + AllSum + "\n");
        //Console.WriteLine($"Food People: {FoodPeople} , Food Rebet: {FoodRebet} and all Food {SumFood}");
    }

}