using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS_ClinicaDental.Modelos;

namespace DLL_ClinicaDental.Interfaces
{
    public interface IDiagnostico
    {

        List<Diagnostico> ListarDiagnostico();
        List<Diagnostico> ListarDiagnostico(int idPaciente, int idDiente);

        List<Diagnostico> ListarDiagnosticoMarca(int idPaciente);
        Diagnostico BuscarDiagnostico(int IdDiagnostico);
        void InsertarDiagnostico(Diagnostico diagnostico);

        void ActualizarDiagnostico(Diagnostico diagnostico);
        void EliminarDiagnostico(int IdDiagnostico);

    }
}
