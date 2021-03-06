﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_ClinicaDental.Interfaces;
using BLL_ClinicaDental.Metodos;
using DATOS_ClinicaDental.Modelos;

namespace UI_ClinicaDental
{
    public partial class InsertarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            ListItem i;
            i = new ListItem("Dentista", "1");
            DDLRol.Items.Add(i);
            i = new ListItem("Asistente", "2");
            DDLRol.Items.Add(i);
            }
           
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtApellido1.Text = String.Empty;
            txtApellido2.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtIdUsuario.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtClave.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            
        }
        private void MostrarMensaje(string texto)
        {
            mensaje.Visible = true;
            mensajeError.Visible = false;
            textoMensajeError.InnerHtml = string.Empty;
            textoMensaje.InnerHtml = texto;
        }

        private void MostrarMensajeError(string texto)
        {
            mensaje.Visible = false;
            mensajeError.Visible = true;
            textoMensajeError.InnerHtml = texto;
            textoMensaje.InnerHtml = string.Empty;
        }

        protected void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int rol;
                if (DDLRol.SelectedIndex == 0)
                {
                    rol = 0;
                }else{
                    rol = 1;
                }
                IUsuario iusuario = new MUsuario();
                string clave;
                if (txtClave.Text == txtValidarClave.Text)
                {
                    clave = Encriptacion.Encriptar(txtClave.Text);
                    DATOS_ClinicaDental.Modelos.Usuario usuario = new DATOS_ClinicaDental.Modelos.Usuario
                    {

                        IdUsuario = Convert.ToInt32(txtIdUsuario.Text),
                        Nombre = txtNombre.Text,
                        Apellido1 = txtApellido1.Text,
                        Apellido2 = txtApellido2.Text,
                        Direccion = txtDireccion.Text,
                        IdRol = rol,
                        Clave = clave,
                        Correo = txtCorreo.Text
       
                    };
                    iusuario.InsertarUsuario(usuario);
                    MostrarMensaje("Usuario insertado correctamente!");
                    Limpiar();

                }
                else
                {
                    MostrarMensajeError("Las contraseñas no coinciden, intente de nuevo");
                }
            }
            catch (Exception)
            {

                MostrarMensajeError("Ocurrio un error");
            }

        }

    }
}