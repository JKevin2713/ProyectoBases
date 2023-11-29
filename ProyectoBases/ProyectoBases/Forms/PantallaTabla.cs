using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using DB;
using Model;

namespace ProyectoBases.Forms
{

    public partial class PantallaTabla : Form
    {

        String tablaNombre, Connection, planta;
        List<string[]> datosTabla;
        Button boton1, boton2;
        List<String> row = new List<String>();
        CalendarioLaboralDB calendarioDB = new CalendarioLaboralDB();
        DiasFeriadosDB diasFeriadosDB = new DiasFeriadosDB();
        DiasLaboralesDB diasLaboralesDB = new DiasLaboralesDB();
        EmpleadoDB empleadoDB = new EmpleadoDB();
        MarcaDB marcaDB = new MarcaDB();
        PlanillasDB planillasDB = new PlanillasDB();
        TipoEmpleadoDB TipoEmpleadoDB = new TipoEmpleadoDB();
        DepartamentoDB departamentoDB = new DepartamentoDB();

        public PantallaTabla(String tn, String connectionString)
        {
            InitializeComponent();
            this.Connection = connectionString;
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
                case "Departamento":
                    es_Departamento();
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
                case "Departamento":
                    actualizar_Departamento();
                    break;
                default:
                    // code block
                    break;
            }
        }

        //Insertar -> Insert
        private void button1_Click(object sender, EventArgs e)
        {
            if (tablaNombre == "Marcas")
            {
                MarcasCRUD insertarMarca = new MarcasCRUD(2, row, Connection);
                insertarMarca.Show();
            }
            else
            {
                PantallaCRUD insertarTabla = new PantallaCRUD(tablaNombre, 1, row, Connection);
                MessageBox.Show(planta);
                insertarTabla.plantaNombre(planta);
                insertarTabla.Show();
            }
        }

        
        //Editar -> Update
        private void button2_Click(object sender, EventArgs e)
        {
            getSelectedItem();
            if (tablaNombre == "Marcas")
            {
                MarcasCRUD insertarMarca = new MarcasCRUD(1, row, Connection);
                insertarMarca.Show();
            }
            else
            {
                PantallaCRUD editarTabla = new PantallaCRUD(tablaNombre, 2, row, Connection);
                editarTabla.plantaNombre(planta);
                editarTabla.Show();
            }
            
        }

        //Eliminar
        private void button3_Click(object sender, EventArgs e)
        {   
            getSelectedItem();
            String respuestaSP = "";
            switch (tablaNombre)
            {   
                case "Calendario":
                    eliminar_Calendario();
                    break;
                case "Feriados":
                    eliminar_Feriados();
                    break;
                case "DiasLaborales":
                    eliminar_Laborales();
                    break;
                case "Empleados":
                    eliminar_Empleados();
                    break;
                case "TiposEmpleados":
                    eliminar_TipoEmpleado();
                    break;
                case "Marcas":
                    eliminar_Marcas();
                    break;
                case "Planillas":
                    eliminar_Planilla();
                    break;
                case "Departamento":
                    eliminar_Departamento();
                    break;
                default:
                    // code block
                    break;
            }
            MessageBox.Show(respuestaSP);
        }

        //MARCAS Y PLANILLAS
        private void boton1_Click(object sender, EventArgs e)
        {
            switch (tablaNombre)
            {
                case "Marcas": //GENERAR MARCAS
                    SimuladorMarcas a = new SimuladorMarcas(Connection);
                    a.Show();
                    break;
                case "Planillas":
                    //aqui va el generar planillas
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
                for (int i = 0; i < r.Cells.Count; i++)
                {
                    SelectedRows.Add(r.Cells[i].Value.ToString());
                }
            }
            row = SelectedRows;
        }

        //----------------------------------------------------------------------------------------
        // CALENDARIO
        private void es_Calendario (){
            label1.Text = "Calendario Laboral";
            tabla1.ColumnCount = 8;
            tabla1.Name = "CalendarioLaboralTabla";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "Id";
            tabla1.Columns[1].Name = "Nombre"; 
            tabla1.Columns[2].Name = "Hora";
            tabla1.Columns[3].Name = "HoraExtra";
            tabla1.Columns[4].Name = "HoraDoble";
            tabla1.Columns[5].Name = "HoraInicio";
            tabla1.Columns[6].Name = "HoraFinal";
            tabla1.Columns[7].Name = "Horario";

            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void eliminar_Calendario()
        {
            int idE = Convert.ToInt32(row[0]);
            calendarioDB.DeleteCalendarioLaboral(idE, Connection);
        }

        private void actualizar_Calendario()
        {
            tabla1.Rows.Clear();
            
            datosTabla = calendarioDB.VerCalendarioLaboral(Connection);

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

        private void eliminar_Feriados()
        {
            int idE = Convert.ToInt32(row[0]);
            diasFeriadosDB.DeleteDiaFeriado(idE, Connection);
        }

        private void actualizar_Feriados()
        {
            tabla1.Rows.Clear();

            datosTabla = diasFeriadosDB.VerDiasFeriados(Connection);

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

        private void eliminar_Laborales()
        {
            int idE = Convert.ToInt32(row[0]);
            diasLaboralesDB.DeleteDiasLaborales(idE, Connection);
        }

        private void actualizar_Laborales()
        {
            tabla1.Rows.Clear();
            datosTabla = diasLaboralesDB.VerDiasLaborales(Connection);

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

        private void eliminar_Empleados()
        {
            int idE = Convert.ToInt32(row[0]);
            empleadoDB.DeleteEmpleado(idE, Connection);
        }

        private void actualizar_Empleados()
        {
            tabla1.Rows.Clear();
            datosTabla = empleadoDB.VerEmpleado(Connection);

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

        private void eliminar_TipoEmpleado()
        {
            int idE = Convert.ToInt32(row[0]);
            TipoEmpleadoDB.DeleteTipoEmpleado(idE, Connection);
        }

        private void actualizar_TipoEmpleado()
        {
            tabla1.Rows.Clear();
            datosTabla = TipoEmpleadoDB.VerTipoEmpleado(Connection);

            int rows = datosTabla.Count;
            for (int i = 0; i < rows; i++)
            {
                tabla1.Rows.Add(datosTabla[i]);
            }

        }

        //----------------------------------------------------------------------------------------
        //DEPARTAMENTO
        private void es_Departamento()
        {
            label1.Text = "Departamento";
            tabla1.ColumnCount = 2;
            tabla1.Name = "Departamento";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "idDepartamento";
            tabla1.Columns[1].Name = "Nombre";

            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void eliminar_Departamento()
        {
            int idE = Convert.ToInt32(row[0]);
            departamentoDB.DeleteDepartamento(idE, Connection);
        }

        private void actualizar_Departamento()
        {
            tabla1.Rows.Clear();
            datosTabla = departamentoDB.VerDepartamento(Connection);

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
            tabla1.ColumnCount = 5;
            tabla1.Name = "marcas";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "Id";
            tabla1.Columns[1].Name = "EmpleadoId";
            tabla1.Columns[2].Name = "Fecha";
            tabla1.Columns[3].Name = "Entrada";
            tabla1.Columns[4].Name = "Salida";

            tabla1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla1.MultiSelect = false;
            tabla1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            boton1 = new Button();
            boton1.Text = "Generar marcas";
            boton1.Location = new Point(60, 285);
            boton1.Size = new Size(128, 45);
            boton1.Click += boton1_Click;
            panel3.Controls.Add(boton1);

            button1.Location = new Point(60, 75);
            button3.Location = new Point(60, 145);
            button4.Location = new Point(60, 5);
        }

        private void eliminar_Marcas()
        {
            int idE = Convert.ToInt32(row[0]);
            marcaDB.DeleteMarca(idE, Connection);
        }

        private void actualizar_Marcas()
        {
            tabla1.Rows.Clear();
            datosTabla = marcaDB.VerMarca(Connection);

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
            tabla1.ColumnCount = 7;
            tabla1.Name = "planilla";
            tabla1.RowHeadersVisible = true;

            tabla1.Columns[0].Name = "Id";
            tabla1.Columns[1].Name = "Empleado";
            tabla1.Columns[2].Name = "Planta";
            tabla1.Columns[3].Name = "Estado";
            tabla1.Columns[4].Name = "Salario Bruto";
            tabla1.Columns[5].Name = "Salario Neto";
            tabla1.Columns[6].Name = "Porcentaje Obligaciones";

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

        private void eliminar_Planilla()
        {
            int idE = Convert.ToInt32(row[0]);
            planillasDB.DeletePlanilla(idE, Connection);
        }

        private void actualizar_Planilla()
        {
            tabla1.Rows.Clear();
            datosTabla = planillasDB.VerPlanilla(Connection);

            int rows = datosTabla.Count;
            for (int i = 0; i < rows; i++)
            {
                tabla1.Rows.Add(datosTabla[i]);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        //----------------------------------------------------------------------------------------

        public void plantaNombre(String nombre)
        {
            this.planta = nombre;
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
