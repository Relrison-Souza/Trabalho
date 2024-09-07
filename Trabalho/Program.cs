using System;

public class Program
{
    // Método para calcular o valor da parcela do financiamento
    public static double CalcularParcela(double valorTotal, double taxaMensal, int numeroParcelas)
    {
        // Convertendo a taxa de juros mensal para decimal
        taxaMensal /= 100;

        // Fórmula para o cálculo da parcela fixa
        double parcela = valorTotal * taxaMensal / (1 - Math.Pow(1 + taxaMensal, -numeroParcelas));

        return parcela;
    }

    static void Main()
    {
        // Código principal
    }
}
