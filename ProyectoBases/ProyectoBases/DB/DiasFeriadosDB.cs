using System;
using MySql.Data.MySqlClient;
using Model;

namespace DB
{
    public class DiasFeriadosDB
    {
        private string connectionString = Utils.Constantes.ConnectionString;

        public void InsertarDiaFeriado(DiasFeriados diaFeriado)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarDiaFeriado(@IdDia, @IdCalendario, @Fecha, @Etiqueta)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdDia", diaFeriado.IdDia);
                    command.Parameters.AddWithValue("@IdCalendario", diaFeriado.IdCalendario);
                    command.Parameters.AddWithValue("@Fecha", diaFeriado.Fecha);
                    command.Parameters.AddWithValue("@Etiqueta", diaFeriado.Etiqueta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarDiaFeriado(DiasFeriados diaFeriado)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarDiaFeriado(@IdDia, @IdCalendario, @Fecha, @Etiqueta)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdDia", diaFeriado.IdDia);
                    command.Parameters.AddWithValue("@IdCalendario", diaFeriado.IdCalendario);
                    command.Parameters.AddWithValue("@Fecha", diaFeriado.Fecha);
                    command.Parameters.AddWithValue("@Etiqueta", diaFeriado.Etiqueta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteDiaFeriado(int idDia)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarDiaFeriado(@idDia)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idDia", idDia);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
