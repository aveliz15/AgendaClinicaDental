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
        public static int id;
        public static int diente;
        public static List<DATOS_ClinicaDental.Modelos.Diagnostico> ListaDiagnosticos;

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
                    txtDetalle.TextMode = TextBoxMode.MultiLine;
                    txtDetalle.Rows = 2;
                    divMantenimientoDiag.Visible = false;
                    buscador.Visible = true;
                    divOdontogramaNiño.Visible = false;
                    divOdontogramaAdulto.Visible = false;
                    MostrarDiagnostico.Visible = false;
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
            Diagnostico.id = 0;
            Diagnostico.id = Convert.ToInt32(ttIdPaciente.Text);
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

        public void QuitarMensajes()
        {
            mensaje.Visible = false;
            mensajeError.Visible = false;
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
                    case 11:
                        d11.BackColor = Color.Red;
                        break;
                    case 12:
                        d12.BackColor = Color.Red;
                        break;
                    case 13:
                        d13.BackColor = Color.Red;
                        break;
                    case 14:
                        d14.BackColor = Color.Red;
                        break;
                    case 15:
                        d11.BackColor = Color.Red;
                        break;
                    case 16:
                        d16.BackColor = Color.Red;
                        break;
                    case 17:
                        d17.BackColor = Color.Red;
                        break;
                    case 18:
                        d18.BackColor = Color.Red;
                        break;
                    case 19:
                        d11.BackColor = Color.Red;
                        break;
                    case 20:
                        d20.BackColor = Color.Red;
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
       

        public void OcultarOdonto()
        {
            divOdontogramaNiño.Visible = false;
            divOdontogramaAdulto.Visible = false;
            buscador.Visible = true;
            ttIdPaciente.Text = String.Empty;
        }

       public void OcultarDiagnosticos(){
           MostrarDiagnostico.Visible = false;
           
        }
        protected void Volver2_Click(object sender, EventArgs e)
        {
            OcultarOdonto();
            OcultarDiagnosticos();
            divMantenimientoDiag.Visible = false;
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            OcultarOdonto();
            OcultarDiagnosticos();
            divMantenimientoDiag.Visible = false;
        }

        
        protected void d1_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 1;
                if (d1.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        divMantenimientoDiag.Visible = false;
                        
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 1);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

      
        protected void d2_Click(object sender, EventArgs e)
        {
            try
            {
                 Diagnostico.diente = 2;
                    if (d2.BackColor==Color.Red)
	                {
                        if (MostrarDiagnostico.Visible==true)
                        {
                             OcultarDiagnosticos();
                             QuitarMensajes();
                        }
                        else
                        {
                            QuitarMensajes();
                            divMantenimientoDiag.Visible = false;
                         
                          ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 2);
                          LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                          LVDiagnosticos.DataBind();
                          MostrarDiagnostico.Visible = true;
                        }

                    }
                    else
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                        divMantenimientoDiag.Visible = true;
                    }
        
                    }
                    catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
                    

            }

         
        protected void d4_Click(object sender, EventArgs e)
        {

            try
            {
                Diagnostico.diente = 4;
                if (d4.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible==true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {

                        QuitarMensajes();
                        divMantenimientoDiag.Visible = false;
                        
                    ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 4);
                    LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                    LVDiagnosticos.DataBind();
                    MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d3_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 3;
                if (d3.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 3);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d6_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 6;
                if (d6.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 6);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d5_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 5;
                if (d5.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                       
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 5);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d7_Click(object sender, EventArgs e)
        {
            try
            {
                    Diagnostico.diente = 7;
                if (d7.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                       
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 7);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d8_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 8;
                if (d8.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 8);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d9_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 9;
                if (d9.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                     
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 9);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d10_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 10;
                if (d10.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 10);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d11_Click(object sender, EventArgs e)
        {
            try
            {
                 Diagnostico.diente = 11;
                if (d11.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                       
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 11);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d20_Click(object sender, EventArgs e)
        {
            try
            {
                 Diagnostico.diente = 20;
                if (d20.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                       
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 20);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d12_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 12;
                if (d12.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                       
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 12);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d19_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 19;
                if (d19.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 19);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d13_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 13;
                if (d13.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                       
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 13);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d18_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 18;
                if (d18.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 18);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d14_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 14;
                if (d14.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 14);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d17_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 17;
                if (d17.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 17);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d15_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostico.diente = 15;
                if (d15.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                       
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 15);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void d16_Click(object sender, EventArgs e)
        {
            try
            {

                if (d16.BackColor == Color.Red)
                {
                    Diagnostico.diente = 16;
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                    }
                    else
                    {
                        QuitarMensajes();
                        
                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(Diagnostico.id, 16);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }

                }
                else
                {
                    OcultarDiagnosticos();
                    QuitarMensajes();
                    divMantenimientoDiag.Visible = true;
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error, intente mas tarde");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            OcultarDiagnosticos();
            divMantenimientoDiag.Visible = true;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDetalle.Text = String.Empty;
        }

        
        protected void btnAgregarDiagnostico_Click(object sender, EventArgs e)
        {
            try
            {
                DATOS_ClinicaDental.Modelos.Diagnostico di = new DATOS_ClinicaDental.Modelos.Diagnostico
                {
                    IdPaciente = Diagnostico.id,
                    IdDiente = Diagnostico.diente,
                    Detalle = txtDetalle.Text,
                    Fecha = DateTime.Today
                };
                if (di!=null)
                {
                diag.InsertarDiagnostico(di);
                MostrarMensaje("Diagnostico agregado correctamente");
                txtDetalle.Text = String.Empty;
                divMantenimientoDiag.Visible = false;
                }
                
            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error al procesar la solicitud, intente mas tarde");
            }
            txtDetalle.Text = String.Empty;
        }

       

        
    }
}