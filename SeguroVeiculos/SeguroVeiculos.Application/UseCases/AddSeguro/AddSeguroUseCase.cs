using SeguroVeiculos.Domain.Contracts.Repositories.AddSeguro;
using SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro;
using SeguroVeiculos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
