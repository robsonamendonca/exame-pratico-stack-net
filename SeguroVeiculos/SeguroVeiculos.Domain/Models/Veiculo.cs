using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string MarcaModelo { get; set; }
    }
}
