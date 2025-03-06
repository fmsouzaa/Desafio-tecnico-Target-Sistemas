using DesafioTecnico.Interface;

namespace DesafioTecnico.Services
{
    public class StringReversaService : IExercicioInterface
    {
        public void Executar()
        {
            Console.Write("Digite uma string: ");
            string palavra = Console.ReadLine();

            string palavraInvertida = "";

            // Laço para percorrer a string de trás para frente
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                // Concatena o caractere atual à string invertida
                palavraInvertida += palavra[i];
            }

            Console.WriteLine($"String invertida: {palavraInvertida}");
        }
    }
}
