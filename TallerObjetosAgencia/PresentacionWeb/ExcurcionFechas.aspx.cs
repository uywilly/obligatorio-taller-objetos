using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fachadas;
using Dominio;

namespace PresentacionWeb
{
    public partial class ExcurcionFechas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.SelectedDate = Calendar1.TodaysDate;
                Calendar2.SelectedDate = Calendar2.TodaysDate;
            }

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = Calendar1.SelectedDate;
            DateTime fecha2 = Calendar2.SelectedDate;
            IList<Excurcion> excurciones = new List<Excurcion>();
            if (fecha1 > fecha2)
            {
                lblMensaje.Text = "RANGO FECHA INVALIDO";
            }
            else
            {
                foreach (Contrato unC in FachadaAgencia.Instancia.RepoContratos.ListaContratos)
                {
                    if (unC.FechaContrato < fecha2 && unC.FechaContrato > fecha1 &&!excurciones.Contains(unC.Excurcion))
                    {
                        
                        excurciones.Add(unC.Excurcion);
                    }
                    else if ((unC.FechaContrato == fecha2 || unC.FechaContrato == fecha1) && !excurciones.Contains(unC.Excurcion))
                    {

                        excurciones.Add(unC.Excurcion);
                    }
                }
            }
            this.grdExcurciones.DataSource = excurciones;
            this.grdExcurciones.DataBind();
        }
    }
}