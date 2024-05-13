using DesafioAula2_1.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        //Console.WriteLine(resposta);
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        Console.WriteLine(filmes.Count);
        filmes[9].ExibirDetalhesDoFilme();



    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
  
}
