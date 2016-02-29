using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fachadas;
using Dominio;
using Dominio.Entidades;

namespace PresentacionWeb
{
    public partial class RankingPasajeros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //FALTA RECORTAR LA LISTA PARA EL TOP10
            if (!IsPostBack)
            {
                List<Pasajero> rankingP = (List<Pasajero>)FachadaAgencia.Instancia.RepoPasajeros.ListaPasajeros;
                rankingP.Sort(new ComparadoraPuntaje());
                int i = 0;
                List<Pasajero> aux = new List<Pasajero>();
                while (i < rankingP.Count && i < 10)
                {
                    aux.Add(rankingP[i]);
                    i++;
                }

                
                this.lbxRanking.DataSource = aux;
                this.lbxRanking.DataTextField = "ParaListado";
                this.lbxRanking.DataValueField = "Id";
                this.lbxRanking.DataBind();
                this.lbxRanking.SelectedIndex = 0;
            }
        }
    }
}