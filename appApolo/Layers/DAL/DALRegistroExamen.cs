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
    class DALRegistroExamen : IDALRegistroExamen
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        private Usuario _Usuario = new Usuario();
        public DALRegistroExamen()
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
        }

        public bool CreateRegistroExamen(RegistroExamen pRegistroExamen)
        {
            string sql = @"usp_INSERT_RegistroExamen";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                //SecuenciaRegistroEsUnIdentity
                //command.Parameters.AddWithValue("@SecuenciaRegistroExamen", pRegistroExamen.SecuenciaRegistroExamen);
                command.Parameters.AddWithValue("@idDoctorEspecialista", pRegistroExamen.IdDoctorEspecialista);
                command.Parameters.AddWithValue("@idFactura", pRegistroExamen.IdFactura);
                command.Parameters.AddWithValue("@Secuencia", pRegistroExamen.SecuenciaDetalleFact);
                command.Parameters.AddWithValue("@idExamen", pRegistroExamen.IdExamen);
                command.Parameters.AddWithValue("@Valor", pRegistroExamen.Valor);
                command.Parameters.AddWithValue("@FechaMuestra", pRegistroExamen.FechaMuestra);
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

        public bool DeleteRegistroExamen(string pId)
        {
            throw new NotImplementedException();
        }

        public List<RegistroExamen> ReadAllRegistroExamen()
        {
            DataSet ds = null;
            List<RegistroExamen> lista = new List<RegistroExamen>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM RegistroExamen WITH (NOLOCK)  ";
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
                        RegistroExamen oRegistroExamen = new RegistroExamen();
                        oRegistroExamen.SecuenciaRegistroExamen = Convert.ToInt32(dr["SecuenciaRegistroExamen"].ToString());
                        oRegistroExamen.IdDoctorEspecialista = Convert.ToInt32(dr["idDoctorEspecialista"].ToString());
                        oRegistroExamen.IdFactura = Convert.ToInt32(dr["idFactura"].ToString());
                        oRegistroExamen.SecuenciaDetalleFact = Convert.ToInt32(dr["Secuencia"].ToString());
                        oRegistroExamen.IdExamen = dr["idExamen"].ToString();
                        oRegistroExamen.Valor = Convert.ToDouble(dr["Valor"].ToString()); //notar que este es double
                        oRegistroExamen.FechaMuestra = DateTime.Parse(dr["FechaMuestra"].ToString());

                        lista.Add(oRegistroExamen);
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

        public List<RegistroExamen> ReadRegistroExamenByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public RegistroExamen ReadRegistroExamenByFilterFacturaYSecuencia(int pFactura, int pSecuencia)
        {
            DataSet ds = null;
            RegistroExamen oRegistroExamen = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM RegistroExamen WHERE  idFactura = @IdFactura
								                                   AND Secuencia = @IdSecuencia";
                command.Parameters.AddWithValue("@IdFactura", pFactura);
                command.Parameters.AddWithValue("@IdSecuencia", pSecuencia);
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
                        oRegistroExamen = new RegistroExamen();
                        oRegistroExamen.SecuenciaRegistroExamen = Convert.ToInt32(dr["SecuenciaRegistroExamen"].ToString());
                        oRegistroExamen.IdDoctorEspecialista = Convert.ToInt32(dr["idDoctorEspecialista"].ToString());
                        oRegistroExamen.IdFactura = Convert.ToInt32(dr["idFactura"].ToString());
                        oRegistroExamen.SecuenciaDetalleFact = Convert.ToInt32(dr["Secuencia"].ToString());
                        oRegistroExamen.IdExamen = dr["idExamen"].ToString();
                        oRegistroExamen.Valor = Convert.ToDouble(dr["Valor"].ToString()); //notar que este es double
                        oRegistroExamen.FechaMuestra = DateTime.Parse(dr["FechaMuestra"].ToString());
                    }
                } // end if

                return oRegistroExamen;
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

        public RegistroExamen ReadRegistroExamenById(string pId)
        {
            DataSet ds = null;
            RegistroExamen oRegistroExamen = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM RegistroExamen WHERE id = @id";
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
                        oRegistroExamen = new RegistroExamen();
                        oRegistroExamen.SecuenciaRegistroExamen = Convert.ToInt32(dr["SecuenciaRegistroExamen"].ToString());
                        oRegistroExamen.IdDoctorEspecialista = Convert.ToInt32(dr["idDoctorEspecialista"].ToString());
                        oRegistroExamen.IdFactura = Convert.ToInt32(dr["idFactura"].ToString());
                        oRegistroExamen.SecuenciaDetalleFact = Convert.ToInt32(dr["Secuencia"].ToString());
                        oRegistroExamen.IdExamen = dr["idExamen"].ToString();
                        oRegistroExamen.Valor = Convert.ToDouble(dr["Valor"].ToString()); //notar que este es double
                        oRegistroExamen.FechaMuestra = DateTime.Parse(dr["FechaMuestra"].ToString());
                    }
                } // end if

                return oRegistroExamen;
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

        public bool UpdateRegistroExamen(RegistroExamen pRegistroExamen)
        {
            string sql = @"usp_UPDATE_RegistroExamen";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                // Pasar parámetros
                command.Parameters.AddWithValue("@SecuenciaRegistroExamen", pRegistroExamen.SecuenciaRegistroExamen);
                command.Parameters.AddWithValue("@idDoctorEspecialista", pRegistroExamen.IdDoctorEspecialista);
                command.Parameters.AddWithValue("@idFactura", pRegistroExamen.IdFactura);
                command.Parameters.AddWithValue("@Secuencia", pRegistroExamen.SecuenciaDetalleFact);
                command.Parameters.AddWithValue("@idExamen", pRegistroExamen.IdExamen);
                command.Parameters.AddWithValue("@Valor", pRegistroExamen.Valor);
                command.Parameters.AddWithValue("@FechaMuestra", pRegistroExamen.FechaMuestra);
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
    }
}
