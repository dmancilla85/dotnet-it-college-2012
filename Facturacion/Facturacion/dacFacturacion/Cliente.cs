using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dacFacturacion
{
   public class Cliente
    {

        #region"Constructores"
        public Cliente()
        {

        }

        public Cliente(int id)
        {
            this.id = id;
            this.nombre = "";
            this.apellido = "";
            this.localidad = "";
        }

         public Cliente(int id, string nombre, string apellido, string localidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.localidad = localidad;
        }
        #endregion

        #region"Propiedades"

        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        string localidad;

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        #endregion
    }
}
