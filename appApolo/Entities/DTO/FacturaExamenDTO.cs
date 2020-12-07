using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winforms.Apolo.Entities.DTO
{
    public class FacturaExamenDTO
    {
        //Para Doctor
        public int IdPaciente { get; set; }

        //Para insertar en Registro Examen
        public int IdFactura { get; set; }
        public int Secuencia { get; set; }
        public string IdExamen { get; set; }

        //Para Doctor
        public string DescripcionExamen { get; set; }

        //Para Factura
        public DateTime Fecha { get; set; }
        public string XML { get; set; }

    }
}
