using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCorporacion
{
    public partial class Corporacion : Form
    {
        public Corporacion()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void corporacion(object sender, EventArgs e)
        {

        }

        private void empleado_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleado regEmpleado= new RegistroEmpleado();
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
    }
}
