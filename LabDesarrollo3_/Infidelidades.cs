using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDesarrollo3
{
    internal class Infidelidades
    {
        public string NombreAfectado { get; set; }
        public string ApellidosAfectado { get; set; }
        public string NombreInfiel { get; set; }
        public string ApellidoInfiel{ get; set; }
        public char SexoAfectado { get; set; }
        public char SexoInfiel { get; set; }
        public DateTime FechaEvento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string EstadoPareja { get; set; }
        public int PrimeraVez { get; set; }

    }
}
