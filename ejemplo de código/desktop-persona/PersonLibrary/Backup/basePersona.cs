using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonLibrary
{
    public enum Gender : byte { Masculino, Femenino };

    public class basePersona
    {
        public enum Gender : byte {Masculino, Femenino };

        private string nombre;
        private string apellido;
        private Gender genero;
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Gender Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public basePersona()
        {
            this.apellido = "Sin asignar";
            this.nombre = "Sin asignar";
        }

        public basePersona(string nombre, string apellido, int edad, Gender genero)
        {
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return "\r\n" + nombre + " " + apellido + " (" + 
                    genero + ") Edad " + edad;
        }
    }

    public class Manager : basePersona
    {
        private string telLaboral;
        private string dirLaboral;

        public string DirLaboral
        {
            get { return dirLaboral; }
            set { dirLaboral = value; }
        }

        public string TelLaboral
        {
            get { return telLaboral; }
            set { telLaboral = value; }
        }

        public Manager()
            : base()
        {
            this.dirLaboral = "Sin asignar";
            this.telLaboral = "Sin asignar";
        }

        public Manager(string nombre, string apellido, int edad, 
                       Gender genero, string telLab, string dirLab) 
            : base(nombre, apellido, edad, genero) 
        {
            this.dirLaboral = dirLab;
            this.telLaboral = telLab;
        }

        public Manager(basePersona bp)
            : base(bp.Nombre, bp.Apellido, bp.Edad, bp.Genero)
        {
            this.dirLaboral = "Sin asignar";
            this.telLaboral = "Sin asignar";
        }

        public override string ToString()
        {
           return base.ToString() + "TEL: " + this.telLaboral + ". Dir. Lab: " + this.dirLaboral;
        }
    }
}
