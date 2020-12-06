using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.DAL;

namespace UTN.Winforms.Apolo.Layers.BLL
{
    class BLLExamen : IBLLExamen
    {
        public bool CreateExamen(Examen pExamen)
        {
            IDALExamen _IDALExamen = new DALExamen();
            return _IDALExamen.CreateExamen(pExamen);
        }

        public Examen ReadExamenById(string pId)
        {
            IDALExamen _IDALExamen = new DALExamen();
            return _IDALExamen.ReadExamenById(pId);
        }

        public List<Examen> ReadAllExamen()
        {
            IDALExamen _IDALExamen = new DALExamen();
            return _IDALExamen.ReadAllExamen();
        }

        public List<Examen> ReadExamenByFilter(string pDescripcion)
        {
            IDALExamen _IDALExamen = new DALExamen();
            return _IDALExamen.ReadExamenByFilter(pDescripcion);
        }

        public bool SaveExamen(Examen pExamen)
        {
            IDALExamen _IDALExamen = new DALExamen();
            bool result = false;
            if (_IDALExamen.ReadExamenById(pExamen.IdExamen) == null)
                result = _IDALExamen.CreateExamen(pExamen);
            else
                result = _IDALExamen.UpdateExamen(pExamen);

            return result;
        }

        public bool DeleteExamen(string pId)
        {
            IDALExamen _IDALExamen = new DALExamen();
            return _IDALExamen.DeleteExamen(pId);
        }

        public string CalculaResultadoExamen(Examen pExamen, FacturaDetalle pFacturaDetalle)
        {
            string result = "";
            DALExamen oDALExamen = new DALExamen();
            DALRegistroExamen oDALRegistroExamen = new DALRegistroExamen();

            RegistroExamen oRegistroExamen = new RegistroExamen();
            Examen oExamen = new Examen();

            oRegistroExamen = oDALRegistroExamen.ReadRegistroExamenByFilterFacturaYSecuencia(pFacturaDetalle.IdFactura,
                                                                                             pFacturaDetalle.Secuencia);
            oExamen = oDALExamen.ReadExamenById(pExamen.IdExamen);

            if ((oRegistroExamen.Valor <= oExamen.ValorMaximo)
                &&
                (oRegistroExamen.Valor <= oExamen.ValorMinimo))
            {
                result = ResultadoExamen.Normal.ToString();
            }else if (oRegistroExamen.Valor >= oExamen.ValorMaximo)
            {
                result = ResultadoExamen.Alto.ToString();
            }
            else if (oRegistroExamen.Valor <= oExamen.ValorMinimo)
            {
                result = ResultadoExamen.Bajo.ToString();
            }

            return result;
        }
    }
}
