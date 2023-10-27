using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Entities
{
    public class Seguro
    {
        public Seguro(string nome, string cpf, decimal valorVeiculo, string marcaModeloveiculo)
        {
            Nome = nome;
            CPF = cpf;
            ValorVeiculo = valorVeiculo;
            MarcaModeloVeiculo = marcaModeloveiculo;
        }

        public string Nome { get; private set; } 
        public string CPF { get; private set; } 
        public decimal ValorVeiculo { get; private set; }
        public string MarcaModeloVeiculo { get; private set; } 
        public decimal ValorSeguro { get; private set; }


        public void CalcularSeguro()
        {
            const decimal MARGEM_SEGURANCA = 0.03m;
            const decimal LUCRO = 0.05m;

            decimal taxaRisco = (ValorVeiculo * 5) / (2 * ValorVeiculo);
            decimal premioRisco = taxaRisco * ValorVeiculo;
            decimal premioPuro = premioRisco * (1 + MARGEM_SEGURANCA);
            decimal premioComercial = LUCRO * premioPuro;

            ValorSeguro =  premioComercial;
        }

    }
}
