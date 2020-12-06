using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IDALRegistroExamen
    {
        #region Create
        bool CreateRegistroExamen(RegistroExamen pRegistroExamen);
        #endregion

        #region Read
        RegistroExamen ReadRegistroExamenById(string pId);
        List<RegistroExamen> ReadAllRegistroExamen();
        List<RegistroExamen> ReadRegistroExamenByFilter(string pDescripcion);
        #endregion

        #region Update
        bool UpdateRegistroExamen(RegistroExamen pRegistroExamen);
        #endregion

        #region Delete
        bool DeleteRegistroExamen(string pId);
        #endregion

        RegistroExamen ReadRegistroExamenByFilterFacturaYSecuencia(int pFactura, int pSecuencia);
    }
}
