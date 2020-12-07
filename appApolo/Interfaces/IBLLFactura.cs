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
        double ReadSumaCostoDetalleFacturaByFilterIdFactura(int pIdFactura);
        double ReadSumaImpuestoDetalleFacturaByFilterIdFactura(int pIdFactura);
        List<FacturaExamenDTO> GetAllFacturaByFilterEstadoHaciendaSinEnviar();
        List<FacturaExamenDTO> GetAllFacturaByFilterTipoEntregaExamen(EstadoExamen pEstadoExamen, int pTipoEntregaExamen);
        List<FacturaExamenDTO> FiltraRangoFechasFactura(List<FacturaExamenDTO> pListaFacturaExamenDTO, DateTime pFechaInicial, DateTime pFechaFinal);
        bool UpdateEstadoDetalleFactura(FacturaDetalle oFacturaDetalle);
        void UpdateEstadoFacturaEncabezadoParaHacienda(List<FacturaExamenDTO> pListapFacturaExamenDTO);
        string CrearXMLFacturaIndividual(FacturaEncabezado pFacturaEncabezado);
        string CrearXMLFacturaHacienda(List<FacturaExamenDTO> pListaFacturaExamenDTO,DateTime pFechaInicial, DateTime pFechaFinal);
    }
}
