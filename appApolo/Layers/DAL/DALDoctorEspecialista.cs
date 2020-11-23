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
    class DALDoctorEspecialista : IDALDoctorEspecialista
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        private Usuario _Usuario = new Usuario();
        public DALDoctorEspecialista()
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
        }

        public bool CreateDoctorEspecialista(DoctorEspecialista pDoctorEspecialista)
        {
            string sql = @"usp_INSERT_DoctorEspecialista";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                command.Parameters.AddWithValue("@id", pDoctorEspecialista.CodigoEspecialista);
                command.Parameters.AddWithValue("@Nombre", pDoctorEspecialista.Nombre);
                command.Parameters.AddWithValue("@Apellidos", pDoctorEspecialista.Apellidos);
                command.Parameters.AddWithValue("@Genero", pDoctorEspecialista.Genero);
                command.Parameters.AddWithValue("@Direccion", pDoctorEspecialista.Direccion);
                command.Parameters.AddWithValue("@Email", pDoctorEspecialista.Email);
                command.Parameters.AddWithValue("@FechaNacimiento", pDoctorEspecialista.FechaNacimiento);
                command.Parameters.AddWithValue("@Fotografia", pDoctorEspecialista.Fotografia.ToArray());
                command.Parameters.AddWithValue("@EjercicioFisico", pDoctorEspecialista.EjercicioFisico);
                command.Parameters.AddWithValue("@AlcoholTabaco", pDoctorEspecialista.AlcoholTabaco);
                command.Parameters.AddWithValue("@Medicamentos", pDoctorEspecialista.Medicamentos);
                command.Parameters.AddWithValue("@Altura", pDoctorEspecialista.Altura);
                command.Parameters.AddWithValue("@Peso", pDoctorEspecialista.Peso);
                command.Parameters.AddWithValue("@Telefono", pDoctorEspecialista.Telefono);
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

        public DoctorEspecialista ReadDoctorEspecialistaById(string pId)
        {
            DataSet ds = null;
            DoctorEspecialista oDoctorEspecialista = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM  DoctorEspecialista WHERE id = @id";
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
                        oDoctorEspecialista = new DoctorEspecialista();
                        oDoctorEspecialista.CodigoEspecialista = dr["id"].ToString();
                        oDoctorEspecialista.Nombre = dr["Nombre"].ToString();
                        oDoctorEspecialista.Apellidos = dr["Apellidos"].ToString();
                        oDoctorEspecialista.Genero = dr["Genero"].ToString();
                        oDoctorEspecialista.Direccion = dr["Direccion"].ToString();
                        oDoctorEspecialista.Email = dr["Email"].ToString(); ;
                        oDoctorEspecialista.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oDoctorEspecialista.Fotografia = (byte[])dr["Fotografia"];
                        oDoctorEspecialista.EjercicioFisico = dr["EjercicioFisico"].ToString(); ;
                        oDoctorEspecialista.AlcoholTabaco = dr["AlcoholTabaco"].ToString(); ;
                        oDoctorEspecialista.Medicamentos = dr["Medicamentos"].ToString(); ;
                        oDoctorEspecialista.Altura = Convert.ToDouble(dr["Altura"]);
                        oDoctorEspecialista.Peso = Convert.ToDouble(dr["Peso"]);
                        oDoctorEspecialista.Telefono = dr["Telefono"].ToString();
                    }
                } // end if

                return oDoctorEspecialista;
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

        public List<DoctorEspecialista> ReadAllDoctorEspecialista()
        {
            DataSet ds = null;
            List<DoctorEspecialista> lista = new List<DoctorEspecialista>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM  DoctorEspecialista  WITH (NOLOCK)  ";
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
                        DoctorEspecialista oDoctorEspecialista = new DoctorEspecialista();
                        oDoctorEspecialista.CodigoEspecialista = dr["id"].ToString();
                        oDoctorEspecialista.Nombre = dr["Nombre"].ToString();
                        oDoctorEspecialista.Apellidos = dr["Apellidos"].ToString();
                        oDoctorEspecialista.Genero = dr["Genero"].ToString();
                        oDoctorEspecialista.Direccion = dr["Direccion"].ToString();
                        oDoctorEspecialista.Email = dr["Email"].ToString(); ;
                        oDoctorEspecialista.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oDoctorEspecialista.Fotografia = (byte[])dr["Fotografia"];
                        oDoctorEspecialista.EjercicioFisico = dr["EjercicioFisico"].ToString(); ;
                        oDoctorEspecialista.AlcoholTabaco = dr["AlcoholTabaco"].ToString(); ;
                        oDoctorEspecialista.Medicamentos = dr["Medicamentos"].ToString(); ;
                        oDoctorEspecialista.Altura = Convert.ToDouble(dr["Altura"]);
                        oDoctorEspecialista.Peso = Convert.ToDouble(dr["Peso"]);
                        oDoctorEspecialista.Telefono = dr["Telefono"].ToString();

                        lista.Add(oDoctorEspecialista);
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

        public List<DoctorEspecialista> ReadDoctorEspecialistaByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<DoctorEspecialista> lista = new List<DoctorEspecialista>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM  DoctorEspecialista WITH (NOLOCK) Where Nombre+Apellidos like @filtro ";
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
                        DoctorEspecialista oDoctorEspecialista = new DoctorEspecialista();
                        oDoctorEspecialista.CodigoEspecialista = dr["id"].ToString();
                        oDoctorEspecialista.Nombre = dr["Nombre"].ToString();
                        oDoctorEspecialista.Apellidos = dr["Apellidos"].ToString();
                        oDoctorEspecialista.Genero = dr["Genero"].ToString();
                        oDoctorEspecialista.Direccion = dr["Direccion"].ToString();
                        oDoctorEspecialista.Email = dr["Email"].ToString(); ;
                        oDoctorEspecialista.FechaNacimiento = DateTime.Parse(dr["Direccion"].ToString());
                        oDoctorEspecialista.Fotografia = (byte[])dr["Fotografia"];
                        oDoctorEspecialista.EjercicioFisico = dr["EjercicioFisico"].ToString(); ;
                        oDoctorEspecialista.AlcoholTabaco = dr["AlcoholTabaco"].ToString(); ;
                        oDoctorEspecialista.Medicamentos = dr["Medicamentos"].ToString(); ;
                        oDoctorEspecialista.Altura = (double)dr["Altura"];
                        oDoctorEspecialista.Peso = (double)dr["Peso"];
                        oDoctorEspecialista.Telefono = dr["Telefono"].ToString();

                        lista.Add(oDoctorEspecialista);
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

        public bool UpdateDoctorEspecialista(DoctorEspecialista pDoctorEspecialista)
        {
            string sql = @"usp_UPDATE_DoctorEspecialista";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                // Pasar parámetros
                command.Parameters.AddWithValue("@id", pDoctorEspecialista.CodigoEspecialista);
                command.Parameters.AddWithValue("@Nombre", pDoctorEspecialista.Nombre);
                command.Parameters.AddWithValue("@Apellidos", pDoctorEspecialista.Apellidos);
                command.Parameters.AddWithValue("@Genero", pDoctorEspecialista.Genero);
                command.Parameters.AddWithValue("@Direccion", pDoctorEspecialista.Direccion);
                command.Parameters.AddWithValue("@Email", pDoctorEspecialista.Email);
                command.Parameters.AddWithValue("@FechaNacimiento", pDoctorEspecialista.FechaNacimiento);
                command.Parameters.AddWithValue("@Fotografia", pDoctorEspecialista.Fotografia.ToArray());
                command.Parameters.AddWithValue("@EjercicioFisico", pDoctorEspecialista.EjercicioFisico);
                command.Parameters.AddWithValue("@AlcoholTabaco", pDoctorEspecialista.AlcoholTabaco);
                command.Parameters.AddWithValue("@Medicamentos", pDoctorEspecialista.Medicamentos);
                command.Parameters.AddWithValue("@Altura", pDoctorEspecialista.Altura); 
                command.Parameters.AddWithValue("@Peso", pDoctorEspecialista.Peso);
                command.Parameters.AddWithValue("@Telefono", pDoctorEspecialista.Telefono);
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

        public bool DeleteDoctorEspecialista(string pId)
        {
            string sql = @"usp_DELETE_DoctorEspecialista_ByID";
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
    }
}
