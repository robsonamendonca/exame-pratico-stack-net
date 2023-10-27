using SeguroVeiculos.API.Models.AddSeguro;
using SeguroVeiculos.Domain.Contracts.Repositories.AddSeguro;
using SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro;
using SeguroVeiculos.Domain.Entities;

namespace SeguroVeiculos.Application.UseCases.AddSeguro
{
    public class AddSeguroUseCase : IAddSeguroUseCase
    {
        private readonly IAddSeguroRepository _addSeguroRepository;

        public AddSeguroUseCase(IAddSeguroRepository addSeguroRepository)
        {
            _addSeguroRepository = addSeguroRepository;
        }

        public void AddSeguro(Seguro seguro)
        {
            _addSeguroRepository.AddSeguro(seguro);
        }

        public void CalcularSeguro(double valorVeiculo)
        {
            _addSeguroRepository.CalulcarSeguro(valorVeiculo);
        }

        public Seguro PesquisarSeguro(string CPF)
        {
            return _addSeguroRepository.PesquisarSeguro(CPF);
        }

        public Relatorio GerarRelatorio()
        {
            return _addSeguroRepository.GerarRelatorio();
        }

    }
}
