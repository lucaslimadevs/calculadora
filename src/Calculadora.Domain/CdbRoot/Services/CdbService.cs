using Calculadora.Domain.CdbRoot.Dtos;
using Calculadora.Domain.CdbRoot.Interfaces;

namespace Calculadora.Domain.CdbRoot.Services
{
    public class CdbService : ICdbService
    {
        private const decimal CDI = 0.009m;
        private const decimal TB = 1.08m;

        public CdbDto Calcular(decimal ValorInicial, int PrazoMeses)
        {
            var result = new CdbDto();

            result.ValorBruto = CalcularValorBruto(ValorInicial, PrazoMeses);
            var imposto = CalcularImposto(result.ValorBruto, ValorInicial, PrazoMeses);
            result.ValorLiquido = CalcularValorLiquido(result.ValorBruto, imposto);

            return result;
        }

        private static decimal CalcularValorBruto(decimal valorInicial, int prazoMeses)
        {
            decimal valorFinal = valorInicial;

            for (int i = 0; i < prazoMeses; i++)
            {
                valorFinal *= (1 + (CDI * TB));
            }

            return valorFinal;
        }

        private static decimal CalcularImposto(decimal valorBruto, decimal valorInicial, int prazoMeses)
        {
            decimal rendimento = valorBruto - valorInicial;
            decimal aliquota = ObterAliquota(prazoMeses);
            return rendimento * aliquota;
        }

        private static decimal ObterAliquota(int prazoMeses)
        {
            if (prazoMeses <= 6)
                return 0.225m; 
            else if (prazoMeses <= 12)
                return 0.20m;  
            else if (prazoMeses <= 24)
                return 0.175m; 
            else
                return 0.15m;
        }

        public static decimal CalcularValorLiquido(decimal valorBruto, decimal imposto)
        {
            return valorBruto - imposto;
        }        
    }
}
