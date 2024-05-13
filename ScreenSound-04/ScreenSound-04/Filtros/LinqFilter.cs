using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas) 
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach(var artista in artistaPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }

    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista) 
        {
            Console.WriteLine($"-{musica.Nome}");
        }
    }
    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicaPorAno = musicas.Where(musica => musica.Ano ==  ano).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Músicas de {ano}");
        foreach (var musica in musicaPorAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    internal static void FiltrarMusicasEmDoSustenido(List<Musica> musicas)
    {
        var musicasEmDoSustenido = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();

        Console.WriteLine("Musicas em C#");
        foreach (var musica in musicasEmDoSustenido)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
