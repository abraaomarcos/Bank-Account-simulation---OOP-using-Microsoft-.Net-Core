using System;

namespace poo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            contaCorrente contaDoJonatas = new contaCorrente();
            contaCorrente contaDoAbraao = new contaCorrente();
            cliente cliente = new cliente();
            cliente.Nome = "Abraao";
            cliente.Profissão = "Desenvolvedor";
            cliente.CPF = "1234567";

            contaDoAbraao.Saldo = -10;
            Console.WriteLine(contaDoAbraao.Saldo);
            contaDoAbraao.Titular = cliente;
            Console.WriteLine(contaDoAbraao.Titular.Nome);
            
            
        }
    }
}