﻿using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Rol, IEntity  
    {
        /* Completado: 
         *  - Propiedades automaticas
         *  - Constructor
         *  - Validaciones
         *  
         *  Falta:
         *  - Manejo de Id
         *  - ToString + Equals 
         */
        #region Properties
        public string DireccionFactura { get; set; }
        #endregion
        
        #region Constructor
        public Cliente():base()
        {
            this.DireccionFactura = "";
        }
        public Cliente(string nombre, string apellido, string ci, string direccionFactura):base(nombre, apellido, ci)
        {
            this.DireccionFactura = direccionFactura;
        }
        #endregion
       
        #region ToString-Equals
        public override string ToString()
        {
            return "";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion

        #region Validaciones
        public override bool Validar()
        {
            return base.Validar() && !(string.IsNullOrEmpty(this.DireccionFactura.Trim()));
        }
        public override List<Rol.ErroresAltaRol> Validar2()
        {
            List<Rol.ErroresAltaRol> retorno = new  List<Rol.ErroresAltaRol>();
            if (string.IsNullOrEmpty(this.DireccionFactura.Trim()))
                retorno.Add(Rol.ErroresAltaRol.ERR_DIR_ENVIO);
            if (base.Validar2().Contains(Rol.ErroresAltaRol.EXITO) && retorno.Count == 0)
            {
                retorno.Add(Rol.ErroresAltaRol.EXITO);
            }

            return retorno;
        }

        #endregion
    }
}
