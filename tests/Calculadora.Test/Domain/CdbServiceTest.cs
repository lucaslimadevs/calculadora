using Calculadora.Domain.CdbRoot.Services;

namespace Calculadora.Tests
{
    public class CdbServiceTests
    {
        private readonly CdbService _cdbService;

        public CdbServiceTests()
        {
            _cdbService = new CdbService();
        }

        [Theory]
        [InlineData(1000, 6, 1059.76)]
        [InlineData(1000, 12, 1123.08)]
        [InlineData(1000, 24, 1261.31)]
        [InlineData(1000, 25, 1273.57)]
        public void CalcularValorBruto_ValoresCorretos(decimal valorInicial, int prazoMeses, decimal valorEsperado)
        {
            // Act
            var resultado = _cdbService.Calcular(valorInicial, prazoMeses);

            // Assert
            Assert.Equal(valorEsperado, resultado.ValorBruto, 2);
        }

        [Theory]
        [InlineData(1000, 6, 13.45)]
        [InlineData(1000, 12, 24.62)]
        [InlineData(1000, 24, 45.73)]
        [InlineData(1000, 25, 41.04)]
        public void CalcularImposto_ValoresCorretos(decimal valorInicial, int prazoMeses, decimal valorImpostoEsperado)
        {
            // Arrange
            var valores = _cdbService.Calcular(valorInicial, prazoMeses);

            // Act
            var imposto = valores.ValorBruto - valores.ValorLiquido;

            // Assert
            Assert.Equal(valorImpostoEsperado, imposto, 2);
        }

        [Theory]
        [InlineData(1000, 6, 1046.31)]
        [InlineData(1000, 12, 1098.47)]
        [InlineData(1000, 24, 1215.58)]
        [InlineData(1000, 25, 1232.54)]
        public void Calcular_ValoresLiquidoCorretos(decimal valorInicial, int prazoMeses, decimal valorLiquidoEsperado)
        {
            // Act
            var resultado = _cdbService.Calcular(valorInicial, prazoMeses);

            // Assert
            Assert.Equal(valorLiquidoEsperado, resultado.ValorLiquido, 2);
        }
    }
}