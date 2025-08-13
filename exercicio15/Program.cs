namespace exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verifcando produto  1(R$ 45.00 com máximo de R$ 50.00)");
            if (VerificarPrecoPromocional(45.00, 50.00))
            {
                Console.WriteLine("Está em promoção!");
            }
            else
            {
                Console.WriteLine("Não está em promoção!");
            }

            Console.WriteLine("Verifcando produto 2 (R$ 55.00 com máximo de R$ 50.00)");
            if (VerificarPrecoPromocional(55.00, 50.00))
            {
                Console.WriteLine("Está em promoção!");
            }
            else
            {
                Console.WriteLine("Não está em promoção!");
            }
        }

        public static bool VerificarPrecoPromocional(double precoProduto, double precoMaxPromocao)
        {
            if (precoMaxPromocao >= precoProduto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
