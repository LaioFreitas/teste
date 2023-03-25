namespace ExercicioClasse
{
    class ExercicioClasse
    {
        static void Main()
        {
            Console.WriteLine("digite o nome");
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();
            a.Name = Console.ReadLine();
            Console.WriteLine("dgite a idade");
            a.Idade = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("digite o nome");
            b.Name = Console.ReadLine();
            Console.WriteLine("dgite a idade");
            b.Idade = int.Parse(Console.ReadLine()!);
            if (a.Idade > b.Idade)
                Console.WriteLine("Pessoa mais velha: {0}", a.Name);
            else
                Console.WriteLine($"Pessoa mais velha: {b.Name}");

        }
    }
}


