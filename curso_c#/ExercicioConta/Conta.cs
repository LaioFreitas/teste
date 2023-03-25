using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace ExercicioConta
{
    public class Conta
    {
        private int _taxa = 5;
        public int Numero_conta {get; private set;}
        public string? Nome_titular {get; set;}
        public double Saldo {get; private set;}

        public Conta(string titular, int numero_conta)
        {
            Numero_conta = numero_conta;
            Nome_titular = titular;
            Saldo = 0;
        }

        public Conta(string titular, int numero_conta, double saldo) : this(titular, numero_conta)
        {
            Deposito(saldo);
        }

        public void Deposito(double valor_deposito)
        {
            Saldo += valor_deposito;
            
        }

        public void Saque(double valor_saque)
        {
            Saldo  -= (valor_saque + _taxa);
        } 

        public override string ToString()
        {
            return "conta: " + Numero_conta + ", titular" + Nome_titular + ", saldo $" 
            + Saldo.ToString("f2", CultureInfo.InvariantCulture);  
        }


    }
}