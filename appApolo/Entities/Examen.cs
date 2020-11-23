using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winforms.Apolo.Entities
{
    class Examen
    {
        public string IdExamen { get; set; }

        public string Descripcion { get; set; }

        public string TipoExamen { get; set; }

        public double Costo { get; set; }

        public double ValorMinimo { get; set; }

        public double ValorMaximo { get; set; }
    }
}
