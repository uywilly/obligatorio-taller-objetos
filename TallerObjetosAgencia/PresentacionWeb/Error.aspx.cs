using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mensaje = "Ocurrio un error inesperado!";
            if (!string.IsNullOrEmpty(Request.QueryString["err"]))
            {
                mensaje = Request.QueryString["err"];

            }

            Label1.Text = mensaje;
        }
    }
}