using DesafioAula4_2.Modelos;
using System.Text.Json;

string fileName = "dados-cliente-Layse.json";

if (File.Exists(fileName))
{
    
    string jsonString = File.ReadAllText(fileName);


    Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

    Console.WriteLine($"Nome: {pessoa.Nome}");
    Console.WriteLine($"Idade: {pessoa.Idade}");
    Console.WriteLine($"Email: {pessoa.Email}");

    pessoa.ExibirDetalhesPessoa();
}
else
{
    Console.WriteLine("Arquivo inexistente.");
}

/// meu codigo nao funcionou, da erro dizendo que a pasta nao existe
/// // estava procurando a pasta no lugar errado, achei a pasta porem o programa nao le as informações
/// //consegui, nao tinha definido a jsonpropertyname