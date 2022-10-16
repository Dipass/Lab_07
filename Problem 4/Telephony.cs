using System;

class Telephony
{
    public void Numbers(string num)
    {
        string[] num2 = num.Split(' ');
        foreach (string s in num2)
        {
            Console.WriteLine($"Calling... {s}");
        }
    }

    public void Web_site(string web)
    {
        string[] web2 = web.Split(' ');
        foreach (string s in web2)
        {
            Console.WriteLine($"Browsing: {s}!");
        }
    }
}