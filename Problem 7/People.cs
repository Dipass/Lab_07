using System;

internal class People : ICheckPeople
{
    private string _name = "None";
    private int _age = 0;
    private string _Id = "None";
    private int _day = 0;
    private int _month = 0;
    private int _year = 0;

    public People(string people, int age, string peopleid, int day, int mounth, int year)
    {
        Name = peopleid;
        Age = age;
        Id = peopleid;
        Day = day;
        Month = mounth;
        Year = year;
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

    public int Day
    {
        get
        {
            return _day;
        }
        set
        {
            if (value < 0 || value > 31)
            {
                throw new Exception("Enter a day from 1 to 31");
            }
            _day = value;
        }
    }

    public int Month
    {
        get
        {
            return _month;
        }
        set
        {
            if (value < 0 || value > 13)
            {
                throw new Exception("Enter a month from the 1st to the 12th");
            }
            _month = value;
        }
    }

    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            _year = value;
        }
    }

}