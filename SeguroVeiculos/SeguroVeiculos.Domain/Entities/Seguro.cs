using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Entities
{
    public class Seguro
    {
        public Seguro(string nome, string cpf, decimal valorVeiculo, string marcaModeloveiculo, decimal valorSeguro)
        {
            Nome = nome;
            CPF = cpf;
            ValorVeiculo = valorVeiculo;
            MarcaModeloVeiculo = marcaModeloveiculo;
            ValorSeguro = valorSeguro;
        }

        public string Nome { get; private set; } 
        public string CPF { get; private set; } 
        public decimal ValorVeiculo { get; private set; }
        public string MarcaModeloVeiculo { get; private set; } 
        public decimal ValorSeguro { get; private set; } 
    }
}
