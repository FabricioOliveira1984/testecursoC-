using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TerceiroApp
{
    class ContaBancaria
    {
        public int Numero { get; private set; } //numero da conta não poderá ser alterado.
        public string Titular { get; set; } 
        public double Saldo { get; private set; } // O saldo da conta só poderá ser alterador por deposito ou saque.

        //Haverá sobrecarga de construtor onde um terá 3 argumentos e outro 2 argumentos pois um exemplo não haverá o deposito inicial
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) // uso da palavra this utilizando outro construtor
        {
            Deposito(depositoInicial);
        }

        // criação do método Depósito onde será realizado um depósito de determinada quantia
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0; //no problema aós ser feito o saque será descontado a taxa de R$ 5,00
        }

        //usando o To String solicitando o que foi pedido no exemplo: Conta 8532, Titular: Alex Green, Saldo: $ 500.00
        public override string ToString()
        {
            return "Conta" + Numero + ", Titular:" + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
