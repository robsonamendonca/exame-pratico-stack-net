﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguroVeiculos.Domain.Models
{
    internal class Segurado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
    }
}
