using DATOS_ClinicaDental.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_ClinicaDental.Interfaces
{
    public interface IPaciente
    {
        List<Paciente> ListarPacientes();
        Paciente BuscarPaciente(int IdPaciente);
        void InsertarPaciente(Paciente paciente);
        
        void ActualizarPaciente(Paciente paciente);
        void EliminarPaciente(int IdPaciente);
    }
}
