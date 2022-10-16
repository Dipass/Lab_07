using System;

class Ferrari : Driver
{
    private string driver;
    public string Name 
    { 
        get { return driver; }
        set
        {
            driver = value;
        } 
    }

   
    public string Type()
    {
        return $"488-Spider";
    }

    public string Brak()
    {
        return $"Brakes!";
    }

    public string Zadu()
    {
        return $"Zadu6avam sA!";
    }
    public string Information_car()
    {
        return $"{Type()}/{Brak()}/{Zadu()}/{Name}";
    }
        
}