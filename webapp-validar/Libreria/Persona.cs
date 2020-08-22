using System;

namespace Libreria
{
    namespace Entidad
    {
        public class Persona
        {
            protected string nombre;
            protected string apellido;

            protected DateTime FechaNacimiento { get; set; }

            public Persona(string nombre = "", string apellido = "")
            {
                this.nombre = nombre;
                this.apellido = apellido;
            }

            public string Apellido
            {
                get { return apellido; }
                set { apellido = value; }
            }

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
        }

        internal class Alumno : Persona
        {
            private readonly string legajo;

            public Alumno() => this.legajo = "Sin asignar";

            public Alumno(string legajo) : base() => this.legajo = legajo;

            public Alumno(string nombre, string apellido, string legajo)
                : base(nombre, apellido) => this.legajo = legajo;
        }
    }
}