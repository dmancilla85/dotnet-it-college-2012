using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManejoEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            impresora obj = new impresora("Test de impresi�n ");
            obj.ImpresionOK += new EventHandler(impresionOK);

            obj.Imprimir();

        }

        static void impresionOK(object sender, EventArgs e)
        {
            Console.Write("Ejecuci�n del evento - impresi�n OK");
            Console.ReadLine();
        }
    }
}
