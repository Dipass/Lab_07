using System;

internal class People : ICheckPeople
{
    private string _name = "None";
    private int _age = 0;
    private string _Id = "None";
    List<People> people = new List<People>();

    public People(string people, int age, string peopleid)
    {
        Name = peopleid;
        Age = age;
        Id=peopleid;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (_name.Length < 3)
            {
                throw new Exception("The name must be longer than 3 characters ");
            }
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
            if (value < 0 || value > 100)
            {
                throw new Exception("Age must be between 0 and 100");
            }
            _age = value;
        }

    }

    public string Id
    {
        get
        {
            return _Id;
        }

        set
        {
            if (_Id.Length < 4 || _Id.Length > 11)
            {
                throw new Exception("ID must be between 4 and 11");
            }
            _Id = value;
        }

    }
}