using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;

namespace DB
{
    public class DepartamentoDB
    {

        public void InsertarDepartamento(Departamento departamento, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarDepartamento(@nombre)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", departamento.Nombre);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarDepartamento(Departamento departamento, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarDepartamento(@idDepartamento, @nombre)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idDepartamento", departamento.IdDepartamento);
                    command.Parameters.AddWithValue("@nombre", departamento.Nombre);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<String[]> VerDepartamento(String connectionString)
        {
            List<String[]> departamentos = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerDepartamento()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] departamento = new String[]
                            {
                                reader["idDepartamento"].ToString(),
                                reader["Nombre"].ToString()
                            };

                            departamentos.Add(departamento);
                        }
                    }
                }
            }

            return departamentos;
        }

        public List<String> VerNombreDep(String connectionString)
        {
            List<String> departamentos = new List<String>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerNombreDep()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String departamento = reader["Nombre"].ToString();
                            

                            departamentos.Add(departamento);
                        }
                    }
                }
            }

            return departamentos;
        }

        public void DeleteDepartamento(int idDepartamento, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarDepartamento(@idDepartamento)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
