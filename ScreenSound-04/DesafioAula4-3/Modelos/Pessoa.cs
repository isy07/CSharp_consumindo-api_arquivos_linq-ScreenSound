using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesafioAula4_3.Modelos;

internal class Pessoa
{

    public Pessoa()
    {

    }

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public string SerializarParaJson()
    {
        return JsonSerializer.Serialize(this);
    }

}

    //public void GerarArquivoJson()
    //{
    //    string json = JsonSerializer.Serialize(new
    //    {
    //        nome = Nome,
    //        idade = Idade,
    //        email = Email

    //    });
    //    string nomeDoArquivo = "pessoas.json";

//        File.WriteAllText(nomeDoArquivo, json);
//        Console.WriteLine($"O arquivo Json foi criado com sucesso.{Path.GetFullPath(nomeDoArquivo)}");
//    }
//}

