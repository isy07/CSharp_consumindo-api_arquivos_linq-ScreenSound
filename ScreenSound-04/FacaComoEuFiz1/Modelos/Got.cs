using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FacaComoEuFiz1.Modelos;

internal class Got
{
    [JsonPropertyName("name")]
    public string NomePersonagem { get; set; }

    [JsonPropertyName("aliases")]
    public List<string> apelidos{ get; set; } = new();

    public void DetalhesPersonagem() 
    {
        Console.WriteLine($"Personagem: {NomePersonagem}" +
            $"Apelido:");
            foreach (string apelido in apelidos)
            {
                Console.WriteLine($" {apelido}");
            }
        }
    }