using SeguroVeiculos.API.Models.AddSeguro;
using SeguroVeiculos.Domain.Entities;

namespace SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro
{
    public interface IAddSeguroUseCase
    {
        void AddSeguro(Seguro seguro);

        Seguro PesquisarSeguro(string CPF);

        void CalcularSeguro(double valorVeiculo);

        Relatorio GerarRelatorio();
    }
}
