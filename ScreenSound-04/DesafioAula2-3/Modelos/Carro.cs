using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DesafioAula2_3.Modelos
{
    internal class Carro
    {
        [JsonPropertyName("marca")]
        public string Marca { get; set; }

        [JsonPropertyName("modelo")]
        public string Modelo { get; set; }

        [JsonPropertyName("ano")]
        public int? Ano { get; set; }

        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }

        public void ExibirDetalhesCarro()
        {
            Console.WriteLine($"Carro: {Modelo}; Marca: {Marca}; Ano: {Ano}; Tipo: {Tipo}");
        }
    }


}
