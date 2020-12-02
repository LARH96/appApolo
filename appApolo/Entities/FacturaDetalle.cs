using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winforms.Apolo.Entities
{
    class FacturaDetalle
    {
        public int IdFactura { set; get; }
        public int Secuencia { set; get; }
        public string Examen { set; get; }
        public double Costo { set; get; }
        public double Impuesto { set; get; }
    }
}
