using System;
using Model;
using MySql.Data.MySqlClient;

namespace DB
{
    public class DiasLaboralesDB
    {
        private string connectionString = Utils.Constantes.ConnectionString;

        public void InsertarDiasLaborales(DiasLaborales diasLaborales)
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

        public void ActualizarDiasLaborales(DiasLaborales diasLaborales)
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
