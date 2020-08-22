using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManejoEventos
{
    class impresora
    {
        private string _texto;

        //declaraci�n del evento
        public event EventHandler ImpresionOK;

        public impresora(string texto)
        {
            this._texto = texto;
        }

        public void Imprimir()
        {
            Console.Write(this._texto);
            //invocaci�n del evento
            ImpresionOK(_texto, null);
        
        }

    }
}
