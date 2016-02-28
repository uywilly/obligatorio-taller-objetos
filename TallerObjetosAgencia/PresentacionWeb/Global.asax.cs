using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Fachadas;
using Dominio;
using System.IO; //manejo de archivos
using System.Runtime.Serialization; //serializacion
using System.Runtime.Serialization.Formatters.Binary;//formateador binario-serializacion

namespace PresentacionWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            FachadaAgencia.Instancia.DeserializarTodo();
            //FachadaAgencia.Instancia.Leer(":"); 

            #region DESTINOS
            ////crear destinos
            //FachadaAgencia.Instancia.AgregarDestino("D1-MN", "MN", "Mexico", "1");
            //FachadaAgencia.Instancia.AgregarDestino("D2-NY", "NY", "EEUU", "2");
            //FachadaAgencia.Instancia.AgregarDestino("D2-AZ", "AZ", "EEUU", "3");

            //Destino d1 = FachadaAgencia.Instancia.RepoDestinos.FindById("1");
            //Destino d2 = FachadaAgencia.Instancia.RepoDestinos.FindById("2");
            //Destino d3 = FachadaAgencia.Instancia.RepoDestinos.FindById("3");
            ///*
            //foreach (Destino d in FachadaAgencia.Instancia.RepoDestinos.ListaDestinos)
            //{
            //    Console.WriteLine(d.ToString());
            //}
            //*/
            //#endregion
            //#region ITINERARIO + HOJA DE RUTA
            //Itinerario i1 = new Itinerario(3, 90, d3, "1");
            //Itinerario i2 = new Itinerario(3, 90, d3, "1");
            //IList<Itinerario> hoja1 = new List<Itinerario>();
            //hoja1.Add(i1);
            //hoja1.Add(i2);

            //Itinerario i3 = new Itinerario(3, 90, d3, "1");
            //IList<Itinerario> hoja2 = new List<Itinerario>();
            //hoja2.Add(i3);
            //#endregion
            //#region MyRegion
            //FachadaAgencia.Instancia.AgregarPersona("Juan", "Lopez", "1234567-1");
            //FachadaAgencia.Instancia.AgregarPersona("Jose", "Lopez", "1234567-2");
            //FachadaAgencia.Instancia.AgregarPersona("Ana", "Lopez", "1234567-3");
            //FachadaAgencia.Instancia.AgregarPersona("Lujan", "Lopez", "1234567-4");


            //FachadaAgencia.Instancia.AgregarCliente("Juan", "Lopez", "1234567-1", "Ejido 1234");

            //FachadaAgencia.Instancia.AgregarPasajero("Juan", "Lopez", "1234567-1", 0);
            //FachadaAgencia.Instancia.AgregarPasajero("Jose", "Lopez", "1234567-2", 0);
            //FachadaAgencia.Instancia.AgregarPasajero("Ana", "Lopez", "1234567-3", 0);
            //FachadaAgencia.Instancia.AgregarPasajero("Lujan", "Lopez", "1234567-4", 0);

            //IList<Pasajero> pasajeros1 = new List<Pasajero>();
            //IList<Pasajero> pasajeros2 = new List<Pasajero>();
            //FachadaAgencia.Instancia.AgregarExcurcionNac("1", "excurcion en usa", System.DateTime.Today, hoja1, 3, 5, 10, pasajeros1, 0.5);
            //Excurcion ex1 = FachadaAgencia.Instancia.RepoExcurciones.FindById("1");


            //Cliente cli1 = FachadaAgencia.Instancia.RepoClientes.FindById("1234567-1");
            //Console.WriteLine(FachadaAgencia.Instancia.RepoPasajeros.ListaPasajeros.ToString());
            //Console.WriteLine(FachadaAgencia.Instancia.RepoClientes.ListaClientes.ToString());
            //Console.WriteLine(FachadaAgencia.Instancia.RepoPasajeros.ListaPasajeros.ToString());
            //Console.WriteLine(ex1.Pasajeros.ToString());

            ////pasajeros1.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById("1234567-1"));
            ////pasajeros1.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById("1234567-2"));
            //pasajeros2.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById("1234567-3"));
            //pasajeros2.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById("1234567-4"));



            //FachadaAgencia.Instancia.AgregarContrato(ex1, cli1, pasajeros2, "1");
            //Console.WriteLine(FachadaAgencia.Instancia.RepoContratos.FindById("1").ToString());
            #endregion


        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //VARIABLES DE SESION - Session["rol"] = null;

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
            //FachadaAgencia.Instancia.SerializarTodo();
            //FachadaAgencia.Instancia.GuardarParametros(":"); 

        }
    }
}