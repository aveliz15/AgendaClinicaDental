using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack.OrmLite;
using DATOS_ClinicaDental.Modelos;
using DLL_ClinicaDental.Interfaces;
using DAL_ClinicaDental;

namespace DLL_ClinicaDental.Metodos
{
    public class MPaciente: IPaciente
    {
        private OrmLiteConnectionFactory _conexion;
        private System.Data.IDbConnection _db;


          public MPaciente()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }


          public List<DATOS_ClinicaDental.Modelos.Paciente> ListarPacientes()
          {
              return _db.Select<Paciente>();
          }

          public DATOS_ClinicaDental.Modelos.Paciente BuscarPaciente(int IdPaciente)
          {
              return _db.Select<Paciente>(x => x.IdPaciente == IdPaciente)
                   .FirstOrDefault();
          }

          public void InsertarPaciente(DATOS_ClinicaDental.Modelos.Paciente paciente)
          {
              _db.Insert(paciente);
          }



          public void ActualizarPaciente(DATOS_ClinicaDental.Modelos.Paciente paciente)
          {
              _db.Update(paciente);
          }

          public void EliminarPaciente(int IdPaciente)
          {
              _db.Delete(IdPaciente);
          }
    }
}
