using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{

    public partial class PantallaTabla : Form
    {

        String tablaNombre, rowId;
        List<string[]> datosTabla;
        Button boton1, boton2;

        public PantallaTabla(String tn)
        {
            InitializeComponent();
            this.tablaNombre = tn;

            //Llama a funcion para formatear la tabla con las columnas indicadas
            switch (tablaNombre)
            {
                case "Calendario":
                    es_Calendario();
                    break;
                case "Feriados":
                    es_Feriado();
                    break;
                case "DiasLaborales":
                    es_DiaLaboral();
                    break;
                case "Empleados":
                    es_Empleados();
                    break;
                case "TiposEmpleados":
                    es_TipoEmpleado();
                    break;
                case "Marcas":
                    es_Marcas();
                    break;
                case "Planillas":
                    es_Planilla();
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
            actualizarTabla(); 
        }

        private void actualizarTabla()
        {
            switch (tablaNombre)
            {
                case "Calendario":
                    actualizar_Calendario();
                    break;
                case "Feriados":
                    actualizar_Feriados();
                    break;
                case "DiasLaborales":
                    actualizar_Laborales();
                    break;
                case "Empleados":
                    actualizar_Empleados();
                    break;
                case "TiposEmpleados":
                    actualizar_TipoEmpleado();
                    break;
                case "Marcas":
                    actualizar_Marcas();
                    break;
                case "Planillas":
                    actualizar_Planilla();
                    break;
                default:
                    // code block
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getSelectedItem();
            PantallaCRUD insertarCalendario = new PantallaCRUD(tablaNombre, 1, rowId);
            insertarCalendario.Show();
            actualizarTabla();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            getSelectedItem();
            PantallaCRUD insertarCalendario = new PantallaCRUD(tablaNombre, 2, rowId);
            insertarCalendario.Show();
            actualizarTabla();

        }

        private void button3_Click(object sender, EventArgs e)
        {   //ELIMINAR
            String respuestaSP = "";
            switch (tablaNombre)
            {   
                case "Calendario":
                    // CODE BLOCK

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
                case "Marcas":
                    // code block
                    break;
                case "Planillas":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
            MessageBox.Show(respuestaSP);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            switch (tablaNombre)
            {
                case "Marcas": //GENERAR MARCAS
                    SimuladorMarcas a = new SimuladorMarcas();
                    a.Show();
                    break;
                case "Planillas":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            switch (tablaNombre)
            {
                case "Marcas": // APROBAR MARCAS
                    // code block
                    break;
                case "Planillas":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }

        //----------------------------------------------------------------------------------------


        private void getSelectedItem()
        {
            List<string> SelectedRows = new List<string>();
            foreach (DataGridViewRow r in tabla1.SelectedRows)
            {
                SelectedRows.Add(r.Cells[0].Value.ToString());
            }

            rowId = (SelectedRows[0]);
        }

        //----------------------------------------------------------------------------------------
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

        //----------------------------------------------------------------------------------------
        //Feriados
        private void es_Feriado()
        {
            label1.Text = "Dias Feriados";
            tabla1.ColumnCount = 4;
            tabla1.Name = "Feriados";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "IdDia";
            tabla1.Columns[1].Name = "IdCalendario";
            tabla1.Columns[2].Name = "Fecha";
            tabla1.Columns[3].Name = "Etiqueta";
            

            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void actualizar_Feriados()
        {
            tabla1.Rows.Clear();
            datosTabla = new List<string[]>();

            String[] one = { "1", "1", "10/11/2025", "Pago"}; //
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
        //----------------------------------------------------------------------------------------
        private void es_DiaLaboral()
        {
            label1.Text = "Dias Laborales";
            tabla1.ColumnCount = 8;
            tabla1.Name = "DiasLaborales";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "IdCalendario";
            tabla1.Columns[1].Name = "Lunes";
            tabla1.Columns[2].Name = "Martes";
            tabla1.Columns[3].Name = "Miercoles";
            tabla1.Columns[4].Name = "Jueves";
            tabla1.Columns[5].Name = "Viernes";
            tabla1.Columns[6].Name = "Sabados";
            tabla1.Columns[7].Name = "Domingos";


            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void actualizar_Laborales()
        {
            tabla1.Rows.Clear();
            datosTabla = new List<string[]>();

            String[] one = { "1", "Y", "Y", "Y", "Y", "Y", "N", "N" }; //
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


        //----------------------------------------------------------------------------------------
        //EMPLEADOS
        private void es_Empleados()
        {
            label1.Text = "Empleados";
            tabla1.ColumnCount = 9;
            tabla1.Name = "Empleados";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "idEmpleado";
            tabla1.Columns[1].Name = "nombre";
            tabla1.Columns[2].Name = "fecha_ingreso";
            tabla1.Columns[3].Name = "fecha_salida";
            tabla1.Columns[4].Name = "tipo_empleado_id";
            tabla1.Columns[5].Name = "id_calendario";
            tabla1.Columns[6].Name = "departamento";
            tabla1.Columns[7].Name = "supervisor";
            tabla1.Columns[8].Name = "planta";


            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void actualizar_Empleados()
        {
            tabla1.Rows.Clear();
            datosTabla = new List<string[]>();

            String[] one = { "1", "1", "10/11/2025", "Pago", "1", "1", "1", "10/11/2025", "Pago" }; //
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


        //----------------------------------------------------------------------------------------
        //TIPOS EMPLEADOS
        private void es_TipoEmpleado()
        {
            label1.Text = "Tipos de Empleado";
            tabla1.ColumnCount = 2;
            tabla1.Name = "TipoEmpleado";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "idTipo";
            tabla1.Columns[1].Name = "nombreTipoEmpleado";
            
            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void actualizar_TipoEmpleado()
        {
            tabla1.Rows.Clear();
            datosTabla = new List<string[]>();

            String[] one = { "1", "1", "10/11/2025", "Pago" }; //
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


        //----------------------------------------------------------------------------------------
        // MARCAS
        private void es_Marcas()
        {
            label1.Text = "Marcas Empleados";
            tabla1.ColumnCount = 6;
            tabla1.Name = "marcas";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "Id";
            tabla1.Columns[1].Name = "EmpleadoId";
            tabla1.Columns[2].Name = "Fecha";
            tabla1.Columns[3].Name = "Entrada";
            tabla1.Columns[4].Name = "Salida";
            tabla1.Columns[5].Name = "Aprobado";

            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            boton1 = new Button();
            boton1.Text = "Generar marcas";
            boton1.Location = new Point(60, 285);
            boton1.Size = new Size(128, 45);
            boton1.Click += boton1_Click;
            panel3.Controls.Add(boton1);

            boton2 = new Button();
            boton2.Text = "Aprobar * marcas";
            boton2.Location = new Point(60, 355);
            boton2.Size = new Size(128, 45);
            boton2.Click += boton2_Click;
            panel3.Controls.Add(boton2);

            button1.Location = new Point(60, 75);
            button2.Location = new Point(60, 145);
            button3.Location = new Point(60, 215);
            button4.Location = new Point(60, 5);
        }

        private void actualizar_Marcas()
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

        //----------------------------------------------------------------------------------------
        // PLANILLA
        private void es_Planilla()
        {
            label1.Text = "Planilla";
            tabla1.ColumnCount = 6;
            tabla1.Name = "planilla";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "Id";
            tabla1.Columns[1].Name = "Empleado";
            tabla1.Columns[2].Name = "Estado";
            tabla1.Columns[3].Name = "Salario Bruto";
            tabla1.Columns[4].Name = "Salario Neto";
            tabla1.Columns[5].Name = "Porcentaje Obligaciones";

            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            boton1 = new Button();
            boton1.Text = "Generar planilla";
            boton1.Location = new Point(60, 285);
            boton1.Size = new Size(128, 45);
            boton1.Click += boton1_Click;   
            panel3.Controls.Add(boton1);

            boton2 = new Button();
            boton2.Text = "Enviar planilla";
            boton2.Location = new Point(60, 355);
            boton2.Size = new Size(128, 45);
            boton2.Click += boton2_Click;   
            panel3.Controls.Add(boton2);

            button1.Location = new Point(60, 75);
            button2.Location = new Point(60, 145);
            button3.Location = new Point(60, 215);
            button4.Location = new Point(60, 5);
        }

        private void actualizar_Planilla()
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





        //----------------------------------------------------------------------------------------
        private void tabla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

          
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
