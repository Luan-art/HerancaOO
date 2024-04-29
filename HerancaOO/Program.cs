using System.Data;

Cliente cliente = new Cliente();

Console.WriteLine("Digita seu nome:  ");
cliente.DefinirNome(Console.ReadLine());

Console.WriteLine("Digita seu endereço:  ");
cliente.DefinirEndereco(Console.ReadLine());

Console.WriteLine("Digita seu sexo:  ");
cliente.DefinirSexo(Console.ReadLine());

Console.WriteLine("Digita seu telefone:  ");
cliente.DefinirTelefone(Console.ReadLine());

Console.WriteLine("Digita seu salario:  ");
cliente.DefinirSalario(float.Parse(Console.ReadLine())) ;

Console.WriteLine("Digita sua data de nascimento:  ");
cliente.DefinirNascimento(DateOnly.Parse(Console.ReadLine ( ) )) ;

Console.WriteLine("Digita sua conta:  ");
cliente.DefinirConta(int.Parse(Console.ReadLine()));

cliente.ImprimirCliente();

Funcionario funcionario = new Funcionario();

Console.WriteLine("Digita seu nome:  ");
funcionario.DefinirNome(Console.ReadLine());

Console.WriteLine("Digita seu endereço:  ");
funcionario.DefinirEndereco(Console.ReadLine());

Console.WriteLine("Digita seu sexo:  ");
funcionario.DefinirSexo(Console.ReadLine());

Console.WriteLine("Digita seu telefone:  ");
funcionario.DefinirTelefone(Console.ReadLine());

Console.WriteLine("Digita seu salario:  ");
funcionario.DefinirSalario(float.Parse(Console.ReadLine()));

Console.WriteLine("Digita sua data de nascimento:  ");
funcionario.DefinirNascimento(DateOnly.Parse(Console.ReadLine()));

Console.WriteLine("Digita seu codigo:  ");
funcionario.DefinirCodigo(int.Parse(Console.ReadLine()));

Console.WriteLine("Digita seu cargo:  ");
funcionario.DefinirCargo(Console.ReadLine());


funcionario.ImprimirFuncionario();

