using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Planillas
    {
        public int IdPlanilla { get; set; }
        public int IdEmpleado { get; set; }
        public int IdPlanta { get; set; }
        public bool Estado { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal SalarioNeto { get; set; }
        public decimal PorcentajeObligaciones { get; set; }
    }
}