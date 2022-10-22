using System;

internal class Pet : ICheckPet
{
    private string _petname = "None";
    private int _day = 0;
    private int _mounth = 0;
    private int _year = 0;

    public Pet(string pet, int day,int mounth,int year)
    {
        PetName = pet;
        Day = day;
        Month = mounth;
        Year = year;
    }

    public string PetName
    {
        get
        {
            return _petname;
        }

        set
        {
            if(_petname.Length <3)
            {
                throw new Exception("The Pet Name must be longer than 3 characters");
            }
            _petname = value;
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
            if(value <0 || value > 31)
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
            return _mounth;
        }
        set
        {
            if(value <0 || value >= 12)
            {
                throw new Exception("Enter a month from the 1st to the 12th");
            }
            _mounth = value;
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