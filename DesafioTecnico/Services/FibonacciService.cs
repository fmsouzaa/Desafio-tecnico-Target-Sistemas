using DesafioTecnico.Interface;

namespace DesafioTecnico.Services
{
    public class FibonacciService : IExercicioInterface
    {
        public void Executar()
        {
            Console.Write("Digite um número para verificar se está na sequência de Fibonacci: ");
            int numero = int.Parse(Console.ReadLine());

            if (VerificaFibonacci(numero))
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }

        // Função que verifica se o número está na sequência de Fibonacci
        private bool VerificaFibonacci(int numero)
        {
            int a = 0;
            int b = 1;
            int valor;

            // Gera a sequência até o número solicitado
            while (b < numero)
            {
                valor = a + b;
                a = b;
                b = valor;
            }

            return (b == numero);
        }
    }
}
