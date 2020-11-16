using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.DAL;

namespace UTN.Winforms.Apolo.Layers.BLL
{
    class BLLLogin : IBLLLogin
    {
        public bool Login(string pUsuario, string pContrasena)
        {
            IDALLogin _DALLogin = new DALLogin();
            return _DALLogin.Login(pUsuario, pContrasena);
        }
    }
}
