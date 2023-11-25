using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int TipoEmpleadoId { get; set; }
        public int IdCalendario { get; set; }
        public string Departamento { get; set; }
        public int Supervisor { get; set; }
        public int Planta { get; set; }
    }
}
