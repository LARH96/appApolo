using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IBLLPaciente
    {
        #region Create
        bool CreatePaciente(Paciente pPaciente);
        #endregion

        #region Read
        Paciente ReadPacienteById(string pId);
        List<Paciente> ReadAllPaciente();
        List<Paciente> ReadPacienteByFilter(string pDescripcion);
        #endregion

        #region Update
        bool SavePaciente(Paciente pPaciente);
        #endregion

        #region Delete
        bool DeletePaciente(string pId);
        #endregion

        string SeleccionaSexo(bool femenino, bool masculino, bool otro);
    }
}
