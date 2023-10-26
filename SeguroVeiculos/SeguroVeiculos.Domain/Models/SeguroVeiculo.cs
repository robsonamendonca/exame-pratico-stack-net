using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Models
{
    public class SeguroVeiculo
    {
        public int Id { get; set; }
        public int SeguradoId { get; set; }
        public int VeiculoId { get; set; }

        public decimal ValorSeguro { get; set; }
    }
}
