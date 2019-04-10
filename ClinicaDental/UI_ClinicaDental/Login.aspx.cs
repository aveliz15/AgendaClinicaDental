using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_ClinicaDental.Interfaces;
using BLL_ClinicaDental.Metodos;

namespace UI_ClinicaDental
{
    public partial class Login : System.Web.UI.Page
    {
        IUsuario iusu;
   

        protected void Page_Load(object sender, EventArgs e)
        {

         iusu = new MUsuario();

        }

        public void Limpiar()
        {
            txtContra.Text = string.Empty;
            txtIdUsuario.Text = string.Empty;
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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

    
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                 var admin = iusu.Login(Convert.ToInt32(txtIdUsuario.Text), Encriptacion.Encriptar(txtContra.Text));

                 
                     if (admin != null)
                     {
                         MostrarMensaje("Sesion iniciada correctamente"); 
                         System.Threading.Thread.Sleep(3000);
                         Session["usuario"] = admin.Nombre;
                         Session["id"] = admin.IdUsuario;
                         Session["contra"] = Encriptacion.Decriptar(admin.Clave);
                         Session["rol"] = admin.IdRol;
                        
                         if (admin.IdRol == 0)
                         {
                             Response.Redirect("IndexDentista.aspx");
                         }
                         else if(admin.IdRol == 1)
                         {
                             Response.Redirect("IndexSecretaria.aspx");
                         }

                     }
                     else
                     {
                         MostrarMensajeError("Usuario o contraseña invalidas");
                     }
            }
            catch (Exception)
            {
                
                MostrarMensajeError("Ha ocurrido un error, intente de nuevo");
            }
            
           
       

}
        }
}