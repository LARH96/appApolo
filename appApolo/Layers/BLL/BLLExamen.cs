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

        public bool UpdateExamen(Examen pExamen)
        {
            IDALExamen _IDALExamen = new DALExamen();
            return _IDALExamen.UpdateExamen(pExamen);
        }

        public bool DeleteExamen(string pId)
        {
            IDALExamen _IDALExamen = new DALExamen();
            return _IDALExamen.DeleteExamen(pId);
        }
    }
}
