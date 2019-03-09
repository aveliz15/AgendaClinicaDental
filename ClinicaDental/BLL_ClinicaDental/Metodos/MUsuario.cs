using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using BLL_ClinicaDental.Interfaces;
using DATOS_ClinicaDental.Modelos;


namespace BLL_ClinicaDental.Metodos
{
    public class MUsuario: IUsuario
    {
         private DLL_ClinicaDental.Interfaces.IUsuario usu;

         public MUsuario()
        {
            usu = new DLL_ClinicaDental.Metodos.MUsuario();
        }

         public List<Usuario> ListarUsuarios()
         {
             throw new NotImplementedException();
         }

         public Usuario BuscarUsuario(int IdUsuario)
         {
             throw new NotImplementedException();
         }

         public void InsertarUsuario(Usuario Usuario)
         {
             throw new NotImplementedException();
         }

         public Usuario Login(int IdUsuario, string password)
         {
             throw new NotImplementedException();
         }

         public void ActualizarUsuario(Usuario Usuario)
         {
             throw new NotImplementedException();
         }

         public void EliminarUsuario(int IdUsuario)
         {
             throw new NotImplementedException();
         }
    }
}
