using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Entities.DTO;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.DAL;

namespace UTN.Winforms.Apolo.Layers.BLL
{
    class BLLFactura : IBLLFactura
    {
        public int GetNextNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetNextNumeroFactura();
        }

        public int GetCurrentNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetCurrentNumeroFactura();
        }

        public FacturaEncabezado SaveFactura(FacturaEncabezado pFactura)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.SaveFactura(pFactura);
        }


        public double GetTotalFactura(double pIdFactura)
        {
            DALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetTotalFactura(pIdFactura);

        }

        public List<FacturaExamenDTO> GetAllFacturaPendiente()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetAllFacturaPendiente();
        }

        public List<FacturaExamenDTO> ReadAllFacturaPendienteByFilter(string pIdPaciente)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.ReadAllFacturaPendienteByFilter(pIdPaciente);
        }

        public bool UpdateEstadoDetalleFactura(FacturaDetalle oFacturaDetalle)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.UpdateEstadoDetalleFactura(oFacturaDetalle);
        }
    }
}
