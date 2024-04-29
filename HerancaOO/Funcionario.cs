using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Funcionario : Pessoa
{
    public string cargo;
    public int codigo;
    public Funcionario()
    {
        
    }

    public void DefinirCargo(string cargo)
    {
        this.cargo = cargo;
    }

    public void DefinirCodigo(int codigo)
    {
        this.codigo = codigo;
    }

    public void ImprimirFuncionario()
    {
        ImprimirPessoa();
        Console.WriteLine(cargo);
        Console.WriteLine(codigo);

    }
}


