using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CalendarioLaboral
    {
        public int IdCalendario { get; set; }
        public string Nombre { get; set; }
        public decimal PagoHora { get; set; }
        public decimal PagoHoraExtra { get; set; }
        public decimal PagoHoraDoble { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFinal { get; set; }
        public int TipoPago { get; set; }
    }
}
