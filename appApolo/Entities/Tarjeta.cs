using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winforms.Apolo.Entities
{
    class Tarjeta
    {
        public int IdTarjeta { get; set; }
        public string DescripcionTarjeta { get; set; }

        public override string ToString() => $"{DescripcionTarjeta}";
    }
}
