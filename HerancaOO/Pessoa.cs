using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string nome;
    public string endereco;
    public string telefone;
    public string sexo;
    public float salario;
    public DateOnly data;

    public Pessoa()
    {

    }

    public void DefinirNome(string nome)
    {
        this.nome = nome;
    }

    public void DefinirEndereco(string e)
    {
        this.endereco = e;
    }

    public void DefinirSexo(string e)
    {
        this.sexo = e;
    }

    public void DefinirTelefone(string tel)
    {
        this.telefone = tel;
    }

    public void DefinirSalario(float salario)
    {
        this.salario = salario;

    }

    public void DefinirNascimento(DateOnly d)
    {
        this.data = d;
    }


    public void ImprimirPessoa()
    {
        Console.WriteLine(nome);
        Console.WriteLine(endereco);
        Console.WriteLine(telefone);
        Console.WriteLine(sexo);
        Console.WriteLine(salario);
        Console.WriteLine(data.ToString());

    }
}   

