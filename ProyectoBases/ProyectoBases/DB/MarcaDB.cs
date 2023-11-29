using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace DB
{
    public class MarcaDB
    {
   

        public void InsertarMarca(Marca marca, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarMarca(@empleado_id, @fecha, @entrada, @salida)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@empleado_id", marca.EmpleadoId);
                    command.Parameters.AddWithValue("@fecha", marca.Fecha);
                    command.Parameters.AddWithValue("@entrada", marca.Entrada);
                    command.Parameters.AddWithValue("@salida", marca.Salida);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool MarcaExistente(int empleadoId, DateTime fecha, String connectionString)
        {

            using (var connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                var query = "SELECT COUNT(*) FROM Marca WHERE empleado_id = @empleadoId AND fecha = @fecha";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@empleadoId", empleadoId);
                    command.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
                    try
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al verificar la existencia de la marca: {ex.Message}");
                        return false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public List<String[]> ObtenerMarcasPorEmpleado(int idEmpleado, string connectionString)
        {
            List<String[]> marcas = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT id, fecha, entrada, salida FROM Marca WHERE empleado_id = @idEmpleado";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] marca = new String[]
                            {
                        reader["id"].ToString(),
                        reader["empleado_id"].ToString(),
                        reader["fecha"].ToString(),
                        reader["entrada"].ToString(),
                        reader["salida"].ToString()
                            };

                            marcas.Add(marca);
                        }
                    }
                }
            }

            return marcas;
        }

        public void ActualizarMarca(Marca marca, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarMarca(@id, @empleado_id, @fecha, @entrada, @salida)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", marca.Id);
                    command.Parameters.AddWithValue("@empleado_id", marca.EmpleadoId);
                    command.Parameters.AddWithValue("@fecha", marca.Fecha);
                    command.Parameters.AddWithValue("@entrada", marca.Entrada);
                    command.Parameters.AddWithValue("@salida", marca.Salida);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMarca(int id, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarMarca(@id)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<String[]> VerMarca(String connectionString)
        {
            List<String[]> calendarios = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerMarca()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] calendario = new String[]
                            {
                                reader["id"].ToString(),
                                reader["empleado_id"].ToString(),
                                reader["fecha"].ToString(),
                                reader["entrada"].ToString(),
                                reader["salida"].ToString()
                               
                            };

                            calendarios.Add(calendario);
                        }
                    }
                }
            }

            return calendarios;
        }

    }
}
