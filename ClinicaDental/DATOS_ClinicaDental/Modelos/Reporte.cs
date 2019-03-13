using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_ClinicaDental.Modelos
{
    public class Reporte
    {
        [AutoIncrement]
        public int IdReporte { get; set; }
        public int IdTipoReporte { get; set; }
        public string Descripcion { get; set; }
        public int TotalCitas { get; set; }
        public int CitasCanceladas { get; set; }
        public int CitasExitosas { get; set; }
    }
}
