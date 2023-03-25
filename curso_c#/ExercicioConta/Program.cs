using System.Globalization;
using System;

namespace ExercicioConta
{
    class Exercicio
    {
        
        static void Main(string[] args)
        {
            Conta usuario1;
            Console.Write("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine()!;
            
            Console.Write("havera deposito inicial (s/n): ");
            char escolha = char.Parse(Console.ReadLine()!.ToLower());
            
            if (escolha == 's')
            {
                Console.Write("Digite o valor que deseja depositar: ");
                double deposito_inicial = double.Parse(Console.ReadLine()!);
                usuario1 = new Conta(titular, numero, deposito_inicial);

            }
            else 
            {
                usuario1 = new Conta(titular, numero);
            }
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(usuario1);

            Console.Write("Digite um valor para desito: ");
            double deposito = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            usuario1.Deposito(deposito);

            Console.WriteLine("Dados da conta atalizados:");
            Console.WriteLine(usuario1);

            Console.Write("Digite um valor para saque:");
            double saque = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            
            usuario1.Saque(saque);
            Console.WriteLine(usuario1);



            
        } 
    }
}