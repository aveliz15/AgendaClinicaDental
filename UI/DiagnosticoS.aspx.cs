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
    public partial class DiagnosticoS : System.Web.UI.Page
    {
        
        public IPaciente usu;
        public IDiagnostico diag = new MDiagnostico();
        public static int id;
        public static int diente;
        public static List<DATOS_ClinicaDental.Modelos.Diagnostico> ListaDiagnosticos;

        public DiagnosticoS()
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
                DiagnosticoS.id = 0;
                DiagnosticoS.id = Convert.ToInt32(ttIdPaciente.Text);
                Paciente u = usu.BuscarPaciente(id);
               

                if (u.IdTipoOntograma == 1)
                {
                    divOdontogramaNiño.Visible = true;
                    MarcarDiente();
                    buscador.Visible = false;
                    tituloPaciente.InnerText = "Paciente: " + u.Nombre + " " + u.Apellido1 + " " + u.Apellido2 + "";
                }
                else
                {
                    divOdontogramaAdulto.Visible = true;
                    MarcarDiente();
                    buscador.Visible = false;
                    tituloPaciente2.InnerText = "Paciente: " + u.Nombre + " " + u.Apellido1 + " " + u.Apellido2 + "";
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
                        d15.BackColor = Color.Red;
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
                        d19.BackColor = Color.Red;
                        break;
                    case 20:
                        d20.BackColor = Color.Red;
                        break;
                    case 21:
                        d21.BackColor = Color.Red;
                        break;
                    case 22:
                        d22.BackColor = Color.Red;
                        break;
                    case 23:
                        d23.BackColor = Color.Red;
                        break;
                    case 24:
                        d24.BackColor = Color.Red;
                        break;
                    case 25:
                        d25.BackColor = Color.Red;
                        break;
                    case 26:
                        d26.BackColor = Color.Red;
                        break;
                    case 27:
                        d27.BackColor = Color.Red;
                        break;
                    case 28:
                        d28.BackColor = Color.Red;
                        break;
                    case 29:
                        d29.BackColor = Color.Red;
                        break;
                    case 30:
                        d30.BackColor = Color.Red;
                        break;
                    case 31:
                        d31.BackColor = Color.Red;
                        break;
                    case 32:
                        d32.BackColor = Color.Red;
                        break;
                    case 33:
                        d33.BackColor = Color.Red;
                        break;
                    case 34:
                        d34.BackColor = Color.Red;
                        break;
                    case 35:
                        d35.BackColor = Color.Red;
                        break;
                    case 36:
                        d36.BackColor = Color.Red;
                        break;
                    case 37:
                        d37.BackColor = Color.Red;
                        break;
                    case 38:
                        d38.BackColor = Color.Red;
                        break;
                    case 39:
                        d39.BackColor = Color.Red;
                        break;
                    case 40:
                        d40.BackColor = Color.Red;
                        break;
                    case 41:
                        d41.BackColor = Color.Red;
                        break;
                    case 42:
                        d42.BackColor = Color.Red;
                        break;
                    case 43:
                        d43.BackColor = Color.Red;
                        break;
                    case 44:
                        d44.BackColor = Color.Red;
                        break;
                    case 45:
                        d45.BackColor = Color.Red;
                        break;
                    case 46:
                        d46.BackColor = Color.Red;
                        break;
                    case 47:
                        d47.BackColor = Color.Red;
                        break;
                    case 48:
                        d48.BackColor = Color.Red;
                        break;
                    case 49:
                        d49.BackColor = Color.Red;
                        break;
                    case 50:
                        d50.BackColor = Color.Red;
                        break;
                    case 51:
                        d51.BackColor = Color.Red;
                        break;
                    case 52:
                        d52.BackColor = Color.Red;
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
       
        public void OcultarOdonto()
        {
            divOdontogramaNiño.Visible = false;
            divOdontogramaAdulto.Visible = false;
            buscador.Visible = true;
            ttIdPaciente.Text = String.Empty;
        }

        public void OcultarDiagnosticos()
        {
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
                DiagnosticoS.diente = 1;
                if (d1.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 1);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                        
                    }
                    else
                    {
                        QuitarMensajes();
                        divMantenimientoDiag.Visible = false;

                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 1);
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
                DiagnosticoS.diente = 2;
                if (d2.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 2);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();
                        divMantenimientoDiag.Visible = false;

                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 2);
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
                DiagnosticoS.diente = 4;
                if (d4.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 4);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {

                        QuitarMensajes();
                        divMantenimientoDiag.Visible = false;

                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 4);
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
                DiagnosticoS.diente = 3;
                if (d3.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 3);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 3);
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
                DiagnosticoS.diente = 6;
                if (d6.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 6);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 6);
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
                DiagnosticoS.diente = 5;
                if (d5.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 5);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 5);
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
                DiagnosticoS.diente = 7;
                if (d7.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 7);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 7);
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
                DiagnosticoS.diente = 8;
                if (d8.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 8);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 8);
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
                DiagnosticoS.diente = 9;
                if (d9.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 9);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 9);
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
                DiagnosticoS.diente = 10;
                if (d10.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 10);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 10);
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
                DiagnosticoS.diente = 11;
                if (d11.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 11);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 11);
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
                DiagnosticoS.diente = 20;
                if (d20.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 20);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 20);
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
                DiagnosticoS.diente = 12;
                if (d12.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 12);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 12);
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
                DiagnosticoS.diente = 19;
                if (d19.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 19);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 19);
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
                DiagnosticoS.diente = 13;
                if (d13.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 13);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 13);
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
                DiagnosticoS.diente = 18;
                if (d18.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 18);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 18);
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
                DiagnosticoS.diente = 14;
                if (d14.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 14);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 14);
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
                DiagnosticoS.diente = 17;
                if (d17.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 17);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 17);
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
                DiagnosticoS.diente = 15;
                if (d15.BackColor == Color.Red)
                {
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 15);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 15);
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
                DiagnosticoS.diente = 16;
                if (d16.BackColor == Color.Red)
                {
                   
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 16);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 16);
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
                    IdPaciente = DiagnosticoS.id,
                    IdDiente = DiagnosticoS.diente,
                    Detalle = txtDetalle.Text,
                    Fecha = DateTime.Today
                };
                if (di != null)
                {
                    diag.InsertarDiagnostico(di);
                    MostrarMensaje("Diagnostico agregado correctamente");
                    txtDetalle.Text = String.Empty;
                    divMantenimientoDiag.Visible = false;
                    MarcarDiente();
                }

            }
            catch (Exception)
            {

                MostrarMensajeError("Ha ocurrido un error al procesar la solicitud, intente mas tarde");
            }
            txtDetalle.Text = String.Empty;
        }

        protected void d27_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 27;
                if (d27.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 27);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 27);
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

        protected void d28_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 28;
                if (d28.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 28);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 28);
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

        protected void d29_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 29;
                if (d29.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 29);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 29);
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

        protected void d30_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 30;
                if (d30.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 30);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 30);
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

        protected void d26_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 26;
                if (d26.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 26);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 26);
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

        protected void d31_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 31;
                if (d31.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 31);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 31);
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

        protected void d25_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 25;
                if (d25.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 25);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 25);
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

        protected void d32_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 32;
                if (d32.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 32);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 32);
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

        protected void d24_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 24;
                if (d24.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 24);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 24);
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

        protected void d33_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 33;
                if (d33.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 33);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 33);
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

        protected void d23_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 23;
                if (d23.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 23);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 23);
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

        protected void d34_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 34;
                if (d34.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 34);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 34);
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

        protected void d22_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 22;
                if (d22.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 22);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 22);
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

        protected void d35_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 35;
                if (d35.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 35);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 35);
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

        protected void d21_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 21;
                if (d21.BackColor == Color.Red)
                {
                    
                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 21);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 21);
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

        protected void d36_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 36;
                if (d36.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 36);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 36);
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

        protected void d52_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 52;
                if (d52.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 52);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 52);
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

        protected void d37_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 37;
                if (d37.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 37);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 37);
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

        protected void d51_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 51;
                if (d51.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 51);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 51);
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

        protected void d38_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 38;
                if (d38.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 38);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 38);
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

        protected void d50_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 50;
                if (d50.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 50);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 50);
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

        protected void d39_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 39;
                if (d39.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 39);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 39);
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

        protected void d49_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 49;
                if (d49.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 49);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 49);
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

        protected void d40_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 40;
                if (d40.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 40);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 40);
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

        protected void d48_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 48;
                if (d48.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 48);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 48);
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

        protected void d41_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 41;
                if (d41.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 41);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 41);
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

        protected void d47_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 47;
                if (d47.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 47);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 47);
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

        protected void d42_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 42;
                if (d42.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 42);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 42);
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

        protected void d46_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 46;
                if (d46.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 46);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 46);
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

        protected void d45_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 45;
                if (d45.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 45);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 45);
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

        protected void d44_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 44;
                if (d44.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 44);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 44);
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

        protected void d43_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticoS.diente = 43;
                if (d43.BackColor == Color.Red)
                {

                    if (MostrarDiagnostico.Visible == true)
                    {
                        OcultarDiagnosticos();
                        mensaje.Visible = false;
                        mensajeError.Visible = false;
                        QuitarMensajes();
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 43);
                        LVDiagnosticos.DataSource = ListaDiagnosticos.ToList();
                        LVDiagnosticos.DataBind();
                        MostrarDiagnostico.Visible = true;
                    }
                    else
                    {
                        QuitarMensajes();

                        divMantenimientoDiag.Visible = false;
                        ListaDiagnosticos = diag.ListarDiagnostico(DiagnosticoS.id, 43);
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

       
    }
}