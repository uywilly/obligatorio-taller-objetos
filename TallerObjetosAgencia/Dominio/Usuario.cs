using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        private string id;
        private string clave;
        private Roles tipo;

        #region Constructor
        public Usuario()
        {
            this.id = "";
            this.clave = "";
            this.tipo = Usuario.Roles.VENDEDOR;
        }
        public Usuario(string id, string clave, Roles rol)
        {
            this.id = id;
            this.clave = clave;
            this.tipo = rol;
        }

        #endregion

        #region Properties
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Clave
        {
            get { return this.clave; }
            set { this.clave = value; }
        }
        public Roles Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        
        #endregion

        #region ToString-Equals
        
        #endregion

        #region ENUM
        public enum Roles
        {
            ADMIN,
            GERENTE,
            VENDEDOR
        }
        #endregion
    }
}
