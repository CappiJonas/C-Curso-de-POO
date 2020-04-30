using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Proposto
{
    class Conta_Bancaria
    {
        private int _numeroConta;
        private string _nome;
        public double Valor { get; set; }

        public string Nome
        {
            get { return _nome; }
            set 
            { 
                if (value != null)
                {
                    _nome = value;
                }
            }
        }

        public int NumeroConta
        {
            get { return _numeroConta; }
            set 
            {
                if (value != 0)
                {
                    _numeroConta = value;
                }
            }
        }

        public Conta_Bancaria()
        {

        }

        public Conta_Bancaria(int numeroConta, string nome)
        {
            _numeroConta = numeroConta;
            _nome = nome;
        }

        public Conta_Bancaria(int numeroConta, string nome, double valor) : this(numeroConta, nome)
        {
            Valor = valor;
        }

        public double ValorInicial(double valor)
        {
            Valor = valor;
            return Valor;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo $ {Valor.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void Depositar(double valorDeposito)
        {
            Valor += valorDeposito;
        }

        public void Sacar(double valorSaque)
        {
            Valor -= (valorSaque + 5.0);
        }
    }
}
