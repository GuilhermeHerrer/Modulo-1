namespace exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = { 7.5, 8.0, 6.0 };
            Console.WriteLine($"A média das notas é: {CalcularMedia(notas[0], notas[1], notas[2]):F2}");
        }

        public static double CalcularMedia(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
