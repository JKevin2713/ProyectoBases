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
    public partial class EmpleadosTabla : Form
    {
        public EmpleadosTabla()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarBTN_Click(object sender, EventArgs e)
        {
            ModificarEmpleado modEmpleado = new ModificarEmpleado();
            modEmpleado.Show();
        }
    }
}
