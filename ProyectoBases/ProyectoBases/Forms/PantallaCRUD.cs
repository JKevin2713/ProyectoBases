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
using Org.BouncyCastle.Crypto.Agreement.JPake;
using Google.Protobuf;

namespace ProyectoBases
{
    public partial class PantallaCRUD : Form
    {
        // variables para obtener los datos y enviarlas a SP
        System.Windows.Forms.TextBox txf1, txf2, txf3, txf4, txf5;
        System.Windows.Forms.ComboBox cb1, cb2, cb3, cb4, cb5, cb6;
        String dato1, dato2, dato3, dato4, dato5, dato6, dato7, dato8, dato9;
        System.Windows.Forms.CheckBox ck1, ck2, ck3, ck4, ck5, ck6, ck7;
        DateTimePicker datePicker, datePicker2;
        List<String> row = new List<String>();
        String tablaNombre, planta;
        int codigo;
        String connection;
        EmpleadoDB empleadoDB = new EmpleadoDB();

        public PantallaCRUD(String tn, int cd, List<String> row, String connectionString)
        {
            InitializeComponent();
            this.tablaNombre = tn;
            this.codigo = cd;
            this.row = row;
            this.connection = connectionString;
            button1.Text = "Insertar";

            //Llama a funcion para formatear los espacios necesarios dependiendo de la tabla
            switch (tablaNombre)
            {
                case "Calendario":
                    es_Calendario();
                    if (codigo == 2)
                    {
                        formato_calendario();

                    }
                    break;
                case "Feriados":
                    es_Feriado();
                    if (codigo == 2)
                    {
                        formato_Feriado();
                    }
                    break;
                case "Departamento":
                    es_Departamento();
                    if (codigo == 2)
                    {
                        formato_Departamento();
                    }
                    break;
                case "DiasLaborales":
                    es_DiaLaboral();
                    if (codigo == 2)
                    {
                        formato_diaLaboral();
                    }
                    break;
                case "Empleados":
                    es_Empleados();
                    if (codigo == 2)
                    {
                        formato_empleado();
                    }
                    break;
                case "TiposEmpleados":
                    es_TipoEmpleado();
                    if (codigo == 2)
                    {
                        formato_tipoEmpleado();
                    }
                    break;
                case "Planillas":
                    es_Planilla();
                    if (codigo == 2)
                    {
                        formato_planilla();
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
                        insertar_calendario();
                    }
                    if (codigo == 2)
                    {
                        editar_calendario();
                    }
                    break;
                case "Feriados":
                    if (codigo == 1)
                    {
                        insertar_Feriado();
                    }
                    if (codigo == 2)
                    {
                        editar_Feriado();
                    }
                    break;
                case "DiasLaborales":
                    if (codigo == 1)
                    {
                        insertar_Laboral();
                    }
                    if (codigo == 2)
                    {
                        editar_Laboral();
                    }
                    break;
                case "Empleados":
                    if (codigo == 1)
                    {
                        insertar_empleado();
                    }
                    if (codigo == 2)
                    {
                        editar_empleado();
                    }
                    break;
                case "TiposEmpleados":
                    if (codigo == 1)
                    {
                        insertar_tipoEmpleado();
                    }
                    if (codigo == 2)
                    {
                        editar_tipoEmpleado();
                    }
                    break;
                case "Planillas":
                    if (codigo == 1)
                    {
                        insertar_planilla();
                    }
                    if (codigo == 2)
                    {
                        editar_planilla();
                    }
                    break;
                case "Departamento":
                    if (codigo == 1)
                    {
                        insertar_Departamento();
                    }
                    if (codigo == 2)
                    {
                        editar_Departamento();
                    }
                    break;
                default:
                    // code block
                    break;
            }
            this.Dispose();
        }


        //-------------------------------------------------------
        // CALENDARIO

        public void es_Calendario()
        {
            label2.Visible = false;
            textBox1.Visible = false;
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

        public void formato_calendario()
        {
            label1.Text = "Editar calendario";
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = false; //id
            button1.Text = "Editar";
            textBox1.Text = row[0];
            txf1.Text = row[1];
            txf2.Text = row[2];
            txf3.Text = row[3];
            txf4.Text = row[4];
            cb1.SelectedItem = row[5].Substring(0, 2);
            cb2.SelectedItem = row[5].Substring(3, 2);
            cb3.SelectedItem = row[6].Substring(0, 2);
            cb4.SelectedItem = row[6].Substring(3, 2);
            cb5.SelectedIndex = Convert.ToInt32(row[7]) - 1;

        }

        public void editar_calendario()
        {
            bool error = false;
            CalendarioLaboral c = new CalendarioLaboral();
            c.IdCalendario = Convert.ToInt32(row[0]);
            c.Nombre = txf1.Text; //nombre
            decimal temp;
            if (decimal.TryParse(txf2.Text, out temp))
            {
                c.PagoHora = temp;
            }
            else
            {
                error = true;
            }

            if (decimal.TryParse(txf3.Text, out temp))
            {
                c.PagoHoraExtra = temp;
            }
            else
            {
                error = true;
            }

            if (decimal.TryParse(txf4.Text, out temp))
            {
                c.PagoHoraDoble = temp;
            }
            else
            {
                
            }
            c.HoraInicio = cb1.SelectedIndex * 10000 + cb2.SelectedIndex * 100; //horaInicio
            c.HoraFinal = cb3.SelectedIndex * 10000 + cb4.SelectedIndex * 100; //horaFin
            c.TipoPago = cb5.SelectedIndex + 1; //pago

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                CalendarioLaboralDB calendario = new CalendarioLaboralDB();
                MessageBox.Show(calendario.ToString());
                calendario.ActualizarCalendarioLaboral(c, connection);
            }
        }

        public void insertar_calendario()
        {
            bool error = false;
            CalendarioLaboral c = new CalendarioLaboral();
            c.Nombre = txf1.Text; //nombre
            decimal temp;
            if (decimal.TryParse(txf2.Text, out temp))
            {
                c.PagoHora = temp;
            }
            else
            {
                error = true;
            }

            if (decimal.TryParse(txf3.Text, out temp))
            {
                c.PagoHoraExtra = temp;
            }
            else
            {
                error = true;
            }

            if (decimal.TryParse(txf4.Text, out temp))
            {
                c.PagoHoraDoble = temp;
            }
            else
            {

            }
            c.HoraInicio = cb1.SelectedIndex * 10000 + cb2.SelectedIndex; //horaInicio
            c.HoraFinal = cb3.SelectedIndex * 10000 + cb4.SelectedIndex; //horaFin
            c.TipoPago = cb5.SelectedIndex + 1; //pago

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                CalendarioLaboralDB calendario = new CalendarioLaboralDB();
                calendario.InsertarCalendarioLaboral(c, connection);
            }
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

            //datePicker = Fecha
            datePicker = new DateTimePicker();
            datePicker.Location = new Point(155, 205);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Width = 200;
            this.Controls.Add(datePicker);

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

        public void formato_Feriado()
        {
            label1.Text = "Editar Dias Feriados";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";
            textBox1.Text = row[0];
            txf1.Text = row[1];
            if (DateTime.TryParseExact(row[2], "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime sd2))
            {
                datePicker.Value = sd2;
            }
            cb5.SelectedItem = row[3];
        }

        public void editar_Feriado()
        {
            bool error = false;
            DiasFeriados d = new DiasFeriados();
            int temp;
            if (int.TryParse(txf1.Text, out temp))
            {
                d.IdCalendario = temp;
            }
            else
            {
                error = true;
            }
            if (int.TryParse(textBox1.Text, out temp))
            {
                d.IdDia = temp;
            }
            else
            {
                error = true;
            }

            d.Fecha = datePicker.Value;
            d.Etiqueta = cb5.SelectedItem.ToString();

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                DiasFeriadosDB DB = new DiasFeriadosDB();
                DB.ActualizarDiaFeriado(d, connection);
            }
        }

        public void insertar_Feriado()
        {
            bool error = false;
            DiasFeriados d = new DiasFeriados();
            int temp;
            if (int.TryParse(txf1.Text, out temp))
            {
                d.IdCalendario = temp;
            }
            else
            {
                error = true;
            }
            if (int.TryParse(textBox1.Text, out temp))
            {
                d.IdDia = temp;
            }
            else
            {
                error = true;
            }

            d.Fecha = datePicker.Value;
            d.Etiqueta = cb5.SelectedItem.ToString();

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                DiasFeriadosDB db = new DiasFeriadosDB();
                db.InsertarDiaFeriado(d, connection);
            }
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

        public void formato_diaLaboral()
        {
            label1.Text = "Editar dia laboral";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";
            textBox1.Text = row[0];
            ck1.Checked = row[1].Equals("true");
            ck2.Checked = row[2].Equals("true");
            ck3.Checked = row[3].Equals("true");
            ck4.Checked = row[4].Equals("true");
            ck5.Checked = row[5].Equals("true");
            ck6.Checked = row[6].Equals("true");
            ck7.Checked = row[7].Equals("true");

        }

        public void editar_Laboral()
        {
            bool error = false; 
            DiasLaborales d = new DiasLaborales();
            int temp;
            if (int.TryParse(textBox1.Text, out temp))
            {
                d.IdCalendario = temp;
            }
            else
            {
                error = true;
            }
            d.Lunes = ck1.Checked;
            d.Martes = ck2.Checked;
            d.Miercoles = ck3.Checked;
            d.Jueves = ck4.Checked;
            d.Viernes = ck5.Checked;
            d.Sabados = ck6.Checked;
            d.Domingos = ck7.Checked;

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                DiasLaboralesDB dias = new DiasLaboralesDB();
                dias.ActualizarDiasLaborales(d, connection);
            }
        }

        public void insertar_Laboral()
        {
            bool error = false;
            DiasLaborales d = new DiasLaborales();
            int temp;
            if (int.TryParse(textBox1.Text, out temp))
            {
                d.IdCalendario = temp;
            }
            else
            {
                error = true;
            }
            d.Lunes = ck1.Checked;
            d.Martes = ck2.Checked;
            d.Miercoles = ck3.Checked;
            d.Jueves = ck4.Checked;
            d.Viernes = ck5.Checked;
            d.Sabados = ck6.Checked;
            d.Domingos = ck7.Checked;

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                DiasLaboralesDB dias = new DiasLaboralesDB();
                dias.InsertarDiasLaborales(d, connection);
            }
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
            label6.Text = "Tipo Empleado";
            label7.Text = "Id Calendario";
            label8.Text = "Departamento";
            label9.Text = "Supervisor";
            label10.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;

            //txf1 = nombre
            txf1 = new System.Windows.Forms.TextBox();
            txf1.Location = new Point(155, 157);
            txf1.Size = new Size(235, 22);
            this.Controls.Add(txf1);

            //datePicker = FechaEntrada
            datePicker = new DateTimePicker();
            datePicker.Location = new Point(190, 205);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Width = 200;
            this.Controls.Add(datePicker);

            //datePicker 2 = Fecha Salida
            datePicker2 = new DateTimePicker();
            datePicker2.Location = new Point(190, 255);
            datePicker2.Format = DateTimePickerFormat.Short;
            datePicker2.Width = 200;
            this.Controls.Add(datePicker2);

            //cb1 = tipos empleado  ->  GET ALL TiposEmpleados
          
            TipoEmpleadoDB tipoEmpleado = new TipoEmpleadoDB();
            String[] tiposEmpleados = tipoEmpleado.VerNombreTipos(connection).ToArray();
          
            cb1 = new System.Windows.Forms.ComboBox();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.Items.AddRange(tiposEmpleados);
            cb1.Location = new Point(190, 305);
            cb1.Size = new Size(200, 22);
            cb1.DropDownHeight = 22 * 5;
            this.Controls.Add(cb1);
      

            //cb2 = id calendario ->  GET ALL CalendarioNums
            CalendarioLaboralDB calendarioLaboralDB = new CalendarioLaboralDB();
            String[] calendario = calendarioLaboralDB.VerIdCalendario(connection).ToArray();
            cb2 = new System.Windows.Forms.ComboBox();
            cb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb2.Items.AddRange(calendario);
            cb2.Location = new Point(190, 355);
            cb2.Size = new Size(50, 22);
            cb2.DropDownHeight = 22 * 5;
            this.Controls.Add(cb2);

            //cb3 = departamento   ->  GET ALL TiposEmpleados
            DepartamentoDB departamentos = new DepartamentoDB();
            String[] departamento = departamentos.VerNombreDep(connection).ToArray();
            cb3 = new System.Windows.Forms.ComboBox();
            cb3.DropDownStyle = ComboBoxStyle.DropDownList;
            cb3.Items.AddRange(departamento);
            cb3.Location = new Point(190, 405);
            cb3.Size = new Size(200, 22);
            cb3.DropDownHeight = 22 * 5;
            this.Controls.Add(cb3); 

            //txf4 = supervisor num
            txf4 = new System.Windows.Forms.TextBox();
            txf4.Location = new Point(190, 455);
            txf4.Size = new Size(200, 22);
            this.Controls.Add(txf4);
        }

        public void formato_empleado()
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Editar empleado";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            textBox1.Text = row[0]; //id
            txf1.Text = row[1]; //nombre
            //fecha entrada
            if (DateTime.TryParseExact(row[2], "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime sd2))
            {
                datePicker.Value = sd2;
            }
            //fecha salida
            if (DateTime.TryParseExact(row[3], "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime sd1))
            {
                datePicker2.Value = sd1;
            }
            //Tipo Empleado Id
            int temp;
            if (int.TryParse(row[4], out temp))
            {
                TipoEmpleadoDB TipoEmpleadoDB = new TipoEmpleadoDB();
                int TipoEmpleado = temp;
                String TipoEmpleadoId = TipoEmpleadoDB.BuscarNombreTipo(TipoEmpleado, connection);
                cb1.SelectedItem = TipoEmpleadoId;
            }
            //Id Calendario
            if (int.TryParse(row[5], out temp))
            {
                cb2.SelectedIndex = temp;
            }
            //Id Departamento
            if (int.TryParse(row[6], out temp))
            {

                DepartamentoDB DepartamentoDB2 = new DepartamentoDB();
                int departamentoDB = temp;
                String DepartamentoDB = DepartamentoDB2.BuscarNombreDepartamento(departamentoDB, connection);
                cb3.SelectedItem = DepartamentoDB;
            }
            //Id Supervisor
            txf4.Text = row[7];
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void editar_empleado()
        {
            bool error = false;
            Empleado e = new Empleado();
            TipoEmpleadoDB TipoEmpleadoDB = new TipoEmpleadoDB();
            CalendarioLaboralDB CalendarioDB = new CalendarioLaboralDB();
            DepartamentoDB DepartamentoDB = new DepartamentoDB();

            e.IdEmpleado = Convert.ToInt32(row[0]);
            e.Nombre = txf1.Text;
            e.FechaIngreso = datePicker.Value;
            e.FechaSalida = datePicker2.Value;

            String TipoEmpleado = cb1.SelectedItem.ToString();
            int TipoEmpleadoId = TipoEmpleadoDB.BuscarIdTipo(TipoEmpleado, connection);
            e.TipoEmpleadoId = TipoEmpleadoId;

            String Calendario = cb2.SelectedItem.ToString();
            //int CalendarioId = BuscarIdCalendario(Calendario, connection);
            e.IdCalendario = Convert.ToInt32(Calendario);

            String Departamento = cb3.SelectedItem.ToString();
            int DepartamentoId = DepartamentoDB.BuscarIdDepartamento(Departamento, connection);
            e.Departamento = DepartamentoId;

            int temp;
            if (int.TryParse(txf4.Text, out temp))
            {
                e.Supervisor = temp;
            }
            else if (txf4.Text == "")
            {
                e.Supervisor = 0;
            }
            else
            {
                error = true;
            }
            switch (planta)
            {
                case "Guayabo":
                    e.Planta = 1;
                    break;
                case "Central":
                    e.Planta = 2;
                    break;
                case "La Romana":
                    e.Planta = 3;
                    break;
            }
            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                EmpleadoDB empleadoDB = new EmpleadoDB();
                empleadoDB.ActualizarEmpleado(e, connection);
            }

        }

        public void insertar_empleado()
        {
            bool error = false;
            Empleado e = new Empleado();
            TipoEmpleadoDB TipoEmpleadoDB = new TipoEmpleadoDB();
            CalendarioLaboralDB CalendarioDB = new CalendarioLaboralDB();
            DepartamentoDB DepartamentoDB = new DepartamentoDB();


            e.Nombre = txf1.Text;
            e.FechaIngreso = datePicker.Value;
            e.FechaSalida = datePicker2.Value;

            String TipoEmpleado = cb1.SelectedItem.ToString();
            int TipoEmpleadoId = TipoEmpleadoDB.BuscarIdTipo(TipoEmpleado, connection);
            e.TipoEmpleadoId = TipoEmpleadoId;

            String Calendario = cb2.SelectedItem.ToString();
            //int CalendarioId = BuscarIdCalendario(Calendario, connection);
            e.IdCalendario = Convert.ToInt32(Calendario);

            String Departamento = cb3.SelectedItem.ToString();
            int DepartamentoId = DepartamentoDB.BuscarIdDepartamento(Departamento, connection);
            e.Departamento = DepartamentoId;

            int temp;
            if (int.TryParse(txf4.Text, out temp))
            {
                e.Supervisor = temp;
            }
            else if (txf4.Text == "")
            {
                e.Supervisor = 0;
            }
            else
            {
                error = true;
            }
            switch (planta)
            {
                case "Guayabo":
                    e.Planta = 1;
                    break;
                case "Central":
                    e.Planta = 2;
                    break;
                case "La Romana":
                    e.Planta = 3;
                    break;
            }
            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                EmpleadoDB empleadoDB = new EmpleadoDB();
                empleadoDB.InsertarEmpleado(e, connection);
            }
            
        }


        //-------------------------------------------------------
        // Tipo Empleado

        public void es_TipoEmpleado()
        {
            label2.Visible = false;
            textBox1.Visible = false;
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

        public void formato_tipoEmpleado()
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Editar Tipo Empleado";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";
            textBox1.Text = row[0];
            txf1.Text = row[1];  
        }

        public void editar_tipoEmpleado()
        {
            TipoEmpleado tp = new TipoEmpleado();
            tp.IdTipo = Convert.ToInt32(row[0]);
            tp.NombreTipoEmpleado = txf1.Text;

            TipoEmpleadoDB db = new TipoEmpleadoDB();
            db.ActualizarTipoEmpleado(tp, connection);    
        }

        public void insertar_tipoEmpleado()
        {
            TipoEmpleado tp = new TipoEmpleado();
            tp.NombreTipoEmpleado = txf1.Text;

            TipoEmpleadoDB db = new TipoEmpleadoDB();
            db.InsertarTipoEmpleado(tp, connection);
            
        }


        //-------------------------------------------------------
        // Departamento

        public void es_Departamento()
        {
            label2.Visible = false;
            textBox1.Visible = false;
            label1.Text = "Insertar Departamento";
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

        public void formato_Departamento()
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Editar Departamento";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";
            textBox1.Text = row[0];
            txf1.Text = row[1];
        }

        public void editar_Departamento()
        {
            Departamento d = new Departamento();
            d.IdDepartamento = Convert.ToInt32(row[0]);
            d.Nombre = txf1.Text;

            DepartamentoDB db = new DepartamentoDB();
            db.ActualizarDepartamento(d, connection);

        }

        public void insertar_Departamento()
        {
            Departamento d = new Departamento();
            d.Nombre = txf1.Text;
            DepartamentoDB db = new DepartamentoDB();
            db.InsertarDepartamento(d, connection);
            
        }


        //-------------------------------------------------------
        // PLANILLA

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
            label2.Visible  = false;
            textBox1.Visible = false;


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

        public void formato_planilla()
        {
            label2.Visible = true;
            textBox1.Visible = true;
            label1.Text = "Editar Planilla";
            textBox1.Enabled = false; //id
            button1.Text = "Editar";

            textBox1.Text = row[0]; //id planilla
            txf1.Text = row[1]; //id empleado
            //id planta row[2]
            ck1.Checked = row[3].Equals("true");
            txf2.Text = row[4]; //salario bruto
            txf3.Text = row[3]; //salario neto
            txf4.Text = row[4]; //porc obl
        }

        public void editar_planilla()
        {
            bool error = false;
            Planillas pl = new Planillas(); 
            //id empleado
            pl.IdPlanilla = Convert.ToInt32(row[0]);
            int temp2;
            if (int.TryParse(txf1.Text, out temp2))
            {
               pl.IdEmpleado = temp2;
            }
            else
            {
                error = true;
            }
            //id planta
            switch (planta)
            {
                case "Guayabo":
                    pl.IdPlanta = 1;
                    break;
                case "Central":
                    pl.IdPlanta = 2;
                    break;
                case "La Romana":
                    pl.IdPlanta = 3;
                    break;
            }            
            //estado
            pl.Estado = ck1.Checked;
            decimal temp;
            //salariobruto
            if (decimal.TryParse(txf2.Text, out temp))
            {
                pl.SalarioBruto = temp;
            }
            else
            {
                error = true;
            }
            //salarioneto
            if (decimal.TryParse(txf3.Text, out temp))
            {
                pl.SalarioNeto = temp;
            }
            else
            {
                error = true;
            }
            //porcentaje obl
            if (decimal.TryParse(txf4.Text, out temp))
            {
                pl.PorcentajeObligaciones = temp;
            }
            else
            {
                error = true;
            }

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                PlanillasDB dB = new PlanillasDB();
                dB.ActualizarPlanilla(pl, connection);
            }
        }

        public void insertar_planilla()
        {
            bool error = false;
            Planillas pl = new Planillas();
            //id empleado
            int temp;
            if (int.TryParse(txf1.Text, out temp))
            {
                pl.IdEmpleado = temp;
            }
            else
            {
                error = true;
            }
            //id planta
            switch (planta)
            {
                case "Guayabo":
                    pl.IdPlanta = 1;
                    break;
                case "Central":
                    pl.IdPlanta = 2;
                    break;
                case "La Romana":
                    pl.IdPlanta = 3;
                    break;
            }
            //estado
            pl.Estado = ck1.Checked;
            decimal temp2;
            //salariobruto
            if (decimal.TryParse(txf2.Text, out temp2))
            {
                pl.SalarioBruto = temp2;
            }
            else
            {
                error = true;
            }
            //salarioneto
            if (decimal.TryParse(txf3.Text, out temp2))
            {
                pl.SalarioNeto = temp2;
            }
            else
            {
                error = true;
            }
            
            //porcentaje obl
            if (decimal.TryParse(txf4.Text, out temp2))
            {
                pl.PorcentajeObligaciones = temp2;
            }
            else
            {
                error = true;
            }

            if (error)
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            else
            {
                PlanillasDB dB = new PlanillasDB();
                dB.InsertarPlanilla(pl, connection);
            }
        }


        //------------------------------------------------------
        public void plantaNombre(String nombre)
        {
            this.planta = nombre;
        }


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
