using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Entities.DTO;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IBLLFactura
    {
        FacturaEncabezado SaveFactura(FacturaEncabezado pFactura);
        int GetNextNumeroFactura();
        int GetCurrentNumeroFactura();
        List<FacturaExamenDTO> GetAllFactura(EstadoExamen pEstadoExamen);
        List<FacturaExamenDTO> ReadAllFacturaByFilter(string pIdPaciente, EstadoExamen pEstadoExamen);
        List<FacturaExamenDTO> GetAllFacturaByFilterTipoEntregaExamen(EstadoExamen pEstadoExamen, int pTipoEntregaExamen);
        bool UpdateEstadoDetalleFactura(FacturaDetalle oFacturaDetalle);
    }
}
