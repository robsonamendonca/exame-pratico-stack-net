using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Application.Services
{
    public class CalculoSeguroService
    {
        public decimal CalcularSeguro(decimal valorVeiculo)
        {
            const decimal MARGEM_SEGURANCA = 0.03m;
            const decimal LUCRO = 0.05m;

            decimal taxaRisco = valorVeiculo * 5 / (2 * valorVeiculo);
            decimal premioRisco = taxaRisco * valorVeiculo;
            decimal premioPuro = premioRisco * (1 + MARGEM_SEGURANCA);
            decimal premioComercial = LUCRO * premioPuro;

            return premioComercial;
        }
    }
}
