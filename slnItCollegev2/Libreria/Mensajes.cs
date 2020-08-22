using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public class Mensajes
    {
        /// <summary>
        /// este s para mostrar mensaje de bienvenida
        /// </summary>
        /// <param name="prmNombre">recibe un nombre</param>
        /// <returns></returns>
        public string msj(string prmNombre)
        {
         
            // lblMensaje.Text = "Bienvenido " + txtNombre.Text;
            return "Bienvenido "+ prmNombre;
        }
    }
}
