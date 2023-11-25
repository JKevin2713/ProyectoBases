using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProyectoBases.Forms
{
    public partial class QueryPlantas : Form
    {
        List<String[]> datosTabla;
        public QueryPlantas()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
           String[] queries = { "Ausencias por periodo de tiempo", "Tardias por periodo de tiempo", "Empleado sin marca de salida por periodo de tiempo",
                "Monto ganado por empleado por periodo de tiempo", "Informacion general de un empleado", "Informacion general de empleados por departamento",
                "Empleados acargo de un supervisor", "Empleados dados de baja en un periodo de tiempo"};
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(queries);
            comboBox1.SelectedIndex = 0;

        }


        private void actualizarColumnasTabla()
        {
            tabla.ColumnCount = datosTabla[0].Length;

            //depende el query las columnas son diferentes
            tabla.Columns[0].Name = "Id";
            tabla.Columns[1].Name = "Nombre";
            tabla.Columns[2].Name = "Hora";
            tabla.Columns[3].Name = "HoraExtra";
            tabla.Columns[4].Name = "HoraDoble";
            tabla.Columns[5].Name = "HoraInicio";
            tabla.Columns[6].Name = "HoraFinal";

            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void actualizarDatosTabla()
        {

            tabla.Rows.Clear();
            datosTabla = new List<string[]>();
            //En datosTabla agrego los valores de obtenidos del query
            
            //Agregar los valores obtenidos a la tabla
            int rows = datosTabla.Count;
            for (int i = 0; i < rows; i++)
            {
                tabla.Rows.Add(datosTabla[i]);
            }


        }



        //--------------------------------------------------


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            label2.Visible = true;
            textBox1.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            switch (comboBox1.SelectedIndex)
            {
                case 4:
                    label2.Text = "Id Empleado";
                    break;
                case 5:
                    label2.Text = "Departamento";
                    break;
                case 6:
                    label2.Text = "Id Supervisor";
                    break;
                
            }


            if (comboBox1.SelectedIndex.Equals(0) | comboBox1.SelectedIndex.Equals(1) | comboBox1.SelectedIndex.Equals(3) | comboBox1.SelectedIndex.Equals(2) | comboBox1.SelectedIndex.Equals(7) )
            {
                label2.Visible = false;
                textBox1.Visible = false;
            }
            else if (comboBox1.SelectedIndex.Equals(4) | comboBox1.SelectedIndex.Equals(5) | comboBox1.SelectedIndex.Equals(6)) {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }


        }
    }
}
