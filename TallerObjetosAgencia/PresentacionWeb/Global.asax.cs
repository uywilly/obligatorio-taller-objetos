﻿using System;
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
            FachadaAgencia.Instancia.Leer(":"); 

            #region DATOS DE PRUEBA
            ////crear destinos
            //FachadaAgencia.Instancia.AgregarDestino("Destino 1", "Cuzco", "Perú", "1");
            //FachadaAgencia.Instancia.AgregarDestino("Destino 2", "Hong Kong", "China", "2");
            //FachadaAgencia.Instancia.AgregarDestino("Destino 3", "Singapur", "Malasia", "3");
            //FachadaAgencia.Instancia.AgregarDestino("Destino 4", "Bangkok", "Tailandia", "4");
            //FachadaAgencia.Instancia.AgregarDestino("Destino 5", "Londres", "Inglaterra", "5");
            //FachadaAgencia.Instancia.AgregarDestino("Destino 6", "Macau", "China", "6");
            //FachadaAgencia.Instancia.AgregarDestino("Destino 7", "Rocha", "Uruguay", "7");
            //FachadaAgencia.Instancia.AgregarDestino("Destino 8", "Punta del Este", "Uruguay", "8");

            //Itinerario i1 = new Itinerario(5, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("1"), "1");
            //Itinerario i2 = new Itinerario(10, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("2"), "2");
            //Itinerario i3 = new Itinerario(8, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("3"), "3");
            //Itinerario i4 = new Itinerario(4, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("4"), "4");
            //Itinerario i5 = new Itinerario(6, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("5"), "5");
            //Itinerario i6 = new Itinerario(9, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("6"), "6");
            //Itinerario i7 = new Itinerario(6, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("7"), "7");
            //Itinerario i8 = new Itinerario(9, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("8"), "8");

            //IList<Itinerario> hoja1 = new List<Itinerario>();
            //hoja1.Add(i1);

            //IList<Itinerario> hoja2 = new List<Itinerario>();
            //hoja2.Add(i2);
            //hoja2.Add(i3);
            //hoja2.Add(i4);
            //hoja2.Add(i6);

            //IList<Itinerario> hoja3 = new List<Itinerario>();
            //hoja3.Add(i7);
            //hoja3.Add(i8);

            //FachadaAgencia.Instancia.AgregarPersona("Juan", "Lopez", "1234567-1");
            //FachadaAgencia.Instancia.AgregarPersona("Jose", "Gomez", "1234567-2");
            //FachadaAgencia.Instancia.AgregarPersona("Ana", "Mendez", "1234567-3");
            //FachadaAgencia.Instancia.AgregarPersona("Lucas", "Acevedo", "1234567-4");
            //FachadaAgencia.Instancia.AgregarPersona("Marcos", "Gonsalez", "1234567-5");
            //FachadaAgencia.Instancia.AgregarPersona("Susana", "Mitre", "1234567-6");
            //FachadaAgencia.Instancia.AgregarPersona("Carmen", "Ejido", "1234567-7");
            //FachadaAgencia.Instancia.AgregarPersona("Andres", "Roco", "1234567-8");
            //FachadaAgencia.Instancia.AgregarPersona("Andres", "Roco", "1234567-9");
            //FachadaAgencia.Instancia.AgregarPersona("Andres", "Lescano", "1234561-0");
            //FachadaAgencia.Instancia.AgregarPersona("Tabare", "Cardozo", "1234561-1");
            //FachadaAgencia.Instancia.AgregarPersona("Juan", "Cabrera", "1234561-2");
            //FachadaAgencia.Instancia.AgregarPersona("Marcos", "Rivero", "1234561-3");

            //FachadaAgencia.Instancia.AgregarCliente("Juan", "Lopez", "1234567-1", "Ejido 1234");
            //FachadaAgencia.Instancia.AgregarCliente("Jose", "Gomez", "1234567-2", "Andes 3215");
            //FachadaAgencia.Instancia.AgregarCliente("Ana", "Mendez", "1234567-3", "Yi 2132");

            //FachadaAgencia.Instancia.AgregarPasajero("Juan", "Lopez", "1234567-1", 0);
            //FachadaAgencia.Instancia.AgregarPasajero("Lucas", "Acevedo", "1234567-4", 100);
            //FachadaAgencia.Instancia.AgregarPasajero("Marcos", "Gonsalez", "1234567-5", 25);
            //FachadaAgencia.Instancia.AgregarPasajero("Susana", "Mitre", "1234567-6", 321);
            //FachadaAgencia.Instancia.AgregarPasajero("Carmen", "Ejido", "1234567-7", 201);
            //FachadaAgencia.Instancia.AgregarPasajero("Andres", "Roco", "1234567-8", 1);
            //FachadaAgencia.Instancia.AgregarPasajero("Andres", "Roco", "1234567-9", 5);
            //FachadaAgencia.Instancia.AgregarPasajero("Andres", "Lescano", "1234561-0", 2200);
            //FachadaAgencia.Instancia.AgregarPasajero("Tabare", "Cardozo", "1234561-1", 132);
            //FachadaAgencia.Instancia.AgregarPasajero("Juan", "Cabrera", "1234561-2", 322);
            //FachadaAgencia.Instancia.AgregarPasajero("Marcos", "Rivero", "1234561-3", 324);


            //IList<Pasajero> pasajeros1 = new List<Pasajero>();
            //IList<Pasajero> pasajeros2 = new List<Pasajero>();
            //IList<Pasajero> pasajeros3 = new List<Pasajero>();
            //FachadaAgencia.Instancia.AgregarExcurcionInt("1", "Locura en Peru", System.DateTime.Today, hoja1, 1, 5, 6, pasajeros1);
            //FachadaAgencia.Instancia.AgregarExcurcionInt("2", "Misterios de Asia", System.DateTime.Today, hoja2, 5, 8, 10, pasajeros2);
            //FachadaAgencia.Instancia.AgregarExcurcionNac("3", "Tesoros del Uruguay", System.DateTime.Today, hoja3, 5, 8, 10, pasajeros3, 5);


            //Excurcion ex1 = FachadaAgencia.Instancia.RepoExcurciones.FindById("1");
            //pasajeros1.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById("1234567-1"));
            //pasajeros1.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById("1234567-2"));
            //pasajeros2.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById("1234567-3"));
            //pasajeros2.Add(FachadaAgencia.Instancia.RepoPasajeros.FindById("1234567-4"));



            ////FachadaAgencia.Instancia.AgregarContrato(ex1, cli1, pasajeros2, "1");
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
            FachadaAgencia.Instancia.SerializarTodo();
            FachadaAgencia.Instancia.GuardarParametros(":"); 

        }
    }
}