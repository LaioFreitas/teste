
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaVetores
{
    public class Quarto
    {
        public string? NomeInquilino {get; set;}
        public string? Email {get; set;}
        public int NumeroQuarto {get; set;}


        public Quarto(string? nome, string? email, int numeroquarto)
        {
            NomeInquilino = nome;
            Email = email;
            NumeroQuarto = numeroquarto;
        }

        public override string ToString()
        {
            return  NumeroQuarto + ":" + NomeInquilino + ", " + Email;//$"{NumeroQuarto}: {NomeInquilino}, {Email}";
        }
        
    }
}