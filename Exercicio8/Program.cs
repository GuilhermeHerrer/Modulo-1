namespace Exercicio8;

internal class Program
{
    static void Main(string[] args)
    {
        double nota = 5;

        Console.WriteLine(nota);
        Console.WriteLine();

        if (nota >= 9)
        {
            Console.WriteLine("Conceito:A");
        }
        else if (nota < 9 && nota >= 8)
        {
            Console.WriteLine("Conceito:B");
        }
        else if (nota < 8 && nota >= 7)
        {
            Console.WriteLine("Conceito:C");
        }
        else if (nota < 7 && nota >= 6)
        {
            Console.WriteLine("Conceito:D");
        }
        else
        {
            Console.WriteLine("Conceito:F");
        }
    }
}
