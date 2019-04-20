using BLL_ClinicaDental.Interfaces;
using BLL_ClinicaDental.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI_ClinicaDental
{
    public partial class InsertarPacienteS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem i;
                i = new ListItem("Niño", "1");
                DDLTipoOntograma.Items.Add(i);
                i = new ListItem("Adulto", "2");
                DDLTipoOntograma.Items.Add(i);
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

        protected void btnInsertarPaciente_Click(object sender, EventArgs e)
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
                ipaciente.InsertarPaciente(paciente);
                MostrarMensaje("Paciente insertado correctamente!");
                Limpiar();


            }
            catch (Exception ee)
            {

                MostrarMensajeError(ee.ToString());
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
            txtCorreo.Text = String.Empty;
            txtIdPaciente.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtIdPaciente.Text = String.Empty;
            txtTelefono.Text = String.Empty;


        }
    }
}