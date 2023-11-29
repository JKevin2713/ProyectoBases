using DB;
using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBases.Forms
{
    public partial class SimuladorMarcas : Form
    {
        String connection;
        System.Windows.Forms.ComboBox cb1, cb3, cb4, cb5, cb6;

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
            dtp2.Enabled = false;

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
            cb1.Location = new Point(265, 128);
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
            cb5 = new System.Windows.Forms.ComboBox();
            cb5.DropDownStyle = ComboBoxStyle.DropDownList;
            cb5.Items.AddRange(minutos);
            cb5.Location = new Point(318, 128);
            cb5.Size = new Size(50, 22);
            cb5.DropDownHeight = 22 * 5;
            this.Controls.Add(cb5);
            cb5.SelectedIndex = 0;


            //cb3 = horaFin
            cb3 = new System.Windows.Forms.ComboBox();
            cb3.DropDownStyle = ComboBoxStyle.DropDownList;
            cb3.Items.AddRange(hora);
            cb3.Location = new Point(265, 178);
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
            cb4.Location = new Point(318, 178);
            cb4.Size = new Size(50, 22);
            cb4.DropDownHeight = 22 * 5;
            this.Controls.Add(cb4);
            cb4.SelectedIndex = 0;

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
            String Calendario, idEmpleado;
            int horaInicio, horaFin;
            double ProbabilidadAusentismo, ProbabilidadOmision, ProbabilidadTardia;
            Random random = new Random();

            idEmpleado = textBox4.Text;
            Calendario = cb2.SelectedItem.ToString();

            horaInicio = cb1.SelectedIndex * 10000 + cb5.SelectedIndex * 100;
            horaFin = cb3.SelectedIndex * 10000 + cb4.SelectedIndex * 100;

            EmpleadoDB empleadoDB = new EmpleadoDB();

            int id = empleadoDB.BuscarIdEmpleado(idEmpleado, connection);

            if(id == 0)
            {
                MessageBox.Show("El IdEmpleado no existe");
                return;
            }

            DateTime fechaInicio = dtp1.Value;
            DateTime fechaFinal = checkBox1.Checked ? dtp2.Value : dtp1.Value;

            int numeroDias = ObtenerNumeroDias(fechaInicio, fechaFinal);

            if (double.TryParse(textBox1.Text, out double probAusentismo))
            {
                ProbabilidadAusentismo = probAusentismo;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            if (double.TryParse(textBox2.Text, out double probOmision))
            {
                ProbabilidadOmision = probOmision;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }
            if (double.TryParse(textBox3.Text, out double probTardia))
            {
                ProbabilidadTardia = probTardia;
            }
            else
            {
                MessageBox.Show("Tipo de dato incorrecto");
            }

            DiasFeriadosDB diasFeriadosDB = new DiasFeriadosDB();
            List<String[]> feriadosStrings = diasFeriadosDB.VerDiasFeriados(connection);

            List<DiasFeriados> fechasFeriadas = feriadosStrings
                .Select(feriado => new DiasFeriados
                {
                    IdDia = int.Parse(feriado[0]),
                    IdCalendario = int.Parse(feriado[1]),
                    Fecha = DateTime.Parse(feriado[2]),
                    Etiqueta = feriado[3]
                })
                .ToList();

            DiasLaboralesDB diasLaboralesDB = new DiasLaboralesDB();
            List<String[]> LaboralesStrings = diasLaboralesDB.VerDiasLaborales(connection);

            List<DiasLaborales> DiasLaborales = LaboralesStrings
                .Select(laboral => new DiasLaborales
                {
                    IdCalendario = int.Parse(laboral[0]),
                    Lunes = Convert.ToBoolean(laboral[1]),
                    Martes = Convert.ToBoolean(laboral[2]),
                    Miercoles = Convert.ToBoolean(laboral[3]),
                    Jueves = Convert.ToBoolean(laboral[4]),
                    Viernes = Convert.ToBoolean(laboral[5]),
                    Sabados = Convert.ToBoolean(laboral[6]),
                    Domingos = Convert.ToBoolean(laboral[7]),
                })
        .ToList();

            CalendarioLaboralDB calendario = new CalendarioLaboralDB();
            List<String[]> calendarios = calendario.VerCalendarioLaboral(connection);

            List<CalendarioLaboral> Calenda = calendarios
                .Select(calen => new CalendarioLaboral
                {
                    IdCalendario = int.Parse(calen[0]),
                    Nombre = calen[1],
                    HoraInicio = (int)TimeSpan.Parse(calen[5]).TotalHours * 10000 + (int)((TimeSpan.Parse(calen[5]).TotalMinutes) % 60) * 100,
                    HoraFinal = (int)TimeSpan.Parse(calen[6]).TotalHours * 10000 + (int)((TimeSpan.Parse(calen[6]).TotalMinutes) % 60) * 100,

                })
        .ToList();

            CalendarioLaboral calendarioEspecifico = Calenda.FirstOrDefault(c => c.IdCalendario == int.Parse(Calendario));

            if (calendarioEspecifico.HoraInicio > horaInicio || calendarioEspecifico.HoraFinal < horaFin)
            {
                // Aquí puedes realizar las acciones necesarias para los días fuera de las horas laborales
                Console.WriteLine($"No se debe marcar en las horas Ingresadas");
                return;
            }

            for (int i = 0; i <= numeroDias; i++)
            {
                DateTime fechaActual = fechaInicio.AddDays(i);

                // Verificar si es un día feriado con etiqueta NULL o no laboral
                if (EsDiaFeriado(fechaActual, fechasFeriadas) || !EsDiaLaboral(fechaActual, DiasLaborales, int.Parse(Calendario)))
                {
                    // Aquí puedes realizar las acciones necesarias para los días que no deben marcarse
                    Console.WriteLine($"No se debe marcar en la fecha: {fechaActual.ToShortDateString()}");
                }
                else
                {
                    // Generar un número aleatorio entre 0 y 1 para cada probabilidad
                    double randomAusentismo = random.NextDouble();
                    double randomOmision = random.NextDouble();
                    double randomTardia = random.NextDouble();
                    int minutosTardanza = 0;

                    // Verificar si se cumple la probabilidad de ausentismo
                    bool ausentismo = randomAusentismo < probAusentismo;

                    // Verificar si se cumple la probabilidad de omisión
                    bool omision = randomOmision < probOmision;

                    if(omision || ausentismo)
                    {
                        Console.WriteLine($"Obtuvo una Ausencia o Omision");
                        continue;
                    }

                     // Verificar si se cumple la probabilidad de tardía
                     bool tardia = randomTardia < probTardia;

                    Marca marca = new Marca();
                    marca.EmpleadoId = id;
                    marca.Fecha = fechaActual;
                    marca.Salida = horaFin;

                    if (tardia)
                    {
                        // Sumar entre 1 minutos y 59 minutos a la hora de inicio
                        minutosTardanza = random.Next(01, 59);
                        Console.WriteLine($"Obtuvo una llegada Tardia de {minutosTardanza} minutos");
                    }

                    marca.Entrada = horaInicio + (minutosTardanza * 100);

                    MarcaDB marcaDB = new MarcaDB();

                    if (marcaDB.MarcaExistente(marca.EmpleadoId, marca.Fecha, connection))
                    {
                        Console.WriteLine("Ya existe una marca para este empleado en la fecha especificada.");
                        continue;
                    }

                    if (checkBox2.Checked)
                    {
                        marcaDB.InsertarMarca(marca, connection);
                    }

                    Console.WriteLine($"Puede marcar en la fecha: {fechaActual.ToShortDateString()} a la hora: {marca.Entrada}");
                    
                }
            }
        }
        
        private int ObtenerNumeroDias(DateTime fechaInicio, DateTime fechaFinal)
        {
            TimeSpan diferencia = fechaFinal - fechaInicio;
            return Math.Abs(diferencia.Days);
        }

        private bool EsDiaFeriado(DateTime fecha, List<DiasFeriados> feriados)
        {
            return feriados.Any(feriado => feriado.Fecha.Date == fecha.Date && feriado.Etiqueta == "NULL");
        }

        private bool EsDiaLaboral(DateTime fecha, List<DiasLaborales> laborales, int idCalendario)
        {
            DiasLaborales diaLaboral = laborales.FirstOrDefault(laboral => laboral.IdCalendario == idCalendario);

            // Verificar si la fecha es un día laboral según la lógica de DiasLaborales
            if (diaLaboral != null)
            {
                switch (fecha.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        return diaLaboral.Lunes;
                    case DayOfWeek.Tuesday:
                        return diaLaboral.Martes;
                    case DayOfWeek.Wednesday:
                        return diaLaboral.Miercoles;
                    case DayOfWeek.Thursday:
                        return diaLaboral.Jueves;
                    case DayOfWeek.Friday:
                        return diaLaboral.Viernes;
                    case DayOfWeek.Saturday:
                        return diaLaboral.Sabados;
                    case DayOfWeek.Sunday:
                        return diaLaboral.Domingos;
                    default:
                        return false;
                }
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SimuladorMarcas_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
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
