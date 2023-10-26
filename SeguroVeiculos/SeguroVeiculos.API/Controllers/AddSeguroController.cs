using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeguroVeiculos.API.Models.AddSeguro;
using SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro;
using SeguroVeiculos.Domain.Entities;

namespace SeguroVeiculos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddSeguroController : ControllerBase
    {
        private readonly IAddSeguroUseCase _addSeguroUseCase;
        public AddSeguroController(IAddSeguroUseCase addSeguroUseCase)
        {
            _addSeguroUseCase = addSeguroUseCase;
        }


        [HttpPost]
        public IActionResult AddSeguro(AddSeguroInput input)
        {
            var seguro = new Seguro(input.Nome, input.CPF, input.ValorVeiculo, input.MarcaModeloVeiculo, input.ValorVeiculo);
            _addSeguroUseCase.AddSeguro(seguro);
            return Created("", seguro);
        }
    }
}
