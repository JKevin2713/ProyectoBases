using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB
{
    public class TipoEmpleadoDB
    {
        

        public void InsertarTipoEmpleado(TipoEmpleado tipoEmpleado, String connectionString)
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


        public void ActualizarTipoEmpleado(TipoEmpleado tipoEmpleado, String connectionString)
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

        public int BuscarIdTipo(String tipoEmpleado, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL BuscarIdTipoEmpleado(@nombreTipoEmpleado)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreTipoEmpleado", tipoEmpleado);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return Convert.ToInt32(reader["idTipo"]);
                        }
                        return 0;
                    }
                }
            }
        }

        public String BuscarNombreTipo(int tipoEmpleado, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL BuscarNombreTipoEmpleado(@idTipo)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idTipo", tipoEmpleado);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader["nombreTipoEmpleado"].ToString();
                        }
                        return "";
                    }
                }
            }
        }

        public void DeleteTipoEmpleado(int idTipo, String connectionString)
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

        public List<String[]> VerTipoEmpleado(String connectionString)
        {
            List<String[]> calendarios = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerTipoEmpleado()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] calendario = new String[]
                            {
                                reader["idTipo"].ToString(),
                                reader["nombreTipoEmpleado"].ToString()
                            };

                            calendarios.Add(calendario);
                        }
                    }
                }
            }

            return calendarios;
        }

        public List<String> VerNombreTipos(String connectionString)
        {
            List<String> Tipos = new List<String>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerTipoEmpleado()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String Tipo = reader["nombreTipoEmpleado"].ToString();

                            MessageBox.Show(Tipo);
                            Tipos.Add(Tipo);
                        }
                    }
                }
            }

            return Tipos;
        }


    }
}
