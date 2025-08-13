namespace Exercicio9;

internal class Program
{
    static void Main(string[] args)
    {
        int trajeto = 3;

        switch (trajeto)
        {
            case 1:
                Console.WriteLine("Tipo de trajeto escolhido: 1 (Curto)");
                Console.WriteLine("Sugestão: Vá a pé ou de bicicleta.");
                break;
            case 2:
                Console.WriteLine("Tipo de trajeto escolhido: 2 (Média)");
                Console.WriteLine("Sugestão: Use transporte público ou carro.\"");
                break;
            case 3:
                Console.WriteLine("Tipo de trajeto escolhido: 3 (Longo)");
                Console.WriteLine("Sugestão: Considere avião ou ônibus de viagem.");
                break;
            default:
                Console.WriteLine("Tipo de trajeto inválido. Por favor, escolha 1, 2 ou 3.");
                break;
        }
    }
}
