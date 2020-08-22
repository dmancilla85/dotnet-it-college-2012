using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dacDatasetTipado
{
    public class ADminDB
    {
        public static dsFacturacion TraerTodos()
        {
            dsFacturacion ds = new dsFacturacion();
            dsFacturacionTableAdapters.ClienteTableAdapter da = new dsFacturacionTableAdapters.ClienteTableAdapter();

            da.Fill(ds.Cliente);


            return ds;
        }
    }
}
