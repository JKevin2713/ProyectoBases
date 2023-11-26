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
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void cargarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
