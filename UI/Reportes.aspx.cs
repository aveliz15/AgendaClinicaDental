using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL_ClinicaDental;
using ServiceStack.OrmLite;
using DATOS_ClinicaDental.Modelos;

namespace UI_ClinicaDental
{
    public partial class Reportes : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.Visible = true;
            reporte2.Visible = false;

        }
      
        protected void btnCrearReporte_Click(object sender, EventArgs e)
        {
            String FechaHoy = DateTime.Today.ToShortDateString();
            String FechaIni = txtFechaini.Text;
            String FechaFin = txtFechaFin.Text;

           
        }
    }
}