using System;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace Exercicio4
{
    class Atividade4
    {
        static void Main()
        {
            Console.WriteLine("Digite o numeros de funcionarios");
            
         
            int quantidade_funcionario = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("digite quntas horas os funcionarios trabalam");
            double horas_trabalhadas = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("digite o valor da hora trabalhad");
            double valor_da_hora = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"number = {quantidade_funcionario}");

            double salario = valor_da_hora * horas_trabalhadas;

            Console.WriteLine($"salario = {salario}");
        }       
    }
}