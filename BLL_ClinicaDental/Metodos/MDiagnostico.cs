using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_ClinicaDental.Interfaces;
using DATOS_ClinicaDental.Modelos;

namespace BLL_ClinicaDental.Metodos
{
    public class MDiagnostico : IDiagnostico
    {
       
        private DLL_ClinicaDental.Interfaces.IDiagnostico usu;
        public MDiagnostico()
        {
            usu = new DLL_ClinicaDental.Metodos.MDiagnostico();
        }
        public void ActualizarDiagnostico(Diagnostico diagnostico)
        {
            
        }

        public Diagnostico BuscarDiagnostico(int IdDiagnostico)
        {
            return usu.BuscarDiagnostico(IdDiagnostico);
        }

        public void EliminarDiagnostico(int IdDiagnostico)
        {
            usu.EliminarDiagnostico(IdDiagnostico);
        }

        public void InsertarDiagnostico(Diagnostico diagnostico)
        {
            usu.InsertarDiagnostico(diagnostico);
        }

        public List<Diagnostico> ListarDiagnostico()
        {
            return usu.ListarDiagnostico();
        }

        public List<Diagnostico> ListarDiagnostico(int idPaciente, int idDiente)
        {
            return usu.ListarDiagnostico(idPaciente,idDiente);
        }

        public List<Diagnostico> ListarDiagnosticoMarca(int idPaciente)
        {
            return usu.ListarDiagnosticoMarca(idPaciente);
        }
    }
}
