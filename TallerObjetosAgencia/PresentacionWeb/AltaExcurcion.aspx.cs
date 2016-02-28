using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Fachadas;

namespace PresentacionWeb
{
    public partial class AltaExcurcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.grdDestinos.DataSource = FachadaAgencia.Instancia.RepoDestinos.ListaDestinos;
                this.grdDestinos.DataBind();
            }

        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            IList<Pasajero> pasajeros = new List<Pasajero>();
            double puntos = double.Parse(this.txtPuntos.Text);
            byte stock = byte.Parse(this.txtStock.Text);
            DateTime fechaIni = this.calFini.SelectedDate;
            string desc = this.txtDesc.Text;
            string codigo = this.txtCodigo.Text;
            byte diasTraslado = byte.Parse(this.txtTraslado.Text);
            IList<Itinerario> hojaRuta = new List<Itinerario>();
            byte diasEstadia = 0;
            decimal costoDiario = 0;
            int i = 1;
            foreach(GridViewRow row in this.grdDestinos.Rows)
            {
                CheckBox unChk = (CheckBox)row.FindControl("chkDestino");
                TextBox txtCostoDiario = (TextBox)row.FindControl("txtCostoDiario"); 
                TextBox txtDiasEstadia = (TextBox)row.FindControl("txtDiasEstadia"); 
                if (unChk.Checked)
                {
                    Destino unD = FachadaAgencia.Instancia.RepoDestinos.FindById(row.Cells[4].Text);
                    diasEstadia = byte.Parse(txtDiasEstadia.Text);
                    costoDiario = decimal.Parse(txtCostoDiario.Text);
                    if (unD != null)
                    {
                        
                        hojaRuta.Add(new Itinerario() { DiasEstadia = diasEstadia, CostoDiario = costoDiario , Destino=unD, Id=""+i});
                        i++;
                    } 
                }
            }
            FachadaAgencia.Instancia.AgregarExcurcionNac(codigo, desc, fechaIni, hojaRuta, diasTraslado, stock, puntos, pasajeros, 10);

        }
    }
}