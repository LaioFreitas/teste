// See https://aka.ms/new-console-template for more information
namespace SwitchCase
{
    class Pregram
    {
        static void Main()
        {
            Console.WriteLine("Digite o numero da semana");
            int x = int.Parse(Console.ReadLine()!);
            string day;
            switch (x)
            {
                case 1:
                    day = "domingo";
                    break;
                case 2:
                    day = "segunda";
                    break;
                case 3:
                    day = "terça";
                    break;
                case 4:
                    day = "quarta";
                    break;
                case 5: 
                    day = "quinta";
                    break;
                case 6: 
                    day = "sexta";
                    break;
                case 7:
                    day = "sabado";
                    break;
                default:
                    day = "dia nao valido";
                    break;
            }
            
            Console.WriteLine(day);
        }           
    }
}
