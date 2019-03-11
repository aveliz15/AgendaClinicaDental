using DATOS_ClinicaDental.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ClinicaDental.Interfaces
{
    public interface IPaciente
    {
        List<Paciente> ListarPacientes();
        Paciente BuscarPaciente(int IdPaciente);
        void InsertarPaciente(Paciente paciente);
        void ActualizarPaciente(Usuario paciente);
        void EliminarPaciente(int IdPaciente);
    }
}
