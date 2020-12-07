using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Entities.DTO;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.DAL;
using UTN.Winforms.Apolo.Properties;

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

        public double ReadSumaCostoDetalleFacturaByFilterIdFactura(int pIdFactura)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.ReadSumaCostoDetalleFacturaByFilterIdFactura(pIdFactura);
        }

        public double ReadSumaImpuestoDetalleFacturaByFilterIdFactura(int pIdFactura)
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.ReadSumaImpuestoDetalleFacturaByFilterIdFactura(pIdFactura);
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

        public void UpdateEstadoFacturaEncabezadoParaHacienda(List<FacturaExamenDTO> pListapFacturaExamenDTO)
        {
            IDALFactura _DALFactura = new DALFactura();

            foreach (FacturaExamenDTO oFacturaExamenDTO in pListapFacturaExamenDTO)
            {
                _DALFactura.UpdateEstadoFacturaEncabezadoParaHacienda(oFacturaExamenDTO);
            }
        }

        public List<FacturaExamenDTO> GetAllFacturaByFilterEstadoHaciendaSinEnviar()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetAllFacturaByFilterEstadoHaciendaSinEnviar();
        }

        public List<FacturaExamenDTO> FiltraRangoFechasFactura(List<FacturaExamenDTO> pListaFacturaExamenDTO, DateTime pFechaInicial, DateTime pFechaFinal)
        {
            List<FacturaExamenDTO> _ListaFacturaExamenDTO = new List<FacturaExamenDTO>();

            foreach (FacturaExamenDTO oFacturaExamenDTO in pListaFacturaExamenDTO)
            {
                if (oFacturaExamenDTO.Fecha.Date >= pFechaInicial.Date
                    &&
                    oFacturaExamenDTO.Fecha.Date <= pFechaFinal.Date)
                {
                    _ListaFacturaExamenDTO.Add(oFacturaExamenDTO);
                }
            }

            return _ListaFacturaExamenDTO;
        }

        public string CrearXMLFacturaIndividual(FacturaEncabezado pFacturaEncabezado)
        {
            /*XML ej
            <factura>
                <numerofactura>00001</numerofactura>
                <fecha>01/08/2013</fecha>
                <cliente>Maria </cliente>
                <monto>1000</monto>
                <impuesto>130</impuesto>
            <factura>
            */

            //-----Agrega linea "<?xml version="1.0"?>"
            XmlDocument documento = new XmlDocument();
            //XmlDeclaration declaracion = documento.CreateXmlDeclaration("1.0", null, null);
            //documento.AppendChild(declaracion);

            //-----crea documento XML y cargo los datos de las variables
            XmlElement factura = documento.CreateElement("factura"); //abre <raiz>

            XmlElement numeroFactura = documento.CreateElement("numeroFactura");
            numeroFactura.InnerText = pFacturaEncabezado.IdFactura.ToString();
            factura.AppendChild(numeroFactura);

            XmlElement fecha = documento.CreateElement("fecha");
            fecha.InnerText = pFacturaEncabezado.FechaFacturacion.ToString();
            factura.AppendChild(fecha);

            XmlElement cliente = documento.CreateElement("cliente");
            cliente.InnerText = pFacturaEncabezado._Paciente.Nombre.ToString() + " " + pFacturaEncabezado._Paciente.Apellidos.ToString();
            factura.AppendChild(cliente);

            XmlElement monto = documento.CreateElement("monto");
            monto.InnerText = pFacturaEncabezado._ListaFacturaDetalle.Sum(p => p.Costo).ToString();
            factura.AppendChild(monto);

            XmlElement impuesto = documento.CreateElement("impuesto");
            impuesto.InnerText = pFacturaEncabezado._ListaFacturaDetalle.Sum(p => p.Impuesto).ToString();
            factura.AppendChild(impuesto);

            documento.AppendChild(factura); //cierra factura
            return documento.OuterXml;
        }

        public string CrearXMLFacturaHacienda(List<FacturaExamenDTO> pListaFacturaExamenDTO, DateTime pFechaInicial, DateTime pFechaFinal)
        {
            /*XML ej
            <ministeriohaciendacr>
	        <comercio>
		        <consecutivo>0000000001</consecutivo>
		        <nombre> Laboratorio Clínico XXXX </nombre>
		        <cedula># de cédula Jurídica</cedula>
		        <fechainicial>01/03/2014 </fechainicial>
		        <fechafinal>02/03/2014 </fechafinal>
		        <montototalfacturado> 3000 </montototalfacturado>
		        <montototalimpuesto> 390 </montototalimpuesto>
	        </comercio>
	        <facturacion>
		        <factura>
			        <numerofactura>00001</numerofactura>
			        <fecha>01/08/2013</fecha>
			        <cliente>Maria </cliente>
			        <monto>1000</monto>
			        <impuesto>130</impuesto>
		        <factura>
			        </factura>
			        <numerofactura>00002</numerofactura>
			        <fecha>01/08/2013</fecha>
			        <cliente>Jose </cliente>
            */

            double montoTotalFacturado = 0d;
            double montoTotalImpuesto = 0d;
            IBLLMinisterioHacienda _IBLLMinisterioHacienda = new BLLMinisterioHacienda();
            IBLLFactura _IBLLFactura = new BLLFactura();

            foreach (FacturaExamenDTO oFacturaExamenDTO in pListaFacturaExamenDTO)
            {
                montoTotalFacturado += _IBLLFactura.ReadSumaCostoDetalleFacturaByFilterIdFactura(oFacturaExamenDTO.IdFactura);
                montoTotalImpuesto += _IBLLFactura.ReadSumaImpuestoDetalleFacturaByFilterIdFactura(oFacturaExamenDTO.IdFactura);
            }

            //-----Agrega linea "<?xml version="1.0"?>"
            XmlDocument documento = new XmlDocument();
            XmlDeclaration declaracion = documento.CreateXmlDeclaration("1.0", null, null);
            documento.AppendChild(declaracion);

            //-----crea documento XML y cargo los datos de las variables
            XmlElement ministeriohaciendacr = documento.CreateElement("ministeriohaciendacr");  //abre raiz

            #region Llena encabezado XML
            XmlElement comercio = documento.CreateElement("comercio"); //abre comercio

            XmlElement cliente = documento.CreateElement("consecutivo");
            cliente.InnerText = _IBLLMinisterioHacienda.GetCurrentNumeroConsecutivo().ToString();
            comercio.AppendChild(cliente);

            XmlElement nombre = documento.CreateElement("nombre");
            nombre.InnerText = "Laboratorio Clínico " + Settings.Default.NombreLaboratorio;
            comercio.AppendChild(nombre);

            XmlElement cedula = documento.CreateElement("cedula");
            cedula.InnerText = Settings.Default.CedJuridica;
            comercio.AppendChild(cedula);

            XmlElement fechainicial = documento.CreateElement("fechainicial");
            fechainicial.InnerText = pFechaInicial.ToString();
            comercio.AppendChild(fechainicial);

            XmlElement fechafinal = documento.CreateElement("fechafinal");
            fechafinal.InnerText = pFechaFinal.ToString();
            comercio.AppendChild(fechafinal);

            XmlElement montototalfacturado = documento.CreateElement("montototalfacturado");
            montototalfacturado.InnerText = montoTotalFacturado.ToString();
            comercio.AppendChild(montototalfacturado);

            XmlElement montototalimpuesto = documento.CreateElement("montototalimpuesto");
            montototalimpuesto.InnerText = montoTotalImpuesto.ToString();
            comercio.AppendChild(montototalimpuesto);

            ministeriohaciendacr.AppendChild(comercio); //cierra comercio
            #endregion

            XmlElement facturacion = documento.CreateElement("facturacion");

            //campos iteracionados
            foreach (FacturaExamenDTO oFacturaExamenDTO in pListaFacturaExamenDTO)
            {
                facturacion.InnerXml += oFacturaExamenDTO.XML; //llena  factura
            }

            ministeriohaciendacr.AppendChild(facturacion);
            documento.AppendChild(ministeriohaciendacr); 
            return documento.OuterXml;
        }
    }
}
