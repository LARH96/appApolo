using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winforms.Apolo.Entities
{
    class FacturaDetalle
    {
        public double IdFactura { set; get; }
        public int Secuencia { set; get; }
        public string IdExamen { set; get; }
        public int Cantidad { set; get; }
        public double Precio { set; get; }
        public double Impuesto { set; get; }
    }
}
