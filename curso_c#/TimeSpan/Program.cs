namespace AulaTimeSpan;
class Program
{
    static void Main(string[] args)
    {
        TimeSpan ts1 = new TimeSpan(0, 1, 30);
        Console.WriteLine(ts1); 
        Console.WriteLine(ts1.Ticks);
        long a = ts1.Ticks;

        TimeSpan ts2 = new TimeSpan();
        TimeSpan ts3 = new TimeSpan(a);

        Console.WriteLine($"{ts2}\n{ts3}");


        TimeSpan ts4 = new TimeSpan(1, 2, 11, 21);
        Console.WriteLine(ts4);
        

        TimeSpan ts5 = new TimeSpan(1, 2, 11, 21, 321);

        TimeSpan ts6 = TimeSpan.FromDays(1.5);
        Console.WriteLine(ts6);

        TimeSpan ts7 = TimeSpan.FromHours(1.5);
        Console.WriteLine(ts7);

        TimeSpan ts8 = TimeSpan.FromMinutes(1.5);
        Console.WriteLine(ts8);

        TimeSpan ts9 = TimeSpan.FromMilliseconds(1.5);
        Console.WriteLine(ts9);

        TimeSpan ts10 = TimeSpan.FromTicks(900000000L);
        Console.WriteLine(ts10);
        
        
    }
}
