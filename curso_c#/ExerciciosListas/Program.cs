using System.Collections.Generic;

namespace ExerciciosListas
{
    class Listas
    {
        static void Main(string[] args)
        {
            List<Empregado> empregados = new List<Empregado>();

            Console.Write("how many employees will be registered: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Empleyee #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine()!);

                empregados.Add(new Empregado(id, name!, salary));

                
            }
            Console.Write("enter the employee id that will have salary increse: ");
            int idEscolhido = int.Parse(Console.ReadLine()!);
            
            Empregado asdf = (empregados.Find(x => x.Id == idEscolhido)!);
            Console.WriteLine(asdf.Salary);    

        }
    }
}