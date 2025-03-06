using DesafioTecnico.Interface;

namespace DesafioTecnico.Services
{
    public class SomaService : IExercicioInterface
    {
        public void Executar()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k++;
                soma =+ k;
            }

            Console.WriteLine($"Valor da soma é: {soma}");
        }
    }
}
