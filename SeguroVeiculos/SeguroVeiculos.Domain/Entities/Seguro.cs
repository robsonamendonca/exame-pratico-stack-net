using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Entities
{
    public class Seguro
    {
        public Seguro(string nome, string cpf, string valorVeiculo, string marcaModeloveiculo, string valorSeguro)
        {
            Nome = nome;
            CPF = cpf;
            ValorVeiculo = valorVeiculo;
            MarcaModeloVeiculo = marcaModeloveiculo;
            ValorSeguro = valorSeguro;
        }

        public string Nome { get; private set; } 
        public string CPF { get; private set; } 
        public string ValorVeiculo { get; private set; }
        public string MarcaModeloVeiculo { get; private set; } 
        public string ValorSeguro { get; private set; } 
    }
}
