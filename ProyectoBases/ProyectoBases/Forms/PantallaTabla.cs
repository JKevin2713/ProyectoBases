using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{

    public partial class PantallaTabla : Form
    {

        String tablaNombre;
        List<string[]> datosTabla;

        public PantallaTabla(String tn)
        {
            InitializeComponent();
            this.tablaNombre = tn;


            switch (tablaNombre)
            {
                case "Calendario":
                    es_Calendario();
                    break;
                case "Feriados":
                    // code block
                    break;
                case "DiasLaborales":
                    // code block
                    break;
                case "Empleados":
                    // code block
                    break;
                case "TiposEmpleados":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }


        }

        //-----------------------------------------------------------------------------------
        // CUAL TABLA SE LE REALIZA MANTENIMIENTO

        private void button4_Click(object sender, EventArgs e)
        {   //ACTUALIZAR
            switch (tablaNombre)
            {
                case "Calendario":
                    actualizar_Calendario();
                    break;
                case "Feriados":
                    // code block
                    break;
                case "DiasLaborales":
                    // code block
                    break;
                case "Empleados":
                    // code block
                    break;
                case "TiposEmpleados":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tablaNombre)
            {   //INSERTAR
                case "Calendario":
                    PantallaCRUD insertarCalendario = new PantallaCRUD(tablaNombre, 1);
                    insertarCalendario.ShowDialog();
                    actualizar_Calendario();
                    break;
                case "Feriados":
                    // code block
                    break;
                case "DiasLaborales":
                    // code block
                    break;
                case "Empleados":
                    // code block
                    break;
                case "TiposEmpleados":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {   
            switch (tablaNombre)
            {   //EDITAR
                case "Calendario":
                    PantallaCRUD insertarCalendario = new PantallaCRUD(tablaNombre, 2);
                    insertarCalendario.ShowDialog();
                    actualizar_Calendario();
                    break;
                case "Feriados":
                    // code block
                    break;
                case "DiasLaborales":
                    // code block
                    break;
                case "Empleados":
                    // code block
                    break;
                case "TiposEmpleados":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }

        //----------------------------------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // CALENDARIO
        private void es_Calendario (){
            label1.Text = "Calendario Laboral";
            tabla1.ColumnCount = 7;
            tabla1.Name = "CalendarioLaboralTabla";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "Id";
            tabla1.Columns[1].Name = "Nombre"; 
            tabla1.Columns[2].Name = "Hora";
            tabla1.Columns[3].Name = "HoraExtra";
            tabla1.Columns[4].Name = "HoraDoble";
            tabla1.Columns[5].Name = "HoraInicio";
            tabla1.Columns[6].Name = "HoraFinal";

            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void actualizar_Calendario()
        {
            tabla1.Rows.Clear();
            datosTabla = new List<string[]>();

            String[] one = { "1", "caledariouno", "5", "6", "7", "9 am", "10am" }; //
            for (int i = 0; i < 30; i++)
            {
                datosTabla.Add(one);
            }

            int rows = datosTabla.Count;
            for (int i = 0; i < rows; i++)
            {
                tabla1.Rows.Add(datosTabla[i]);
            }
            
        }

        
    }
}
