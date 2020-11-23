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
    class DALPaciente : IDALPaciente
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        private Usuario _Usuario = new Usuario();
        public DALPaciente()
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
        }

        public bool CreatePaciente(Paciente pPaciente)
        {
            string sql = @"usp_INSERT_Paciente";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                command.Parameters.AddWithValue("@id", pPaciente.IdPaciente);
                command.Parameters.AddWithValue("@Nombre", pPaciente.Nombre);
                command.Parameters.AddWithValue("@Apellidos", pPaciente.Apellidos);
                command.Parameters.AddWithValue("@Genero", pPaciente.Genero);
                command.Parameters.AddWithValue("@Direccion", pPaciente.Direccion);
                command.Parameters.AddWithValue("@Email", pPaciente.Email);
                command.Parameters.AddWithValue("@FechaNacimiento", pPaciente.FechaNacimiento);
                command.Parameters.AddWithValue("@Fotografia", pPaciente.Fotografia.ToArray());
                command.Parameters.AddWithValue("@EjercicioFisico", pPaciente.EjercicioFisico);
                command.Parameters.AddWithValue("@AlcoholTabaco", pPaciente.AlcoholTabaco);
                command.Parameters.AddWithValue("@Medicamentos", pPaciente.Medicamentos);
                command.Parameters.AddWithValue("@Altura", pPaciente.Altura);
                command.Parameters.AddWithValue("@Peso", pPaciente.Peso);
                command.Parameters.AddWithValue("@Telefono", pPaciente.Telefono);

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

        public Paciente ReadPacienteById(string pId)
        {
            DataSet ds = null;
            Paciente oPaciente = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM  Paciente WHERE id = @id";
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
                        oPaciente = new Paciente();
                        oPaciente.IdPaciente = dr["id"].ToString();
                        oPaciente.Nombre = dr["Nombre"].ToString();
                        oPaciente.Apellidos = dr["Apellidos"].ToString();
                        oPaciente.Genero = dr["Genero"].ToString();
                        oPaciente.Direccion = dr["Direccion"].ToString();
                        oPaciente.Email = dr["Email"].ToString(); ;
                        oPaciente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oPaciente.Fotografia = (byte[])dr["Fotografia"];
                        oPaciente.EjercicioFisico = dr["EjercicioFisico"].ToString(); ;
                        oPaciente.AlcoholTabaco = dr["AlcoholTabaco"].ToString(); ;
                        oPaciente.Medicamentos = dr["Medicamentos"].ToString(); ;
                        oPaciente.Altura = Convert.ToDouble(dr["Altura"]);
                        oPaciente.Peso = Convert.ToDouble(dr["Peso"]);
                        oPaciente.Telefono = dr["Telefono"].ToString();
                    }
                }

                return oPaciente;
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

        public List<Paciente> ReadAllPaciente()
        {
            DataSet ds = null;
            List<Paciente> lista = new List<Paciente>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM  Paciente  WITH (NOLOCK)  ";
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
                        Paciente oPaciente = new Paciente();
                        oPaciente.IdPaciente = dr["id"].ToString();
                        oPaciente.Nombre = dr["Nombre"].ToString();
                        oPaciente.Apellidos = dr["Apellidos"].ToString();
                        oPaciente.Genero = dr["Genero"].ToString();
                        oPaciente.Direccion = dr["Direccion"].ToString();
                        oPaciente.Email = dr["Email"].ToString(); ;
                        oPaciente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        oPaciente.Fotografia = (byte[])dr["Fotografia"];
                        oPaciente.EjercicioFisico = dr["EjercicioFisico"].ToString();
                        oPaciente.AlcoholTabaco = dr["AlcoholTabaco"].ToString(); ;
                        oPaciente.Medicamentos = dr["Medicamentos"].ToString(); ;
                        oPaciente.Altura = Convert.ToDouble(dr["Altura"]);
                        oPaciente.Peso = Convert.ToDouble(dr["Peso"]);
                        oPaciente.Telefono = dr["Telefono"].ToString();

                        lista.Add(oPaciente);
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

        public List<Paciente> ReadPacienteByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Paciente> lista = new List<Paciente>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT * FROM  Paciente WITH (NOLOCK) Where Nombre+Apellidos like @filtro ";
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
                        Paciente oPaciente = new Paciente();
                        oPaciente.IdPaciente = dr["id"].ToString();
                        oPaciente.Nombre = dr["Nombre"].ToString();
                        oPaciente.Apellidos = dr["Apellidos"].ToString();
                        oPaciente.Genero = dr["Genero"].ToString();
                        oPaciente.Direccion = dr["Direccion"].ToString();
                        oPaciente.Email = dr["Email"].ToString(); ;
                        oPaciente.FechaNacimiento = DateTime.Parse(dr["Direccion"].ToString());
                        oPaciente.Fotografia = (byte[])dr["Fotografia"];
                        oPaciente.EjercicioFisico = dr["EjercicioFisico"].ToString(); ;
                        oPaciente.AlcoholTabaco = dr["AlcoholTabaco"].ToString(); ;
                        oPaciente.Medicamentos = dr["Medicamentos"].ToString(); ;
                        oPaciente.Altura = (double)dr["Altura"];
                        oPaciente.Peso = (double)dr["Peso"];
                        oPaciente.Telefono = dr["Telefono"].ToString();

                        lista.Add(oPaciente);
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

        public bool UpdatePaciente(Paciente pPaciente)
        {
            string sql = @"usp_UPDATE_Paciente";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                // Pasar parámetros
                command.Parameters.AddWithValue("@id", pPaciente.IdPaciente);
                command.Parameters.AddWithValue("@Nombre", pPaciente.Nombre);
                command.Parameters.AddWithValue("@Apellidos", pPaciente.Apellidos);
                command.Parameters.AddWithValue("@Genero", pPaciente.Genero);
                command.Parameters.AddWithValue("@Direccion", pPaciente.Direccion);
                command.Parameters.AddWithValue("@Email", pPaciente.Email);
                command.Parameters.AddWithValue("@FechaNacimiento", pPaciente.FechaNacimiento);
                command.Parameters.AddWithValue("@Fotografia", pPaciente.Fotografia.ToArray());
                command.Parameters.AddWithValue("@EjercicioFisico", pPaciente.EjercicioFisico);
                command.Parameters.AddWithValue("@AlcoholTabaco", pPaciente.AlcoholTabaco);
                command.Parameters.AddWithValue("@Medicamentos", pPaciente.Medicamentos);
                command.Parameters.AddWithValue("@Altura", pPaciente.Altura);
                command.Parameters.AddWithValue("@Peso", pPaciente.Peso);
                command.Parameters.AddWithValue("@Telefono", pPaciente.Telefono);
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

        public bool DeletePaciente(string pId)
        {
            string sql = @"usp_DELETE_Paciente_ByID";
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
