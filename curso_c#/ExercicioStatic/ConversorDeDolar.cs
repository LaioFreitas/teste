using System.Globalization;

namespace ExercicioStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da cotacao do dolar hoje: ");
            double cotacao = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quntidade de doalres que voce vai converter");
            double quantidadeDeDolares = double.Parse(Console.ReadLine()!);

            Console.WriteLine(Conversor.ConverteMoeda(cotacao, quantidadeDeDolares).ToString("f2", CultureInfo.InvariantCulture ));
            Console.ReadLine();
            
            

            
            
            
            
            
            
            
            
        }
    }
}