using Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBases.DB
{
    public class SinConexion
    {

        string insertarPlanilla = "insertarPlanilla.txt";
        string editarPlanilla = "editarPlanilla.txt";
        string eliminarPlanilla = "eliminarPlanilla.txt";

        string insertarEmpleados = "insertarEmpleados.txt";
        string editarEmpleados = "editarEmpleados.txt";
        string eliminarEmpleados = "eliminarEmpleados.txt";



        //PLANILLA--------------------------------------------------------------------------------------------------------------------------------------------

        public void exportarPlanilla(Planillas planilla, int accion)
        {
            String path = "";
            switch (accion)
            {
                case 0:
                    path = insertarPlanilla; break;
                case 1:
                    path = editarPlanilla; break;
            }
            try
            {

                {
                    if (!File.Exists(path))
                    {
                        using (FileStream fs = File.Create(path))
                        {
                            Console.WriteLine("File" + path + "created successfully.");
                        }
                    }


                    using (StreamWriter writer = File.AppendText(path))
                    {

                        string[] datosPlanilla = {
                        planilla.IdPlanilla.ToString(),
                        planilla.IdEmpleado.ToString(),
                        planilla.IdPlanta.ToString(),
                        planilla.Estado.ToString(),
                        planilla.SalarioBruto.ToString(),
                        planilla.SalarioNeto.ToString(),
                        planilla.PorcentajeObligaciones.ToString()
                    };

                        string nuevaLinea = string.Join(",", datosPlanilla);
                        writer.WriteLine(nuevaLinea);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void importarPlanilla(string connectionString, int accion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    String path = "";
                    switch (accion)
                    {
                        case 0:
                            path = insertarPlanilla; break;
                        case 1:
                            path = editarPlanilla; break;
                    }

                    using (StreamReader reader = new StreamReader(path))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] columns = line.Split(',');

                            Planillas p = new Planillas();

                            p.IdPlanilla = Convert.ToInt32(columns[0]);
                            p.IdEmpleado = Convert.ToInt32(columns[1]);
                            p.IdPlanta = Convert.ToInt32(columns[2]);
                            p.Estado = columns[3].Equals("true");
                            decimal temp;
                            if (decimal.TryParse(columns[4], out temp))
                            {
                                p.SalarioBruto = temp;
                            }
                            if (decimal.TryParse(columns[5], out temp))
                            {
                                p.SalarioNeto = temp;
                            }
                            if (decimal.TryParse(columns[6], out temp))
                            {
                                p.PorcentajeObligaciones = temp;
                            }

                            DB.CorporacionDB corp = new CorporacionDB();

                            switch (accion)
                            {
                                case 0:
                                    corp.insertarPlanilla(p);
                                    break;
                                case 1:
                                    corp.modificarPlanilla(p);//
                                    break;
                            }
                        }
                        File.WriteAllText(path, string.Empty);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void exportarPlanillaEliminada(int IdPlanilla, int IdPlanta)
        {
            try
            {

                if (!File.Exists(eliminarPlanilla))
                {
                    using (FileStream fs = File.Create(eliminarPlanilla))
                    {
                        Console.WriteLine("File" + eliminarPlanilla + "created successfully.");
                    }
                }

                using (StreamWriter writer = File.AppendText(eliminarPlanilla))
                {

                    string[] datosPlanilla = {
                        IdPlanilla.ToString(),
                        IdPlanta.ToString()
                    };

                    string nuevaLinea = string.Join(",", datosPlanilla);
                    writer.WriteLine(nuevaLinea);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void importarPlanillaEliminada(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    using (StreamReader reader = new StreamReader(eliminarPlanilla))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] columns = line.Split(',');

                            Planillas p = new Planillas();

                            p.IdPlanilla = Convert.ToInt32(columns[0]);
                            p.IdPlanta = Convert.ToInt32(columns[1]);

                            DB.CorporacionDB corp = new CorporacionDB();
                            corp.eliminarPlanilla(p.IdPlanilla);
                            break;
                            
                        }
                        File.WriteAllText(eliminarPlanilla, string.Empty);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }



        //EMPLEADOS-------------------------------------------------------------------------------------------------------------------------------------------
        public void exportarEmpleado(Empleado e, int accion)
        {
            try
            {
                String path = "";
                switch (accion)
                {
                    case 0:
                        path = insertarEmpleados; break;
                    case 1:
                        path = editarEmpleados; break;
                }

                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path))
                    {
                        Console.WriteLine("File" + path + "created successfully.");
                    }
                }


                using (StreamWriter writer = File.AppendText(path))
                {

                    string[] datosEmpleados = {
                        e.IdEmpleado.ToString(),
                        e.Nombre.ToString(),
                        e.FechaIngreso.ToString(),
                        e.FechaSalida.ToString(),
                        e.TipoEmpleadoId.ToString(),
                        e.IdCalendario.ToString(),
                        e.Departamento.ToString(),
                        e.Supervisor.ToString(),
                        e.Planta.ToString()
                    };

                    string nuevaLinea = string.Join(",", datosEmpleados);
                    writer.WriteLine(nuevaLinea);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void importarEmpleado(string connectionString, int accion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    String path = "";
                    switch (accion)
                    {
                        case 0:
                            path = insertarEmpleados; break;
                        case 1:
                            path = editarEmpleados; break;
                    }

                    using (StreamReader reader = new StreamReader(path))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] columns = line.Split(',');

                            Empleado e = new Empleado();
                            e.IdEmpleado = Convert.ToInt32(columns[0]);
                            e.Nombre = columns[1];
                            if (DateTime.TryParseExact(columns[2], "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime sd2))
                            {
                                e.FechaIngreso = sd2;
                            }
                            if (DateTime.TryParseExact(columns[3], "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime sd3))
                            {
                                e.FechaSalida = sd3;
                            }
                            e.TipoEmpleadoId = Convert.ToInt32(columns[4]);
                            e.IdCalendario = Convert.ToInt32(columns[5]);
                            e.Departamento = Convert.ToInt32(columns[6]);
                            e.Supervisor = Convert.ToInt32(columns[7]);
                            e.Planta = Convert.ToInt32(columns[8]);

                            DB.CorporacionDB corp = new CorporacionDB();

                            switch (accion)
                            {
                                case 0:
                                    corp.insertarEmpleado(e, connectionString);
                                    break;
                                case 1:
                                    corp.modificarEmpleado(e, connectionString);
                                    break;

                            }
                        }
                        File.WriteAllText(path, string.Empty);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void exportarEmpleadoEliminado(int empleadoID, int plantaID)
        {
            try
            {

                if (!File.Exists(eliminarEmpleados))
                {
                    using (FileStream fs = File.Create(eliminarEmpleados))
                    {
                        Console.WriteLine("File" + eliminarEmpleados + "created successfully.");
                    }
                }

                using (StreamWriter writer = File.AppendText(eliminarEmpleados))
                {

                    string[] datosEmpleados = {
                        empleadoID.ToString(),
                        plantaID.ToString()
                    };

                    string nuevaLinea = string.Join(",", datosEmpleados);
                    writer.WriteLine(nuevaLinea);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void importarEmpleadoEliminado(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (StreamReader reader = new StreamReader(eliminarEmpleados))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] columns = line.Split(',');

                            Empleado e = new Empleado();
                            e.IdEmpleado = Convert.ToInt32(columns[0]);
                            e.Planta = Convert.ToInt32(columns[1]);

                            DB.CorporacionDB corp = new CorporacionDB();
                            corp.eliminarEmpleado(e.IdEmpleado, connectionString);
                        }
                        File.WriteAllText(eliminarEmpleados, string.Empty);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }



    }

}
