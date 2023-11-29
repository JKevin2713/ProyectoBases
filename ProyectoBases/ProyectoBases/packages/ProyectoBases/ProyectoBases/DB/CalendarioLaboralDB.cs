using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;

namespace DB
{
    public class CalendarioLaboralDB
    {

        public void InsertarCalendarioLaboral(CalendarioLaboral calendarioLaboral, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL InsertarCalendarioLaboral(@Nombre, @PagoHora, @PagoHoraExtra, @PagoHoraDoble, @HoraInicio, @HoraFinal, @tipoPago)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", calendarioLaboral.Nombre);
                    command.Parameters.AddWithValue("@PagoHora", calendarioLaboral.PagoHora);
                    command.Parameters.AddWithValue("@PagoHoraExtra", calendarioLaboral.PagoHoraExtra);
                    command.Parameters.AddWithValue("@PagoHoraDoble", calendarioLaboral.PagoHoraDoble);
                    command.Parameters.AddWithValue("@HoraInicio", calendarioLaboral.HoraInicio);
                    command.Parameters.AddWithValue("@HoraFinal", calendarioLaboral.HoraFinal);
                    command.Parameters.AddWithValue("@tipoPago", calendarioLaboral.TipoPago);
                    command.ExecuteNonQuery();
                }
            }
        }


        public List<String[]> VerCalendarioLaboral(String connectionString)
        {
            List<String[]> calendarios = new List<String[]>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerCalendarioLaboral()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String[] calendario = new String[]
                            {
                                reader["idCalendario"].ToString(),
                                reader["Nombre"].ToString(),
                                reader["PagoHora"].ToString(),
                                reader["PagoHoraExtra"].ToString(),
                                reader["PagoHoraDoble"].ToString(),
                                reader["HoraInicio"].ToString(),
                                reader["HoraFinal"].ToString(),
                                reader["tipoPago"].ToString()
                            };

                            calendarios.Add(calendario);
                        }
                    }
                }
            }

            return calendarios;
        }

        public int VerHoraFinal(int calendario, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerHoraFinal(@idCalendario)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCalendario", calendario);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TimeSpan horaFinal = (TimeSpan)reader["HoraFinal"];
                            int hora = (int)horaFinal.TotalHours;

                            return hora;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
        public int VerHoraInicio(int calendario, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerHoraInicio(@idCalendario)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCalendario", calendario);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TimeSpan horaInicio = (TimeSpan)reader["HoraInicio"];
                            int hora = (int)horaInicio.TotalHours;

                            return hora;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }


        public int BuscarIdCalendario(String calendario, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL BuscarIdCalendario(@nombreTipoEmpleado)";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            command.Parameters.AddWithValue("@Nombre", calendario);
                            command.ExecuteNonQuery();
                            return Convert.ToInt32(reader["@idCalendario"]);
                        }
                        else
                        {
                            return 0;
                        }
                    }
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

        public List<String> VerIdCalendario(String connectionString)
        {
            List<String> calendarios = new List<String>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL VerCalendarioLaboral()";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String calendario = reader["idCalendario"].ToString();


                            calendarios.Add(calendario);
                        }
                    }
                }
            }

            return calendarios;
        }

        public void ActualizarCalendarioLaboral(CalendarioLaboral calendarioLaboral, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL ActualizarCalendarioLaboral(@idCalendario, @Nombre, @PagoHora, @PagoHoraExtra, @PagoHoraDoble, @HoraInicio, @HoraFinal, @tipoPago)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCalendario", calendarioLaboral.IdCalendario);
                    command.Parameters.AddWithValue("@Nombre", calendarioLaboral.Nombre);
                    command.Parameters.AddWithValue("@PagoHora", calendarioLaboral.PagoHora);
                    command.Parameters.AddWithValue("@PagoHoraExtra", calendarioLaboral.PagoHoraExtra);
                    command.Parameters.AddWithValue("@PagoHoraDoble", calendarioLaboral.PagoHoraDoble);
                    command.Parameters.AddWithValue("@HoraInicio", calendarioLaboral.HoraInicio);
                    command.Parameters.AddWithValue("@HoraFinal", calendarioLaboral.HoraFinal);
                    command.Parameters.AddWithValue("@tipoPago", calendarioLaboral.TipoPago);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteCalendarioLaboral(int idCalendario, String connectionString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "CALL EliminarCalendarioLaboral(@idCalendario)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCalendario", idCalendario);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
