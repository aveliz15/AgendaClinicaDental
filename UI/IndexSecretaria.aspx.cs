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
    public partial class IndexSecretaria : System.Web.UI.Page
    {
        public IUsuario usu = new MUsuario();
        public Usuario c;
        protected void Page_Load(object sender, EventArgs e)
        {
            int admin = Convert.ToInt32(Session["id"]);
            Usuario c = usu.BuscarUsuario(admin);
            LblUsuario.Text = c.Nombre + " " + c.Apellido1.ToString();
        }
    }
}