using System.Data;
using System.Data.SqlClient;

namespace dacFacturacion
{
    public class AdminCliente
    {

        public static DataSet TraerTodos()
        {
            const string strQuery = @"SELECT id, nombre, apellido, fechaNacimiento, localidad FROM Cliente";
            DataSet dsClientes = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(strQuery, AdminDB.ConectarDB());
            adapter.Fill(dsClientes, @"Clientes");
            return dsClientes;
        }

        public static DataSet TraerTodos(string localidad)
        {
            /*const string strQuery = @"SELECT id, nombre, apellido, fechaNacimiento, localidad FROM Cliente WHERE Localidad = @local";
            DataSet dsClientes = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(strQuery, AdminDB.ConectarDB());
            adapter.SelectCommand.Parameters.Add(@"@local", SqlDbType.VarChar, 50).Value = localidad;
            adapter.Fill(dsClientes, @"Clientes");
            return dsClientes;*/
            DataSet ds = new DataSet();

            const string sp = @"traerTodosClientePorLocalidad";
            using (SqlConnection conn = AdminDB.ConectarDB())
            {
                SqlCommand comm = new SqlCommand
                {
                    CommandText = sp,
                    CommandType = CommandType.StoredProcedure,
                    Connection = conn
                };
                comm.Parameters.Add(@"@Localidad", SqlDbType.VarChar, 50).Value = localidad;

                SqlDataAdapter da = new SqlDataAdapter(comm);
             
                da.Fill(ds);
                System.Console.WriteLine("Tablas: " + ds.Tables[0].Rows.Count);

                return ds;
            }

        }

        public static int Insertar(Cliente cliente)
        {
            const string sp = @"insertarCliente";

            using (SqlConnection conn = AdminDB.ConectarDB())
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = sp;
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                comm.Parameters.Add(@"@Nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                comm.Parameters.Add(@"@Apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                comm.Parameters.Add(@"@FechaNacimiento", SqlDbType.VarChar, 50).Value = cliente.FechaNacimiento;
                comm.Parameters.Add(@"@Localidad", SqlDbType.VarChar, 50).Value = cliente.Localidad;

                return comm.ExecuteNonQuery();
            }
        }

        public static int Actualizar(Cliente cliente)
        {
            const string sp = @"modificarCliente";

            using (SqlConnection conn = AdminDB.ConectarDB())
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = sp;
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                comm.Parameters.Add(@"@Nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                comm.Parameters.Add(@"@Apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                comm.Parameters.Add(@"@FechaNacimiento", SqlDbType.VarChar, 50).Value = cliente.FechaNacimiento;
                comm.Parameters.Add(@"@Localidad", SqlDbType.VarChar, 50).Value = cliente.Localidad;

                return comm.ExecuteNonQuery();
            }
        }
    }
}
