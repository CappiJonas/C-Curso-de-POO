using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao_5
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public override string ToString()
        {
            return $"{_nome}, $ {_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades," +
                   $" $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void AdicionarProdutos(int quantidade)
        {
            //Quantidade = Quantidade + quantidade;
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            //Quantidade = Quantidade - quantidade;
            _quantidade -= quantidade;
        }
    }
}
