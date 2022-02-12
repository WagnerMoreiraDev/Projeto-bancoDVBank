using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvContaBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaWagner = new ContaCorrente();
            contaWagner.titular = "Wagner";
            Console.WriteLine(contaWagner.saldo);
            contaWagner.Sacar(50);
            Console.WriteLine(contaWagner.saldo);
            bool resultadoSacque = contaWagner.Sacar(50);
            Console.WriteLine(contaWagner.saldo);
            Console.WriteLine(resultadoSacque);

            ContaCorrente contaWagnerMoreira = new ContaCorrente();
            contaWagnerMoreira.titular = "wagner moreira ";
            Console.WriteLine(contaWagnerMoreira.saldo);
            contaWagnerMoreira.Depositar(500);
            Console.WriteLine(contaWagnerMoreira.saldo);

            ContaCorrente contaWagnerSilva = new ContaCorrente();
            contaWagnerSilva.titular = "wagner silva";
            Console.WriteLine("Saldo conta Wagner moreira" + contaWagnerMoreira.saldo);
            Console.WriteLine("Saldo conta Wagner Silva " + contaWagnerSilva.saldo);
            contaWagnerMoreira.Transferir(200, contaWagnerSilva);
            Console.WriteLine("Saldo conta Wagner Moreira " + contaWagnerMoreira.saldo);
            Console.WriteLine("Saldo conta Wagner Silva" + contaWagnerSilva.saldo);
            contaWagnerSilva.Transferir(100, contaWagnerMoreira);
            Console.WriteLine("Saldo conta Wagner moreira " + contaWagnerMoreira.saldo);
            Console.WriteLine("saldo conta Wagner Silva" + contaWagnerSilva.saldo);
        }
    }
}
