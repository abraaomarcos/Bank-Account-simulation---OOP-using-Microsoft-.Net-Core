using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poo_3;

public class contaCorrente

{
    public cliente Titular
    { get;  set; }
    private int agencia;
    public int Agencia { get; private set;}
    public int numero;
    public int conta;
    private double saldo = 100;
    public contaCorrente(int agencia, int numero)
    {
        this.agencia = agencia;
        this.numero = numero;
    }
    public double Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            }
            Saldo = value;
        }
    }


    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;

        }
    }
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool Transferir(double valor, contaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }



}