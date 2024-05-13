using DesafioAula2_3.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        //Console.WriteLine(resposta);
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);
        Console.WriteLine(carros.Count);
        carros[0].ExibirDetalhesCarro();
        carros[1].ExibirDetalhesCarro();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
