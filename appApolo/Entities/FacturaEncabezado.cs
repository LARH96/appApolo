using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public string CrearXML()
        {
            /*
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
            XmlDeclaration declaracion = documento.CreateXmlDeclaration("1.0", null, null);
            documento.AppendChild(declaracion);

            //-----crea documento XML y cargo los datos de las variables
            XmlElement factura = documento.CreateElement("factura"); //abre <raiz>

            XmlElement numeroFactura = documento.CreateElement("numeroFactura");
            numeroFactura.InnerText = this.IdFactura.ToString();
            factura.AppendChild(numeroFactura);

            XmlElement fecha = documento.CreateElement("fecha");
            fecha.InnerText = this.FechaFacturacion.ToString();
            factura.AppendChild(fecha);

            XmlElement cliente = documento.CreateElement("cliente");
            cliente.InnerText = this._Paciente.Nombre.ToString() + " " + this._Paciente.Apellidos.ToString();
            factura.AppendChild(cliente);

            XmlElement monto = documento.CreateElement("monto");
            monto.InnerText = this._ListaFacturaDetalle.Sum(p => p.Costo).ToString();
            factura.AppendChild(monto);

            XmlElement impuesto = documento.CreateElement("impuesto");
            impuesto.InnerText = this._ListaFacturaDetalle.Sum(p => p.Impuesto).ToString();
            factura.AppendChild(impuesto);

            documento.AppendChild(factura); //cierra factura
            return documento.OuterXml;
        }
    }
}
