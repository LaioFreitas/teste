namespace AulaDateTimeKind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dt2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dt3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine($"{dt1}\n{dt2}\n{dt3}");

            Console.WriteLine($"d1t: {dt1}");
            Console.WriteLine($"dt1 kind: {dt1.Kind}");
            Console.WriteLine($"dt1 to local: {dt1.ToLocalTime()}");
            Console.WriteLine($"dt1 to UTC: {dt1.ToUniversalTime()}\n\n");

            Console.WriteLine($"d1t: {dt2}");
            Console.WriteLine($"dt1 kind: {dt2.Kind}");
            Console.WriteLine($"dt1 to local: {dt2.ToLocalTime()}");
            Console.WriteLine($"dt1 to UTC: {dt2.ToUniversalTime()}\n\n");

            Console.WriteLine($"d1t: {dt3}");
            Console.WriteLine($"dt1 kind: {dt3.Kind}");
            Console.WriteLine($"dt1 to local: {dt3.ToLocalTime()}");
            Console.WriteLine($"dt1 to UTC: {dt3.ToUniversalTime()}");

            DateTime dt4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dt5 = DateTime.Parse("2000-08-15T13:05:58Z");
            Console.WriteLine(dt5);

            Console.WriteLine();
            Console.WriteLine($"d1t: {dt4}");
            Console.WriteLine($"dt1 kind: {dt4.Kind}");
            Console.WriteLine($"dt1 to local: {dt4.ToLocalTime()}");
            Console.WriteLine($"dt1 to UTC: {dt4.ToUniversalTime()}\n\n");

            Console.WriteLine($"d1t: {dt5}");
            Console.WriteLine($"dt1 kind: {dt5.Kind}");
            Console.WriteLine($"dt1 to local: {dt5.ToLocalTime()}");
            Console.WriteLine($"dt1 to UTC: {dt5.ToUniversalTime()}\n\n");
            Console.WriteLine(dt5.ToString("yyyy-MM-ddTHH:mm:ssZ")); //cuidado o certo e o a seguir.
            Console.WriteLine(dt5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));



        }
    }
}