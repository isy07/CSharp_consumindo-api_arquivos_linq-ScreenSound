try
{
    Console.WriteLine("Digite um número:  ");
    int numerador = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite outro número:  ");
    int denominador = int.Parse(Console.ReadLine());

    int resultado = numerador / denominador;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
}
catch(DivideByZeroException)
{
    Console.WriteLine("O denominador não pode ser 0");
}







