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
        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cargarRegistro_Click(object sender, EventArgs e)
        {



            this.Close();

        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void calendario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
