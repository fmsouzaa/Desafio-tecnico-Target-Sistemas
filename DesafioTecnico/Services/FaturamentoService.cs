using System.Text.Json;
using System.Text.Json.Serialization;
using DesafioTecnico.Interface;

namespace DesafioTecnico.Services
{
    public class FaturamentoService : IExercicioInterface
    {
        public void Executar()
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Data\dados.json");
            string caminhoAbsoluto = Path.GetFullPath(caminho);

            var dados = LerJson(caminhoAbsoluto);
            CalcularFaturamento(dados);
        }

        // Método para ler e desserializar o arquivo JSON para uma lista de objetos Faturamento
        public List<Faturamento> LerJson(string caminho)
        {
            try
            {
                string json = File.ReadAllText(caminho);
                var resultado = JsonSerializer.Deserialize<List<Faturamento>>(json);

                if (resultado is null)
                    Console.WriteLine("O arquivo JSON está vazio ou inválido.");

                return resultado;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Diretório não encontrado: {caminho}");
                throw;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
                throw;
            }

        }

        // Método para calcular e exibir o menor, maior faturamento e a quantidade de dias acima da média
        public void CalcularFaturamento(List<Faturamento> dados)
        {
            // Filtra os dias que possuem um valor de faturamento maior que zero
            var diasComFaturamento = dados.Where(x => x.Valor > 0).ToList();

            double menorFaturamento = diasComFaturamento.Min(x => x.Valor);
            double maiorFaturamento = diasComFaturamento.Max(x => x.Valor);
            double mediaMensal = diasComFaturamento.Average(x => x.Valor);
            
            int diasAcimaDaMedia = diasComFaturamento.Count(x => x.Valor > mediaMensal);

            Console.WriteLine($"Menor faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
            Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");
        }

        // Classe que representa os dados de faturamento
        public class Faturamento
        {
            [JsonPropertyName("dia")]
            public int Dia { get; set; }

            [JsonPropertyName("valor")]
            public double Valor { get; set; }
        }
    }

}
