using DB;
using Model;
using ProyectoBases.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyectoBases
{
    
    public partial class ModificarEmpleado : Form

    {
        private string con;
        string connectionstring;
        public ModificarEmpleado(string con)

        {

            InitializeComponent();
            opcionPlanta();

            // dias (entrada/salida)
            dateTimeEntrada.Format = DateTimePickerFormat.Custom;
            dateTimeEntrada.CustomFormat = "yyyy-MM-dd";
            dateTimeSalida.Format = DateTimePickerFormat.Custom;
            dateTimeSalida.CustomFormat = "yyyy-MM-dd";
            //horas (entradas/ salidas)
            horainicial.Format = DateTimePickerFormat.Custom;
            horainicial.CustomFormat = "HH: mm: ss";
            horafinal.Format = DateTimePickerFormat.Custom;
            horafinal.CustomFormat = "HH: mm: ss";

        }

        public int idEmpleado;



        public void recibeIdEmpleado(int id)
        {
            idEmpleado = id;

        }
        public void conexion(String nombre)
        {
            if (nombre == "Guayabo")
            {
                connectionstring = Utils.Constantes.ConnectionString;
            }
            else if (nombre == "Central")
            {
                connectionstring = Utils.Constantes.ConnectionString2;
            }
            else if (nombre == "La Romana")
            {
                connectionstring = Utils.Constantes.ConnectionString3;
            }

        }

        public void opcionPlanta()
        {
            conexion(con);
            //tipo empleado
            TipoEmpleadoDB tipoEmpleadoDB = new TipoEmpleadoDB();
            String[] tiposEmpleados = tipoEmpleadoDB.VerNombreTipos(connectionstring).ToArray();
            cargoCB.Items.Clear();
            cargoCB.Items.AddRange(tiposEmpleados);

            //departamento
            DepartamentoDB DepaDB = new DepartamentoDB();
            String[] Depa = DepaDB.VerNombreDep(connectionstring).ToArray();
            DepCB.Items.Clear();
            DepCB.Items.AddRange(Depa);

            //calendario 
            CalendarioLaboralDB CalDB = new CalendarioLaboralDB();
            String[][] Cal = CalDB.VerCalendarioLaboral(connectionstring).ToArray();


        }


        private void volver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void calendario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarRegistro_Click_1(object sender, EventArgs e)

        {
            try
            {
                using (SqlConnection connection = CorporacionBD.GetConnection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand command = new SqlCommand("ModificarDatosEmpleado", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        CorporacionDB cor = new CorporacionDB();
                        string planta = plantaCB.SelectedItem.ToString();
                        int horaInicio = horainicial.Value.Hour;
                        int horaFinal = horafinal.Value.Hour;
                        int idPlanta = cor.Planta(plantaCB.SelectedItem.ToString());
                        int idCalendario = cor.calendario(calendario.SelectedItem.ToString(), planta);
                        int idTipoEmpleado = cor.tipoEmpleado(cargoCB.SelectedItem.ToString(), planta);


                        command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                        command.Parameters.AddWithValue("@nombre", NombreText.Text + ApellidoText.Text);
                        command.Parameters.AddWithValue("@fecha_ingreso", dateTimeEntrada.Value.Date);
                        command.Parameters.AddWithValue("@fecha_salida", dateTimeSalida.Value.Date);
                        command.Parameters.AddWithValue("@horaInicio", horaInicio);
                        command.Parameters.AddWithValue("@horaFinal", horaFinal);
                        command.Parameters.AddWithValue("@tipo_empleado_id", idTipoEmpleado);
                        command.Parameters.AddWithValue("@id_calendario", idCalendario);
                        command.Parameters.AddWithValue("@departamento", DepCB.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@supervisor", Convert.ToInt32(textBox1.Text));
                        command.Parameters.AddWithValue("@planta", idPlanta);
                        command.ExecuteNonQuery();


                        MessageBox.Show($"Datos guardados correctamente:\n" +
                        $"Nombre: {NombreText.Text + ApellidoText.Text}\n" +
                        $"Fecha de Ingreso: {dateTimeEntrada.Value.Date}\n" +
                        $"Fecha de Salida: {dateTimeSalida.Value.Date}\n" +
                        $"Hora de Inicio: {horaInicio}\n" +
                        $"Hora Final: {horaFinal}\n"+
                        $"tipo_empleado_id: {idTipoEmpleado}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void DepCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargoCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}



