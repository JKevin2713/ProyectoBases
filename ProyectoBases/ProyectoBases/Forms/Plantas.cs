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
        String connectionstring;

        public Plantas(String nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            label1.Text = "Planta " + nombre;

            if (nombre == "Guayabo")
            {
                connectionstring = Utils.Constantes.ConnectionString;

            }else if (nombre == "Central")
            {
                connectionstring = Utils.Constantes.ConnectionString2;

            }
            else if (nombre == "La Romana")
            {
                connectionstring = Utils.Constantes.ConnectionString3;

            }
        }

        //--------------------------------

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            conexion = checkBox1.Checked;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PantallaTabla abrirplanta = new PantallaTabla("Calendario", connectionstring);
            abrirplanta.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PantallaTabla abrirplanta = new PantallaTabla("Feriados", connectionstring);
            abrirplanta.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            PantallaTabla abrirplanta = new PantallaTabla("DiasLaborales", connectionstring);
            abrirplanta.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaTabla abrirplanta = new PantallaTabla("Empleados", connectionstring);
            abrirplanta.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PantallaTabla abrirplanta = new PantallaTabla("TiposEmpleados", connectionstring);
            abrirplanta.Show();
        }


        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            PantallaTabla abrirplanta = new PantallaTabla("Marcas", connectionstring);
            abrirplanta.Show();
        }

        private void BtnPlanillas_Click(object sender, EventArgs e)
        {
            PantallaTabla abrirplanta = new PantallaTabla("Planillas", connectionstring);
            abrirplanta.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            QueryPlantas queryPlantas = new QueryPlantas();
            queryPlantas.Show();    
        }


        //----------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        



        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        


       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
