using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Dominio.Repositorios;
using Dominio.Entidades;
using Fachadas;
using System.IO; //manejo de archivos
using System.Runtime.Serialization; //serializacion
using System.Runtime.Serialization.Formatters.Binary;//formateador binario-serializacion

namespace Test
{
    public class Class1
    {
        static void Main(string[] args)
        {
            //probar destinos
            FachadaAgencia.Instancia.AgregarDestino("D1-Cancun", "Cancun", "Mexico", "1");
            FachadaAgencia.Instancia.AgregarDestino("D2-NY", "NY", "EEUU", "2");

            foreach (Destino d in FachadaAgencia.Instancia.RepoDestinos.ListaDestinos)
            {
                Console.WriteLine(d.ToString());
            }
            Console.ReadLine();

        }
    }
}
