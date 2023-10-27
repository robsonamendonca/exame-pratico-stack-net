using SeguroVeiculos.API.Models.AddSeguro;
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

        Seguro PesquisarSeguro(string CPF);

        Seguro CalulcarSeguro(double valorVeiculo);

        Relatorio GerarRelatorio();

    }
}
