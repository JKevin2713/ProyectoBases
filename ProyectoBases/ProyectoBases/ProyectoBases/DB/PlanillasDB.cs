using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;

namespace DB
{
    public class PlanillasDB
    {

        public void InsertarPlanilla(Planillas planilla, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarPlanilla(@idEmpleado, @idPlanta, @estado, @salarioBruto, @salarioNeto, @PorcentajeObligaciones)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idEmpleado", planilla.IdEmpleado);
                    command.Parameters.AddWithValue("@idPlanta", planilla.IdPlanta);
                    command.Parameters.AddWithValue("@estado", planilla.Estado);
                    command.Parameters.AddWithValue("@salarioBruto", planilla.SalarioBruto);
                    command.Parameters.AddWithValue("@salarioNeto", planilla.SalarioNeto);
                    command.Parameters.AddWithValue("@PorcentajeObligaciones", planilla.PorcentajeObligaciones);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarPlanilla(Planillas planilla, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarPlanilla(@idPlanilla, @idEmpleado, @idPlanta, @estado, @salarioBruto, @salarioNeto, @PorcentajeObligaciones)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPlanilla", planilla.IdPlanilla);
                    command.Parameters.AddWithValue("@idEmpleado", planilla.IdEmpleado);
                    command.Parameters.AddWithValue("@idPlanta", planilla.IdPlanta);
                    command.Parameters.AddWithValue("@estado", planilla.Estado);
                    command.Parameters.AddWithValue("@salarioBruto", planilla.SalarioBruto);
                    command.Parameters.AddWithValue("@salarioNeto", planilla.SalarioNeto);
                    command.Parameters.AddWithValue("@PorcentajeObligaciones", planilla.PorcentajeObligaciones);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePlanilla(int idPlanilla, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarPlanilla(@idPlanilla)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPlanilla", idPlanilla);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<String[]> VerPlanilla(String connectionString)
        {
            List<String[]> calendarios = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerPlanilla()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] calendario = new String[]
                            {
                                reader["idPlanilla"].ToString(),
                                reader["idEmpleado"].ToString(),
                                reader["idPlanta"].ToString(),
                                reader["estado"].ToString(),
                                reader["salarioBruto"].ToString(),
                                reader["salarioNeto"].ToString(),
                                reader["PorcentajeObligaciones"].ToString()
                                
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
