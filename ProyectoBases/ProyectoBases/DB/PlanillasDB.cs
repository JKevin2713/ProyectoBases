using System;
using MySql.Data.MySqlClient;
using Model;

namespace DB
{
    public class PlanillasDB
    {
        private string connectionString = Utils.Constantes.ConnectionString;

        public void InsertarPlanilla(Planillas planilla)
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

        public void ActualizarPlanilla(Planillas planilla)
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

        public void DeletePlanilla(int idPlanilla)
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
    }
}
