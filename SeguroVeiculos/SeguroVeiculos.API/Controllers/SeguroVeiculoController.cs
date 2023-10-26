using Microsoft.AspNetCore.Mvc;

namespace SeguroVeiculos.API.Controllers
{
    [ApiController]
    [Route("api/seguro")]
    public class SeguroController : ControllerBase
    {
        private readonly CalculoSeguroService _calculoSeguroService;

        public SeguroController(CalculoSeguroService calculoSeguroService)
        {
            _calculoSeguroService = calculoSeguroService;
        }

        [HttpPost("calcular")]
        public IActionResult CalcularSeguro([FromBody] decimal valorVeiculo)
        {
            var premio = _calculoSeguroService.CalcularSeguro(valorVeiculo);
            return Ok(premio);
        }
    }

}
