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
    class BLLTipoExamen : IBLLTipoExamen
    {
        public bool CreateTipoExamen(TipoExamen pTipoExamen)
        {
            IDALTipoExamen _IDALTipoExamen = new DALTipoExamen();
            return _IDALTipoExamen.CreateTipoExamen(pTipoExamen);
        }

        public TipoExamen ReadTipoExamenById(string pId)
        {
            IDALTipoExamen _IDALTipoExamen = new DALTipoExamen();
            return _IDALTipoExamen.ReadTipoExamenById(pId);
        }

        public List<TipoExamen> ReadAllTipoExamen()
        {
            IDALTipoExamen _IDALTipoExamen = new DALTipoExamen();
            return _IDALTipoExamen.ReadAllTipoExamen();
        }

        public List<TipoExamen> ReadTipoExamenByFilter(string pDescripcion)
        {
            IDALTipoExamen _IDALTipoExamen = new DALTipoExamen();
            return _IDALTipoExamen.ReadTipoExamenByFilter(pDescripcion);
        }

        public bool SaveTipoExamen(TipoExamen pTipoExamen)
        {
            IDALTipoExamen _IDALTipoExamen = new DALTipoExamen();
            bool result = false;
            if (_IDALTipoExamen.ReadTipoExamenById(pTipoExamen.IdTipoExamen) == null)
                result = _IDALTipoExamen.CreateTipoExamen(pTipoExamen);
            else
                result = _IDALTipoExamen.UpdateTipoExamen(pTipoExamen);

            return result;
        }

        public bool DeleteTipoExamen(string pId)
        {
            IDALTipoExamen _IDALTipoExamen = new DALTipoExamen();
            return _IDALTipoExamen.DeleteTipoExamen(pId);
        }
    }
}
