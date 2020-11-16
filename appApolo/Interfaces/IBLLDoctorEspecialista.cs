using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IBLLDoctorEspecialista
    {
        #region Create
        bool CreateDoctorEspecialista(DoctorEspecialista pDoctorEspecialista);
        #endregion

        #region Read
        DoctorEspecialista ReadDoctorEspecialistaById(string pId);
        List<DoctorEspecialista> ReadAllDoctorEspecialista();
        List<DoctorEspecialista> ReadDoctorEspecialistaByFilter(string pDescripcion);
        #endregion

        #region Update
        bool UpdateDoctorEspecialista(DoctorEspecialista pDoctorEspecialista);
        #endregion

        #region Delete
        bool DeleteDoctorEspecialista(string pId);
        #endregion
    }
}
