using ProyectoBases.Forms;
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
    public partial class Plantas : Form
    {

        String nombre;
        Boolean conexion;

        public Plantas(String nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            label1.Text = "Planta " + nombre;
        }

        //--------------------------------

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            conexion = checkBox1.Checked;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            PantallaTabla abrirplanta = new PantallaTabla("Calendario");
            abrirplanta.ShowDialog();
        }


        //----------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
