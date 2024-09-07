

namespace MenuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1. Financiamento de Veículo");
                Console.WriteLine("2. Operações com Matriz Quadrada");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ExecutarFinanciamento();
                        break;
                    case "2":
                        ExecutarMatrizQuadrada();
                        break;
                    case "3":
                        return; // Sai do programa
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ExecutarFinanciamento()
        {
            Console.Clear();
            Console.WriteLine("Financiamento de Veículo");

            // Exemplo de chamada para o método de financiamento
            Console.Write("Digite o valor do veículo: ");
            double valorVeiculo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da entrada: ");
            double valorEntrada = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de parcelas: ");
            int numParcelas = int.Parse(Console.ReadLine());

            Console.Write("Digite a taxa de juros mensal (em %): ");
            double taxaJuros = double.Parse(Console.ReadLine());

            double valorFinanciado = valorVeiculo - valorEntrada;

            double parcela = Financiamento.CalcularParcela(valorFinanciado, taxaJuros / 100, numParcelas);
            Console.WriteLine($"Valor da parcela: {parcela:C}");

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        private static void ExecutarMatrizQuadrada()
        {
            Console.Clear();
            Console.WriteLine("Operações com Matriz Quadrada");

            Console.Write("Digite o tamanho da matriz (N x N): ");
            int N = int.Parse(Console.ReadLine());

            // Gerar a matriz
            int[,] matriz = MatrizQuadrada.GerarMatrizQuadrada(N);

            // Exibir a matriz
            MatrizQuadrada.ExibirMatriz(matriz);

            // Obter e exibir a diagonal principal
            int[] diagonalPrincipal = MatrizQuadrada.ObterDiagonalPrincipal(matriz);
            Console.WriteLine("Diagonal Principal:");
            foreach (int num in diagonalPrincipal)
            {
                Console.Write(num + "\t");
            }
            Console.WriteLine();

            // Obter e exibir a diagonal secundária
            int[] diagonalSecundaria = MatrizQuadrada.ObterDiagonalSecundaria(matriz);
            Console.WriteLine("Diagonal Secundária:");
            foreach (int num in diagonalSecundaria)
            {
                Console.Write(num + "\t");
            }
            Console.WriteLine();

            // Calcular e exibir o determinante
            double determinante = MatrizQuadrada.CalcularDeterminante(matriz);
            Console.WriteLine($"Determinante: {determinante}");

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
