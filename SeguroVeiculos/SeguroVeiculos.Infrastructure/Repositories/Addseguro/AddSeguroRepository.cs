using SeguroVeiculos.Domain.Contracts.Repositories.AddSeguro;
using SeguroVeiculos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Infrastructure.Repositories.Addseguro
{
    public class AddSeguroRepository : IAddSeguroRepository
    {
        private readonly IList<Seguro> _seguros = new List<Seguro>(); 
        public void AddSeguro(Seguro seguro)
        {
            _seguros.Add(seguro);
        }
    }
}
