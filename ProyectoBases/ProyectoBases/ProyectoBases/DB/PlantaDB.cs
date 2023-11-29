
using System;
using MySql.Data.MySqlClient;
using Model;

namespace DB
{
    public class PlantaDB
    {

        public void ActualizarPlanta(Planta planta, String connectionString)
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
                connection.Close();
            }
        }

    }
}