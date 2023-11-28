using DB;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBases
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
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

            // cargar datos a los combobox
            CargarDepartamentos();
            CargarTipoEmpleados();
            CargarCalendario();


        }

        // hacer lo mismo para supervisor 
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
                MessageBox.Show($"Error al cargar tipo de empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                // Añadir cada nombre de departamento al ComboBox
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


        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cargarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("InsertarDatosEmpleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@nombre", NombreText.Text +ApellidoText.Text);
                        command.Parameters.AddWithValue("@fecha_ingreso", dateTimeEntrada.Value.Date);
                        command.Parameters.AddWithValue("@fecha_salida", dateTimeSalida.Value.Date);
                        command.Parameters.AddWithValue("@horaInicio", Convert.ToInt32(horainicial.Value.Hour));
                        command.Parameters.AddWithValue("@horaFinal", Convert.ToInt32(horafinal.Value.Hour));
                        command.Parameters.AddWithValue("@tipo_empleado_id", Convert.ToInt32(cargoCB.SelectedValue));
                        command.Parameters.AddWithValue("@id_calendario", Convert.ToInt32(calendario.SelectedValue));
                        command.Parameters.AddWithValue("@departamento", DepCB.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@supervisor", Convert.ToInt32(SupervisorCB.SelectedValue));
                        command.Parameters.AddWithValue("@planta", Convert.ToInt32(plantaCB.SelectedValue));
                        // ver casos de departamento. planta. calendario...
                        command.ExecuteNonQuery();

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

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimeEntrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void horainicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void horafinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DepCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NombreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void plantaCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calendario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SupervisorCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
