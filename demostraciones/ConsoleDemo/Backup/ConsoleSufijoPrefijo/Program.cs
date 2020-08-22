using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSufijoPrefijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int objetoCuenta = 42;
            int prefijoValor = ++objetoCuenta;  // prefijoValor == 43 
            Console.WriteLine(objetoCuenta);
            int sufijoValor = objetoCuenta++; // sufijoValor = 43 
            Console.WriteLine(objetoCuenta);

            Console.ReadLine();
        }
    }
}
