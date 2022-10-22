using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Numbers = "88444 344333 4343434 343434";
            string Web = "http://softuni.bg http://youtube.com http://www.g00gle.com";
            Telephony numbers = new Telephony();
            numbers.Numbers(Numbers);
            numbers.Web_site(Web);

            Console.ReadLine();
        }
    }
}
