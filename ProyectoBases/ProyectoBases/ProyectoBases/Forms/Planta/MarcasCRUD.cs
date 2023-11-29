using DB;
using Google.Protobuf;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{
    public partial class MarcasCRUD : Form
    {

        List<String> row = new List<String>();
        String connection;
        int accion;

        public MarcasCRUD(int Action, List<String> row, String ConnectionString)
        {
            InitializeComponent();
            this.row = row;
            this.connection = ConnectionString;
            this.accion = Action;
            formatearCampos(); 
        }


        private void formatearCampos()
        {
            label2.Visible = false;
            textBox1.Visible = false;
            dtp1.Format = DateTimePickerFormat.Short;
            dtp2.Format = DateTimePickerFormat.Time;
            dtp3.Format = DateTimePickerFormat.Time;
            dtp2.ShowUpDown = true;
            dtp3.ShowUpDown = true;
            if (accion == 1)
            {
                format_editar();
            }

        }

        private void format_editar()
        {
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = false;
            bool error = false;
            textBox1.Text = row[0]; // id marca
            textBox2.Text = row[1]; //empleado id
            //fecha
            if (DateTime.TryParseExact(row[2], "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime sd1))
            {
                dtp1.Value = sd1;
            }
            else
            {
                error = true;
            }
            //entrada hora
            if (DateTime.TryParseExact(row[3], "hh:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime pt1))
            {
                dtp2.Value = pt1;
            }
            else
            {
                error = true;
            }
            //hora salida
            if (DateTime.TryParseExact(row[4], "hh:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime pt2))
            {
                dtp2.Value = pt2;
            }
            else
            {
                error = true;
            }
            if (error)
            {
                MessageBox.Show("Invalid time format", "Error");
            }
            textBox1.Enabled = false;

        }

        private void editar_marca()
        {
            bool error = false;

            Marca m = new Marca();

            //id
            int temp;
            if (int.TryParse(textBox1.Text, out temp))
            {
               m.Id = temp;
            }
            else
            {
                error = true;
            }

            //empleaod
            if (int.TryParse(textBox2.Text, out temp))
            {
                m.EmpleadoId= temp;
            }
            else
            {
                error = true;
            }

            //fecha
            m.Fecha = dtp1.Value;

            //entrada
            m.Entrada = dtp2.Value.Hour * 10000 + dtp2.Value.Minute;

            //salida
            m.Salida = dtp3.Value.Hour * 10000 + dtp3.Value.Minute;

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
               MarcaDB db = new MarcaDB();
                db.ActualizarMarca(m, connection);
            }

        }

        private void insertar_marca()
        {
            bool error = false;

            Marca m = new Marca();
            int temp;
            //empleaod
            if (int.TryParse(textBox2.Text, out temp))
            {
                m.EmpleadoId = temp;
            }
            else
            {
                error = true;
            }

            //fecha
            m.Fecha = dtp1.Value;

            //entrada
            m.Entrada = dtp2.Value.Hour * 10000 + dtp2.Value.Minute;

            //salida
            m.Salida = dtp3.Value.Hour * 10000 + dtp3.Value.Minute;

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                MarcaDB db = new MarcaDB();
                db.InsertarMarca(m, connection);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accion == 1)
            {
                editar_marca();
            }
            else if (accion == 2)
            {
                insertar_marca();
            }
        }

        private void MarcasCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
