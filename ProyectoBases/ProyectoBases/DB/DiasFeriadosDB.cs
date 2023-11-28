using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;

namespace DB
{
    public class DiasFeriadosDB
    {

        public void InsertarDiaFeriado(DiasFeriados diaFeriado, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarDiasFeriados(@IdDia, @IdCalendario, @Fecha, @Etiqueta)";
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
        public List<String[]> VerDiasFeriados(String connectionString)
        {
            List<String[]> feriados = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerDiasFeriados()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] feriado = new String[]
                            {
                                reader["IdDia"].ToString(),
                                reader["IdCalendario"].ToString(),
                                reader["Fecha"].ToString(),
                                reader["Etiqueta"].ToString(),

                            };

                            feriados.Add(feriado);
                        }
                    }
                }
            }

            return feriados;
        }
        public void ActualizarDiaFeriado(DiasFeriados diaFeriado, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarDiasFeriados(@IdDia, @IdCalendario, @Fecha, @Etiqueta)";
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

        public void DeleteDiaFeriado(int idDia, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarDiasFeriados(@idDia)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idDia", idDia);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
