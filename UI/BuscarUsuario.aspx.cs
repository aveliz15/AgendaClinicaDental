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
    public partial class BuscarUsuario : System.Web.UI.Page
    {
        public Usuario u;
        IUsuario iusu;
        public List<Usuario> lista;
        public BuscarUsuario()
        {
            iusu= new MUsuario();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {

            lista= iusu.ListarUsuarios();
            GV1.DataSource = lista;
            GV1.DataBind();
            GV1.HeaderRow.Cells[6].Visible = false;
            GV1.HeaderRow.Cells[0].Text = "ID Usuario";
            GV1.HeaderRow.Cells[2].Text = "Primer apellido"; 
                GV1.HeaderRow.Cells[3].Text = "Segundo apellido";
                GV1.HeaderRow.Cells[5].Text = "ID Rol";
                GV1.HeaderRow.Cells[7].Text = "Correo";
            
                for (int w = 0; w < GV1.Rows.Count; w++)
			{
			 GV1.Rows[w].Cells[6].Visible = false;
			}
            
                
                 divMantenimiento.Visible = false;
                 ListItem i;
                 i = new ListItem("Dentista", "1");
                 DDLRol.Items.Add(i);
                 i = new ListItem("Asistente", "2");
                 DDLRol.Items.Add(i);

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
        
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                u = iusu.BuscarUsuario(Convert.ToInt32(txtIdCliente.Text));
                if (u!=null)
                {
                     MostrarMensaje("Usuario encontrado correctamente");
                     divMantenimiento.Visible = true;
                     txtIdUsuario.Text = u.IdUsuario.ToString();
                     txtIdUsuario.ReadOnly = true;
                     txtNombre.Text = u.Nombre;
                     txtApellido1.Text = u.Apellido1;
                     txtApellido2.Text = u.Apellido2;
                     txtDireccion.Text = u.Direccion;
                     txtCorreo.Text = u.Correo;
                     buscar.Visible = false;
                     gridview.Visible = false;
                }
                else
                {
                    MostrarMensajeError("El usuario solicitado no existe, intente de nuevo");
                }
                }
               
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }


        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            divMantenimiento.Visible = false;
            buscar.Visible = true;
            gridview.Visible = true;
            mensaje.Visible = false;
        }

        public int rol;
        protected void Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (DDLRol.SelectedIndex == 0)
                {
                    rol = 0;
                }
                else if (DDLRol.SelectedIndex == 1)
                {
                    rol = 1;
                }
                u = iusu.BuscarUsuario(Convert.ToInt32(txtIdCliente.Text));
              Usuario usuario = new Usuario
                {

                    IdUsuario = u.IdUsuario,
                    Nombre = txtNombre.Text,
                    Apellido1 = txtApellido1.Text,
                    Apellido2 = txtApellido2.Text,
                    Direccion = txtDireccion.Text,
                    IdRol = rol,
                    Clave = u.Clave,
                    Correo = txtCorreo.Text

                };
               
                iusu.ActualizarUsuario(usuario);
                MostrarMensaje("Usuario modificado correctamente!");
                divMantenimiento.Visible = false;
                buscar.Visible = true;
                gridview.Visible = true;
                this.mensaje.Visible = false;
            }
            catch (Exception ee)
            {

                MostrarMensajeError(ee.ToString());
            }
           
        }


    }
}