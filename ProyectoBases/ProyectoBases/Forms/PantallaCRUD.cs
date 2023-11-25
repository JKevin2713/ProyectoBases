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

using DB;
using Model;
namespace ProyectoBases
{
    public partial class PantallaCRUD : Form
    {
        // variables para obtener los datos y enviarlas a SP
        System.Windows.Forms.TextBox txf1, txf2, txf3, txf4, txf5;
        System.Windows.Forms.ComboBox cb1, cb2, cb3, cb4, cb5, cb6;
        String dato1, dato2, dato3, dato4, dato5, dato6, dato7, dato8, dato9;
        System.Windows.Forms.CheckBox ck1, ck2, ck3, ck4, ck5, ck6, ck7;

        String tablaNombre, IdRow;
        int codigo;
        String connection;

        public PantallaCRUD(String tn, int cd, string Id, String connectionString)
        {
            InitializeComponent();
            this.tablaNombre = tn;
            this.codigo = cd;
            this.IdRow = Id;
            this.connection = connectionString;
            button1.Text = "Insertar";

            //Llama a funcion para formatear los espacios necesarios dependiendo de la tabla
            switch (tablaNombre)
            {
                case "Calendario":
                    esCalendario();
                    if (codigo == 2)
                    {
                        CalendarioAnterior();

                    }
                    break;
                case "Feriados":
                    es_Feriado();
                    if (codigo == 2)
                    {
                        editar_Feriado();
                    }
                    break;
                case "DiasLaborales":
                    es_DiaLaboral();
                    if (codigo == 2)
                    {
                        editar_diaLaboral();
                    }
                    break;
                case "Empleados":
                    es_Empleados();
                    if (codigo == 2)
                    {
                        editar_empleados();
                    }
                    break;
                case "TiposEmpleados":
                    es_TipoEmpleado();
                    if (codigo == 2)
                    {
                        editar_tipoEmpleado();
                    }
                    break;
                case "Marcas":
                    es_TipoEmpleado();
                    if (codigo == 2)
                    {
                       // editar_Marcas();
                    }
                    break;
                case "Planillas":
                    es_Planilla();
                    if (codigo == 2)
                    {
                        editar_planilla();
                    }
                    break;
                default:
                    // code block
                    break;
            }
        }

        //BOTON PARA ENVIAR (INSERTAR 1 O EDITAR 2)
        private void button1_Click(object sender, EventArgs e)
        {

            String respuestaSP = "";


            switch (tablaNombre)
            {
                case "Calendario":
                   
                    if (codigo == 1)
                    {
                        enviar_calendario();
                        respuestaSP = "Simple MessageBox";

                    }
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


            MessageBox.Show(respuestaSP);
            this.Dispose();
        }


        //-------------------------------------------------------
        // CALENDARIO

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
            label10.Visible = false;
            

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

        public void CalendarioAnterior()
        {
            label1.Text = "Editar calendario";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            textBox1.Text = IdRow;
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
        public void editar_calendario()
        {

            CalendarioLaboral c = new CalendarioLaboral();
            c.IdCalendario = Convert.ToInt32(textBox1.Text);
            c.Nombre = txf1.Text; //nombre
            decimal temp;
            if (decimal.TryParse(txf2.Text, out temp))
            {
                c.PagoHora = temp;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }

            if (decimal.TryParse(txf3.Text, out temp))
            {
                c.PagoHoraExtra = temp;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }

            if (decimal.TryParse(txf4.Text, out temp))
            {
                c.PagoHoraDoble = temp;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }

            c.HoraInicio = cb1.SelectedIndex * 10000 + cb2.SelectedIndex; //horaInicio
            c.HoraFinal = cb3.SelectedIndex * 10000 + cb4.SelectedIndex; //horaFin
            c.TipoPago = cb5.SelectedIndex + 1; //pago

            CalendarioLaboralDB calendario = new CalendarioLaboralDB();
            calendario.ActualizarCalendarioLaboral(c, connection);

        }

        public void enviar_calendario()
        {
            CalendarioLaboral c = new CalendarioLaboral();
            c.Nombre = txf1.Text; //nombre
            decimal temp;
            if (decimal.TryParse(txf2.Text, out temp))
            {
                c.PagoHora = temp;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }

            if (decimal.TryParse(txf3.Text, out temp))
            {
                c.PagoHoraExtra = temp;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }

            if (decimal.TryParse(txf4.Text, out temp))
            {
                c.PagoHoraDoble = temp;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }

            c.HoraInicio = cb1.SelectedIndex * 10000 + cb2.SelectedIndex; //horaInicio
            c.HoraFinal = cb3.SelectedIndex * 10000 + cb4.SelectedIndex; //horaFin
            c.TipoPago = cb5.SelectedIndex + 1; //pago
            
            CalendarioLaboralDB calendario = new CalendarioLaboralDB();
            calendario.InsertarCalendarioLaboral(c, connection);
        }

        
        //-------------------------------------------------------
        // FERIADOS

        public void es_Feriado()
        {
            label1.Text = "Insertar Dias Feriados";
            label2.Text = "IdDia";
            label3.Text = "IdCalendario";
            label4.Text = "Fecha";
            label5.Text = "Etiqueta";
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;


            //txf1 = IdCalendario
            txf1 = new System.Windows.Forms.TextBox();
            txf1.Location = new Point(155, 157);
            txf1.Size = new Size(235, 22);
            this.Controls.Add(txf1);

            //txf2 = Fecha
            txf2 = new System.Windows.Forms.TextBox();
            txf2.Location = new Point(155, 205);
            txf2.Size = new Size(200, 22);
            this.Controls.Add(txf2);

            String[] etiquetas = { "Doble", "Extra", "Null" };
            //cb5 = Etiqueta
            cb5 = new System.Windows.Forms.ComboBox();
            cb5.DropDownStyle = ComboBoxStyle.DropDownList;
            cb5.Items.AddRange(etiquetas);
            cb5.Location = new Point(155, 255);
            cb5.Size = new Size(100, 22);
            cb5.DropDownHeight = 22 * 5;
            this.Controls.Add(cb5);
        }

        public void editar_Feriado()
        {
            label1.Text = "Editar Dias Feriados";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            //HERE SQL
            //Procedimiento para obtener los valores actuales.
            //CHANGE estos valores por los valores anteriores obtenidos
            textBox1.Text = "IdDIa";
            txf1.Text = "IdCalendario";
            txf2.Text = "Fecha";
            cb5.SelectedItem = "Null";
        }

        public void enviar_Calendario()
        {
            dato1 = textBox1.Text; //IdDIa
            dato2 = txf1.Text; //IdCalendario
            dato3 = txf2.Text; //Fecha
            dato4 = cb5.SelectedItem.ToString(); //etiqueta
        }


        //-------------------------------------------------------
        // DiaLaboral

        public void es_DiaLaboral()
        {
            label1.Text = "Insertar dia laboral";
            label2.Text = "idCalendario";
            label3.Text = "Lunes";
            label4.Text = "Martes";
            label5.Text = "Miercoles";
            label6.Text = "Jueves";
            label7.Text = "Viernes";
            label8.Text = "Sabados";
            label9.Text = "Domingos";
            label10.Visible = false;


            //ck1 = lunes
            ck1 = new System.Windows.Forms.CheckBox();
            ck1.Location = new Point(155, 155);
            ck1.Height = 22;
            ck1.Width = 22;
            this.Controls.Add(ck1);

            //ck2 = martes
            ck2 = new System.Windows.Forms.CheckBox();
            ck2.Location = new Point(155, 205);
            ck2.Height = 22;
            ck2.Width = 22;
            this.Controls.Add(ck2);

            //ck3 = miercoles
            ck3 = new System.Windows.Forms.CheckBox();
            ck3.Location = new Point(155, 255);
            ck3.Height = 22;
            ck3.Width = 22;
            this.Controls.Add(ck3);

            //ck4 = nombre
            ck4 = new System.Windows.Forms.CheckBox();
            ck4.Location = new Point(155, 305);
            ck4.Height = 22;
            ck4.Width = 22;
            this.Controls.Add(ck4);

            //ck5 = nombre
            ck5 = new System.Windows.Forms.CheckBox();
            ck5.Location = new Point(155, 355);
            ck5.Height = 22;
            ck5.Width = 22;
            this.Controls.Add(ck5);

            //ck6 = nombre
            ck6 = new System.Windows.Forms.CheckBox();
            ck6.Location = new Point(155, 405);
            ck6.Height = 22;
            ck6.Width = 22;
            this.Controls.Add(ck6);

            //ck7 = nombre
            ck7 = new System.Windows.Forms.CheckBox();
            ck7.Location = new Point(155, 455);
            ck7.Height = 22;
            ck7.Width = 22;
            this.Controls.Add(ck7);

        }

        public void editar_diaLaboral()
        {
            label1.Text = "Editar dia laboral";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            //HERE SQL
            //Procedimiento para obtener los valores actuales.

            textBox1.Text = IdRow;
            ck1.Checked = true;
            ck2.Checked = true;
            ck3.Checked = true;
            ck4.Checked = true;
            ck5.Checked = true;
            ck6.Checked = true;
            ck7.Checked = true;

        }

        public void enviar_feriado()
        {
            dato1 = textBox1.Text; //id

            dato2 = ck1.Checked.ToString();
            if (ck1.Checked){ dato2 = "Y"; } else { dato2 = "N"; }


        }


        //-------------------------------------------------------
        // EMPLEADOS

        public void es_Empleados()
        {
            label1.Text = "Insertar empleado";
            label2.Text = "Id";
            label3.Text = "Nombre";
            label4.Text = "Fecha Ingreso";
            label5.Text = "Fecha Salida";
            label6.Text = "Departamento";
            label7.Text = "Id Calendario";
            label8.Text = "Supervisor";
            label9.Visible = false;
            label10.Visible = false;


            //txf1 = nombre
            txf1 = new System.Windows.Forms.TextBox();
            txf1.Location = new Point(155, 157);
            txf1.Size = new Size(235, 22);
            this.Controls.Add(txf1);

            //txf2 = fecha ingreso
            txf2 = new System.Windows.Forms.TextBox();
            txf2.Location = new Point(190, 205);
            txf2.Size = new Size(200, 22);
            this.Controls.Add(txf2);

            //txf3 = fecha salida
            txf3 = new System.Windows.Forms.TextBox();
            txf3.Location = new Point(190, 255);
            txf3.Size = new Size(200, 22);
            this.Controls.Add(txf3);

            //**
            //cb1 = departamento / tipos empleado  ->  GET ALL TiposEmpleados
            String[] tipoEmpleado = { "Produccion", "Ventas", "Marketing" };
            cb1 = new System.Windows.Forms.ComboBox();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.Items.AddRange(tipoEmpleado);
            cb1.Location = new Point(190, 305);
            cb1.Size = new Size(200, 22);
            cb1.DropDownHeight = 22 * 5;
            this.Controls.Add(cb1);

            //**
            //cb2 = id calendario ->  GET ALL CalendarioNums
            String[] calendario = { "1", "2", "3" };
            cb2 = new System.Windows.Forms.ComboBox();
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb2.Items.AddRange(calendario);
            cb2.Location = new Point(190, 355);
            cb2.Size = new Size(50, 22);
            cb2.DropDownHeight = 22 * 5;
            this.Controls.Add(cb2);

            //txf4 = supervisor num
            txf4 = new System.Windows.Forms.TextBox();
            txf4.Location = new Point(190, 405);
            txf4.Size = new Size(200, 22);
            this.Controls.Add(txf4);


        }

        public void editar_empleados()
        {
            label1.Text = "Editar empleado";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            //HERE SQL
            //Procedimiento para obtener los valores actuales.

            textBox1.Text = IdRow;
            txf1.Text = "Nombre";
            txf2.Text = "fecha ing";
            txf3.Text = "fecha sal";
            txf4.Text = "superv num";
            cb1.SelectedItem = "Produccion";
            cb2.SelectedItem = "1";
       
        }

        public void enviar_empleados()
        {
            dato1 = textBox1.Text; //id
            dato2 = txf1.Text; //nombre
            dato3 = txf2.Text; //ingreso
            dato4 = txf3.Text; //salida
            dato5 = cb1.SelectedItem.ToString(); //dept
            dato6 = cb2.SelectedItem.ToString(); //calendario
            dato7 = txf4.Text; //supervisor
        
        }


        //-------------------------------------------------------
        // Tipo Empleado

        public void es_TipoEmpleado()
        {
            label1.Text = "Insertar Tipo Empleado";
            label2.Text = "Id";
            label3.Text = "Nombre";
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;


            //txf1 = nombre
            txf1 = new System.Windows.Forms.TextBox();
            txf1.Location = new Point(155, 157);
            txf1.Size = new Size(235, 22);
            this.Controls.Add(txf1);
            
        }

        public void editar_tipoEmpleado()
        {
            label1.Text = "Editar Tipo Empleado";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            //HERE SQL
            //Procedimiento para obtener los valores actuales.

            textBox1.Text = IdRow;
            txf1.Text = "Nombre";
            
        }

        public void enviar_tipoEmpleado()
        {
            dato1 = textBox1.Text; //id
            dato2 = txf1.Text; //nombre
            
        }


        //-------------------------------------------------------
        // CALENDARIO

        public void es_Planilla()
        {
            label1.Text = "Insertar planilla";
            label2.Text = "Id";
            label3.Text = "Id Empleado";
            label4.Text = "Salario bruto";
            label5.Text = "Salario neto";
            label6.Text = "Porcentage obligaciones";
            label7.Text = "Estado";
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;


            //txf1 = id empleado
            txf1 = new System.Windows.Forms.TextBox();
            txf1.Location = new Point(155, 157);
            txf1.Size = new Size(235, 22);
            this.Controls.Add(txf1);

            //txf2 = salario bruto
            txf2 = new System.Windows.Forms.TextBox();
            txf2.Location = new Point(190, 205);
            txf2.Size = new Size(200, 22);
            this.Controls.Add(txf2);

            //txf3 = salario neto
            txf3 = new System.Windows.Forms.TextBox();
            txf3.Location = new Point(190, 255);
            txf3.Size = new Size(200, 22);
            this.Controls.Add(txf3);

            //txf4 = porcentaje obligaciones
            txf4 = new System.Windows.Forms.TextBox();
            txf4.Location = new Point(190, 305);
            txf4.Size = new Size(200, 22);
            this.Controls.Add(txf4);

            //ck1 = estado
            ck1 = new System.Windows.Forms.CheckBox();
            ck1.Location = new Point(155, 355);
            ck1.Height = 22;
            ck1.Width = 22;
            this.Controls.Add(ck1);
        }

        public void editar_planilla()
        {
            label1.Text = "Editar Planilla";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            //HERE SQL
            //Procedimiento para obtener los valores actuales.

            textBox1.Text = IdRow;
            txf1.Text = "Nombre";
            txf2.Text = "PagoHora";
            txf3.Text = "PagoExtra";
            txf4.Text = "PagoDoble";
            //get estado check box
        }

        public void enviar_planilla()
        {
            dato1 = textBox1.Text; //id
            dato2 = txf1.Text; //nombre
            dato3 = txf2.Text; //pagoHora
            dato4 = txf3.Text; //pagoExtra
            dato5 = txf4.Text; //pagoDoble
            dato6 = ck1.Checked.ToString(); //horaInicio
            
        }




        //------------------------------------------------------



        //------------UNUSED
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
