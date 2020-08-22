using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace dacFacturacion
{
    internal class AdminDB
    {
        internal static SqlConnection ConectarDB ()
        {
            // Dos formas de llamar a la misma clave
            //string cadena = dacFacturacion.Properties.Settings.Default.dbFacturacion;
            string cadena = global::dacFacturacion.Properties.Settings.Default.dbFacturacion;

            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();

            return conexion;
        }
    }
}
