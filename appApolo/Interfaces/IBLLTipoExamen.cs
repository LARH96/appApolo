using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IBLLTipoExamen
    {
        #region Create
        bool CreateTipoExamen(TipoExamen pTipoExamen);
        #endregion

        #region Read
        TipoExamen ReadTipoExamenById(string pId);
        List<TipoExamen> ReadAllTipoExamen();
        List<TipoExamen> ReadTipoExamenByFilter(string pDescripcion);
        #endregion

        #region Update
        bool SaveTipoExamen(TipoExamen pTipoExamen);
        #endregion

        #region Delete
        bool DeleteTipoExamen(string pId);
        #endregion
    }
}
