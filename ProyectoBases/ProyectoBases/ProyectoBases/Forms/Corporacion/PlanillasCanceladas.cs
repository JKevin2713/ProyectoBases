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
        private void ObtenerDatosEmpleado(int idPago)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        MessageBox.Show($"ID Pago: {idPago}", "Parámetros SP", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    using (SqlCommand command = new SqlCommand("VerificarPagoPlanilla", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@idPago", SqlDbType.Int).Value = idPago;
                        MessageBox.Show($"ID Pago: {idPago}", "Parámetros SP", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                using (StreamWriter file = new StreamWriter("Comprobante de pago.txt"))
                                {
                                    file.WriteLine("PLANILLA DE PAGO");
                                    file.WriteLine("================");
                                    file.WriteLine();

                                    while (reader.Read())
                                    {
                                        file.WriteLine($"ID Empleado: {reader["idEmpleado"]}");
                                        file.WriteLine($"Nombre: {reader["nombre"]}");
                                        file.WriteLine($"Fecha de Ingreso: {reader["fecha_ingreso"]}");
                                        file.WriteLine($"Fecha de Salida: {reader["fecha_salida"]}");
                                        file.WriteLine($"Hora de Inicio: {reader["horaInicio"]}");
                                        file.WriteLine($"Hora Final: {reader["horaFinal"]}");
                                        file.WriteLine($"Tipo de Empleado ID: {reader["tipo_empleado_id"]}");
                                        file.WriteLine($"ID Calendario: {reader["id_calendario"]}");
                                        file.WriteLine($"Departamento: {reader["departamento"]}");
                                        file.WriteLine($"Supervisor: {reader["supervisor"]}");
                                        file.WriteLine($"Planta: {reader["planta"]}");
                                        file.WriteLine();
                                    }
                                }
                                MessageBox.Show("Datos del empleado guardados en archivo.txt", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró un pago con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos del empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error al obtener datos del empleado: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
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
            // imprimir comprobante 

            {
                if (int.TryParse(IdPagoText.Text, out int idPago))
                {
                    ObtenerDatosEmpleado(idPago);
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
