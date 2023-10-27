using SeguroVeiculos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Contracts.Repositories.AddSeguro
{
    public interface IAddSeguroRepository
    {
        void AddSeguro(Seguro seguro);

        void PesquisarSeguro(string CPF);

        void CalulcarSeguro(decimal valorVeiculo);

        void GerarRelatorio();

    }
}
