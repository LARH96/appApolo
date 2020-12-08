using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Properties;

namespace UTN.Winforms.Apolo.Layers.DAL
{
    class DALUsuario : IDALUsuario
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        private Usuario _Usuario = new Usuario();

        public DALUsuario()
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
        }


        public bool CreateUsuario(Usuario pUsuario)
        {
            string sql = @"usp_INSERT_Usuario";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                //TODO
                //command.Parameters.AddWithValue("@Fotografia", pUsuario.Fotografia.ToArray());
                command.Parameters.AddWithValue("@Fotografia", "foto");
                command.Parameters.AddWithValue("@id", pUsuario.IdUsuario);
                command.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
                command.Parameters.AddWithValue("@Apellidos", pUsuario.Apellidos);
                command.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario);
                command.Parameters.AddWithValue("@Contrasenna", pUsuario.Contrasenna);
                command.Parameters.AddWithValue("@idPerfil", pUsuario.TipoPerfil);

                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo
                return rows > 0;

            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public Usuario ReadUsuarioById(string pId)
        {
            DataSet ds = null;
            Usuario oUsuario = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM Usuario WHERE id = @id";
                command.Parameters.AddWithValue("@Id", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oUsuario = new Usuario();
                        oUsuario.IdUsuario = dr["id"].ToString();
                        oUsuario.NombreUsuario = dr["NombreUsuario"].ToString();
                        oUsuario.TipoPerfil = Convert.ToInt32(dr["idPerfil"].ToString());
                        oUsuario.Contrasenna = dr["Contrasenna"].ToString();
                        oUsuario.Nombre = dr["Nombre"].ToString();
                        oUsuario.Apellidos = dr["Apellidos"].ToString(); ;
                        //oUsuario.Fotografia = (byte[])dr["Fotografia"]; //TODO
                        oUsuario.Fotografia = dr["Fotografia"].ToString();
                    }
                }

                return oUsuario;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public List<Usuario> ReadAllUsuario()
        {
            DataSet ds = null;
            List<Usuario> lista = new List<Usuario>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM Usuario  WITH (NOLOCK)  ";
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Usuario oUsuario = new Usuario();
                        oUsuario.IdUsuario = dr["id"].ToString();
                        oUsuario.NombreUsuario = dr["NombreUsuario"].ToString();
                        oUsuario.TipoPerfil = Convert.ToInt32(dr["idPerfil"].ToString());
                        oUsuario.Nombre = dr["Nombre"].ToString();
                        oUsuario.Apellidos = dr["Apellidos"].ToString(); ;
                        //oUsuario.Fotografia = (byte[])dr["Fotografia"]; //TODO
                        oUsuario.Fotografia = dr["Fotografia"].ToString();

                        lista.Add(oUsuario);
                    }
                }

                return lista;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public List<Usuario> ReadUsuarioByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Usuario> lista = new List<Usuario>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM Usuario WITH (NOLOCK) Where Nombre+Apellidos like @filtro ";
                command.Parameters.AddWithValue("@filtro", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Usuario oUsuario = new Usuario();
                        oUsuario.IdUsuario = dr["id"].ToString();
                        oUsuario.NombreUsuario = dr["NombreUsuario"].ToString();
                        oUsuario.TipoPerfil = Convert.ToInt32(dr["idPerfil"].ToString());
                        oUsuario.Contrasenna = dr["Contrasenna"].ToString();
                        oUsuario.Nombre = dr["Nombre"].ToString();
                        oUsuario.Apellidos = dr["Apellidos"].ToString(); ;
                        //oUsuario.Fotografia = (byte[])dr["Fotografia"]; //TODO
                        oUsuario.Fotografia = dr["Fotografia"].ToString();

                        lista.Add(oUsuario);
                    }
                }

                return lista;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public bool UpdateUsuario(Usuario pUsuario)
        {
            string sql = @"usp_UPDATE_Usuario";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                // Pasar parámetros
                command.Parameters.AddWithValue("@id", pUsuario.IdUsuario);
                command.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario);
                command.Parameters.AddWithValue("@idPerfil", pUsuario.TipoPerfil);
                command.Parameters.AddWithValue("@Contrasenna", pUsuario.Contrasenna);
                command.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
                command.Parameters.AddWithValue("@Apellidos", pUsuario.Apellidos);
                command.Parameters.AddWithValue("@Fotografia", "Foto");
                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo
                return rows > 0;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public bool DeleteUsuario(string pId)
        {
            string sql = @"usp_DELETE_Usuario_ByID";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                // Pasar parámetros
                command.Parameters.AddWithValue("@Id", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                // Ejecutar
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    rows = db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo
                return rows > 0;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public Usuario ReadUsuarioParaLogin(Usuario pUsuario)
        {

            DataSet ds = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT id, NombreUsuario, Contrasenna, idPerfil FROM Usuario WHERE NombreUsuario = @NombreUsuario";
                command.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                Usuario oUsuario = new Usuario();

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oUsuario.IdUsuario = dr["id"].ToString();
                        oUsuario.NombreUsuario = dr["NombreUsuario"].ToString();
                        oUsuario.Contrasenna = dr["Contrasenna"].ToString();
                        oUsuario.TipoPerfil = Convert.ToInt32(dr["idPerfil"].ToString());
                    }
                }

                return oUsuario;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }
    }
}
