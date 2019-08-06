using System;

namespace Granja_el_Manzano
{
    class Program
    {
        static void Main(string[] args)
        {
            Productos Datos = new Productos();
            


            Datos.insercion();
            Datos.Imprimir();
            Datos.calcular();


           



            Console.ReadLine();
        }
    }
}
