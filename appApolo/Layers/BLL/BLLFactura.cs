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

        public List<FacturaExamenDTO> GetAllFactura(EstadoExamen pEstadoExamen)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetAllFactura(pEstadoExamen);
        }

        public List<FacturaExamenDTO> ReadAllFacturaByFilter(string pIdPaciente, EstadoExamen pEstadoExamen)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.ReadAllFacturaByFilter(pIdPaciente,pEstadoExamen);
        }

        public List<FacturaExamenDTO> GetAllFacturaByFilterTipoEntregaExamen(EstadoExamen pEstadoExamen, int pTipoEntregaExamen)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetAllFacturaByFilterTipoEntregaExamen(pEstadoExamen, pTipoEntregaExamen);
        }

        public bool UpdateEstadoDetalleFactura(FacturaDetalle oFacturaDetalle)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.UpdateEstadoDetalleFactura(oFacturaDetalle);
        }
    }
}
