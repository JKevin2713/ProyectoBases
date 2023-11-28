using DB;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoBases
{
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            InitializeComponent();
            // dias (entrada/salida)
            dateTimeEntrada.Format = DateTimePickerFormat.Custom;
            dateTimeEntrada.CustomFormat = "yyyy-MM-dd";
            dateTimeSalida.Format = DateTimePickerFormat.Custom;
            dateTimeSalida.CustomFormat = "yyyy-MM-dd";
            //horas (entradas/ salidas)
            horainicial.Format = DateTimePickerFormat.Custom;
            horainicial.CustomFormat = "HH: mm: ss";
            horafinal.Format = DateTimePickerFormat.Custom;
            horafinal.CustomFormat = "HH: mm: ss";
            CargarDepartamentos();
            CargarTipoEmpleados();
            CargarCalendario();
        }
        public int idEmpleado;



        public void recibeIdEmpleado(int id)
        {
            idEmpleado = id;


        }
        private void CargarDepartamentos()
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("verDepartamentos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DepCB.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar departamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTipoEmpleados()
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("verTipoEmpleados", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Añadir cada nombre de departamento al ComboBox
                                cargoCB.Items.Add(reader["nombreTipoEmpleado"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar departamentos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCalendario()
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("verCalendarioLaboral", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                calendario.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el calendario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int TipoEmpleado(string nombreTipoEmpleado)
        {
            int idTipoEmpleado = -1;

            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string consulta = "verTipoEmpleado";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombreTipoEmpleado);

                        // Ejecutar la consulta y obtener el resultado
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            idTipoEmpleado = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el idTipoEmpleado: {ex.Message}");
            }

            return idTipoEmpleado;
        }

        private int Calendario(string nombreCalendario)
        {
            int idCalendario = -1;

            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string consulta = "verCalendarioPorNombre";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreCalendario", nombreCalendario);

                        // Ejecutar la consulta y obtener el resultado
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            idCalendario = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el idCalendario: {ex.Message}");
                // Aquí puedes manejar el error según tus necesidades
            }

            return idCalendario;
        }
        private int Planta(string nombrePlanta)
        {
            int idPlanta = -1;

            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string consulta = "verPlantaPorNombre";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombrePlanta", nombrePlanta);

                        // Ejecutar la consulta y obtener el resultado
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            idPlanta = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el idPlanta: {ex.Message}");
            }

            return idPlanta;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
        }
        private void calendario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cargarRegistro_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("ModificarDatosEmpleado", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        int horaInicio = horainicial.Value.Hour;
                        int horaFinal = horafinal.Value.Hour;
                        int idCalendario = Calendario(calendario.SelectedItem.ToString());
                        int idTipoEmpleado = TipoEmpleado(cargoCB.SelectedItem.ToString());
                        int idPlanta = Planta(plantaCB.SelectedItem.ToString());



                        command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        command.Parameters.AddWithValue("@nombre", NombreText.Text + ApellidoText.Text);
                        command.Parameters.AddWithValue("@fecha_ingreso", dateTimeEntrada.Value.Date);
                        command.Parameters.AddWithValue("@fecha_salida", dateTimeSalida.Value.Date);
                        command.Parameters.AddWithValue("@horaInicio", horaInicio);
                        command.Parameters.AddWithValue("@horaFinal", horaFinal);
                        command.Parameters.AddWithValue("@tipo_empleado_id", idTipoEmpleado);
                        command.Parameters.AddWithValue("@id_calendario", idCalendario);
                        command.Parameters.AddWithValue("@departamento", DepCB.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@supervisor", Convert.ToInt32(SupervisorCB.SelectedValue));
                        command.Parameters.AddWithValue("@planta", idPlanta);
                        // ver casos de departamento. planta. calendario...
                        command.ExecuteNonQuery();


                        MessageBox.Show($"Datos guardados correctamente:\n" +
                        $"Nombre: {NombreText.Text + ApellidoText.Text}\n" +
                        $"Fecha de Ingreso: {dateTimeEntrada.Value.Date}\n" +
                        $"Fecha de Salida: {dateTimeSalida.Value.Date}\n" +
                        $"Hora de Inicio: {horaInicio}\n" +
                        $"Hora Final: {horaFinal}\n" +
                        $"tipo_empleado_id: {idTipoEmpleado}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
