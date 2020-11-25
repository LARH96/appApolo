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
    class BLLDoctorEspecialista : IBLLDoctorEspecialista
    {
        public bool CreateDoctorEspecialista(DoctorEspecialista pDoctorEspecialista)
        {
            IDALDoctorEspecialista _IDALDoctorEspecialista = new DALDoctorEspecialista();
            return _IDALDoctorEspecialista.CreateDoctorEspecialista(pDoctorEspecialista);
        }

        public DoctorEspecialista ReadDoctorEspecialistaById(string pId)
        {
            IDALDoctorEspecialista _IDALDoctorEspecialistae = new DALDoctorEspecialista();
            return _IDALDoctorEspecialistae.ReadDoctorEspecialistaById(pId);
        }

        public List<DoctorEspecialista> ReadAllDoctorEspecialista()
        {
            IDALDoctorEspecialista _IDALDoctorEspecialista = new DALDoctorEspecialista();
            return _IDALDoctorEspecialista.ReadAllDoctorEspecialista();
        }

        public List<DoctorEspecialista> ReadDoctorEspecialistaByFilter(string pDescripcion)
        {
            IDALDoctorEspecialista _IDALDoctorEspecialista = new DALDoctorEspecialista();
            return _IDALDoctorEspecialista.ReadDoctorEspecialistaByFilter(pDescripcion);
        }

        public bool SaveDoctorEspecialista(DoctorEspecialista pDoctorEspecialista)
        {
            IDALDoctorEspecialista _IDALDoctorEspecialista = new DALDoctorEspecialista();
            bool result = false;
            if (_IDALDoctorEspecialista.ReadDoctorEspecialistaById(pDoctorEspecialista.CodigoEspecialista) == null)
                result = _IDALDoctorEspecialista.CreateDoctorEspecialista(pDoctorEspecialista);
            else
                result = _IDALDoctorEspecialista.UpdateDoctorEspecialista(pDoctorEspecialista);

            return result;
        }

        public bool DeleteDoctorEspecialista(string pId)
        {
            IDALDoctorEspecialista _IDALDoctorEspecialista = new DALDoctorEspecialista();
            return _IDALDoctorEspecialista.DeleteDoctorEspecialista(pId);
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
