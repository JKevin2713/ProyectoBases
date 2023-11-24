using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;
using static System.Windows.Forms.TextBox;
using static System.Windows.Forms.VisualStyles.                                                                                                                                                                                                                                                                                                            VisualStyleElement;

namespace ProyectoBases
{
    public partial class PantallaCRUD : Form
    {
        // variables para obtener los datos y enviarlas a SP
        System.Windows.Forms.TextBox txf1, txf2, txf3, txf4, txf5;
        System.Windows.Forms.ComboBox cb1, cb2, cb3, cb4, cb5, cb6;
        String dato1, dato2, dato3, dato4, dato5, dato6, dato7, dato8, dato9;

        String tablaNombre;
        int codigo;

        public PantallaCRUD(String tn, int cd)
        {
            InitializeComponent();
            this.tablaNombre = tn;
            this.codigo = cd;

            switch (tablaNombre)
            {
                case "Calendario":
                    esCalendario();
                    if (codigo == 2)
                    {
                        editar_calendario();
                    }
                    break;
                case "Feriados":
                    // code block
                    break;
                case "DiasLaborales":
                    // code block
                    break;
                case "Empleados":
                    // code block
                    break;
                case "TiposEmpleados":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }

        //-------------------------------------------------------

        public void esCalendario()
        {
            label1.Text = "Insertar calendario";
            label2.Text = "Id";
            label3.Text = "Nombre";
            label4.Text = "Pago por hora";
            label5.Text = "Pago por hora extra";
            label6.Text = "Pago por hora doble";
            label7.Text = "Hora de inicio";
            label8.Text = "Hora final";
            label9.Text = "Periodo pago";
            button1.Text = "Insertar";

            //txf1 = nombre
            txf1 = new System.Windows.Forms.TextBox();
            txf1.Location = new Point(155, 157);
            txf1.Size = new Size(235, 22);
            this.Controls.Add(txf1);

            //txf2 = pagohora
            txf2 = new System.Windows.Forms.TextBox();
            txf2.Location = new Point(190, 205);
            txf2.Size = new Size(200, 22);
            this.Controls.Add(txf2);

            //txf3 = pagohoraextra
            txf3 = new System.Windows.Forms.TextBox();
            txf3.Location = new Point(190, 255);
            txf3.Size = new Size(200, 22);
            this.Controls.Add(txf3);

            //txf4 = pagohoradoble
            txf4 = new System.Windows.Forms.TextBox();
            txf4.Location = new Point(190, 305);
            txf4.Size = new Size(200, 22);
            this.Controls.Add(txf4);

            String[] minutos = new String[60];
            for (int i = 0; i < 60; i++)
            {
                minutos[i] = i.ToString();
            }

            String[] hora = new String[24];
            for (int i = 0; i < 24; i++)
            {
                hora[i] = i.ToString();
            }

            //cb1 = horaInicio
            cb1 = new System.Windows.Forms.ComboBox();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.Items.AddRange(hora);
            cb1.Location = new Point(190, 355);
            cb1.Size = new Size(50, 22);
            cb1.DropDownHeight = 22 * 5;
            this.Controls.Add(cb1);
            cb1.SelectedIndex = 0;

            System.Windows.Forms.Label puntosInicio = new System.Windows.Forms.Label();
            puntosInicio.Text = ":";
            puntosInicio.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            puntosInicio.Location = new Point(245, 355);
            puntosInicio.AutoSize = true;
            this.Controls.Add(puntosInicio);

            //cb2 = minutosInicio
            cb2 = new System.Windows.Forms.ComboBox();
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb2.Items.AddRange(minutos);
            cb2.Location = new Point(255, 355);
            cb2.Size = new Size(50, 22);
            cb2.DropDownHeight = 22 * 5;
            this.Controls.Add(cb2);
            cb2.SelectedIndex = 0;


            //cb3 = horaFin
            cb3 = new System.Windows.Forms.ComboBox();
            cb3.DropDownStyle = ComboBoxStyle.DropDownList;
            cb3.Items.AddRange(hora);
            cb3.Location = new Point(190, 405);
            cb3.Size = new Size(50, 22);
            cb3.DropDownHeight = 22 * 5;
            this.Controls.Add(cb3);
            cb3.SelectedIndex = 0;

            System.Windows.Forms.Label puntosFin = new System.Windows.Forms.Label();
            puntosFin.Text = ":";
            puntosFin.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            puntosFin.Location = new Point(245, 405);
            puntosFin.AutoSize = true;
            this.Controls.Add(puntosFin);

            //cb4 = minutosFin
            cb4 = new System.Windows.Forms.ComboBox();
            cb4.DropDownStyle = ComboBoxStyle.DropDownList;
            cb4.Items.AddRange(minutos);
            cb4.Location = new Point(255, 405);
            cb4.Size = new Size(50, 22);
            cb4.DropDownHeight = 22 * 5;
            this.Controls.Add(cb4);
            cb4.SelectedIndex = 0;

            String[] pago = { "Mensual", "Quincenal", "Semanal" };
            //cb5 = formaPago
            cb5 = new System.Windows.Forms.ComboBox();
            cb5.DropDownStyle = ComboBoxStyle.DropDownList;
            cb5.Items.AddRange(pago);
            cb5.Location = new Point(190, 455);
            cb5.Size = new Size(100, 22);
            cb5.DropDownHeight = 22 * 5;
            this.Controls.Add(cb5);
        }

        public void editar_calendario()
        {
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            //HERE SQL
            //Procedimiento para obtener los valores actuales.

            textBox1.Text = "Id";
            txf1.Text = "Nombre";
            txf2.Text = "PagoHora";
            txf3.Text = "PagoExtra";
            txf4.Text = "PagoDoble";
            //Asumiendo que las horas sean HH:MM:SS
            String horaPrueba = "12:34:56";
            cb1.SelectedItem = horaPrueba.Substring(0, 2);
            cb2.SelectedItem = horaPrueba.Substring(3, 2);
            cb3.SelectedItem = horaPrueba.Substring(0, 2);
            cb4.SelectedItem = horaPrueba.Substring(3, 2);
            cb5.SelectedItem = "Mensual";
        }

        public void enviar_calendario()
        {
            dato1 = textBox1.Text; //id
            dato2 = txf1.Text; //nombre
            dato3 = txf2.Text; //pagoHora
            dato4 = txf3.Text; //pagoExtra
            dato5 = txf4.Text; //pagoDoble
            dato6 = cb1.SelectedItem.ToString() + ":" + cb2.SelectedItem.ToString() + ":00"; //horaInicio
            dato7 = cb3.SelectedItem.ToString() + ":" + cb4.SelectedItem.ToString() + ":00"; //horaFin
            dato8 = cb5.SelectedItem.ToString(); //pago
        }







        //------------------------------------------------------


        private void button1_Click(object sender, EventArgs e)
        {

            String respuestaSP = "";
            

            switch (tablaNombre)
            {
                case "Calendario":
                    enviar_calendario();
                    if (codigo == 1)
                    {
                        //SP para INSERTAR
                        respuestaSP =  "Simple MessageBox";
                       
                    }
                    if (codigo == 2)
                    {
                        //SP para EDITAR
                    }
                    break;
                case "Feriados":
                    // code block
                    break;
                case "DiasLaborales":
                    // code block
                    break;
                case "Empleados":
                    // code block
                    break;
                case "TiposEmpleados":
                    // code block
                    break;
                default:
                    // code block
                    break;
            }


            MessageBox.Show(respuestaSP);
            this.Dispose();
        }


        //------------
        private void PantallaCRUD_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
