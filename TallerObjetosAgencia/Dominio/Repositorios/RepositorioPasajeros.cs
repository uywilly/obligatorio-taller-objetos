﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Repositorios
{
    public class RepositorioPasajeros : IRepositorio<Pasajero>
    {
        private IList<Pasajero> listaPasajeros = new List<Pasajero>();
        public IEnumerable<Pasajero> List
        {
            get { return this.listaPasajeros; }
        }

        public bool Add(Pasajero entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Pasajero entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pasajero entity)
        {
            throw new NotImplementedException();
        }

        public Pasajero FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}