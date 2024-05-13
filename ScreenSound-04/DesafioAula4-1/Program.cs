using DesafioAula4_1.Modelos;

Pessoa pessoa = new Pessoa();
Console.WriteLine("Digite o nome do cliente: ");
pessoa.Nome = Console.ReadLine();
Console.WriteLine("Digite a idade do cliente: ");
pessoa.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o e-mail do cliente: ");
pessoa.Email = Console.ReadLine();

pessoa.GerarArquivoJson();