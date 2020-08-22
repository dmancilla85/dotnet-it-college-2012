namespace Libreria
{
    public class Mensajes
    {   ///<summary>}
        /// Concatena un mensaje a bienvenido
        /// </summary>
        ///
        private readonly string nombre;

        public Mensajes(string nombre)
        {
            this.nombre = nombre;
        }

        public Mensajes(string nombre, string nombre2)
        {
            this.nombre = nombre;
            this.nombre = nombre2;
        }

        public string Msg(string prmNombre)
        {
            return "Bienvenido a " + prmNombre;
        }
    }
}