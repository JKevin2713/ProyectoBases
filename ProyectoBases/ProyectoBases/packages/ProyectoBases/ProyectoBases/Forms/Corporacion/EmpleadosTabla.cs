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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoBases
{
    public partial class EmpleadosTabla : Form
    {
        string connectionstring;
        public EmpleadosTabla()
        {
            InitializeComponent();
            cargarEmpleados();
        }

        public void cargarEmpleados()  
        {
            string query = "EXEC verEmpleados";

            using (SqlConnection connection = CorporacionBD.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                tabla.DataSource = table;
            }
        }

        private void EliminarEmpleado(int idEmpleado)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("borrarEmpleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                        command.ExecuteNonQuery();

                        Console.WriteLine("Procedimiento almacenado ejecutado correctamente.");
                        MessageBox.Show($"Empleado eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar el procedimiento almacenado: {ex.Message}");
                MessageBox.Show($"Error al eliminar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        public void conexion(String nombre)
        {
            if (nombre == "Guayabo")
            {
                connectionstring = Utils.Constantes.ConnectionString;
            }
            else if (nombre == "Central")
            {
                connectionstring = Utils.Constantes.ConnectionString2;
            }
            else if (nombre == "La Romana")
            {
                connectionstring = Utils.Constantes.ConnectionString3;
            }

        }

        private void ModificarBTN_Click(object sender, EventArgs e)
        {
            string cone = "La Romana"; 

            if (cone == "La Romana" || cone == "Central" || cone == "Guayabo")
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    conexion(cone);

                    ModificarEmpleado modEmpleado = new ModificarEmpleado(connectionstring); 
                    modEmpleado.recibeIdEmpleado(Convert.ToInt32(idEmpleadoText.Text));
                    modEmpleado.Show();
                }
            }
            else
            {
                MessageBox.Show("No se pudo conectar a corporacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EmpleadosTabla_Load(object sender, EventArgs e)
        {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarBTN_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idEmpleadoText.Text, out int idEmpleado))
            {
                EliminarEmpleado(idEmpleado);
            }
            else
            {
                MessageBox.Show("El valor ingresado no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
