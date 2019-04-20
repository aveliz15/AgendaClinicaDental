
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_ClinicaDental.Interfaces;
using BLL_ClinicaDental.Metodos;
using DATOS_ClinicaDental.Modelos;
using SimpleCrypto;

using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace UI_ClinicaDental
{
    public partial class RecuperarPassword : System.Web.UI.Page
    {

        public IUsuario usu;

        public RecuperarPassword()
        {
            usu = new MUsuario();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
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
        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            int usuario = Convert.ToInt32(txtUsuario.Text.Trim());

            Usuario c = usu.BuscarUsuario(usuario);

            if (c != null)
            {
                ICryptoService cryptoService = new PBKDF2();

                string nuevaPass = RandomPassword.Generate(10,PasswordGroup.Uppercase, PasswordGroup.Numeric);
                string nuevaPassEncr = Encriptacion.Encriptar(nuevaPass);

                try
                {
                    
                    usu.ActualizarClave(nuevaPassEncr,c.IdUsuario);
                    EnviarEmail(c.Correo,nuevaPass);
                    MostrarMensaje("Correo Enviado con exito");
                }
                catch (Exception)
                {

                    MostrarMensajeError("Error al enviar el correo, intente mas tarde");
                }
            }
            else
            {
                MostrarMensajeError("El usuario no existe");
            }
        }

       protected void EnviarEmail(string EnviarA , string contraseniaRecuperar)
        {
            string correoAdm = ConfigurationManager.AppSettings["correoElectronico"].ToString();
            string claveAdm = ConfigurationManager.AppSettings["ClaveCorreo"].ToString();
            string asunto = "Recuperacion de Contraseña Clinica Virtual";
            string body = "Su nueva contraseña para el ingreso en la Clinica Virtual es: " + contraseniaRecuperar + " ";

            var smtp = new SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587; //587 o 25
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(correoAdm,claveAdm);
                smtp.Timeout = 20000;
            }

            try
            {
                smtp.Send(correoAdm, EnviarA, asunto, body);
            }
            catch (Exception)
            {

                MostrarMensajeError("No se logro enviar");
            }

        }
    }
}