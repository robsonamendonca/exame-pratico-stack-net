using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using SeguroVeiculos.API.Models.AddSeguro;
using SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro;
using SeguroVeiculos.Domain.Entities;
using WebApi.Models.Error;

namespace SeguroVeiculos.API.Controllers
{
    [Produces("application/json")]
    [Route("api")]
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
        [Route("Gravar/")]
        public IActionResult AddSeguro(AddSeguroInput input)
        {
            var validatorResult = _addSeguroInputrValidator.Validate(input);
            if (!validatorResult.IsValid)
            {
                return BadRequest(validatorResult.Errors.ToCustomValidationFailure());
            }
            var seguro = new Seguro(input.Nome, input.CPF,input.Idade, input.ValorVeiculo, input.MarcaModeloVeiculo);
            seguro.CalcularSeguro();
            _addSeguroUseCase.AddSeguro(seguro);
            return Created("", seguro);
        }

        [HttpGet]
        [Route("Pesquisar/{CPF}")]
        public IActionResult GetSeguro(string CPF)
        {
             var  seguro = _addSeguroUseCase.PesquisarSeguro(CPF);
            if (seguro== null)
            {
                return BadRequest("Nenhum dado encontrado!");
            }
            return Ok(seguro);
        }


        [HttpGet]
        [Route("Calcular/{valorVeiculo}")]
        public IActionResult GetCalcular(double valorVeiculo)
        {
            var seguro = new Seguro("Simulação","999999",99,valorVeiculo,"SIMULACAO_POR_VALOR");
            seguro.CalcularSeguro();
            return Ok(seguro);
        }

        [HttpGet]
        [Route("Gerar/")]
        public IActionResult GetRelatorio()
        {
            var relatorio = _addSeguroUseCase.GerarRelatorio();
            if (relatorio == null)
            {
                return BadRequest("Nenhum dado encontrado!");
            }
            return Ok(relatorio);
        }

    }
}
