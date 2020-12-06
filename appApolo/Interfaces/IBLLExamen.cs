using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IBLLExamen
    {
        #region Create
        bool CreateExamen(Examen pExamen);
        #endregion

        #region Read
        Examen ReadExamenById(string pId);
        List<Examen> ReadAllExamen();
        List<Examen> ReadExamenByFilter(string pDescripcion);
        #endregion

        #region Update
        bool SaveExamen(Examen pExamen);
        #endregion

        #region Delete
        bool DeleteExamen(string pId);
        #endregion

        string CalculaResultadoExamen(Examen pExamen, FacturaDetalle pFacturaDetalle);
    }
}
