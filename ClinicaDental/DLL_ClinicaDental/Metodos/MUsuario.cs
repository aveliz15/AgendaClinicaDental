using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_ClinicaDental.Interfaces;
using DATOS_ClinicaDental.Modelos;

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
              return _db.Select<Usuario>();
          }

          public DATOS_ClinicaDental.Modelos.Usuario BuscarUsuario(int IdUsuario)
          {
              return _db.Select<Usuario>(x => x.IdUsuario == IdUsuario)
                   .FirstOrDefault();
          }

          public void InsertarUsuario(DATOS_ClinicaDental.Modelos.Usuario Usuario)
          {
              _db.Insert(Usuario);
          }

          public DATOS_ClinicaDental.Modelos.Usuario Login(int IdUsuario, string password)
          {
              return _db.Select<Usuario>(x => x.IdUsuario == IdUsuario && x.Clave == password).FirstOrDefault();
          }

          public void ActualizarUsuario(DATOS_ClinicaDental.Modelos.Usuario Usuario)
          {
              _db.Update(Usuario);
          }
        public void ActualizarClave(string clave,int idUsuario)
        {
             Usuario c = BuscarUsuario(idUsuario);
                c.Clave = clave;
            
            _db.Update(c);
        }
        public void EliminarUsuario(int IdUsuario)
          {
              _db.Delete(IdUsuario);
          }
    }
}
