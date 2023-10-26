using SeguroVeiculos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Contracts.UseCases.AddSeguro
{
    public interface IAddSeguroUseCase
    {
        void AddSeguro(Seguro seguro);
    }
}
