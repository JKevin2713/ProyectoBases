﻿using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;

namespace DB
{
    public class MarcaDB
    {

        public void InsertarMarca(Marca marca, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarMarca(@empleado_id, @fecha, @entrada, @salida)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@empleado_id", marca.EmpleadoId);
                    command.Parameters.AddWithValue("@fecha", marca.Fecha);
                    command.Parameters.AddWithValue("@entrada", marca.Entrada);
                    command.Parameters.AddWithValue("@salida", marca.Salida);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarMarca(Marca marca, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarMarca(@id, @empleado_id, @fecha, @entrada, @salida)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", marca.Id);
                    command.Parameters.AddWithValue("@empleado_id", marca.EmpleadoId);
                    command.Parameters.AddWithValue("@fecha", marca.Fecha);
                    command.Parameters.AddWithValue("@entrada", marca.Entrada);
                    command.Parameters.AddWithValue("@salida", marca.Salida);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMarca(int id, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarMarca(@id)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<String[]> VerMarca(String connectionString)
        {
            List<String[]> calendarios = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerMarca()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] calendario = new String[]
                            {
                                reader["id"].ToString(),
                                reader["empleado_id"].ToString(),
                                reader["fecha"].ToString(),
                                reader["entrada"].ToString(),
                                reader["salida"].ToString()
                               
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
