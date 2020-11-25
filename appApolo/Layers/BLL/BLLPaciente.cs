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
    class BLLPaciente : IBLLPaciente
    {

        public bool CreatePaciente(Paciente pPaciente)
        {
            IDALPaciente _IDALPaciente = new DALPaciente();
            return _IDALPaciente.CreatePaciente(pPaciente);
        }

        public Paciente ReadPacienteById(string pId)
        {
            IDALPaciente _IDALPaciente = new DALPaciente();
            return _IDALPaciente.ReadPacienteById(pId);
        }

        public List<Paciente> ReadAllPaciente()
        {
            IDALPaciente _IDALPaciente = new DALPaciente();
            return _IDALPaciente.ReadAllPaciente();
        }

        public List<Paciente> ReadPacienteByFilter(string pDescripcion)
        {
            IDALPaciente _IDALPaciente = new DALPaciente();
            return _IDALPaciente.ReadPacienteByFilter(pDescripcion);
        }

        public bool SavePaciente(Paciente pPaciente)
        {
            IDALPaciente _IDALPaciente = new DALPaciente();
            bool result = false;
            if (_IDALPaciente.ReadPacienteById(pPaciente.IdPaciente) == null)
                result = _IDALPaciente.CreatePaciente(pPaciente);
            else
                result = _IDALPaciente.UpdatePaciente(pPaciente);

            return result;
        }

        public bool DeletePaciente(string pId)
        {
            IDALPaciente _IDALPaciente = new DALPaciente();
            return _IDALPaciente.DeletePaciente(pId);
        }

        public string SeleccionaSexo(bool femenino, bool masculino, bool otro)
        {
            string sexo = "";

            if (femenino)
                sexo = Sexo.f.ToString();
            else if (masculino)
                sexo = Sexo.m.ToString();
            else
                sexo = Sexo.o.ToString();

            return sexo;
        }
    }
}
