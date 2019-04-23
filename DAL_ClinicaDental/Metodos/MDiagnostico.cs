using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_ClinicaDental.Interfaces;
using DAL_ClinicaDental;

using ServiceStack.OrmLite;
using DATOS_ClinicaDental.Modelos;

namespace DLL_ClinicaDental.Metodos
{
    public class MDiagnostico: IDiagnostico
    {
        private OrmLiteConnectionFactory _conexion;
        private System.Data.IDbConnection _db;


        public MDiagnostico()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarDiagnostico(Diagnostico diagnostico)
        {
            _db.Update(diagnostico);
        }

        public Diagnostico BuscarDiagnostico(int IdDiagnostico)
        {
            return _db.Select<Diagnostico>(x => x.IdDiagnostico == IdDiagnostico)
                 .FirstOrDefault();
        }

        public void EliminarDiagnostico(int IdDiagnostico)
        {
            _db.Delete(IdDiagnostico);
        }

        public void InsertarDiagnostico(Diagnostico diagnostico)
        {
            _db.Insert(diagnostico);
        }

        public List<Diagnostico> ListarDiagnostico()
        {
            return _db.Select<Diagnostico>();
        }

        public List<Diagnostico> ListarDiagnostico(int idPaciente, int idDiente)
        {
            return _db.Select<Diagnostico>().Where(p=>p.IdPaciente==idPaciente && p.IdDiente== idDiente).ToList();
        }

        public List<Diagnostico> ListarDiagnosticoMarca(int idPaciente)
        {
            return _db.Select<Diagnostico>().Where(p => p.IdPaciente == idPaciente ).ToList();
        }
    }
}
