namespace ExercicioAlunoClasses;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("Digite o nome do aluno");
        aluno.nome =  Console.ReadLine();

        Console.WriteLine("Digite a nota do aluno nos tres trimestres em em sequencia");
        while (true)
        {
            aluno.notaTrimestre1 = double.Parse(Console.ReadLine()!);
            if (aluno.notaTrimestre1 > 30)
            {
                continue;
            }

            aluno.notaTrimestre2 = double.Parse(Console.ReadLine()!);
            aluno.notaTrimestre3 = double.Parse(Console.ReadLine()!);

            if (aluno.notaTrimestre2 > 35 && aluno.notaTrimestre3 > 35)
            {
                continue;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"NOTA FINAL: {aluno.Total()}");

        if ( aluno.Total() > 60)
        {
            Console.WriteLine("APROVADO");
        }

    }
}
