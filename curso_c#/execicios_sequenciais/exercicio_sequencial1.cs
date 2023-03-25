using System;
using System.Globalization;

namespace Teste
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os numeros para serem somados");
           
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);
            
            //int soma = int.Parse(numero1 + numero2);
            Console.WriteLine("soma = {0}", numero1);


        }
    }
}
