using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace dacFacturacion
{
    public class Utiles
    {
        public static DataTable  SoloLocalidades()
        {
            SqlConnection conn = 
                new SqlConnection(global::dacFacturacion.Properties.Settings.Default.dbFacturacion);
          
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT Localidad FROM Cliente", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Localidad");

            return ds.Tables["Localidad"];
        }
    }
}
