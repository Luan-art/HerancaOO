using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Cliente : Pessoa 
{
    public int conta;

    public Cliente()
    {
        
    }

    public void DefinirConta(int conta)
    {
        this.conta = conta;
    }

    public void ImprimirCliente()
    {
        ImprimirPessoa();
        Console.WriteLine(conta);
    }
}

