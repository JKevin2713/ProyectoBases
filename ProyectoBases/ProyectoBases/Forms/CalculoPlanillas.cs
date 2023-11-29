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
            DateTime fechaInicial = dtp1.Value;
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
                string nombre = empleado[1];
                DateTime fechaIngreso = DateTime.Parse(empleado[2]);
                DateTime fechaSalida = DateTime.Parse(empleado[3]);
                int tipoEmpleadoId = int.Parse(empleado[4]);
                int idCalendario = int.Parse(empleado[5]);
                int departamento = int.Parse(empleado[6]);
                int supervisor = int.Parse(empleado[7]);
                int planta = int.Parse(empleado[8]);

                // Supongamos que ya tienes la lista de marcas del empleado (List<String[]> marcas)
                MarcaDB marcaDB = new MarcaDB();
                List<String[]> marcas = marcaDB.ObtenerMarcasPorEmpleado(idEmpleado, connection);

                foreach (String[] marca in marcas)
                {
                    // Aquí puedes trabajar con la información de cada marca del empleado
                    int idMarca = int.Parse(marca[0]);
                    DateTime fecha = DateTime.Parse(marca[1]);
                    // Otros datos de la marca...

                    // Realiza el cálculo de la planilla para esta marca específica
                }
            }

        }

        private void CalculoPlanillas_Load(object sender, EventArgs e)
        {

        }
    }
}
