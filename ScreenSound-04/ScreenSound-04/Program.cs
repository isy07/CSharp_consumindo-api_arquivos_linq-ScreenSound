using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //Console.WriteLine(musicas.Count);
        //musicas[0].ExibirDetalhesDaMusica();
        //Console.WriteLine();
        //musicas[1].ExibirDetalhesDaMusica();
        //musicas[1998].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2014);

        //var musicasPreferidasDaLayse = new MusicasPreferidas("Layse");
        //musicasPreferidasDaLayse.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDaLayse.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDaLayse.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDaLayse.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDaLayse.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDaLayse.ExibirMusicasFavoritas();

        //var musicasPreferidasDoJhone = new MusicasPreferidas("Jhone");

        //musicasPreferidasDoJhone.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasDoJhone.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasDoJhone.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasDoJhone.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasDoJhone.AdicionarMusicasFavoritas(musicas[71]);

        //musicasPreferidasDoJhone.ExibirMusicasFavoritas();

        //musicasPreferidasDoJhone.GerarArquivoJson();

        LinqFilter.FiltrarMusicasEmDoSustenido(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
