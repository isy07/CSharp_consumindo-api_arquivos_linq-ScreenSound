using DesafioAula3_3.Filtro;
using DesafioAula3_3.Modelos;

Produto produto1 = new Produto("Caderno", 10);
Produto produto2 = new Produto("Caneta", 5);
Produto produto3 = new Produto("Borracha", 2);
Produto produto4 = new Produto("Lapis", 5);
Produto produto5 = new Produto("Apontador", 3);

List<Produto> listaDeProdutos = new List<Produto>();
listaDeProdutos.Add(produto1);
listaDeProdutos.Add(produto2);
listaDeProdutos.Add(produto3);
listaDeProdutos.Add(produto4);
listaDeProdutos.Add(produto5);


Console.WriteLine("Lista de Produtos com Preço:\n");
foreach(var item in listaDeProdutos)
{
    Console.WriteLine($"Produto: {item.NomeProduto} - Preço: {item.PrecoProduto} reais.");
}

LinqFilter.MediaPreco(listaDeProdutos);
