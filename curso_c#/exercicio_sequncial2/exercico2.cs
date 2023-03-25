using System;
using System.Globalization;


namespace Exercicio2
{
    class AtividadeRaio
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(raio, 2.0);
            Console.WriteLine(area);


        }
    }
}