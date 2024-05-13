
using DesafioAula4_3.Modelos;
using System.Text.Json;

List<Pessoa> listaDePessoasAdicionadas = new List<Pessoa>();

while (true)
{

    Pessoa pessoa = new Pessoa();
    Console.WriteLine("\nDigite o nome do cliente ou sair para finalizar: ");
    var nome = Console.ReadLine();


    if (nome.ToLower() == "sair")
        break;

    pessoa.Nome = nome;

    Console.WriteLine("Digite a idade do cliente: ");
    pessoa.Idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o e-mail do cliente: ");
    pessoa.Email = Console.ReadLine();

    Console.WriteLine(pessoa.Nome);

    listaDePessoasAdicionadas.Add(pessoa);
    Console.WriteLine("\nPessoas Adicionadas:");
    foreach (var item in listaDePessoasAdicionadas)
        Console.WriteLine(item.Nome);
        ;
}

string json = JsonSerializer.Serialize(listaDePessoasAdicionadas);

File.WriteAllText("pessoas1.json", json);

Console.WriteLine("Arquivo atualizado.");

//    pessoa.GerarArquivoJson();


//    {
//    }
//}
