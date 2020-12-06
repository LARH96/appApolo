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
using UTN.Winforms.Apolo.Entities.DTO;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Properties;

namespace UTN.Winforms.Apolo.Layers.DAL
{
    class DALFactura : IDALFactura
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        Usuario _Usuario = new Usuario();
        public DALFactura()
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
        }
        public FacturaEncabezado SaveFactura(FacturaEncabezado pFactura)
        {
            FacturaEncabezado oFacturaEncabezado = null;
            string sqlEncabezado = string.Empty;
            string sqlDetalle = string.Empty;
            string sqlElectronico = string.Empty;
            SqlCommand cmdFacturaEncabezado = new SqlCommand();
            SqlCommand cmdFacturaDetalle = new SqlCommand();
            List<IDbCommand> listaCommands = new List<IDbCommand>();
            double rows = 0;

            sqlEncabezado = @"  
                            INSERT INTO [dbo].[FacturaEncabezado]
                                       ([id]
                                       ,[Fecha]
                                       ,[idPaciente]
                                       ,[XML]
                                       ,[idTipoPago]
                                       ,[ReferenciaMedica]
                                       ,[idTipoEntregaExamen] )
                                 VALUES
                                       (@Id
                                       ,@Fecha
                                       ,@idPaciente
                                       ,@XML
                                       ,@idTipoPago
                                       ,@ReferenciaMedica
                                       ,@idTipoEntregaExamen ) ";


            try
            {
                // Encabezado de factura
                cmdFacturaEncabezado.Parameters.AddWithValue("@Id", pFactura.IdFactura);
                cmdFacturaEncabezado.Parameters.AddWithValue("@Fecha", pFactura.FechaFacturacion);
                cmdFacturaEncabezado.Parameters.AddWithValue("@idPaciente", pFactura._Paciente.IdPaciente);
                cmdFacturaEncabezado.Parameters.AddWithValue("@XML", pFactura.XML);
                cmdFacturaEncabezado.Parameters.AddWithValue("@idTipoPago", pFactura.TipoPago);
                cmdFacturaEncabezado.Parameters.AddWithValue("@ReferenciaMedica", pFactura.ReferenciaMedica);
                cmdFacturaEncabezado.Parameters.AddWithValue("@idTipoEntregaExamen", pFactura.TipoEntregaExamen);
                cmdFacturaEncabezado.CommandText = sqlEncabezado;
                cmdFacturaEncabezado.CommandType = CommandType.Text;
                // Agregar a la lista de commands
                listaCommands.Add(cmdFacturaEncabezado);


                // Detalle de factura
                sqlDetalle = @" 
                    INSERT INTO[dbo].[DetalleFactura]
                               ([idFactura]
                               ,[Secuencia]
                               ,[idExamen]
                               ,[Costo]
                               ,[Impuesto]
                               ,[EstadoExamen])
                         VALUES
                               (@idFactura
                               ,@Secuencia
                               ,@IdExamen
                               ,@Costo
                               ,@Impuesto
                               ,@EstadoExamen) ";

                // Guardar el detalle de la factura y a la vez rebajar el saldo del producto en Electronico
                foreach (FacturaDetalle pFacturaDetalle in pFactura._ListaFacturaDetalle)
                {
                    cmdFacturaDetalle = new SqlCommand();
                    cmdFacturaDetalle.Parameters.AddWithValue("@idFactura", pFacturaDetalle.IdFactura);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Secuencia", pFacturaDetalle.Secuencia);
                    cmdFacturaDetalle.Parameters.AddWithValue("@IdExamen", pFacturaDetalle.Examen);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Costo", pFacturaDetalle.Costo);
                    cmdFacturaDetalle.Parameters.AddWithValue("@Impuesto", pFacturaDetalle.Impuesto);
                    cmdFacturaDetalle.Parameters.AddWithValue("@EstadoExamen", "Pendiente");
                    cmdFacturaDetalle.CommandText = sqlDetalle;
                    cmdFacturaDetalle.CommandType = CommandType.Text;
                    // Agregar a la lista de comandos
                    listaCommands.Add(cmdFacturaDetalle);
                }


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {

                    rows = db.ExecuteNonQuery(listaCommands, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo

                if (rows == 0)
                {
                    throw new Exception("No se pudo salvar correctamente la factura");
                }
                else
                {
                    oFacturaEncabezado = GetFactura(pFactura.IdFactura);
                }

                return oFacturaEncabezado;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), null, sqlError));
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
        /// <summary>
        /// Extraer un consecutivo para asignar el numero de factura
        ///  Investigue como crear secuencias en SQLServer
        /// http://technet.microsoft.com/es-es/library/ff878091.aspx
        /// CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;
        /// </summary>
        /// <returns>Num. de factura</returns>
        public int GetNextNumeroFactura()
        {
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT NEXT VALUE FOR SequenceNoFactura";

            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {

                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateSQLExceptionsErrorDetails(sqlError));
                msg.AppendFormat("SQL             {0}\n", command.CommandText);
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
        public int GetCurrentNumeroFactura()
        {

            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT current_value FROM sys.sequences WHERE name = 'SequenceNoFactura'  ";
            DataTable dt = null;
            try
            {

                command.CommandText = sql;
                command.CommandType = CommandType.Text;


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {

                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateSQLExceptionsErrorDetails(sqlError));
                msg.AppendFormat("SQL             {0}\n", command.CommandText);
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
        public double GetTotalFactura(double pNumeroFactura)
        {

            double sumatoria = 0d;
            string sql = @"  select sum(Cantidad * Precio + Impuesto) from DetalleFactura  f
                             where f.IdFactura = @pNumeroFactura";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@pNumeroFactura", pNumeroFactura);

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
            {
                sumatoria = db.ExecuteScalar(command);
            }


            return sumatoria;

        }
        private FacturaEncabezado GetFactura(double pNumeroFactura)
        {
            FacturaEncabezado oFacturaEncabezado = new FacturaEncabezado();
            DataSet ds = null;
            IDALPaciente _IDALPaciente = new DALPaciente();
            IDALTarjeta _DALTarjeta = new DALTarjeta();
            SqlCommand command = new SqlCommand();

            string sql = @"  ";


            sql = @"SELECT        FacturaEncabezado.id, FacturaEncabezado.Fecha, FacturaEncabezado.IdPaciente, FacturaEncabezado.XML, FacturaEncabezado.idTipoPago, FacturaEncabezado.ReferenciaMedica, FacturaEncabezado.idTipoEntregaExamen, 
                                             DetalleFactura.idFactura, DetalleFactura.Secuencia, DetalleFactura.idExamen, DetalleFactura.Costo, DetalleFactura.Impuesto
                    FROM          FacturaEncabezado INNER JOIN DetalleFactura
                                                      ON FacturaEncabezado.id = DetalleFactura.idFactura
                    WHERE        (FacturaEncabezado.id = @id) ";

            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@id", pNumeroFactura);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    oFacturaEncabezado = new FacturaEncabezado()
                    {
                        IdFactura = int.Parse(dr["id"].ToString()),
                        FechaFacturacion = DateTime.Parse(dr["Fecha"].ToString()),
                        _Paciente = _IDALPaciente.ReadPacienteById(dr["idPaciente"].ToString()),
                        XML = dr["XML"].ToString(),
                        TipoPago = (int)dr["idTipoPago"]
                    };


                    foreach (var item in ds.Tables[0].Rows)
                    {
                        FacturaDetalle oFacturaDetalle = new FacturaDetalle();
                        oFacturaDetalle.IdFactura = int.Parse(dr["id"].ToString());
                        oFacturaDetalle.Secuencia = int.Parse(dr["Secuencia"].ToString());
                        oFacturaDetalle.Examen = dr["idExamen"].ToString();
                        oFacturaDetalle.Costo = double.Parse(dr["Costo"].ToString());
                        oFacturaDetalle.Impuesto = double.Parse(dr["Impuesto"].ToString());
                        oFacturaEncabezado.AddDetalle(oFacturaDetalle);
                    }
                }


                return oFacturaEncabezado;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateSQLExceptionsErrorDetails(sqlError));
                msg.AppendFormat("SQL             {0}\n", command.CommandText);
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
        public List<FacturaExamenDTO> GetAllFactura(EstadoExamen pEstadoExamen)
        {
            DataSet ds = null;
            List<FacturaExamenDTO> lista = new List<FacturaExamenDTO>();
            SqlCommand command = new SqlCommand();

            string sql = @"SELECT FacturaEncabezado.idPaciente, DetalleFactura.idFactura, DetalleFactura.Secuencia, 
                                  DetalleFactura.idExamen, Examen.Descripcion
                           FROM   DetalleFactura INNER JOIN
                                  Examen ON DetalleFactura.idExamen = Examen.id INNER JOIN
                                  FacturaEncabezado ON DetalleFactura.idFactura = FacturaEncabezado.id
                            WHERE        (DetalleFactura.EstadoExamen = @EstadoExamen)";

            try
            {
                command.Parameters.AddWithValue("@EstadoExamen", pEstadoExamen.ToString());
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
                        FacturaExamenDTO oFacturaExamenDTO = new FacturaExamenDTO();
                        oFacturaExamenDTO.IdPaciente = Convert.ToInt32(dr["idPaciente"].ToString());
                        oFacturaExamenDTO.IdFactura = Convert.ToInt32(dr["idFactura"].ToString());
                        oFacturaExamenDTO.Secuencia = Convert.ToInt32(dr["Secuencia"].ToString());
                        oFacturaExamenDTO.IdExamen = dr["idExamen"].ToString();
                        oFacturaExamenDTO.DescripcionExamen = dr["Descripcion"].ToString();

                        lista.Add(oFacturaExamenDTO);
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
        public List<FacturaExamenDTO> ReadAllFacturaByFilter(string pIdPaciente, EstadoExamen pEstadoExamen)
        {
            DataSet ds = null;
            List<FacturaExamenDTO> lista = new List<FacturaExamenDTO>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"SELECT FacturaEncabezado.idPaciente, DetalleFactura.idFactura, DetalleFactura.Secuencia, 
                                  DetalleFactura.idExamen, Examen.Descripcion
                           FROM   DetalleFactura INNER JOIN
                                  Examen ON DetalleFactura.idExamen = Examen.id INNER JOIN
                                  FacturaEncabezado ON DetalleFactura.idFactura = FacturaEncabezado.id
                            WHERE        (DetalleFactura.EstadoExamen = @EstadoExamen) 
							             AND FacturaEncabezado.idPaciente like @IdPaciente";

                command.Parameters.AddWithValue("@EstadoExamen", pEstadoExamen.ToString());
                command.Parameters.AddWithValue("@IdPaciente", pIdPaciente);
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
                        FacturaExamenDTO oFacturaExamenDTO = new FacturaExamenDTO();
                        oFacturaExamenDTO.IdPaciente = Convert.ToInt32(dr["idPaciente"].ToString());
                        oFacturaExamenDTO.IdFactura = Convert.ToInt32(dr["idFactura"].ToString());
                        oFacturaExamenDTO.Secuencia = Convert.ToInt32(dr["Secuencia"].ToString());
                        oFacturaExamenDTO.IdExamen = dr["idExamen"].ToString();
                        oFacturaExamenDTO.DescripcionExamen = dr["Descripcion"].ToString();

                        lista.Add(oFacturaExamenDTO);
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
        public List<FacturaExamenDTO> GetAllFacturaByFilterTipoEntregaExamen(EstadoExamen pEstadoExamen, int pTipoEntregaExamen)
        {
            DataSet ds = null;
            List<FacturaExamenDTO> lista = new List<FacturaExamenDTO>();
            SqlCommand command = new SqlCommand();

            string sql = @"SELECT        FacturaEncabezado.idPaciente, DetalleFactura.idFactura, DetalleFactura.Secuencia, DetalleFactura.idExamen, Examen.Descripcion, TipoEntregaExamen.id
FROM            DetalleFactura INNER JOIN
                         Examen ON DetalleFactura.idExamen = Examen.id INNER JOIN
                         FacturaEncabezado ON DetalleFactura.idFactura = FacturaEncabezado.id INNER JOIN
                         TipoEntregaExamen ON FacturaEncabezado.idTipoEntregaExamen = TipoEntregaExamen.id
WHERE        (DetalleFactura.EstadoExamen = @EstadoExamen) AND (TipoEntregaExamen.id = @TipoEntregaExamen)";

            try
            {
                command.Parameters.AddWithValue("@EstadoExamen", pEstadoExamen.ToString());
                command.Parameters.AddWithValue("@TipoEntregaExamen", pTipoEntregaExamen);
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
                        FacturaExamenDTO oFacturaExamenDTO = new FacturaExamenDTO();
                        oFacturaExamenDTO.IdPaciente = Convert.ToInt32(dr["idPaciente"].ToString());
                        oFacturaExamenDTO.IdFactura = Convert.ToInt32(dr["idFactura"].ToString());
                        oFacturaExamenDTO.Secuencia = Convert.ToInt32(dr["Secuencia"].ToString());
                        oFacturaExamenDTO.IdExamen = dr["idExamen"].ToString();
                        oFacturaExamenDTO.DescripcionExamen = dr["Descripcion"].ToString();

                        lista.Add(oFacturaExamenDTO);
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
        public bool UpdateEstadoDetalleFactura(FacturaDetalle oFacturaDetalle)
        {
            string sql = @"UPDATE DetalleFactura
                           SET EstadoExamen = @EstadoExamen
                           WHERE idFactura = @idFactura
	                             AND
	                             Secuencia = @Secuencia";
            SqlCommand command = new SqlCommand();
            double rows = 0;

            try
            {
                // Pasar parámetros
                command.Parameters.AddWithValue("@EstadoExamen", oFacturaDetalle.EstadoExamen);
                command.Parameters.AddWithValue("@idFactura", oFacturaDetalle.IdFactura);
                command.Parameters.AddWithValue("@Secuencia", oFacturaDetalle.Secuencia);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

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
