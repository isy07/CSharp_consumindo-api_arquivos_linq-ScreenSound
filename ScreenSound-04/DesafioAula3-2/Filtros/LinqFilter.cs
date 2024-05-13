using DesafioAula3_2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DesafioAula3_2.Filtros;

internal class LinqFilter
{
    public static void LivrosAposAnos2000Ordenados(List<Livro> livros)
    {
        var livrosSelecionados = livros.Where(livros => livros.Ano > 2000).OrderBy(livros => livros.Titulo).Select(livros => livros.Titulo).ToList();
        foreach(var livro in livrosSelecionados) 
        {
            Console.WriteLine($"\nLivro: {livro}");
        }
    }

}

