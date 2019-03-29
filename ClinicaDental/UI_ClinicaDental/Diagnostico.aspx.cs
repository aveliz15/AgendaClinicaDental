using BLL_ClinicaDental.Interfaces;
using BLL_ClinicaDental.Metodos;
using DATOS_ClinicaDental.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI_ClinicaDental
{
    public partial class Diagnostico : System.Web.UI.Page
    {

        public IPaciente usu;
        public IDiagnostico diag;
        int id;

        public Diagnostico()
        {
            usu = new MPaciente();
            
        }
       

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    divOdontograma.Visible = true;//Ponerlo en false al terminar de programar
                               




                }
            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error al cargar los datos, intente mas tarde");
            }


        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
             id = Convert.ToInt32(ttIdPaciente.Text);
            Paciente u = usu.BuscarPaciente(id);
            tituloPaciente.InnerText = "Paciente: "+ u.Nombre +" "+u.Apellido1+" "+ u.Apellido2+"";
            divOdontograma.Visible = true;

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

        private void MarcarDiente(int idDiente,string boton)
        {
         
            foreach (var item in diag.ListarDiagnosticoMarca(id))
            {
              //haga la magia de pintarlos
            }
           


        }
        private void CrearDiagnostico(int diente,int Paciente)
        {
            //falta

        }

        private void MostrarDiagnosticos(int idDiente)
        {

            //falta
        }


        //Botones
        protected void btnD1_Click(object sender, EventArgs e)
        {

        }

        protected void btnD2_Click(object sender, EventArgs e)
        {

        }

        protected void btnD3_Click(object sender, EventArgs e)
        {

        }

        //Seguir copiando hasta tener todos los botones cuando ya tenga el metodo de uno listp
    }
}