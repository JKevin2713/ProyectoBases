using DB;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
            DateTime fechaInicio = dtp1.Value;
            int IDcalendario = Convert.ToInt32(cb1.SelectedItem);

            //recuepera los datos de calendario
            
            CalendarioLaboralDB calendario = new CalendarioLaboralDB();
            List<String[]> calendarios = calendario.VerCalendarioLaboral(connection);

            List<CalendarioLaboral> Calenda = calendarios
                .Select(calen => new CalendarioLaboral
                {

                    IdCalendario = int.Parse(calen[0]),
                    Nombre = calen[1],
                    PagoHora = decimal.Parse(calen[2]),
                    PagoHoraExtra = decimal.Parse(calen[3]),
                    PagoHoraDoble = decimal.Parse(calen[4]),
                    HoraInicio = (int)TimeSpan.Parse(calen[5]).TotalHours * 10000 + (int)((TimeSpan.Parse(calen[5]).TotalMinutes) % 60) * 100,
                    HoraFinal = (int)TimeSpan.Parse(calen[6]).TotalHours * 10000 + (int)((TimeSpan.Parse(calen[6]).TotalMinutes) % 60) * 100,
                    TipoPago = int.Parse(calen[7]),
                })
            .ToList();

            CalendarioLaboral calendarioEspecifico = Calenda.FirstOrDefault(c => c.IdCalendario == IDcalendario);

            //escoje el calendario al que se le va a calcular la planilla

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

             List<DiasFeriados> feriadosEspecificos = fechasFeriadas.Where(feriado => feriado.IdCalendario == IDcalendario).ToList();

            //escoje los dias feriados especificos del calendario ID

            EmpleadoDB empleadoDB = new EmpleadoDB();
            List<String[]> empleados = empleadoDB.VerEmpleadoPorCalendario(connection, IDcalendario);

            //retorna los empleados con el numero de calendario 

            foreach (String[] empleado in empleados)
            {
                // Aquí puedes realizar el cálculo de la planilla para cada empleado
                int idEmpleado = int.Parse(empleado[0]);
                DateTime fechaIngreso = DateTime.Parse(empleado[2]);
                DateTime fechaSalida = DateTime.Parse(empleado[3]);

                DateTime fechaFinal;

                if (calendarioEspecifico.TipoPago == 1)
                {
                    fechaFinal = fechaInicio.AddDays(30);
                }
                else if(calendarioEspecifico.TipoPago == 2)
                {
                    fechaFinal = fechaInicio.AddDays(15);
                }
                else
                {
                    fechaFinal = fechaInicio.AddDays(7);
                }

                MarcaDB marcaDB = new MarcaDB();
                List<String[]> marcas = marcaDB.ObtenerMarcasPorEmpleado(idEmpleado, fechaInicio, fechaFinal, connection);
                DateTime fechaActual = fechaInicio;
                Planillas planillas = new Planillas();

                planillas.IdEmpleado = int.Parse(empleado[0]);
                planillas.Estado = true;
                planillas.IdPlanta = int.Parse(empleado[8]);

                decimal SalarioBruto = 0;
                decimal SalarioNeto = 0;
                decimal Porcentaje = 0;

                foreach (String[] marca in marcas)
                {

                    DateTime horaEntrada = DateTime.Parse(marca[3]);  // Cambia la posición según la estructura de tus datos
                    DateTime horaSalida = DateTime.Parse(marca[4]);    // Cambia la posición según la estructura de tus datos

                    // Calcula la diferencia de tiempo
                    TimeSpan diferenciaDeTiempo = horaSalida - horaEntrada;

                    // Obtiene el número total de horas
                    double horasTrabajadas = diferenciaDeTiempo.TotalHours;

                    Console.WriteLine(horasTrabajadas.ToString()); 

                    if (fechaIngreso >= fechaActual && fechaActual >= fechaSalida)
                    {
                        Console.WriteLine($"El empleado{int.Parse(empleado[0])} no habia ingresa o no seguia trabajando en la fecha: {fechaActual.ToShortDateString()}");
                    }
                    else if(EsPagoEspecialExtra(fechaActual, feriadosEspecificos))
                    {
                        SalarioBruto = SalarioBruto + ((decimal)horasTrabajadas * calendarioEspecifico.PagoHoraExtra);
                    }
                    else if (EsPagoEspecialDoble(fechaActual, feriadosEspecificos))
                    {
                        SalarioBruto = SalarioBruto + ((decimal)horasTrabajadas * calendarioEspecifico.PagoHoraDoble);
                    }
                    else
                    {
                        SalarioBruto = SalarioBruto + ((decimal)horasTrabajadas * calendarioEspecifico.PagoHora);
                    }
                    fechaActual = fechaActual.AddDays(1);
                }

                Porcentaje = SalarioBruto * (decimal)0.0978;
                SalarioNeto = SalarioBruto - Porcentaje;

                planillas.SalarioBruto = SalarioBruto;
                planillas.SalarioNeto = SalarioNeto;
                planillas.PorcentajeObligaciones = Porcentaje;

                PlanillasDB planillasDB = new PlanillasDB();
                planillasDB.InsertarPlanilla(planillas, connection);
            }

        }
        private bool EsPagoEspecialExtra(DateTime fecha, List<DiasFeriados> feriados)
        {
            return feriados.Any(feriado => feriado.Fecha.Date == fecha.Date && feriado.Etiqueta == "Extra");
        }
        private bool EsPagoEspecialDoble(DateTime fecha, List<DiasFeriados> feriados)
        {
            return feriados.Any(feriado => feriado.Fecha.Date == fecha.Date && feriado.Etiqueta == "Doble");
        }

        private void CalculoPlanillas_Load(object sender, EventArgs e)
        {

        }
    }
}
