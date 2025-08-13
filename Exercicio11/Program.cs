namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalCompra = 0.0;
            char continuarComprando = 's';

            Console.WriteLine("--- Carrinho de Compras ---");

            while (continuarComprando == 's')
            {
                Console.Write("Digite o valor do item:");
                totalCompra += Convert.ToDouble(Console.ReadLine());



                Console.WriteLine("Continuar comprando?(s/n):");
                continuarComprando = Char.ToLower(Convert.ToChar(Console.ReadLine()));
                Console.WriteLine($"Total da compra: R$ {totalCompra}");
            }
        }
    }
}
