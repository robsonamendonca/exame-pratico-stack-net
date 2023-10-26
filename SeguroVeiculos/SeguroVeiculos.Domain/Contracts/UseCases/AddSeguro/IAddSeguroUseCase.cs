using SeguroVeiculos.Domain.Entities;

namespace SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro
{
    public interface IAddSeguroUseCase
    {
        void AddSeguro(Seguro seguro);
    }
}
