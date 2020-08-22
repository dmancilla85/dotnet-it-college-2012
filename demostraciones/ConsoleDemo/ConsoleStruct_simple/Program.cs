//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleStruct_simple
//{
//    class Program
//    {
        
//        public struct Empleado
//        {
//        public string pilaNombre;
//        public int age;
//        }

       
//        static void Main(string[] args)
//        {
            
//            Empleado empresaEmpleado;
//            empresaEmpleado.pilaNombre = "Juan";

//           // Console.WriteLine(empresaEmpleado.pilaNombre, empresaEmpleado.age);
//            Console.ReadLine();
            
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleStruct_simple
{
    class Program
    {

        public struct Empleado
        {
            public string pilaNombre;
            public int age;
        }


        static void Main(string[] args)
        {

            Empleado miempl;
         
            Empleado[] empresaEmpleado= new Empleado[2];
            empresaEmpleado[0].pilaNombre = "Juan";
            empresaEmpleado[1].pilaNombre = "pp";

            Console.WriteLine("{0} // {1}",empresaEmpleado[0].pilaNombre, empresaEmpleado[1].pilaNombre);
            Console.ReadLine();

        }
    }
}
