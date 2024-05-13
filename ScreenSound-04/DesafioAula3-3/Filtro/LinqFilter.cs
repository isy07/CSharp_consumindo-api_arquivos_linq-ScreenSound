using DesafioAula3_3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3_3.Filtro;

internal class LinqFilter
{
    public static void MediaPreco(List<Produto> produtos)
    {
        var mediaPrecoProdutos = produtos.Average(produtos => produtos.PrecoProduto).ToString();

        Console.WriteLine($"\nA média de preço dos produtos é {mediaPrecoProdutos} reais.");
    }

}
