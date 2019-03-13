using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_ClinicaDental.Modelos
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdTipoCita { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
    }
}
