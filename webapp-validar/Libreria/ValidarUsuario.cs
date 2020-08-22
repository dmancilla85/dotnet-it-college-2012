namespace Libreria
{
    public class ValidarUsuario
    {
        public ValidarUsuario()
        {
            Nombre = "Sin asignar";
            Password = "Sin asignar";
        }

        public ValidarUsuario(string nombre, string password)
        {
            this.Nombre = nombre;
            this.Password = password;
        }

        public string Nombre { get; set; }

        public string Password { get; set; }

        public bool Autenticar()
        {
            return Nombre.Equals("David") && Password.Equals("123789");
        }
    }
}