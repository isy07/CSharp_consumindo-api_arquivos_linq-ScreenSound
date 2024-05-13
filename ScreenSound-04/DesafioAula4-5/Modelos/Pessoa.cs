using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAula4_5.Modelos;

internal class Pessoa
{

    [JsonPropertyName("Nome")]
    public string Nome { get; set; }

    [JsonPropertyName("Idade")]
    public int Idade { get; set; }

    [JsonPropertyName("Email")]
    public string Email { get; set; }

    public void ExibirDetalhesPessoa()
    {
        Console.WriteLine($"Nome: {Nome}" +
            $"\nIdade: {Idade}" +
            $"\nEmail: {Email}");
    }


}
