
using System;
using MySql.Data.MySqlClient;
using Model;

namespace DB
{
    public class PlantaDB
    {

        private string connectionString = Utils.Constantes.ConnectionString;

        public void InsertarPlanta(Planta planta)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarPlanta(@nombre, @conexion)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", planta.Nombre);
                    command.Parameters.AddWithValue("@conexion", planta.Conexion);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Planta VerPlantas(int idPlanta)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL Plantas(@idPlanta)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPlanta", idPlanta);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Planta
                            {
                                IdPlanta = Convert.ToInt32(reader["idPlanta"]),
                                Nombre = reader["nombre"].ToString(),
                                Conexion = Convert.ToBoolean(reader["conexion"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public void ActualizarPlanta(Planta planta)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarPlanta(@idPlanta, @nombre, @conexion)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPlanta", planta.IdPlanta);
                    command.Parameters.AddWithValue("@nombre", planta.Nombre);
                    command.Parameters.AddWithValue("@conexion", planta.Conexion);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void DeletePlanta(int idPlanta)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarPlanta(@idPlanta)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPlanta", idPlanta);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}