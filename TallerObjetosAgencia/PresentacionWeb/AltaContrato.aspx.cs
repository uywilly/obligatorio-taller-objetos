using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fachadas;

namespace PresentacionWeb
{
    public partial class AltaContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.grClientes.DataSource = FachadaAgencia.Instancia.RepoClientes;
                this.grClientes.DataBind();
                this.grExcurciones.DataSource = FachadaAgencia.Instancia.RepoExcurciones;
                this.grExcurciones.DataBind();
                this.grPasajeros.DataSource = FachadaAgencia.Instancia.RepoPasajeros;
                this.grPasajeros.DataBind();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

    }
}