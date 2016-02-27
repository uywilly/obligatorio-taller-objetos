using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Repositorios;
using Dominio.Entidades;
using System.IO; //manejo de archivos
using System.Runtime.Serialization; //serializacion
using System.Runtime.Serialization.Formatters.Binary;//formateador binario-serializacion


namespace Fachadas
{
    [Serializable]
    public class FachadaAgencia
    {
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos");

        #region Listados(Repositorios)
        public RepositorioPersonas RepoPersonas { get; set; }
        public RepositorioClientes RepoClientes { get; set; }
        public RepositorioPasajeros RepoPasajeros { get; set; }
        public RepositorioContratos RepoContratos { get; set; }
        public RepositorioExcurciones RepoExcurciones { get; set; }
        public RepositorioDestinos RepoDestinos { get; set; }
        #endregion

        #region Singleton

        private static FachadaAgencia instancia = null;

        public static FachadaAgencia Instancia
        {
            get { if (instancia == null) { FachadaAgencia.instancia = new FachadaAgencia(); } return instancia; }
        }

        private FachadaAgencia()
        {
            this.RepoPersonas = new RepositorioPersonas();
            this.RepoClientes = new RepositorioClientes();
            this.RepoPasajeros = new RepositorioPasajeros();
            this.RepoContratos = new RepositorioContratos();
            this.RepoExcurciones = new RepositorioExcurciones();
            this.RepoDestinos = new RepositorioDestinos();

        }
        #endregion

        #region Manejo de Persistencia
        public void SerializarTodo()
        {
            if (!Directory.Exists(ruta)) Directory.CreateDirectory(ruta);
            using (FileStream streamW = new FileStream(Path.Combine(ruta, "agencia.dat"), FileMode.Create))
            {

                BinaryFormatter formateador = new BinaryFormatter();
                FachadaAgencia fa = Instancia;
                formateador.Serialize(streamW, instancia);
            }
        }

        public void DeserializarTodo()
        {
            if (!Directory.Exists(ruta)) return;
            using (FileStream streamR = new FileStream(Path.Combine(ruta, "agencia.dat"), FileMode.OpenOrCreate))
            {

                BinaryFormatter formateador = new BinaryFormatter();
                instancia = new FachadaAgencia();
                instancia = formateador.Deserialize(streamR) as FachadaAgencia;
            }
        }
        #endregion

        #region ManejoPersonas
        public bool AgregarPersona(string nombre, string apellido, string ci)
        {
            bool retorno = false;
            Persona unaP = new Persona(nombre, apellido, ci);
            retorno = (this.RepoPersonas.Add(unaP) ? true : false);
            return retorno;
        }
        #endregion
        #region ManejoClientes
        public bool AgregarCliente(string nombre, string apellido, string ci, string direccionFactura)
        {
            bool retorno = false;
            Cliente unC = new Cliente(nombre, apellido, ci, direccionFactura);
            retorno = (this.RepoClientes.Add(unC) ? true : false);
            return retorno;
        }
        #endregion
        #region ManejoPasajeros
        public bool AgregarPasajero(string nombre, string apellido, string ci, double puntos)
        {
            bool retorno = false;
            Pasajero unP = new Pasajero(nombre, apellido, ci, puntos);
            retorno = (this.RepoPasajeros.Add(unP) ? true : false);
            return retorno;
        }
        #endregion
        #region ManejoContratos
        public bool AgregarContrato(Excurcion ex, Cliente cliente, IList<Pasajero> listaPasajeros, string id)
        {
            bool retorno = false;
            Contrato unC = new Contrato(ex, cliente, listaPasajeros, id);
            retorno = (this.RepoContratos.Add(unC) ? true : false);            
            return retorno;
        }

        #endregion
        #region ManejoExcurciones
        public bool AgregarExcurcionNac(string codigo, string descripcion, DateTime fechaComienzo, 
            IList<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, 
            IList<Pasajero> pasajeros, double descuento)
        {
            bool retorno = false;
            Nacional unaE = new Nacional(codigo, descripcion, fechaComienzo, hojaRuta, diasTraslado, stock, puntos, pasajeros, descuento);
            retorno = (this.RepoExcurciones.Add(unaE) ? true : false);
            return retorno;
        }
        #endregion
        #region ManejoDestinos
        public bool AgregarDestino(string nombre, string ciudad, string pais, string id)
        {
            bool retorno = false;
            Destino unD = new Destino(nombre, ciudad, pais, id);
            retorno = RepoDestinos.Add(unD);
            return retorno;
        }
        #endregion






        
    }
}
