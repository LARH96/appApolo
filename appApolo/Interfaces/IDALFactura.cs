using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Entities.DTO;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IDALFactura
    {
        FacturaEncabezado SaveFactura(FacturaEncabezado pFactura);
        int GetNextNumeroFactura();
        int GetCurrentNumeroFactura();
        List<FacturaExamenDTO> GetAllFactura(EstadoExamen pEstadoExamen);
        List<FacturaExamenDTO> ReadAllFacturaByFilter(string pIdPaciente, EstadoExamen pEstadoExamen);
        bool UpdateEstadoDetalleFactura(FacturaDetalle oFacturaDetalle);
        List<FacturaExamenDTO> GetAllFacturaByFilterTipoEntregaExamen(EstadoExamen pEstadoExamen, int pTipoEntregaExamen);
    }
}
