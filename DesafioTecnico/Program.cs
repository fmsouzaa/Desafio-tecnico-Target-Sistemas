using DesafioTecnico.Services;
using DesafioTecnico.Interface;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando os serviços
        var somaService = new SomaService();
        var fibonacciService = new FibonacciService();
        var faturamentoService = new FaturamentoService();
        var percentualEstadosService = new PercentualEstadosService();
        var stringReversaService = new StringReversaService();

        bool executar = true;

        while (executar)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("============================================================");
            Console.WriteLine("          Menu de Exercícios - Escolha uma opção");
            Console.WriteLine("============================================================");
            Console.ResetColor();

            Console.WriteLine(" 1 - Exercício 1: Cálculo da Soma");
            Console.WriteLine(" 2 - Exercício 2: Sequência de Fibonacci");
            Console.WriteLine(" 3 - Exercício 3: Faturamento");
            Console.WriteLine(" 4 - Exercício 4: Percentual por Estado");
            Console.WriteLine(" 5 - Exercício 5: Inverter String");
            Console.WriteLine(" 0 - Sair");

            Console.WriteLine("\nDigite sua opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ExecutarExercicio(somaService);
                    break;

                case "2":
                    ExecutarExercicio(fibonacciService);
                    break;

                case "3":
                    ExecutarExercicio(faturamentoService);
                    break;

                case "4":
                    ExecutarExercicio(percentualEstadosService);
                    break;

                case "5":
                    ExecutarExercicio(stringReversaService);
                    break;

                case "0":
                    Console.WriteLine("Saindo...");
                    executar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            if (opcao != "0")
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }

    static void ExecutarExercicio(IExercicioInterface service)
    {
        service.Executar();
    }
}
