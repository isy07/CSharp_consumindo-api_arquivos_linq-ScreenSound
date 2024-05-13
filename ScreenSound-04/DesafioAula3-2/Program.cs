using DesafioAula3_2.Filtros;
using DesafioAula3_2.Modelos;

Livro livro1 = new Livro("Harry Potter", "J. k. Rowlling", 2001);
Livro livro2 = new Livro("Livro Inventado", "Autor inventado", 1996);
Livro livro3 = new Livro("Livro Novo", "Autor Novo", 2010);
Livro livro4 = new Livro("O Casamento", "Nicholas Sparks", 2012);
Livro livro5 = new Livro("Help", "Marcos Prado", 2005);



List<Livro> listaDeLivros = new List<Livro>();

listaDeLivros.Add(livro1);
listaDeLivros.Add(livro2);
listaDeLivros.Add(livro3);
listaDeLivros.Add(livro4);
listaDeLivros.Add(livro5);

Console.WriteLine("Todos os livros");
foreach (var livro in listaDeLivros)
{
    Console.WriteLine($"\nLivro: {livro.Titulo} \nAutor: {livro.Autor} \nAno de Publicação: {livro.Ano}");
}

Console.WriteLine("\nLivros Selecionados");
LinqFilter.LivrosAposAnos2000Ordenados(listaDeLivros);

