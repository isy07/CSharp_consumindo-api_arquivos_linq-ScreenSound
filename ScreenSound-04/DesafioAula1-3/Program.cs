try
{
    List<int> numeros = new List<int> { 1, 2, 4, 5, 10, 8 };
    Console.WriteLine("Escolha um índice: ");
    int indice = int.Parse(Console.ReadLine());
    Console.WriteLine($"Elemento no índice {indice}: {numeros[indice]}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro: Índice inexistente {ex.Message}");
}
