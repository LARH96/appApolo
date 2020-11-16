using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IDALLogin
    {
        bool Login(string pUsuario, string pContrasena);
    }
}
