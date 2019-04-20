using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DATOS_ClinicaDental.Modelos
{
    public class Diagnostico
    {
        [AutoIncrement]
        public int IdDiagnostico { get; set; }
        public int IdPaciente { get; set; }
        public int IdDiente { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
    }
}
