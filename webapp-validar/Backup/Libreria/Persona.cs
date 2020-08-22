using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{

    namespace Entidad
    {
        class Persona
        {
            protected string nombre;
            protected string apellido;
            private DateTime f_nac;

            protected DateTime FechaNacimiento
            {
                get { return f_nac; }
                set { f_nac = value; }
            }

            public Persona(string nombre, string apellido)
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

        class Alumno : Persona 
        {
            private string legajo;

            public Alumno() :base()
            {
                this.legajo = "Sin asignar";
            }

            public Alumno(string legajo) :base()
            {
                this.legajo = legajo;
            }

            public Alumno(string nombre, string apellido, string legajo)
                : base(nombre, apellido)
            {
                this.legajo = legajo;
            }

        }
    }
}
