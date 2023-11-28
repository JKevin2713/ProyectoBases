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

namespace ProyectoBases.Forms.Corporacion
{
    public partial class QueryCorporacion : Form
    {
        List<String[]> datosTabla;
        public QueryCorporacion()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultasLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;


            if (consultasLista.SelectedIndex.Equals(0)){
                label2.Text = "Id Empleado";
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
            else
            {
                label2.Visible = false;
                textBox1.Visible = false;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                label3.Visible =true;
                label4.Visible =true;
            }            
        }


        private void QueryCorporacion_Load(object sender, EventArgs e)
        {

        }

        private void actualizarColumnasTabla()
        {
            tabla.Columns.Clear(); // Limpiar las columnas existentes
            //tabla.ColumnCount = datosTabla[0].Length;

            switch (consultasLista.SelectedIndex)
            {
                case 0: // Aguinaldo de un empleado
                    tabla.Columns.Add("IdEmpleado", "ID Empleado");
                    tabla.Columns.Add("Nombre", "Nombre");
                    tabla.Columns.Add("Aguinaldo", "Aguinaldo");

                    break;
                case 1: // Monto total pagado por la empresa en salarios
                    tabla.Columns.Add("MontoTotalPagado", "Monto Total Pagado");

                    break;
                case 2: // Monto total pagado por la empresa en salarios netos y obligaciones
                    tabla.Columns.Add("MontoTotalPagado", "Monto Total Pagado");
                    break;
                case 3: // Lista de los 10 empleados mejor pagados
                    tabla.Columns.Add("IdEmpleado", "ID Empleado");
                    tabla.Columns.Add("Nombre", "Nombre");
                    tabla.Columns.Add("SalarioTotal", "Salario Total");
                    break;
                case 4: // Planta, cantidad de empleados, monto total de salarios brutos, promedio de salario bruto
                    tabla.Columns.Add("NombrePlanta", "Nombre Planta");
                    tabla.Columns.Add("CantidadEmpleados", "Cantidad Empleados");
                    tabla.Columns.Add("MontoTotalSalariosBrutos", "Monto Total Salarios Brutos");
                    tabla.Columns.Add("PromedioSalarioBruto", "Promedio Salario Bruto");
                    break;
            }


            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Q3_MontoTotalPagado(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("Q3_MontoTotalPagado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = fechaInicio;
                        command.Parameters.Add("@FechaFin", SqlDbType.Date).Value = fechaFin;
                        MessageBox.Show($"FechaInicio: {fechaInicio.ToString("yyyy-MM-dd")}, Fecha Fin: {fechaFin.ToString("yyyy-MM-dd")}", "Parámetros SP", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Verificar si hay filas en el resultado
                            if (reader.HasRows)
                            {
                                // Limpiar las filas existentes
                                tabla.Rows.Clear();

                                while (reader.Read())
                                {
                                    // Agregar datos a la tabla según las columnas especificadas en el caso 2
                                    object[] rowData = { reader["MontoTotalPagado"] };
                                    tabla.Rows.Add(rowData);
                                }
                                MessageBox.Show("Datos cargados en la tabla", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron resultados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el monto total pagado: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void actualizarDatosTabla()
        {
            tabla.Rows.Clear();
            datosTabla = new List<string[]>();

            // Obtener los datos según la selección del combo box
            switch (consultasLista.SelectedIndex)
            {
                case 0: // Aguinaldo de un empleado
                        // Lógica para obtener los datos del aguinaldo de un empleado
                        // Agregar los valores obtenidos a la tabla
                        //anadir sp para el calculo del aguinaldo

                    break;
                case 1: // Monto total pagado por la empresa en salarios
                        // Lógica para obtener los datos del monto total pagado por la empresa en salarios
                        // Agregar los valores obtenidos a la tabla
                    break;
                case 2: // Monto total pagado por la empresa en salarios netos y obligaciones
                    DateTime fechaInicio = dateTimePicker1.Value;
                    DateTime fechaFin = dateTimePicker2.Value;
                    Q3_MontoTotalPagado(fechaInicio, fechaFin);
                    break;
                case 3: // Lista de los 10 empleados mejor pagados
                        // Lógica para obtener los datos de la lista de los 10 empleados mejor pagados
                        // Agregar los valores obtenidos a la tabla
                    break;
                case 4: // Planta, cantidad de empleados, monto total de salarios brutos, promedio de salario bruto
                        // Lógica para obtener los datos de la planta, cantidad de empleados, monto total de salarios brutos, promedio de salario bruto
                        // Agregar los valores obtenidos a la tabla
                    break;
            }

            // Agregar los valores obtenidos a la tabla
            int rows = datosTabla.Count;
            for (int i = 0; i < rows; i++)
            {
                tabla.Rows.Add(datosTabla[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarColumnasTabla();
            actualizarDatosTabla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }




}
