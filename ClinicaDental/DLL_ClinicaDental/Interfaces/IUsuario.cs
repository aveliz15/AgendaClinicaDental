﻿using DATOS_ClinicaDental.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_ClinicaDental.Interfaces
{
    public interface IUsuario
    {
        List<Usuario> ListarUsuarios();
        Usuario BuscarUsuario(int IdUsuario);
        void InsertarUsuario(Usuario Usuario);
        Usuario Login(int IdUsuario, string password);
        void ActualizarUsuario(Usuario Usuario);
        void EliminarUsuario(int IdUsuario);
    }
}
