using DesafioAula2_2.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        //Console.WriteLine(resposta);
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);
        Console.WriteLine(paises.Count);
        //paises[4].ExibirPaises();

        foreach (Pais p in paises) 
        {
            Console.WriteLine($"\nO país {p.NomePais}, cuja capital é {p.Capital} e a língua falada é {p.Lingua}, está localizado no continente {p.Continente} e sua população é de {p.Populacao} habitantes."); 
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}