using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IDALUsuario
    {
        #region Create
        bool CreateUsuario(Usuario pUsuario);
        #endregion

        #region Read
        Usuario ReadUsuarioById(string pId);
        List<Usuario> ReadAllUsuario();
        List<Usuario> ReadUsuarioByFilter(string pDescripcion);
        #endregion

        #region Update
        bool UpdateUsuario(Usuario pUsuario);
        #endregion

        #region Delete
        bool DeleteUsuario(string pId);
        #endregion

        Usuario ReadUsuarioParaLogin(Usuario pUsuario);
    }
}
