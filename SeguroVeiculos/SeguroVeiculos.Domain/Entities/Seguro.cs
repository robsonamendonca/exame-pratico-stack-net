using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Entities
{
    public class Seguro
    {
        public Seguro(string nome, string cpf, double valorVeiculo, string marcaModeloveiculo)
        {
            Nome = nome;
            CPF = cpf;
            ValorVeiculo = valorVeiculo;
            MarcaModeloVeiculo = marcaModeloveiculo;
        }

        public string Nome { get; private set; } 
        public string CPF { get; private set; } 
        public double ValorVeiculo { get; private set; }
        public string MarcaModeloVeiculo { get; private set; } 
        public double ValorSeguro { get; private set; }


        public void CalcularSeguro()
        {
            const double MARGEM_SEGURANCA = 0.03;
            const double LUCRO = 0.05;

            double taxaRisco = ((ValorVeiculo * 5) / (ValorVeiculo * 2) / 100);
            double premioRisco = taxaRisco * ValorVeiculo;
            double premioPuro = premioRisco * (1 + MARGEM_SEGURANCA);
            double premioComercial = (LUCRO * premioPuro) + premioPuro;

            ValorSeguro = Math.Round(premioComercial, 2, MidpointRounding.ToZero); ;
        }

    }
}
