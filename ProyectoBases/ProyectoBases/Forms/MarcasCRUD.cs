using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{
    public partial class MarcasCRUD : Form
    {
        public MarcasCRUD()
        {
            InitializeComponent();
            formatearCampos();
        }


        private void formatearCampos()
        {
            dtp1.Format = DateTimePickerFormat.Short;
            dtp2.Format = DateTimePickerFormat.Time;
            dtp3.Format = DateTimePickerFormat.Time;
            dtp2.ShowUpDown = true;
            dtp3.ShowUpDown = true;

        }

        private void es_editar()
        {
            //get values from SP
            textBox1.Text = "id";
            textBox2.Text = "idemp";


            textBox1.Enabled = false;

        }
    }
}
