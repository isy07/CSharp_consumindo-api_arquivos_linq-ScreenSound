using DesafioAula3_1.Filtros;

List<int>numeros = new List<int> { 3, 7, 4, 9, 1, 6, 9, 5, 8, 4, 6, 8, 6, 7, 4 };

Console.WriteLine("Aqui temos todos os números: ");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine("Aqui temos os números sem repetir:");
LinqFilter.RetornaNumerosUnicos(numeros);
