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

        private void verPlanillasBTN_Click(object sender, EventArgs e)
        {
            // revisar para las tres plantas pero mientras sera asi, se mostraran todas las planillas pagas
            PlanillasCanceladas planillas =  new PlanillasCanceladas();
            planillas.Show();

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleado regEmpleado = new RegistroEmpleado();
            regEmpleado.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosTabla empleados = new EmpleadosTabla();
            empleados.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosTabla empleados = new EmpleadosTabla();
            empleados.Show();
        }

        private void pagoPlanillasBTN_Click(object sender, EventArgs e)
        {
           PagoPlanillas pagoPlanillas = new PagoPlanillas();
           pagoPlanillas.Show();
        }

        private void GuayaboToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Impeimir planillas

        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            QueryCorporacion consultas = new QueryCorporacion();
            consultas.Show();
        }
    }
}
