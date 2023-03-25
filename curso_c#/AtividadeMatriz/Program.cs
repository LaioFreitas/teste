namespace AtividadeMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de linhas e de coolunas");
            string[] valores = Console.ReadLine()!.Split(' ');
            
            int n = int.Parse(valores[0]);
            int m = int.Parse(valores[1]);
            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.Write("Digite o numero que quer encontra: ");
            int numero = int.Parse(Console.ReadLine()!);

            //foreach (int i  in matriz) { Console.WriteLine(i); }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i, j] ==  numero)
                    {
                        Console.WriteLine($"position: ({i}, {j})");
                        if (j >= 0 && j < (m - 1))
                        {
                            Console.WriteLine($"right: {matriz[i, j + 1]}");
                        }
                        if (j < m && j > 0)
                        {
                            Console.WriteLine($"left: {matriz[i, j - 1]}");
                        }
                        if (i >= 0 && i < (n - 1))
                        {
                            Console.WriteLine($"down: {matriz[i + 1, j]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"up: {matriz[i - 1, j]}");
                        }


                    }
                    else
                    {
                        Console.WriteLine("O valor escolhido nao foi encontrado.");

                    }

                }
            }
        }
    }
}