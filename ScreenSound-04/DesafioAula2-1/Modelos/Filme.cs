using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAula2_1.Modelos;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("crew")]
    public string? Elenco { get; set; }

    [JsonPropertyName("rank")]
    public string Nota { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Filme: {Titulo}");
        Console.WriteLine($"Ano de Lançamento: {Ano}");
        Console.WriteLine($"Elenco: {Elenco}");
        Console.WriteLine($"Nota de avaliação: {Nota}");

    }
}
