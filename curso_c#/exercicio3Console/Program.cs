namespace exercicio3Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa:");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("salario");
            pessoa1.salario = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite o nome da pessoa:");
            pessoa2.nome = Console.ReadLine();

            Console.WriteLine("salario");
            pessoa2.salario = double.Parse(Console.ReadLine()!);

            double salario_medio = pessoa1.salario / pessoa2.salario;
            Console.WriteLine(salario_medio.ToString());
        }
    }
}