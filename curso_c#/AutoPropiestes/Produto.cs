using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace AutoPropiestes
{
    public class Produto
    {
        private string? _nome;
        public double Preco {get; private set;}
        public int Quantidade {get; private set;}

        public Produto(string nome, double preco, int quantidade )
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(){}
        
        
        /*public string GetNome()
        {
            return _nome!;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public string Nome {get {return _nome!;} set {if (value != null && value.Length > 1){_nome = value;}}} 
        public double Preco  {get {return _preco;}}
        public int Quantidade {get {return _quantidade;}}
        */
        public double valorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoveProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome! + ", $" + Preco.ToString("f2", CultureInfo.InvariantCulture) + "," + Quantidade
            + "unidade, total: $" + valorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }

    }
}