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
             return usu.ListarUsuarios();
         }

         public Usuario BuscarUsuario(int IdUsuario)
         {
             return usu.BuscarUsuario(IdUsuario);
         }

         public void InsertarUsuario(Usuario Usuario)
         {
             usu.InsertarUsuario(Usuario);
         }

         public Usuario Login(int IdUsuario, string password)
         {
            return usu.Login(IdUsuario, password);
         }

         public void ActualizarUsuario(Usuario Usuario)
         {
             usu.ActualizarUsuario(Usuario);
         }

         public void EliminarUsuario(int IdUsuario)
         {
             usu.EliminarUsuario(IdUsuario);
         }
    }
}
