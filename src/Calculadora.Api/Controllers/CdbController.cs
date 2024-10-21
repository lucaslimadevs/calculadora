using Calculadora.Api.Models.InputModels;
using Calculadora.Domain.CdbRoot.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CdbController : ControllerBase
    {
        private readonly ICdbService _service;

        public CdbController(ICdbService service)
        {
            _service = service;
        }

        [HttpPost("calcular")]
        public IActionResult Calcular([FromBody] CdbInputModel model)
        {
            var result = _service.Calcular(model.ValorInicial, model.PrazoMeses);

            return Ok(result);
        }
    }
}
