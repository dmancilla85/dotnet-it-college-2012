using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class Mensajes
    {   ///<summary>}
        /// Concatena un mensaje a bienvenido
        /// </summary>
        /// 

        private string nombre;

        public Mensajes()
        {
            nombre = "Sin asignar.";
        }

        public Mensajes(string nombre)
        {
            this.nombre = nombre;
        }

        public string msg(string prmNombre)
        {
            return "Bienvenido a " + prmNombre ;
        }
    }
}
