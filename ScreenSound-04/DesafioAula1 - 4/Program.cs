using DesafioAula1___4;

class Program
{
    static void Main()
    {
        ClasseSimples objetoNulo = null;

        try
        {
            objetoNulo.MeuMetodo();
        }
        catch (NullReferenceException ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }




}



//nao entendi o erro

//ClasseSimples objetoNulo = null;

//try
//{
//    objetoNulo.MeuMetodo();
//}
//catch(NullReferenceException ex)
//{
//    Console.WriteLine($"Erro: {ex.Message}");
//}
