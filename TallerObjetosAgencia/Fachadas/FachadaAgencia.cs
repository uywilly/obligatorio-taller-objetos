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
        private string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos");
        private static string ArchivoParametros = AppDomain.CurrentDomain.BaseDirectory + "\\parametros.txt";
        

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
            if (File.Exists(ruta))
            {
                using (FileStream streamR = new FileStream(Path.Combine(ruta, "agencia.dat"), FileMode.OpenOrCreate))
                {

                    BinaryFormatter formateador = new BinaryFormatter();
                    instancia = new FachadaAgencia();
                    instancia = formateador.Deserialize(streamR) as FachadaAgencia;
                }
            }
        }


        public void GuardarParametros(string delimitador)
        {
            if (File.Exists(ArchivoParametros))
            {
                using (StreamWriter sw = new StreamWriter(ArchivoParametros, false))
                {
                    sw.WriteLine("Seguro" + delimitador + Internacional.Seguro);
                    sw.WriteLine("Ultimo" + delimitador + Pasajero.Ultimo);
                }
            }
            //else { File.Create(AppDomain.CurrentDomain.BaseDirectory); }
        }

        private double ObtenerDesdeString(string dato, string delimitador)
        {
            string[] vecDatos = dato.Split(delimitador.ToCharArray());
            return Double.Parse(vecDatos[1]);
        }

        public void Leer(string delimitador)
        {
            StreamReader sr = null;
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory)) return;

            {
                if (File.Exists(ArchivoParametros))
                {
                    using (sr = new StreamReader(ArchivoParametros))
                    {

                        string linea = sr.ReadLine().Trim();

                            Decimal seguro = Decimal.Parse(linea.Split(delimitador.ToCharArray())[1]);
                            linea = sr.ReadLine();
                            int ultimo = int.Parse(linea.Split(delimitador.ToCharArray())[1]);
                            Internacional.Seguro = seguro;
                            Pasajero.Ultimo = ultimo;

                    }
                }
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
            if (this.RepoClientes.Add(unC))
            {
                retorno = true;
                FachadaAgencia.Instancia.SerializarTodo();
                FachadaAgencia.Instancia.GuardarParametros(":");
            }
            return retorno;
        }
        #endregion
        
        #region ManejoPasajeros
        public bool AgregarPasajero(string nombre, string apellido, string ci, double puntos)
        {
            bool retorno = false;
            Pasajero unP = new Pasajero(nombre, apellido, ci, puntos);
            //retorno = (this.RepoPasajeros.Add(unP) ? true : false);
            if(this.RepoPasajeros.Add(unP))
            {
                retorno = true;
                FachadaAgencia.Instancia.SerializarTodo();
                FachadaAgencia.Instancia.GuardarParametros(":");
            }
            return retorno;
        }
        public bool ModificarPasajero(string nombre, string apellido, string ci, double puntos)
        {
            bool retorno = false;
            Pasajero unP = instancia.RepoPasajeros.FindById(ci);
            //verifico si existe el psasajero
            if (unP != null)
            {
                retorno = instancia.RepoPasajeros.Update(unP);
                FachadaAgencia.Instancia.SerializarTodo();
                FachadaAgencia.Instancia.GuardarParametros(":");
            }
            return retorno;
        }
        #endregion

        #region ManejoContratos
        public bool AgregarContrato(Excurcion ex, Cliente cliente, IList<Pasajero> listaPasajeros,DateTime fechaContrato, string id)
        {
            bool retorno = false;
            Contrato unC = new Contrato(ex, cliente, listaPasajeros,fechaContrato, id);
            if (this.RepoContratos.Add(unC))
            {
                retorno = true;
                FachadaAgencia.Instancia.SerializarTodo();
                FachadaAgencia.Instancia.GuardarParametros(":");
            }
            return retorno;
        }

        #endregion

        #region ManejoExcurciones
        public bool AgregarExcurcionNac(string codigo, string descripcion, DateTime fechaComienzo, 
            IList<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, 
            IList<Pasajero> pasajeros, decimal descuento)
        {
            bool retorno = false;
            Nacional unaE = new Nacional(codigo, descripcion, fechaComienzo, hojaRuta, diasTraslado, stock, puntos, pasajeros, descuento);
            if (this.RepoExcurciones.Add(unaE))
            {
                retorno = true;
                FachadaAgencia.Instancia.SerializarTodo();
                FachadaAgencia.Instancia.GuardarParametros(":");
            }
            return retorno;
        }
        public bool AgregarExcurcionInt(string codigo, string descripcion, DateTime fechaComienzo,
            IList<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos,
            IList<Pasajero> pasajeros)
        {
            bool retorno = false;
            Internacional unaI = new Internacional(codigo, descripcion, fechaComienzo, hojaRuta, diasTraslado, stock, puntos, pasajeros);
            if (this.RepoExcurciones.Add(unaI))
            {
                retorno = true;
                FachadaAgencia.Instancia.SerializarTodo();
                FachadaAgencia.Instancia.GuardarParametros(":");
            }
            return retorno;
        }
        public decimal CalcularCosto(Excurcion ex, IList<Pasajero> pasajeros)
        {

            return ex.CostoExcurcion() * pasajeros.Count;
        }
        #endregion

        #region ManejoDestinos
        public bool AgregarDestino(string nombre, string ciudad, string pais, string id)
        {
            bool retorno = false;
            Destino unD = new Destino(nombre, ciudad, pais, id);
            if (RepoDestinos.Add(unD))
            {
                retorno = true;
                FachadaAgencia.Instancia.SerializarTodo();
                FachadaAgencia.Instancia.GuardarParametros(":");
            }
            return retorno;
        }
        public bool EliminarDestino(string nombre, string ciudad, string pais, string id)
        {
            bool retorno = false;
            //Verifico si existe el destino a eliminar
            Destino unD = instancia.RepoDestinos.FindById(id);
            if (unD != null)
            {
                //verifico que el destino no este en uso
                if(RepoExcurciones.FindDestinoById(id) == null)
                {
                    retorno = RepoDestinos.Delete(unD);
                    FachadaAgencia.Instancia.SerializarTodo();
                    FachadaAgencia.Instancia.GuardarParametros(":");
                }
            }
            return retorno;
        }
        #endregion






        
    }
}
