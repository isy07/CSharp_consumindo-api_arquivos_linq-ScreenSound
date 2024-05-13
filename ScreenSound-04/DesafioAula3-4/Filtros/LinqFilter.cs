using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3_4.Filtros;

internal class LinqFilter
{
    public static void RetornaNumeroPares(List<int> numeros)
    {
        var numerosPares = numeros.Where(numeros => numeros%2 ==0);
        foreach (var n in numerosPares)
        {
            Console.WriteLine(n);
        }
    }
}
