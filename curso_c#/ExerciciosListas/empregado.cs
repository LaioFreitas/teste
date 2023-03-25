using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosListas
{
    public class Empregado
    {
        public int Id {get; private set;}
        public string? Name {get; private set;}
        public double Salary {get; set;}

        public Empregado(int id )
        {
            Id = id;
        }
        public Empregado(int id , string? nome, double salario) : this(id)    
        {
            Name = nome;
            Salary = salario;
            //Salary += Salary * (percentage / 100);
        }
        public Empregado(Empregado id)
        {
            this.Id = id.Id;
            this.Name = id.Name;
            this.Salary = id.Salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }
       


    }
}