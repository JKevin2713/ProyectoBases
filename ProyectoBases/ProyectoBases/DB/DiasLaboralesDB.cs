using System;
using Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DB
{
    public class DiasLaboralesDB
    {

        public void InsertarDiasLaborales(DiasLaborales diasLaborales, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarDiasLaborales(@idCalendario, @Lunes, @Martes, @Miercoles, @Jueves, @Viernes, @Sabados, @Domingos)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCalendario", diasLaborales.IdCalendario);
                    command.Parameters.AddWithValue("@Lunes", diasLaborales.Lunes);
                    command.Parameters.AddWithValue("@Martes", diasLaborales.Martes);
                    command.Parameters.AddWithValue("@Miercoles", diasLaborales.Miercoles);
                    command.Parameters.AddWithValue("@Jueves", diasLaborales.Jueves);
                    command.Parameters.AddWithValue("@Viernes", diasLaborales.Viernes);
                    command.Parameters.AddWithValue("@Sabados", diasLaborales.Sabados);
                    command.Parameters.AddWithValue("@Domingos", diasLaborales.Domingos);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<String[]> VerDiasLaborales(String connectionString)
        {
            List<String[]> feriados = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerDiasLaborales()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] semana = new String[]
                            {
                                reader["idCalendario"].ToString(),
                                reader["Lunes"].ToString(),
                                reader["Martes"].ToString(),
                                reader["Miercoles"].ToString(),
                                reader["Jueves"].ToString(),
                                reader["Viernes"].ToString(),
                                reader["Sabados"].ToString(),
                                reader["Domingos"].ToString()
                            };

                            feriados.Add(semana);
                        }
                    }
                }
            }

            return feriados;
        }
        public void DeleteDiasLaborales(int idCalendario, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarDiasLaborales(@idCalendario)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCalendario", idCalendario);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarDiasLaborales(DiasLaborales diasLaborales, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarDiasLaborales(@idCalendario, @Lunes, @Martes, @Miercoles, @Jueves, @Viernes, @Sabados, @Domingos)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCalendario", diasLaborales.IdCalendario);
                    command.Parameters.AddWithValue("@Lunes", diasLaborales.Lunes);
                    command.Parameters.AddWithValue("@Martes", diasLaborales.Martes);
                    command.Parameters.AddWithValue("@Miercoles", diasLaborales.Miercoles);
                    command.Parameters.AddWithValue("@Jueves", diasLaborales.Jueves);
                    command.Parameters.AddWithValue("@Viernes", diasLaborales.Viernes);
                    command.Parameters.AddWithValue("@Sabados", diasLaborales.Sabados);
                    command.Parameters.AddWithValue("@Domingos", diasLaborales.Domingos);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
