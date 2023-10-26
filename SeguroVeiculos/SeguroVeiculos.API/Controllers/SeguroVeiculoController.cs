using Microsoft.AspNetCore.Mvc;
using SeguroVeiculos.Application.Services;

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

        [HttpPost("gravar")]
        public IActionResult GravarSeguroVeiculo([FromBody] decimal valorVeiculo)
        {
            var premio = _calculoSeguroService.CalcularSeguro(valorVeiculo);
            return Ok(premio);
        }


        [HttpPost("calcular")]
        public IActionResult CalcularSeguro([FromBody] decimal valorVeiculo)
        {
            var premio = _calculoSeguroService.CalcularSeguro(valorVeiculo);
            return Ok(premio);
        }

        [HttpPost("pesquisar")]
        public IActionResult Pesquisar([FromBody] decimal valorVeiculo)
        {
            var premio = _calculoSeguroService.CalcularSeguro(valorVeiculo);
            return Ok(premio);
        }

        [HttpPost("gerarRelatorio")]
        public IActionResult gerarRelatorio([FromBody] decimal valorVeiculo)
        {
            var premio = _calculoSeguroService.CalcularSeguro(valorVeiculo);
            return Ok(premio);
        }

    }

}
