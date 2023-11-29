using ProyectoBases.Forms;
using ProyectoBases.Forms.Corporacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBases
{
    public partial class Corporacion : Form
    {
       string connectionstring; 
        public Corporacion()
        {
            InitializeComponent();
            
        }

        private void empleadosBTN_Click(object sender, EventArgs e)
        {

        }

        private void Corporacion_Load(object sender, EventArgs e)
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

        private void verPlanillasBTN_Click(object sender, EventArgs e)
        {
            // revisar para las tres plantas pero mientras sera asi, se mostraran todas las planillas pagas
            PlanillasCanceladas planillas =  new PlanillasCanceladas();
            planillas.Show();

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // RegistroEmpleado regEmpleado = new RegistroEmpleado();
            //regEmpleado.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // EmpleadosTabla empleados = new EmpleadosTabla();
            //empleados.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosTabla empleados = new EmpleadosTabla();
            empleados.Show();
        }

        private void pagoPlanillasBTN_Click(object sender, EventArgs e)
        {
           //PagoPlanillas pagoPlanillas = new PagoPlanillas(1);
           //pagoPlanillas.Show();
        }

        private void GuayaboToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Impeimir planillas guayabo
            PagoPlanillas pagoPlanillas = new PagoPlanillas(1);
            pagoPlanillas.Show();

        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            QueryCorporacion consultas = new QueryCorporacion();
            consultas.Show();
        }

        private void CentralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprimir planillas central
            PagoPlanillas pagoPlanillas = new PagoPlanillas(2);
            pagoPlanillas.Show();
        }

        private void LaRomanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprimir planillas la romana

            PagoPlanillas pagoPlanillas = new PagoPlanillas(3);
            pagoPlanillas.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // registro guayabo
            conexion("Guayabo");
            RegistroEmpleado regEmpleado = new RegistroEmpleado(connectionstring);
            regEmpleado.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // modifica guayabo
            conexion("Guayabo");
            ModificarEmpleado regEmpleado = new ModificarEmpleado(connectionstring);
            regEmpleado.Show();

        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //eliminar guayabo
            EmpleadosTabla empleados = new EmpleadosTabla();
            empleados.Show();

        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // registrar central
            conexion("Central");
            RegistroEmpleado regEmpleado = new RegistroEmpleado(connectionstring);
            regEmpleado.Show();

        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //modificar central
            conexion("Central");
            ModificarEmpleado regEmpleado = new ModificarEmpleado(connectionstring);
            regEmpleado.Show();

        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //eliminar central

            EmpleadosTabla empleados = new EmpleadosTabla();
            empleados.Show();

        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // registrar la romana
            conexion("La Romana");
            RegistroEmpleado regEmpleado = new RegistroEmpleado(connectionstring);
            regEmpleado.Show();
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // modificar la romana
            conexion("La Romana");
            ModificarEmpleado regEmpleado = new ModificarEmpleado(connectionstring);
            regEmpleado.Show();

        }

        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // eliminar la romana

            EmpleadosTabla empleados = new EmpleadosTabla();
            empleados.Show();

        }
    }
}
