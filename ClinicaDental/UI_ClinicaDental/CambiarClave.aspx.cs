using System;
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
    public partial class CambiarClave : System.Web.UI.Page
    {


  public IUsuario usu;

    public CambiarClave()
    {
        usu = new MUsuario();
    }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCambiarClave_Click(object sender, EventArgs e)
        {
            try
            {
                //Hago la busqueda para obtener la clave

                int admin = Convert.ToInt32(Session["id"]); 

                Usuario c = usu.BuscarUsuario(admin);

                string clave = Encriptacion.Decriptar(c.Clave);
                
                //Creo el objeto

                if (txtNuevaClave.Text == txtNuevaClave2.Text & txtClaveActual.Text == clave)
                {
                    Usuario usuario2 = new Usuario
                    {
                        IdUsuario = c.IdUsuario,
                        Nombre = c.Nombre,
                        Apellido1 = c.Apellido1,
                        Apellido2 = c.Apellido2,
                        Direccion = c.Direccion,
                        IdRol = Convert.ToInt32(c.IdRol),
                        Clave = Encriptacion.Encriptar(txtNuevaClave.Text)

                };

                //Actializo el objeto
                usu.ActualizarUsuario(usuario2);

                MostrarMensaje("Contraseña cambiada con exito");

                }
                else
                {
                    MostrarMensajeError("Los campos de contraseña nueva o actual no coinciden, intente de nuevo");
                }
            }
            catch (Exception ex)
            {
                MostrarMensajeError("Ocurrio un error");

            }
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

    }
}