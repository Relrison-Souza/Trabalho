using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Financiamento.Tests
{
    [TestClass]
    public class FinanciamentoTests
    {
        [TestMethod]
        public void TestCalcularParcela_ValorTotal10000_TaxaMensal1_NumParcelas12()
        {
            // Arrange
            double valorTotal = 10000;
            double taxaMensal = 1; // 1% ao mês
            int numeroParcelas = 12;

            // Act
            double resultado = Program.CalcularParcela(valorTotal, taxaMensal, numeroParcelas);

            // Assert
            double esperado = 888.48; //valor esperado calculado com base na formula 
            Assert.AreEqual(esperado, resultado, 0.01, "O valor da parcela calculado não corresponde ao valor esperado.");
        }

        [TestMethod]
        public void TestCalcularParcela_ValorTotal20000_TaxaMensal0_5_NumParcelas24()
        {
            // Arrange
            double valorTotal = 20000;
            double taxaMensal = 0.5; // 0.5% ao mês
            int numeroParcelas = 24;

            // Act
            double resultado = Program.CalcularParcela(valorTotal, taxaMensal, numeroParcelas);

            // Assert
            double esperado = 886.41;//valor esperado com base na formula 
            Assert.AreEqual(esperado, resultado, 0.01, "O valor da parcela calculado não corresponde ao valor esperado.");
        }

        [TestMethod]
        public void TestCalcularParcela_ValorTotal5000_TaxaMensal2_NumParcelas6()
        {
            // Arrange
            double valorTotal = 5000;
            double taxaMensal = 2; // 2% ao mês
            int numeroParcelas = 6;

            // Act
            double resultado = Program.CalcularParcela(valorTotal, taxaMensal, numeroParcelas);

            // Assert
            double esperado = 892.63;//valo esperado calculado com base na fórmula
            Assert.AreEqual(esperado, resultado, 0.01, "O valor da parcela calculado não corresponde ao valor esperado.");
        }
    }
}
