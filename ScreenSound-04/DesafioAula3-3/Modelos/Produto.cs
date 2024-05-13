using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula3_3.Modelos;

internal class Produto
{
    public Produto(string nomeProduto, double precoProduto)
    {
        NomeProduto = nomeProduto;
        PrecoProduto = precoProduto;
    }

    public string NomeProduto { get; set; }
    public double PrecoProduto { get; set; }
}
