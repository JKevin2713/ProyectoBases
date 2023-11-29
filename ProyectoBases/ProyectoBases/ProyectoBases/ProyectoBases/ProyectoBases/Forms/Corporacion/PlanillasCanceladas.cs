using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{
    public partial class PlanillasCanceladas : Form
    {
        public PlanillasCanceladas()
        {
            InitializeComponent();
            cargarPlanillas();

        }
        public void cargarPlanillas() // carga la planilla a la tabla para proceder a pagar, estas son planillas de cualquier planta
        {
            string query = "EXEC verPlanillasPagas"; ///cambiar 

            using (SqlConnection connection = CorporacionBD.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                TablaPagosP.DataSource = table;
            }
        }
        private void DatosPagoPlanilla(int idPago)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("DatosPagoPlanilla", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@IdPago", SqlDbType.Int).Value = idPago;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                using (StreamWriter file = new StreamWriter("PagoPlanilla.txt"))
                                {
                                    file.WriteLine("PAGO DE PLANILLA");
                                    file.WriteLine("=================");
                                    file.WriteLine();

                                    while (reader.Read())
                                    {
                                        file.WriteLine($"ID Pago: {reader["idpago"]}");
                                        file.WriteLine($"ID Empleado: {reader["Id Empleado"]}");
                                        file.WriteLine($"Empleado: {reader["Empleado"]}");
                                        file.WriteLine($"ID Calendario: {reader["Id calendario"]}");
                                        file.WriteLine($"Calendario: {reader["Calendario"]}");
                                        file.WriteLine($"Departamento: {reader["Departamento"]}");
                                        file.WriteLine($"Fecha de Ingreso: {reader["fecha_ingreso"]}");
                                        file.WriteLine($"Fecha de Salida: {reader["fecha_salida"]}");
                                        file.WriteLine($"Hora de Inicio: {reader["horaInicio"]}");
                                        file.WriteLine($"Hora Final: {reader["horaFinal"]}");
                                        file.WriteLine($"Planta: {reader["Planta"]}");
                                        file.WriteLine();
                                    }
                                }

                                MessageBox.Show("Datos del pago de planilla guardados en PagoPlanilla.txt", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron resultados para el ID de pago especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos del pago de planilla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void TablaPagosP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void PlanillasCanceladas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(IdPagoText.Text, out int idPago))
                {
                    DatosPagoPlanilla(idPago);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de pago válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void IdPagoText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
