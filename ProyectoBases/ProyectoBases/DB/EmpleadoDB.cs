using System;
using MySql.Data.MySqlClient;
using Model;

namespace DB
{
    public class EmpleadoDB
    {
        private string connectionString = Utils.Constantes.ConnectionString;

        public void InsertarEmpleado(Empleado empleado)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarEmpleado(@nombre, @fecha_ingreso, @fecha_salida, @tipo_empleado_id, @id_calendario, @departamento, @supervisor, @planta)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    command.Parameters.AddWithValue("@fecha_ingreso", empleado.FechaIngreso);
                    command.Parameters.AddWithValue("@fecha_salida", empleado.FechaSalida);
                    command.Parameters.AddWithValue("@tipo_empleado_id", empleado.TipoEmpleadoId);
                    command.Parameters.AddWithValue("@id_calendario", empleado.IdCalendario);
                    command.Parameters.AddWithValue("@departamento", empleado.Departamento);
                    command.Parameters.AddWithValue("@supervisor", empleado.Supervisor);
                    command.Parameters.AddWithValue("@planta", empleado.Planta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarEmpleado(@idEmpleado, @nombre, @fecha_ingreso, @fecha_salida, @tipo_empleado_id, @id_calendario, @departamento, @supervisor, @planta)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);
                    command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    command.Parameters.AddWithValue("@fecha_ingreso", empleado.FechaIngreso);
                    command.Parameters.AddWithValue("@fecha_salida", empleado.FechaSalida);
                    command.Parameters.AddWithValue("@tipo_empleado_id", empleado.TipoEmpleadoId);
                    command.Parameters.AddWithValue("@id_calendario", empleado.IdCalendario);
                    command.Parameters.AddWithValue("@departamento", empleado.Departamento);
                    command.Parameters.AddWithValue("@supervisor", empleado.Supervisor);
                    command.Parameters.AddWithValue("@planta", empleado.Planta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEmpleado(int idEmpleado)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarEmpleado(@idEmpleado)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
