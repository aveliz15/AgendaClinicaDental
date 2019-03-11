using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_ClinicaDental.Interfaces;

namespace BLL_ClinicaDental.Metodos
{
    public class MPaciente: IPaciente
    {
          private DLL_ClinicaDental.Interfaces.IPaciente usu;

         public MPaciente()
        {
            usu = new DLL_ClinicaDental.Metodos.MPaciente();
        }

         public List<DATOS_ClinicaDental.Modelos.Paciente> ListarPacientes()
         {
             return usu.ListarPacientes();
         }

         public DATOS_ClinicaDental.Modelos.Paciente BuscarPaciente(int IdPaciente)
         {
             return usu.BuscarPaciente(IdPaciente);
         }

         public void InsertarPaciente(DATOS_ClinicaDental.Modelos.Paciente paciente)
         {
             usu.InsertarPaciente(paciente);
         }


         public void ActualizarPaciente(DATOS_ClinicaDental.Modelos.Usuario paciente)
         {
             usu.ActualizarPaciente(paciente);
         }

         public void EliminarPaciente(int IdPaciente)
         {
             usu.EliminarPaciente(IdPaciente);
         }
    }
}
