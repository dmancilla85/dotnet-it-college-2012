using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class ValidarUsuario
    {
        private Libreria.Entidad.Persona pers = new Libreria.Entidad.Persona("Juan", "Perez");

        public ValidarUsuario()
        {
            this.nombre = "Sin asignar";
            this.password = "Sin asignar";
        }

        public ValidarUsuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        public bool autenticar()
        {
            return nombre.Equals("David") && password.Equals("123789");
         }
    }
}
