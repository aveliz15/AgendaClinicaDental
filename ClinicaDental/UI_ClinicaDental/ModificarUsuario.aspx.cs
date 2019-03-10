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
    public partial class ModificarUsuario : System.Web.UI.Page
    {

        public IUsuario usu;

        public ModificarUsuario()
        {
            usu = new MUsuario();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (!IsPostBack)
                {
                      // int admin = Convert.ToInt32(Session["id"]);

                    int admin = Convert.ToInt32(Session["id"]);
                    Usuario c = usu.BuscarUsuario(admin);

                    txtIdUsuario.Text = c.IdUsuario.ToString();
                    txtNombre.Text = c.Nombre;
                    txtApellido1.Text = c.Apellido1.ToString();
                    txtApellido2.Text = c.Apellido2;
                    txtDireccion.Text = c.Direccion;
                    txtRol.Text = c.IdRol.ToString();
                }
                else
                {
                    // Every Time Load When Any click button in page
                }
              
               
            }
            catch (Exception)
            {
                MostrarMensajeError("No se han podido cargar los datos, intente mas tarde");
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Hago la busqueda para obtener la clave
                
                int admin = Convert.ToInt32(Session["id"]);

                Usuario c = usu.BuscarUsuario(admin);

                string clave = c.Clave;

                //Creo el objeto
                Usuario usuario2 = new Usuario
                {
                    IdUsuario = c.IdUsuario,
                    Nombre = txtNombre.Text,
                    Apellido1 = txtApellido1.Text,
                    Apellido2 = txtApellido2.Text,
                    Direccion = txtDireccion.Text,
                    IdRol = Convert.ToInt32(c.IdRol),
                    Clave = c.Clave            
                };

                //Actializo el objeto
                usu.ActualizarUsuario(usuario2);
                         
                MostrarMensaje("Usuario Modificado");

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