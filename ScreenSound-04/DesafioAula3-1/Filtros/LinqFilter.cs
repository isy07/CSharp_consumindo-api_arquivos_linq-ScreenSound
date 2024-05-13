using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3_1.Filtros;

internal class LinqFilter
{
    public static void RetornaNumerosUnicos(List<int> numeros)
    {
        var numerosUnicos = numeros.Distinct();
        foreach (var n in numerosUnicos)
        {
            Console.WriteLine(n);
        }
    }
}
