using System;
using MySql.Data.MySqlClient;
using Model;

namespace DB
{
    public class TipoEmpleadoDB
    {
        private string connectionString = Utils.Constantes.ConnectionString;

        public void InsertarTipoEmpleado(TipoEmpleado tipoEmpleado)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarTipoEmpleado(@nombreTipoEmpleado)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreTipoEmpleado", tipoEmpleado.NombreTipoEmpleado);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void ActualizarTipoEmpleado(TipoEmpleado tipoEmpleado)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarTipoEmpleado(@idTipo, @nombreTipoEmpleado)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idTipo", tipoEmpleado.IdTipo);
                    command.Parameters.AddWithValue("@nombreTipoEmpleado", tipoEmpleado.NombreTipoEmpleado);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoEmpleado(int idTipo)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarTipoEmpleado(@idTipo)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idTipo", idTipo);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
