using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAula4_2.Modelos;

internal class Pessoa
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("idade")]
    public int Idade { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    public void ExibirDetalhesPessoa()
    {
        Console.WriteLine($"Nome: {Nome}" +
            $"\nIdade: {Idade}" +
            $"\nEmail: {Email}");
    }
}
// MEU CODIGO NAO FUNCIONOU, DIZ QUE A PASTA NAO EXISTE
// estava procurando a pasta no lugar errado, achei a pasta porem o programa nao le as informações
//consegui, nao tinha definido a jsonpropertyname
// exibi os dados atraves do metodo e direto na program por conta dos erros ue estavam dando.
