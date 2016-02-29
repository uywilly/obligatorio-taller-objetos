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
    public partial class AltaContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.grClientes.DataSource = FachadaAgencia.Instancia.RepoClientes.DatosPersonales;
                this.grClientes.DataBind();
                this.grExcurciones.DataSource = FachadaAgencia.Instancia.RepoExcurciones.ListaExcurciones;
                this.grExcurciones.DataBind();
                this.grPasajeros.DataSource = FachadaAgencia.Instancia.RepoPasajeros.DatosPersonales;
                this.grPasajeros.DataBind();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Excurcion ex = null;
            Cliente cliente = null;
            IList<Pasajero> listaPasajeros = new List<Pasajero>();
            string id = txtCodigo.Text;
            byte tope = 0;
            
            foreach (GridViewRow row in this.grExcurciones.Rows)
            {
                CheckBox unChk = (CheckBox)row.FindControl("chkExcurcion");
                if (unChk.Checked && tope<1)
                {
                    ex = FachadaAgencia.Instancia.RepoExcurciones.FindById(row.Cells[0].Text);
                    if (ex != null)
                    {
                        tope++;
                        foreach (GridViewRow row2 in this.grPasajeros.Rows)
                        {
                            
                            CheckBox unChk2 = (CheckBox)row2.FindControl("chkPasajeros");
                            if (unChk2.Checked)
                            {

                                if (FachadaAgencia.Instancia.RepoPasajeros.FindById(row2.Cells[2].Text) != null)
                                {
                                    listaPasajeros.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById(row2.Cells[2].Text));
                                }
                            }
                        }
                        ex.AgregarPasajeros(listaPasajeros);
                    }
                }
            }
            tope = 0;
            foreach (GridViewRow row in this.grClientes.Rows)
            {
                CheckBox unChk = (CheckBox)row.FindControl("chkCliente");
                if (unChk.Checked && tope < 1)
                {
                    cliente = FachadaAgencia.Instancia.RepoClientes.FindById(row.Cells[2].Text);
                    if (cliente != null)
                    {
                        tope++;
                    }
                }
            }
            if(FachadaAgencia.Instancia.AgregarContrato(ex,cliente,listaPasajeros,System.DateTime.Today,"12321")) 
                lblMensaje.Text="EXITO";
            else lblMensaje.Text = "ERROR";
        }

        protected void btnCosto_Click(object sender, EventArgs e)
        {
            Excurcion ex = null;
            Cliente cliente = null;
            IList<Pasajero> listaPasajeros = new List<Pasajero>();
            string id = txtCodigo.Text;
            byte tope = 0;

            foreach (GridViewRow row in this.grExcurciones.Rows)
            {
                CheckBox unChk = (CheckBox)row.FindControl("chkExcurcion");
                if (unChk.Checked && tope < 1)
                {
                    ex = FachadaAgencia.Instancia.RepoExcurciones.FindById(row.Cells[0].Text);
                    if (ex != null)
                    {
                        tope++;
                        foreach (GridViewRow row2 in this.grPasajeros.Rows)
                        {

                            CheckBox unChk2 = (CheckBox)row2.FindControl("chkPasajeros");
                            if (unChk2.Checked)
                            {

                                if (FachadaAgencia.Instancia.RepoPasajeros.FindById(row2.Cells[2].Text) != null)
                                {
                                    listaPasajeros.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById(row2.Cells[2].Text));
                                }
                            }
                        }
                    }
                }
            }
            tope = 0;
            lblMensaje.Text = FachadaAgencia.Instancia.CalcularCosto(ex, listaPasajeros).ToString();
        }

    }
}