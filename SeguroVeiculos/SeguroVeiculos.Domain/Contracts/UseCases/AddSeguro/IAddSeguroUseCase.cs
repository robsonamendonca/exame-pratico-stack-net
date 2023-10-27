using SeguroVeiculos.Domain.Entities;

namespace SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro
{
    public interface IAddSeguroUseCase
    {
        void AddSeguro(Seguro seguro);

        void PesquisarSeguro(string CPF);

        void CalcularSeguro(double valorVeiculo);
    }
}
