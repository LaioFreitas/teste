using System;
using System.Globalization;
namespace AulaDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 11, 25);
            Console.WriteLine(d1);
            
            DateTime d2 = new DateTime(2018, 11, 25, 18, 30, 45);
            Console.WriteLine(d2);

            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;   
            DateTime d5 = DateTime.UtcNow;

            Console.WriteLine($"{d3}\n{d4}\n{d5}");

            DateTime d6 = DateTime.Parse("27/12/2001");
            Console.WriteLine(d5); 

            DateTime d7 = DateTime.ParseExact("2001-12-27", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d7);

            DateTime d8 = DateTime.ParseExact("27/12/2001 10:12:33", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.Write(d8);
        }

    }
}