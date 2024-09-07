using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMatriz
{
    [TestClass]
    public class TestMatriz
    {
        [TestMethod]
        public void TestObterDiagonalPrincipal()
        {
            // Arrange
            int[,] matriz = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int[] diagonalEsperada ={1, 5, 9 };

            // Act
            int[] diagonalPrincipal = MatrizQuadrada.ObterDiagonalPrincipal(matriz);
            // Assert
            CollectionAssert.AreEqual(diagonalEsperada, diagonalPrincipal);
        }

        [TestMethod]
        public void TestObterDiagonalSecundaria()
        {
            // Arrange
            int[,] matriz = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int[] diagonalEsperada = { 3, 5, 7 };

            // Act
            int[] diagonalSecundaria = MatrizQuadrada.ObterDiagonalSecundaria(matriz);

            // Assert
            CollectionAssert.AreEqual(diagonalEsperada, diagonalSecundaria);
        }

        [TestMethod]
        public void TestCalcularDeterminante()
        {
            // Arrange
            int[,] matriz = new int[,]
            {
                {1, 2},
                {3, 4}
            };
            double determinanteEsperado = -2; // Determinante para matriz 2x2 [1,2],[3,4]

            // Act
            double determinante = MatrizQuadrada.CalcularDeterminante(matriz);

            // Assert
            Assert.AreEqual(determinanteEsperado, determinante, 0.0001);
        }
    }
}
