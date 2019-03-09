using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_ClinicaDental.Interfaces;

namespace DLL_ClinicaDental.Metodos
{
    public class MUsuario: IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private System.Data.IDbConnection _db;


          public MUsuario()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion,
                SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

          public List<DATOS_ClinicaDental.Modelos.Usuario> ListarUsuarios()
          {
              throw new NotImplementedException();
          }

          public DATOS_ClinicaDental.Modelos.Usuario BuscarUsuario(int IdUsuario)
          {
              throw new NotImplementedException();
          }

          public void InsertarUsuario(DATOS_ClinicaDental.Modelos.Usuario Usuario)
          {
              throw new NotImplementedException();
          }

          public DATOS_ClinicaDental.Modelos.Usuario Login(int IdUsuario, string password)
          {
              throw new NotImplementedException();
          }

          public void ActualizarUsuario(DATOS_ClinicaDental.Modelos.Usuario Usuario)
          {
              throw new NotImplementedException();
          }

          public void EliminarUsuario(int IdUsuario)
          {
              throw new NotImplementedException();
          }
    }
}
