
namespace AulaVetores
{
    class Vetores 
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos quartos serao alugados:");
            int quantidadeQuartos = int.Parse(Console.ReadLine()!);
            Quarto[] quartos = new Quarto[10];
            int[] numero = new int[quantidadeQuartos];
            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine("Nome:");
                string? nome = Console.ReadLine();
                Console.WriteLine("Email:");
                string? email = Console.ReadLine();
                Console.WriteLine("Rooms");
                numero[i] = int.Parse(Console.ReadLine()!);

                quartos[numero[i]] = new Quarto(nome, email, numero[i]);

                Console.WriteLine();
                
            }

            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine("quantos ocupados:");
                Console.WriteLine(quartos[numero[i]].ToString());
            }

            Console.WriteLine("auuii");
            Console.WriteLine("assss");

        }
    }
}
