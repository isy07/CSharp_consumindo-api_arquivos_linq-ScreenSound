using FacaComoEuFiz1.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient()) 
{

    string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/16");
    //Console.WriteLine(resposta);

    Got personagens = JsonSerializer.Deserialize<Got>(resposta)!;
    personagens.DetalhesPersonagem();

}
