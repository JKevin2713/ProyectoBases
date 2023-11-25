using System;
using MySql.Data.MySqlClient;
using Model;

namespace DB
{
    public class MarcaDB
    {
        private string connectionString = Utils.Constantes.ConnectionString;

        public void InsertarMarca(Marca marca)
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

        public void ActualizarMarca(Marca marca)
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

        public void DeleteMarca(int id)
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
    }
}
