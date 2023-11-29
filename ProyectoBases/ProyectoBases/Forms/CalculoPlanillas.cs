using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBases.Forms.Planta
{
    public partial class CalculoPlanillas : Form
    {
        String connection;

        public CalculoPlanillas(String stringConnection)
        {
            InitializeComponent();
            this.connection = stringConnection;
            formateardatos();
        }


        private void formateardatos()
        {
            //hacerlo formato fecha
            dtp1.Format = DateTimePickerFormat.Short;
            //traer los calendarios existentes en la planta
            CalendarioLaboralDB calendarioLaboralDB = new CalendarioLaboralDB();
            String[] calendario = calendarioLaboralDB.VerIdCalendario(connection).ToArray();
            cb1.Items.AddRange(calendario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtp1.Value;
            int calendarioID = Convert.ToInt32(cb1.SelectedItem);

            //calculo planilla
            
        }
    }
}
