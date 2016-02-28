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
    public partial class ExcurcionDestino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.lbxDestinos.DataSource = FachadaAgencia.Instancia.RepoDestinos.ListaDestinos;
                this.lbxDestinos.DataTextField = "ParaListado";
                this.lbxDestinos.DataValueField = "Id";
                this.lbxDestinos.DataBind();
                this.lbxDestinos.SelectedIndex = 0;
            }

        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            string id = lbxDestinos.SelectedValue;
            this.Label1.Text = id;
            this.lbxExcurciones.DataSource = FachadaAgencia.Instancia.RepoExcurciones.FindExcurcionesByDestino(id);
            this.lbxExcurciones.DataTextField = "ParaListado";
            this.lbxExcurciones.DataValueField = "Id";
            this.lbxExcurciones.DataBind();

        }
    }
}