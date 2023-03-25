namespace String
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("");
            string original = "asdf GHJJK LÇZXCV zxcbnm     ";
            
            string maiuscula = original.ToUpper();
            Console.WriteLine(maiuscula);
            
            string minuscula = original.ToLower();
            Console.WriteLine(minuscula);

            string trim = original.Trim();
            Console.WriteLine("Trim: " + trim);

            int i = original.IndexOf("df");
            Console.WriteLine(i);

            int i2 = original.LastIndexOf("J");
            Console.WriteLine(i2);
            
            string substring = original.Substring(3);
            string substring2 = original.Substring(3, 7);

            Console.WriteLine(substring + "\n" + substring2);

            string s1 = original.Replace('a', 'i');
            string s2 = original.Replace("GH", "JJ");

            bool b1 = string.IsNullOrEmpty(original);
            Console.WriteLine($"IsnullOrEmpty: {b1}"); 
            bool b2 = string.IsNullOrWhiteSpace(original);
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
        }
    }
}
