using System;

class Citizen : IPerson, IBirthable, IIDentifiable
{
    public string Name { get;}
    public string Id { get;}
    public string Birthday { get; }
    public int Age { get; }
    public Citizen(string name,int age, string id, string date)
    {
        Name=name; 
        Age=age;
        Id=id;
        Birthday=date;
    }
}