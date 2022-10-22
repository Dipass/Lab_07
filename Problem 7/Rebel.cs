using System;

class Rebel : ICheckRebel
{
    private string _name = "None";
    private int _age = 0;
    private string _group = "None";

    public Rebel(string rebel,int age, string groups)
    {
        Name = rebel;
        Age = age;
        Group = groups;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public int Age
    { 
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }

    public string Group
    {
        get
        {
            return _group;
        }
        set
        {
            _group = value;
        }
    }

}