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
    class BLLRegistroExamen : IBLLRegistroExamen
    {
        public bool CreateRegistroExamen(RegistroExamen pRegistroExamen)
        {
            IDALRegistroExamen _IDALRegistroExamen = new DALRegistroExamen();
            return _IDALRegistroExamen.CreateRegistroExamen(pRegistroExamen);
        }

        public bool DeleteRegistroExamen(string pId)
        {
            throw new NotImplementedException();
        }

        public List<RegistroExamen> ReadAllRegistroExamen()
        {
            IDALRegistroExamen _IDALRegistroExamen = new DALRegistroExamen();
            return _IDALRegistroExamen.ReadAllRegistroExamen();
        }

        public List<RegistroExamen> ReadRegistroExamenByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public RegistroExamen ReadRegistroExamenById(string pId)
        {
            IDALRegistroExamen _IDALRegistroExamen = new DALRegistroExamen();
            return _IDALRegistroExamen.ReadRegistroExamenById(pId);
        }

        public bool SaveRegistroExamen(RegistroExamen pRegistroExamen)
        {
            IDALRegistroExamen _IDALRegistroExamen = new DALRegistroExamen();
            return _IDALRegistroExamen.CreateRegistroExamen(pRegistroExamen);
        }
    }
}
