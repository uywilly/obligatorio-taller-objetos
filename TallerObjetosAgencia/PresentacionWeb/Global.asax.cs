﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace PresentacionWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            this.CargarDatosPrueba();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //VARIABLES DE SESION
            //Session["rol"] = null;

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //REDIRECCION EN CASO DE ERROR
            Exception ex = Server.GetLastError();
            Response.Redirect("Error.aspx?err=" + ex.InnerException.Message);

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
        private void CargarDatosPrueba()
        { }
    }
}