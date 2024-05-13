using DesafioAula4_5.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula4_5;

internal class LinqFilter
{
    public static void FiltrarPorIdade(List<Pessoa> pessoas, int idade)
    {
        List<Pessoa>pessoasPorIdade= pessoas.Where(p => p.Idade == idade).ToList();

        Console.WriteLine("Filtro Por Idade:");

        foreach(Pessoa p in pessoasPorIdade)
        {
            Console.WriteLine(p.Nome);
        }
    }
}

