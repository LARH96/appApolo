using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Interfaces
{
    interface IBLLUsuario
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
        bool SaveUsuario(Usuario pUsuario);
        #endregion

        #region Delete
        bool DeleteUsuario(string pId);
        #endregion

        int SeleccionaTipoPerfil(TipoPerfil pTipoPerfil);

        bool VerificaLoginUsuario(Usuario pUsuario);
    }
}
