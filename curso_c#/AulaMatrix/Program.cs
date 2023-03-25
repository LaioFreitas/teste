namespace AulaMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Digite o tamanho da matriz quadrada:");
            int n = int.Parse(Console.ReadLine()!);
            int[,] matriz = new int[n, n];
            
            for (int i = 0; i < n; i++)
            {
                string?[] valores = Console.ReadLine()!.Split(' ');
                 for (int j = 0; j < valores.Length; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]!);
                }

            }

            for (int i = 0; i < n; i++) 
                Console.Write(matriz[i, i] + " ");
              
            

            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n;  j++)
                {
                    if (matriz[i, j] < 0)
                        cont++;
                }
            }
            Console.WriteLine("\n" + cont);
        }
    }
}