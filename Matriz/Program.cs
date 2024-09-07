using System;

public static class MatrizQuadrada
{
    // Método estático para gerar uma matriz quadrada N x N
    public static int[,] GerarMatrizQuadrada(int N)
    {
        Random rand = new Random();
        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = rand.Next(1, 10); // Preenche com números aleatórios de 1 a 9
            }
        }

        return matriz;
    }

    // Método estático para exibir a matriz
    public static void ExibirMatriz(int[,] matriz)
    {
        int N = matriz.GetLength(0);

        Console.WriteLine("Matriz:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Método estático para obter a diagonal principal
    public static int[] ObterDiagonalPrincipal(int[,] matriz)
    {
        int N = matriz.GetLength(0);
        int[] diagonal = new int[N];

        for (int i = 0; i < N; i++)
        {
            diagonal[i] = matriz[i, i];
        }

        return diagonal;
    }

    // Método estático para obter a diagonal secundária
    public static int[] ObterDiagonalSecundaria(int[,] matriz)
    {
        int N = matriz.GetLength(0);
        int[] diagonal = new int[N];

        for (int i = 0; i < N; i++)
        {
            diagonal[i] = matriz[i, N - 1 - i];
        }

        return diagonal;
    }

    // Método estático para calcular o determinante da matriz
    public static double CalcularDeterminante(int[,] matriz)
    {
        int N = matriz.GetLength(0);
        if (N == 1)
        {
            return matriz[0, 0];
        }
        else if (N == 2)
        {
            return matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
        }
        else
        {
            double det = 0;
            for (int p = 0; p < N; p++)
            {
                int[,] submatriz = ObterSubmatriz(matriz, 0, p);
                det += Math.Pow(-1, p) * matriz[0, p] * CalcularDeterminante(submatriz);
            }
            return det;
        }
    }

    // Método para obter a submatriz excluindo a linha e a coluna especificadas
    private static int[,] ObterSubmatriz(int[,] matriz, int excluirLinha, int excluirColuna)
    {
        int N = matriz.GetLength(0);
        int[,] submatriz = new int[N - 1, N - 1];

        int linha = 0, coluna = 0;
        for (int i = 0; i < N; i++)
        {
            if (i == excluirLinha) continue;
            coluna = 0;
            for (int j = 0; j < N; j++)
            {
                if (j == excluirColuna) continue;
                submatriz[linha, coluna] = matriz[i, j];
                coluna++;
            }
            linha++;
        }
        return submatriz;
    }

    // Método principal para testar a funcionalidade
    public static void Main()
    {

    }
}
