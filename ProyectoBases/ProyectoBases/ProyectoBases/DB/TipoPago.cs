using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;

namespace DB
{
    public class TipoPagoDB
    {


        public void InsertarTipoPago(TipoPago tipoPago, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarTipoPago(@nombre)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", tipoPago.Nombre);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void ActualizarTipoPago(TipoPago tipoPago, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarTipoPago(@idTipo, @nombre)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idTipo", tipoPago.IdTipo);
                    command.Parameters.AddWithValue("@nombre", tipoPago.Nombre);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoPago(int idTipo, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarTipoPago(@idTipo)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idTipo", idTipo);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<String[]> VerTipoPago(String connectionString)
        {
            List<String[]> calendarios = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerTipoPago()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] calendario = new String[]
                            {
                                reader["idTipo"].ToString(),
                                reader["nombre"].ToString()
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
