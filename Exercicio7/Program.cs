namespace Exercicio7;

internal class Program
{
    static void Main(string[] args)
    {
        string senhaCorreta = "aulaCsharp";
        string senhaDigitada = "aulaCsharp";
        Console.WriteLine($"Senha digitada:{senhaDigitada}");

        if (senhaDigitada == senhaCorreta)
        {
            Console.WriteLine("Senha Correta");
        }
        else
        {
            Console.WriteLine("Senha incorreta");
        }
    }
}
