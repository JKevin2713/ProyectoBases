using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DB;
using System.Drawing.Text;
using Org.BouncyCastle.Asn1.Pkcs;
using System.Collections;
using ProyectoBases.DB;
using Model;



namespace ProyectoBases
{
    public partial class PagoPlanillas : Form
    {
        string connectionstring;
        int opcion;
        string plantaOpcion;
        SinConexion sc = new SinConexion();

        public PagoPlanillas(int planta)
        {
            InitializeComponent();
            opcion = planta;
            //cargarPlanillas(opcion);
            fechaPagoPlanilla.Format = DateTimePickerFormat.Custom;
            fechaPagoPlanilla.CustomFormat = "yyyy-MM-dd";

        }
        public void conexion(int opcionPlanta)
        {
            if (opcionPlanta == 1 )//"Guayabo"
            {
                connectionstring = Utils.Constantes.ConnectionString;
                plantaOpcion = "Guayabo";
            }
            else if (opcionPlanta == 1)//"Central"
            {
                connectionstring = Utils.Constantes.ConnectionString2;
                plantaOpcion = "Central";

            }
            else if (opcionPlanta == 1)//"La Romana"
            {
                connectionstring = Utils.Constantes.ConnectionString3;
                plantaOpcion = "La Romana";
            }

        }
        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void cargarPlanillas(int opcion)
        {
            string query = "";

            switch (opcion)
            {
                case 1:
                    query = "EXEC verPlanilla1";
                    break;
                case 2:
                    query = "EXEC verPlanilla2";
                    break;
                case 3:
                    query = "EXEC verPlanilla3";
                    break;

            }

            using (SqlConnection connection = CorporacionBD.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                TablaPagosP.DataSource = table;
            }
        }

        private void PagarPlanilla(int idPlanilla, DateTime fechaPago)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("PagarPlanilla", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Añadir los parámetros
                        command.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idPlanilla;
                        command.Parameters.Add("@fechaPago", SqlDbType.Date).Value = fechaPago;

                        // Mostrar un mensaje para verificar los valores antes de ejecutar el SP
                        MessageBox.Show($"ID Planilla: {idPlanilla}, Fecha Pago: {fechaPago.ToString("yyyy-MM-dd")}", "Parámetros SP", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ejecutar el stored procedure
                        command.ExecuteNonQuery();
                        MessageBox.Show($"La planilla {idPlanilla} se pagó exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Console.WriteLine("¡La planilla se pagó exitosamente!");
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 51000)
                {
                    MessageBox.Show("Error: La planilla ya ha sido pagada y no se puede pagar nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 51001)
                {
                    MessageBox.Show("Error: La planilla especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Error al pagar la planilla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Console.WriteLine($"Error al pagar la planilla: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al pagar la planilla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error al pagar la planilla: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
        }



        private void pagarBTN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idPlanillaText.Text, out int idPlanilla))
            {
                DateTime fechaPago = fechaPagoPlanilla.Value;
                PagarPlanilla(idPlanilla, fechaPago);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de planilla válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PagoPlanillas_Load(object sender, EventArgs e)
        {

        }

        private void tabla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fechaPagoPlanilla_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarPlanillas(opcion);
        }
    }
}
