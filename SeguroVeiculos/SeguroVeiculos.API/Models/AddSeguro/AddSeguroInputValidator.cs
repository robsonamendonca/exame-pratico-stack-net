using FluentValidation;

namespace SeguroVeiculos.API.Models.AddSeguro
{
    public class AddSeguroInputValidator : AbstractValidator<AddSeguroInput>
    {
        public AddSeguroInputValidator() 
        {
            RuleFor(c => c.Nome).NotEmpty();
            RuleFor(c => c.CPF).IsValidCPF().WithMessage("'CPF' informado é inválido.");
            RuleFor(c => c.ValorVeiculo).NotEmpty();
            RuleFor(c => c.MarcaModeloVeiculo).NotEmpty();

        }
    }
}
