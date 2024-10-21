using Calculadora.Domain.CdbRoot.Dtos;

namespace Calculadora.Domain.CdbRoot.Interfaces
{
    public interface ICdbService
    {
        CdbDto Calcular(decimal ValorInicial, int PrazoMeses);
    }
}
