using DesafioTecnico.Interface;

namespace DesafioTecnico.Services
{
    public class PercentualEstadosService : IExercicioInterface
    {
        public void Executar()
        {
            var estadosFaturamento = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            // Calcula o total de faturamento somando os valores dos estados
            double totalFaturamento = estadosFaturamento.Values.Sum();

            foreach (var estado in estadosFaturamento)
            {
                // Calcula o percentual de faturamento de cada estado em relação ao total
                double percentual = (estado.Value / totalFaturamento) * 100;

                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }
        }
    }
    
}
