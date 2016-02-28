using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fachadas;

namespace PresentacionWeb
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FachadaAgencia.Instancia.SerializarTodo();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FachadaAgencia.Instancia.DeserializarTodo();
        }
    }
}