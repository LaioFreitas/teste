using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
namespace Propriedade
{
  public class Produto
    {
        private string? _nome;
        private double _preco = 10;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade )
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public Produto(){}
        
        
        /*public string GetNome()
        {
            return _nome!;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }*/
        public string Nome {get {return _nome!;} set {if (value != null && value.Length > 1){_nome = value;}}} 
        public double Preco  {get {return _preco;}}
        public int Quantidade {get {return _quantidade;}}
        public double valorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoveProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome! + ", $" + _preco.ToString("f2", CultureInfo.InvariantCulture) + "," + _quantidade
            + "unidade, total: $" + valorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }

    }
}