using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UTN.Winforms.Apolo.Entities.DTO;

namespace UTN.Winforms.Apolo.Entities
{
    class FacturaEncabezado
    {
        public int IdFactura { set; get; }
        public DateTime FechaFacturacion { set; get; }
        public Paciente _Paciente { set; get; }
        public string XML { get; set; }
        public int TipoPago { set; get; }
        public string ReferenciaMedica { set; get; }
        public int TipoEntregaExamen { set; get; }

        public List<FacturaDetalle> _ListaFacturaDetalle { get; } = new List<FacturaDetalle>();

        public void AddDetalle(FacturaDetalle pFacturaDetalle)
        {
            _ListaFacturaDetalle.Add(pFacturaDetalle);
        }

        public double GetSubTotal()
        {
            return _ListaFacturaDetalle.Sum(p => p.Costo);
        }

        public double GetImpuesto()
        {
            return _ListaFacturaDetalle.Sum(p => p.Impuesto);
        }
     }
}
