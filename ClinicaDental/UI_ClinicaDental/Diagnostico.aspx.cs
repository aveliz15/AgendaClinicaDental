using BLL_ClinicaDental.Interfaces;
using BLL_ClinicaDental.Metodos;
using DATOS_ClinicaDental.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI_ClinicaDental
{
    public partial class Diagnostico : System.Web.UI.Page
    {

        public IPaciente usu;
        public IDiagnostico diag = new MDiagnostico();
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
                    buscador.Visible = true;
                    divOdontogramaNiño.Visible = false;
                    divOdontogramaAdulto.Visible = false;

                }
            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error al cargar los datos, intente mas tarde");
            }


        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
            LimpiarDiente();
            divOdontogramaNiño.Visible = false;
            divOdontogramaAdulto.Visible = false;
            id = Convert.ToInt32(ttIdPaciente.Text);
            Paciente u = usu.BuscarPaciente(id);
            tituloPaciente.InnerText = "Paciente: "+ u.Nombre +" "+u.Apellido1+" "+ u.Apellido2+"";
           
            if (u.IdTipoOntograma==1)
            {
                divOdontogramaNiño.Visible = true;
                MarcarDiente();
                buscador.Visible = false;
            }
            else
            {
                divOdontogramaAdulto.Visible = true;
                MarcarDiente();
                buscador.Visible = false;
            }
           
            }
            catch (Exception)
            {

                MostrarMensajeError("El paciente no ha podido ser encontrado, intente de nuevo");
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

        private void MarcarDiente()
        {
            int dient;
            foreach (var item in diag.ListarDiagnosticoMarca(Convert.ToInt32(ttIdPaciente.Text)))
            {
                dient = item.IdDiente;
                switch (dient)
                {
                    case 1:
                        d1.BackColor = Color.Red;
                        break;
                    case 2:
                        d2.BackColor = Color.Red;
                        break;
                    case 3:
                        d3.BackColor = Color.Red;
                        break;
                    case 4:
                        d4.BackColor = Color.Red;
                        break;
                    case 5:
                        d5.BackColor = Color.Red;
                        break;
                    case 6:
                        d6.BackColor = Color.Red;
                        break;
                    case 7:
                        d7.BackColor = Color.Red;
                        break;
                    case 8:
                        d8.BackColor = Color.Red;
                        break;
                    case 9:
                        d9.BackColor = Color.Red;
                        break;
                    case 10:
                        d10.BackColor = Color.Red;
                        break;
                }
            }
           


        }

        public void LimpiarDiente()
        {
            d1.BackColor = Color.White;
            d2.BackColor = Color.White;
            d3.BackColor = Color.White;
            d4.BackColor = Color.White;
            d5.BackColor = Color.White;
            d6.BackColor = Color.White;
            d7.BackColor = Color.White;
            d8.BackColor = Color.White;
            d9.BackColor = Color.White;
            d10.BackColor = Color.White;
            d11.BackColor = Color.White;
            d12.BackColor = Color.White;
            d13.BackColor = Color.White;
            d14.BackColor = Color.White;
            d15.BackColor = Color.White;
            d16.BackColor = Color.White;
            d17.BackColor = Color.White;
            d18.BackColor = Color.White;
            d19.BackColor = Color.White;
            d20.BackColor = Color.White;
            d21.BackColor = Color.White;
            d22.BackColor = Color.White;
            d23.BackColor = Color.White;
            d24.BackColor = Color.White;
            d25.BackColor = Color.White;
            d26.BackColor = Color.White;
            d27.BackColor = Color.White;
            d28.BackColor = Color.White;
            d29.BackColor = Color.White;
            d30.BackColor = Color.White;
            d31.BackColor = Color.White;
            d32.BackColor = Color.White;
            d33.BackColor = Color.White;
            d34.BackColor = Color.White;
            d35.BackColor = Color.White;
            d36.BackColor = Color.White;
            d37.BackColor = Color.White;
            d38.BackColor = Color.White;
            d39.BackColor = Color.White;
            d40.BackColor = Color.White;
            d41.BackColor = Color.White;
            d42.BackColor = Color.White;
            d43.BackColor = Color.White;
            d44.BackColor = Color.White;
            d45.BackColor = Color.White;
            d46.BackColor = Color.White;
            d47.BackColor = Color.White;
            d48.BackColor = Color.White;
            d49.BackColor = Color.White;
            d50.BackColor = Color.White;
            d51.BackColor = Color.White;
            d52.BackColor = Color.White;
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

        public void OcultarOdonto()
        {
            divOdontogramaNiño.Visible = false;
            divOdontogramaAdulto.Visible = false;
            buscador.Visible = true;
            ttIdPaciente.Text = String.Empty;
        }
        protected void Volver2_Click(object sender, EventArgs e)
        {
            OcultarOdonto();
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            OcultarOdonto();
        }

        //Seguir copiando hasta tener todos los botones cuando ya tenga el metodo de uno listp
    }
}