using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3_2.Modelos;
internal class Livro
{
    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }

    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }

    public void DetalhesLivro()
    {
        Console.WriteLine($"Livro: {Titulo}" +
            $"\nAutor: {Autor}" +
            $"Ano de Publicação: {Ano}");
    }
}



//Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.
