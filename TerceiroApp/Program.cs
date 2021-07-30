using System;
using System.Globalization;

namespace TerceiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do 
            titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito 
            inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua 
            conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
            Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já 
            o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por 
            exemplo). 
            Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger 
            isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque 
            realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for 
            suficiente para realizar o saque e/ou pagar a taxa.
            Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não 
            informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre 
            os dados da conta após cada operação. */

            //implementação da interação

            ContaBancaria conta; //necessário colocar aqui se não ficará aenas dentro do if

            Console.WriteLine("Entre com o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta:");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial(s/n):");
            char resp = char.Parse(Console.ReadLine());


            //Utilização da estrutura da condicional caso o deósito seja positivo
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor de deósito inicial:");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, DepositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            //Depósito
            Console.WriteLine();
            Console.WriteLine("Entre com um valor para depósito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("D ados da conta atualizados:");
            Console.WriteLine(conta);

            //Saque
            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque:");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("D ados da conta atualizados:");
            Console.WriteLine(conta);









        }
    }
}
