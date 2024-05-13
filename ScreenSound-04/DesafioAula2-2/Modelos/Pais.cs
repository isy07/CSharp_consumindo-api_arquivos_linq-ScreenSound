using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAula2_2.Modelos;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string NomePais { get; set; }

    [JsonPropertyName("capital")]
    public string Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }

    [JsonPropertyName("continente")]
    public string Continente { get; set; }

    [JsonPropertyName("idioma")]
    public string Lingua { get; set; }
}  

//    public void ExibirPaises()
//    {
//        Console.WriteLine($"O país {NomePais}, cuja capital é {Capital} e a língua falada é {Lingua}, está localizado no continente {Continente} e sua população é de {Populacao} habitantes.");
//    }

//}
