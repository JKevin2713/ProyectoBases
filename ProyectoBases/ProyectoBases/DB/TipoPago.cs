using System;
using MySql.Data.MySqlClient;
using Model;

namespace DB
{
    public class TipoPagoDB
    {
        private string connectionString = Utils.Constantes.ConnectionString;

        public void InsertarTipoPago(TipoPago tipoPago)
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
        public void ActualizarTipoPago(TipoPago tipoPago)
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

        public void DeleteTipoPago(int idTipo)
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
    }
}
