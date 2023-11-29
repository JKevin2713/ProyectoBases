using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;

namespace DB
{
    public class EmpleadoDB
    {

        public void InsertarEmpleado(Empleado empleado, String connectionString)
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
                    if(empleado.Supervisor == 0)
                    {
                        command.Parameters.AddWithValue("@supervisor", null);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@supervisor", empleado.Supervisor);
                    }
                    command.Parameters.AddWithValue("@planta", empleado.Planta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<String[]> VerEmpleado(String connectionString)
        {
            List<String[]> calendarios = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerEmpleado()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] calendario = new String[]
                            {
                                reader["idEmpleado"].ToString(),
                                reader["nombre"].ToString(),
                                reader["fecha_ingreso"].ToString(),
                                reader["fecha_salida"].ToString(),
                                reader["tipo_empleado_id"].ToString(),
                                reader["id_calendario"].ToString(),
                                reader["departamento"].ToString(),
                                reader["supervisor"].ToString(),
                                reader["planta"].ToString()
                            };

                            calendarios.Add(calendario);
                        }
                    }
                }
            }

            return calendarios;
        }

        public int BuscarIdEmpleado(String empleado, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL BuscarIdEmpleado(@idEmpleado)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idEmpleado", empleado);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return Convert.ToInt32(reader["idEmpleado"]);
                        }
                        return 0;
                    }
                }
            }
        }
        public void ActualizarEmpleado(Empleado empleado, String connectionString)
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

        public void DeleteEmpleado(int idEmpleado, String connectionString)
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
