using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Agencia
    {

        private List<Usuario> usuarios;
        private List<Excurcion> excurciones;
        private List<Destino> destinos;
        private List<Contrato> contratos;

        private List<Cliente> cliente;
        private List<Pasajero> pasajeros;
        
        #region Properties
        public List<Usuario> Usuarios
        {
            get { return this.usuarios; }
            set { this.usuarios = value; }
        }
        public List<Excurcion> Excurciones
        {
            get { return this.excurciones; }
            set { this.excurciones = value; }
        }
        public List<Destino> Destinos
        {
            get { return this.destinos; }
            set { this.destinos = value; }
        }
        public List<Contrato> Contratos
        {
            get { return this.contratos; }
            set { this.contratos = value; }
        }


        #endregion
        
        #region Singleton
        private static Agencia instancia = null;

        public static Agencia Instancia
        {
            get { 
                if (instancia ==null) Agencia.instancia = new Agencia();
                return Agencia.instancia;
                }
        }
        private Agencia()
        {
            this.usuarios = new List<Usuario>();
            this.excurciones = new List<Excurcion>();
            this.destinos = new List<Destino>();
            this.Contratos = new List<Contrato>();
        }
        #endregion
        
        #region METODOS
        
        #endregion



    }
}
