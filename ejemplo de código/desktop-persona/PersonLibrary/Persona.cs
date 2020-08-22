namespace PersonLibrary
{
    public enum Gender : byte { Masculino, Femenino };

    public class BasePersona
    {
        public enum Gender : byte { Masculino, Femenino };

        public int Edad { get; set; }

        public string Apellido { get; set; }

        public Gender Genero { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public BasePersona()
        {
            Apellido = "Sin asignar";
            Nombre = "Sin asignar";
        }

        public BasePersona(string nombre, string apellido, int edad, Gender genero)
        {
            this.Apellido = apellido;
            this.Edad = edad;
            this.Genero = genero;
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            return "\r\n" + Nombre + " " + Apellido + " (" +
                    Genero + ") Edad " + Edad;
        }
    }

    public class Manager : BasePersona
    {
        public string DirLaboral { get; set; }

        public string TelLaboral { get; set; }

        public Manager()
            : base()
        {
            this.DirLaboral = "Sin asignar";
            this.TelLaboral = "Sin asignar";
        }

        public Manager(string nombre, string apellido, int edad,
                       Gender genero, string telLab, string dirLab)
            : base(nombre, apellido, edad, genero)
        {
            this.DirLaboral = dirLab;
            this.TelLaboral = telLab;
        }

        public Manager(BasePersona bp)
            : base(bp.Nombre, bp.Apellido, bp.Edad, bp.Genero)
        {
            this.DirLaboral = "Sin asignar";
            this.TelLaboral = "Sin asignar";
        }

        public override string ToString()
        {
            return base.ToString() + "TEL: " + this.TelLaboral + ". Dir. Lab: " + this.DirLaboral;
        }
    }
}