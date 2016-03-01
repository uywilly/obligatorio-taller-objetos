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

                Label1.Text = "ULTIMO PASAJERO " + Pasajero.Ultimo;

                Label2.Text = "SEGURO INTERNACIONAL " + Internacional.Seguro;

                Label3.Text = "LOCALIDAD NACIONAL " + Nacional.Localidad;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FachadaAgencia.Instancia.AgregarPasajero("Andres", "Roco", "1234567-9", 5);
            FachadaAgencia.Instancia.AgregarPasajero("Andres", "Lescano", "1234561-0", 2200);
            FachadaAgencia.Instancia.AgregarPasajero("Tabare", "Cardozo", "1234561-1", 132);
            FachadaAgencia.Instancia.AgregarPasajero("Juan", "Cabrera", "1234561-2", 322);
            FachadaAgencia.Instancia.AgregarPasajero("Marcos", "Rivero", "1234561-3", 324);


            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //crear destinos
            FachadaAgencia.Instancia.AgregarDestino("Destino 1", "Cuzco", "Perú", "1");
            FachadaAgencia.Instancia.AgregarDestino("Destino 2", "Hong Kong", "China", "2");
            FachadaAgencia.Instancia.AgregarDestino("Destino 3", "Singapur", "Malasia", "3");
            FachadaAgencia.Instancia.AgregarDestino("Destino 4", "Bangkok", "Tailandia", "4");
            FachadaAgencia.Instancia.AgregarDestino("Destino 5", "Londres", "Inglaterra", "5");
            FachadaAgencia.Instancia.AgregarDestino("Destino 6", "Macau", "China", "6");
            FachadaAgencia.Instancia.AgregarDestino("Destino 7", "Rocha", "Uruguay", "7");
            FachadaAgencia.Instancia.AgregarDestino("Destino 8", "Punta del Este", "Uruguay", "8");

            Itinerario i1 = new Itinerario(5, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("1"), "1");
            Itinerario i2 = new Itinerario(10, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("2"), "2");
            Itinerario i3 = new Itinerario(8, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("3"), "3");
            Itinerario i4 = new Itinerario(4, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("4"), "4");
            Itinerario i5 = new Itinerario(6, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("5"), "5");
            Itinerario i6 = new Itinerario(9, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("6"), "6");
            Itinerario i7 = new Itinerario(6, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("7"), "7");
            Itinerario i8 = new Itinerario(9, 120, FachadaAgencia.Instancia.RepoDestinos.FindById("8"), "8");

            IList<Itinerario> hoja1 = new List<Itinerario>();
            hoja1.Add(i1);

            IList<Itinerario> hoja2 = new List<Itinerario>();
            hoja2.Add(i2);
            hoja2.Add(i3);
            hoja2.Add(i4);
            hoja2.Add(i6);

            IList<Itinerario> hoja3 = new List<Itinerario>();
            hoja3.Add(i7);
            hoja3.Add(i8);

            FachadaAgencia.Instancia.AgregarPersona("Juan", "Lopez", "1234567-1");
            FachadaAgencia.Instancia.AgregarPersona("Jose", "Gomez", "1234567-2");
            FachadaAgencia.Instancia.AgregarPersona("Ana", "Mendez", "1234567-3");
            FachadaAgencia.Instancia.AgregarPersona("Lucas", "Acevedo", "1234567-4");
            FachadaAgencia.Instancia.AgregarPersona("Marcos", "Gonsalez", "1234567-5");
            FachadaAgencia.Instancia.AgregarPersona("Susana", "Mitre", "1234567-6");
            FachadaAgencia.Instancia.AgregarPersona("Carmen", "Ejido", "1234567-7");
            FachadaAgencia.Instancia.AgregarPersona("Andres", "Roco", "1234567-8");
            FachadaAgencia.Instancia.AgregarPersona("Andres", "Roco", "1234567-9");
            FachadaAgencia.Instancia.AgregarPersona("Andres", "Lescano", "1234561-0");
            FachadaAgencia.Instancia.AgregarPersona("Tabare", "Cardozo", "1234561-1");
            FachadaAgencia.Instancia.AgregarPersona("Juan", "Cabrera", "1234561-2");
            FachadaAgencia.Instancia.AgregarPersona("Marcos", "Rivero", "1234561-3");

            FachadaAgencia.Instancia.AgregarCliente("Juan", "Lopez", "1234567-1", "Ejido 1234");
            FachadaAgencia.Instancia.AgregarCliente("Jose", "Gomez", "1234567-2", "Andes 3215");
            FachadaAgencia.Instancia.AgregarCliente("Ana", "Mendez", "1234567-3", "Yi 2132");

            FachadaAgencia.Instancia.AgregarPasajero("Juan", "Lopez", "1234567-1", 0);
            FachadaAgencia.Instancia.AgregarPasajero("Lucas", "Acevedo", "1234567-4", 100);
            FachadaAgencia.Instancia.AgregarPasajero("Marcos", "Gonsalez", "1234567-5", 25);
            FachadaAgencia.Instancia.AgregarPasajero("Susana", "Mitre", "1234567-6", 321);
            FachadaAgencia.Instancia.AgregarPasajero("Carmen", "Ejido", "1234567-7", 201);
            FachadaAgencia.Instancia.AgregarPasajero("Andres", "Roco", "1234567-8", 1);


            IList<Pasajero> pasajeros1 = new List<Pasajero>();
            IList<Pasajero> pasajeros2 = new List<Pasajero>();
            IList<Pasajero> pasajeros3 = new List<Pasajero>();
            FachadaAgencia.Instancia.AgregarExcurcionInt("1", "Locura en Peru", System.DateTime.Today, hoja1, 1, 5, 6, pasajeros1);
            FachadaAgencia.Instancia.AgregarExcurcionInt("2", "Misterios de Asia", System.DateTime.Today, hoja2, 5, 8, 10, pasajeros2);
            FachadaAgencia.Instancia.AgregarExcurcionNac("3", "Tesoros del Uruguay", System.DateTime.Today, hoja3, 5, 8, 10, pasajeros3, 5);

        }
    }
}