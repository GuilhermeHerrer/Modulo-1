namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuarioCorreto = "aluno";
            string senhaCorreta = "1234";

            string usuarioDigitado;
            string senhaDigitada;

            do
            {
                Console.WriteLine("Digite o usuário:");
                usuarioDigitado = Console.ReadLine();

                Console.WriteLine("Digite a senha:");
                senhaDigitada = Console.ReadLine();

                Console.WriteLine("Senha ou usuário incorretos,tente novamente!");
            } while (usuarioDigitado != usuarioCorreto || senhaCorreta != senhaDigitada);
            Console.WriteLine("Login efetuado com sucesso!Bem-vindo aluno(a)");
        }
    }
}
