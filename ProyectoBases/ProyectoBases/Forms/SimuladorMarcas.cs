using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{
    public partial class SimuladorMarcas : Form
    {
        String connection;
        public SimuladorMarcas(String connection)
        {
            InitializeComponent();
            this.connection = connection;
            formatearCampos();
        }


        private void formatearCampos()
        {
            dtp1.Format = DateTimePickerFormat.Short;
            dtp2.Format = DateTimePickerFormat.Short;
            dtp3.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dtp2.Enabled = false;
            dtp3.ShowUpDown = true;
            dateTimePicker1.ShowUpDown = true;

            //GET FROM SQL

            CalendarioLaboralDB calendarioLaboralDB = new CalendarioLaboralDB();
            String[] calendario = calendarioLaboralDB.VerIdCalendario(connection).ToArray();
            cb2.Items.AddRange(calendario);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtp2.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dato1, dato2, dato3, dato4, dato5, dato6, dato7, dato8, dato9;
            dato1 = dtp1.ToString();
            if (checkBox1.Checked)
            {
                dato2 = dtp2.ToString();
            }
            else
            {
                dato2 = dtp1.ToString(); //misma fecha
            }
            dato3 = dtp3.ToString();
            dato4 = dateTimePicker1.ToString();
            dato9 = textBox4.Text;
            dato5 = textBox1.Text;
            dato6 = textBox2.Text;
            dato7 = textBox3.Text;
            dato8 = cb2.SelectedItem.ToString(); 
               
            //FUNCION PARA GENERAR LAS MARCAS
        }


        //-9------------------


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SimuladorMarcas_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
