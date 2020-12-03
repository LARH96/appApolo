using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.DAL;
using UTN.Winforms.Apolo.Properties;

namespace UTN.Winforms.Apolo.Layers.BLL
{
    class BLLUsuario : IBLLUsuario
    {
        public bool CreateUsuario(Usuario pUsuario)
        {
            IDALUsuario _IDALUsuario = new DALUsuario();
            return _IDALUsuario.CreateUsuario(pUsuario);
        }

        public List<Usuario> ReadAllUsuario()
        {
            IDALUsuario _IDALUsuario = new DALUsuario();
            return _IDALUsuario.ReadAllUsuario();
        }

        public List<Usuario> ReadUsuarioByFilter(string pDescripcion)
        {
            IDALUsuario _IDALUsuario = new DALUsuario();
            return _IDALUsuario.ReadUsuarioByFilter(pDescripcion);
        }

        public Usuario ReadUsuarioById(string pId)
        {
            IDALUsuario _IDALUsuario = new DALUsuario();
            return _IDALUsuario.ReadUsuarioById(pId);
        }

        public bool SaveUsuario(Usuario pUsuario)
        {
            pUsuario.Contrasenna = HasheaContrasenna(pUsuario); //Convierte a hash la contraseña

            IDALUsuario _IDALUsuario = new DALUsuario();
            bool result = false;
            if (_IDALUsuario.ReadUsuarioById(pUsuario.IdUsuario) == null)
                result = _IDALUsuario.CreateUsuario(pUsuario);
            else
                result = _IDALUsuario.UpdateUsuario(pUsuario);

            return result;
        }

        public bool DeleteUsuario(string pId)
        {
            IDALUsuario _IDALUsuario = new DALUsuario();
            return _IDALUsuario.DeleteUsuario(pId);
        }

        public string HasheaContrasenna(Usuario pUsuario)
        {
            return Utilitarios.ComputeSha256Hash(pUsuario.Contrasenna);
        }

        public int SeleccionaTipoPerfil(TipoPerfil pTipoPerfil)
        {
            int perfil = 0;

            if (pTipoPerfil.Equals(TipoPerfil.Administrador))
                perfil = 1;
            else if(pTipoPerfil.Equals(TipoPerfil.Procesos))
                perfil = 2;
            else //TipoPerfil.Reportes
            {
                perfil = 3;
            }

            return perfil;
        }

        public string SeleccionaTipoPerfil(Usuario pUsuario)
        {
            string perfil = "";

            if (pUsuario.TipoPerfil == 1)
                perfil = TipoPerfil.Administrador.ToString();
            else if (pUsuario.TipoPerfil == 2)
                perfil = TipoPerfil.Procesos.ToString();
            else //TipoPerfil.Reportes
            {
                perfil = TipoPerfil.Reportes.ToString();
            }

            return perfil;
        }

        public bool VerificaLoginUsuario(Usuario pUsuario)
        {
            bool verificado = false;
            Usuario oUsuarioComparacion = new Usuario();
            IDALUsuario _IDALUsuario = new DALUsuario();

            pUsuario.Contrasenna = HasheaContrasenna(pUsuario).Substring(0,25); //Convierte a hash la contraseña

            oUsuarioComparacion = _IDALUsuario.ReadUsuarioParaLogin(pUsuario);

            if (pUsuario.NombreUsuario == oUsuarioComparacion.NombreUsuario
                &&
                pUsuario.Contrasenna == oUsuarioComparacion.Contrasenna
                )
            {
                verificado = true;
                //asignacion que controla seguridad del menú
                Settings.Default.TipoPerfil = SeleccionaTipoPerfil(oUsuarioComparacion);
                ////asignacion para control de quien ingresa las transacciones
                Settings.Default.IdUsuario = oUsuarioComparacion.IdUsuario;
            }

            return verificado;
                
        }
    }
}
