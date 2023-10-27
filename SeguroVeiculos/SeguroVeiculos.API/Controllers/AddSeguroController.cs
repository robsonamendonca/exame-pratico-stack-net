using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SeguroVeiculos.API.Models.AddSeguro;
using SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro;
using SeguroVeiculos.Domain.Entities;
using WebApi.Models.Error;

namespace SeguroVeiculos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddSeguroController : ControllerBase
    {
        private readonly IAddSeguroUseCase _addSeguroUseCase;
        private readonly IValidator<AddSeguroInput> _addSeguroInputrValidator;
        public AddSeguroController(IAddSeguroUseCase addSeguroUseCase, IValidator<AddSeguroInput> addSeguroInputrValidator)
        {
            _addSeguroUseCase = addSeguroUseCase;
            _addSeguroInputrValidator = addSeguroInputrValidator;
        }


        [HttpPost]
        public IActionResult AddSeguro(AddSeguroInput input)
        {
            var validatorResult = _addSeguroInputrValidator.Validate(input);
            if (!validatorResult.IsValid)
            {
                return BadRequest(validatorResult.Errors.ToCustomValidationFailure());
            }
            var seguro = new Seguro(input.Nome, input.CPF, input.ValorVeiculo, input.MarcaModeloVeiculo);
            seguro.CalcularSeguro();
            _addSeguroUseCase.AddSeguro(seguro);
            return Created("", seguro);
        }

        [HttpGet]
        [Route("Pesquisar/")]
        public IActionResult GetSeguro(string CPF)
        {
             _addSeguroUseCase.PesquisarSeguro(CPF);
            return Ok(CPF);
        }


        [HttpGet]
        [Route("Calcular/")]
        public IActionResult GetCalcular(double valorVeiculo)
        {
            return Ok(valorVeiculo);
        }

        [HttpGet]
        [Route("Gerar/")]
        public IActionResult GetRelatorio()
        {
            return Ok("ok");
        }

    }
}
