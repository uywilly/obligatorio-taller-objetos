using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fachadas;

namespace PresentacionWeb
{
    public partial class ListadosGenerales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //clientes
                this.ListBox1.DataSource = FachadaAgencia.Instancia.RepoClientes.ListaClientes;
                this.ListBox1.DataTextField = "ParaListado";
                this.ListBox1.DataValueField = "Id";
                this.ListBox1.DataBind();
                this.ListBox1.SelectedIndex = 0;

                //pasajeros
                this.ListBox2.DataSource = FachadaAgencia.Instancia.RepoPasajeros.ListaPasajeros;
                this.ListBox2.DataTextField = "ParaListado";
                this.ListBox2.DataValueField = "Id";
                this.ListBox2.DataBind();
                this.ListBox2.SelectedIndex = 0;

                //destinos
                this.ListBox3.DataSource = FachadaAgencia.Instancia.RepoDestinos.ListaDestinos;
                this.ListBox3.DataTextField = "ParaListado";
                this.ListBox3.DataValueField = "Id";
                this.ListBox3.DataBind();
                this.ListBox3.SelectedIndex = 0;

                //Excursiones
                this.ListBox4.DataSource = FachadaAgencia.Instancia.RepoExcurciones.ListaExcurciones;
                this.ListBox4.DataTextField = "ParaListado";
                this.ListBox4.DataValueField = "Id";
                this.ListBox4.DataBind();
                this.ListBox4.SelectedIndex = 0;

                //Contratos
                this.ListBox5.DataSource = FachadaAgencia.Instancia.RepoContratos.ListaContratos;
                this.ListBox5.DataTextField = "ParaListado";
                this.ListBox5.DataValueField = "Id";
                this.ListBox5.DataBind();
                this.ListBox5.SelectedIndex = 0;
            }


        }
    }
}