using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DiasFeriados
    {
        public int IdDia { get; set; }
        public int IdCalendario { get; set; }
        public DateTime Fecha { get; set; }
        public string Etiqueta { get; set; }
    }
}