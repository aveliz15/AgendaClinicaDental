using BLL_ClinicaDental.Interfaces;
using BLL_ClinicaDental.Metodos;
using DATOS_ClinicaDental.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UI_ClinicaDental
{
    public partial class ModificarPacienteS : System.Web.UI.Page
    {
         public IPaciente usu;

        public ModificarPacienteS()
        {
            usu = new MPaciente();
        }


   
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {

               
                    divMantenimiento.Visible = false;
                    ListItem i;
                    i = new ListItem("Niño", "1");
                    DDLTipoOntograma.Items.Add(i);
                    i = new ListItem("Adulto", "2");
                    DDLTipoOntograma.Items.Add(i);
                    //int admin = Convert.ToInt32(Session["id"]);                   

                  
                    

                }
            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error al cargar los datos, intente mas tarde");
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

        public void Limpiar()
        {
            txtApellido1.Text = String.Empty;
            txtApellido2.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtIdPaciente.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtIdPaciente.Text = String.Empty;
            txtTelefono.Text = String.Empty;


        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipo;
                if (DDLTipoOntograma.SelectedIndex == 0)
                {
                    tipo = 0;
                }
                else
                {
                    tipo = 1;
                }

                IPaciente ipaciente = new MPaciente();
                DATOS_ClinicaDental.Modelos.Paciente paciente = new DATOS_ClinicaDental.Modelos.Paciente
                {

                    IdPaciente = Convert.ToInt32(txtIdPaciente.Text),
                    Nombre = txtNombre.Text,
                    Apellido1 = txtApellido1.Text,
                    Apellido2 = txtApellido2.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text,
                    FechaNacimiento = Convert.ToDateTime(txtFecha.Text),
                    IdTipoOntograma = tipo
                };
               
                usu.ActualizarPaciente(paciente);
                buscar.Visible = true;
                divMantenimiento.Visible = false;
                MostrarMensaje("Paciente modificado con éxito");
                ttIdPaciente.Text = String.Empty;
            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(ttIdPaciente.Text);
           Paciente u = usu.BuscarPaciente(id);
           txtIdPaciente.Text = u.IdPaciente.ToString();
           txtApellido1.Text = u.Apellido1;
           txtApellido2.Text = u.Apellido2;
           txtCorreo.Text = u.Correo;
              
           txtFecha.Text =  Convert.ToDateTime(u.FechaNacimiento).ToShortDateString();
           txtNombre.Text = u.Nombre;
           txtTelefono.Text = u.Telefono;
           txtIdPaciente.ReadOnly = true;
           divMantenimiento.Visible = true;
           buscar.Visible = false;
           txtFecha.ReadOnly = true;
        }
    }
}