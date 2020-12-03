using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winforms.Apolo.Entities
{
    class RegistroExamen
    {
        public int SecuenciaRegistroExamen { get; set; }
        public int IdDoctorEspecialista { get; set; }
        public int IdFactura { get; set; }
        public int SecuenciaDetalleFact { get; set; }
        public string IdExamen { get; set; }
        public double Valor { get; set; }
        public DateTime FechaMuestra { get; set; }
    }
}
