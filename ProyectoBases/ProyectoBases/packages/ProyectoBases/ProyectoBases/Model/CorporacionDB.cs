using DB;
using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBases.DB
{
    //ALE
    public class CorporacionDB
    {
        String connectionstring;
        //Empleado
        public void insertarEmpleado(Empleado empleado, String connectionPlanta)
        {
            try
            {
                CalendarioLaboralDB calen = new CalendarioLaboralDB();
                int horaInicio = calen.VerHoraInicio(empleado.IdCalendario, connectionPlanta);
                int horaFinal = calen.VerHoraFinal(empleado.IdCalendario, connectionPlanta);

                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }


                    using (SqlCommand command = new SqlCommand("InsertarDatosEmpleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                        command.Parameters.AddWithValue("@fecha_ingreso", empleado.FechaIngreso);
                        command.Parameters.AddWithValue("@fecha_salida", empleado.FechaSalida);
                        command.Parameters.AddWithValue("@horaInicio", horaInicio);
                        command.Parameters.AddWithValue("@horaFinal", horaFinal);
                        command.Parameters.AddWithValue("@tipo_empleado_id", empleado.TipoEmpleadoId);
                        command.Parameters.AddWithValue("@id_calendario", empleado.IdCalendario);
                        command.Parameters.AddWithValue("@departamento", empleado.Departamento);
                        command.Parameters.AddWithValue("@supervisor", empleado.Supervisor);
                        command.Parameters.AddWithValue("@planta", empleado.Planta);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {

            }
            
        }

        public void modificarEmpleado(Empleado empleado, String connectionPlanta)
        {
            try
            {
                int horaInicio = 0;
                int horaFinal = 0;
                CalendarioLaboralDB calendarioDB = new CalendarioLaboralDB();
                List<String[]> calendarios = calendarioDB.VerCalendarioLaboral(connectionPlanta);

                for (int i = 0; i < calendarios.Count; i++)
                {
                    if (calendarios[i][0].Equals(empleado.IdCalendario))
                    {
                        horaInicio = Convert.ToInt32(calendarios[i][5]);
                        horaFinal = Convert.ToInt32(calendarios[i][6]);
                    }
                }

                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }


                    using (SqlCommand command = new SqlCommand("ModificarDatosEmpleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                        command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                        command.Parameters.AddWithValue("@fecha_ingreso", empleado.FechaIngreso);
                        command.Parameters.AddWithValue("@fecha_salida", empleado.FechaSalida);
                        command.Parameters.AddWithValue("@horaInicio", horaInicio);
                        command.Parameters.AddWithValue("@horaFinal", horaFinal);
                        command.Parameters.AddWithValue("@tipo_empleado_id", empleado.TipoEmpleadoId);
                        command.Parameters.AddWithValue("@id_calendario", empleado.IdCalendario);
                        command.Parameters.AddWithValue("@departamento", empleado.Departamento);
                        command.Parameters.AddWithValue("@supervisor", empleado.Supervisor);
                        command.Parameters.AddWithValue("@planta", empleado.Planta);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {

            }

        }
        public void eliminarEmpleado(int IdEmpleado, String connectionPlanta)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("EliminarEmpleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Error al eliminar empleado: {ex.Message}");
            }
        }

        //Planilla
        public void insertarPlanilla(Planillas planilla)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {

                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        string insertQuery = "INSERT INTO Planillas (idEmpleado, idPlanta, estado, salarioBruto, salarioNeto, PorcentajeObligaciones) " +
                                         "VALUES (@idEmpleado, @idPlanta, @estado, @salarioBruto, @salarioNeto, @PorcentajeObligaciones)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@idEmpleado", planilla.IdEmpleado);
                        command.Parameters.AddWithValue("@idPlanta", planilla.IdPlanta);
                        command.Parameters.AddWithValue("@estado", planilla.Estado);
                        command.Parameters.AddWithValue("@salarioBruto", planilla.SalarioBruto);
                        command.Parameters.AddWithValue("@salarioNeto", planilla.SalarioNeto);
                        command.Parameters.AddWithValue("@PorcentajeObligaciones", planilla.PorcentajeObligaciones);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // Manejo de excepciones
            }
        }

        ////Planilla
        //public void insertarPlanilla(Planillas planilla)
        //{
        //    try
        //    {

        //        using (SqlConnection connection = CorporacionBD.GetConnection())
        //        {
        //            if (connection.State != ConnectionState.Open)
        //            {
        //                connection.Open();
        //            }

        //            using (SqlCommand command = new SqlCommand("InsertarPlanilla", connection))
        //            {
        //                command.CommandType = CommandType.StoredProcedure;

        //                command.Parameters.AddWithValue("@idEmpleado", planilla.IdEmpleado);
        //                command.Parameters.AddWithValue("@idPlanta", planilla.IdPlanta);
        //                command.Parameters.AddWithValue("@estado", planilla.Estado);
        //                command.Parameters.AddWithValue("@salarioBruto", planilla.SalarioBruto);
        //                command.Parameters.AddWithValue("@salarioNeto", planilla.SalarioNeto);
        //                command.Parameters.AddWithValue("@PorcentajeObligaciones", planilla.PorcentajeObligaciones);

        //                command.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    catch
        //    {

        //    }

        //}


        public void modificarPlanilla(Planillas planilla)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("ModificarPlanilla", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@idEmpleado", planilla.IdEmpleado);
                        command.Parameters.AddWithValue("@idPlanta", planilla.IdPlanta);
                        command.Parameters.AddWithValue("@estado", planilla.Estado);
                        command.Parameters.AddWithValue("@salarioBruto", planilla.SalarioBruto);
                        command.Parameters.AddWithValue("@salarioNeto", planilla.SalarioNeto);
                        command.Parameters.AddWithValue("@PorcentajeObligaciones", planilla.PorcentajeObligaciones);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {

            }

        }

        public void eliminarPlanilla(int idPlanilla)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("EliminarPlanilla", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idPlanilla", idPlanilla);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar planilla: {ex.Message}");
            }
        }



        public int Planta(string nombrePlanta)
        {
            int idPlanta = -1;

            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string consulta = "verPlantaPorNombre";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombrePlanta", nombrePlanta);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            idPlanta = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el idPlanta: {ex.Message}");
            }

            return idPlanta;
        }


        public void conexion(String nombre)
        {
            if (nombre == "Guayabo")
            {
                connectionstring = Utils.Constantes.ConnectionString;
            }
            else if (nombre == "Central")
            {
                connectionstring = Utils.Constantes.ConnectionString2;
            }
            else if (nombre == "La Romana")
            {
                connectionstring = Utils.Constantes.ConnectionString3;
            }

        }
        public int tipoEmpleado(string cargo, string planta)
        {
            conexion(planta);
            TipoEmpleadoDB TipoEmpleadoDB = new TipoEmpleadoDB();
            int TipoID = TipoEmpleadoDB.BuscarIdTipo(cargo, connectionstring);
            return TipoID;

        }

        public int calendario(string calendario, string planta )
        {
            conexion(planta);

            CalendarioLaboralDB CL = new CalendarioLaboralDB();
            int calendarioID = CL.BuscarIdCalendario(calendario, connectionstring);
            return calendarioID;

        }

       








    }



}
