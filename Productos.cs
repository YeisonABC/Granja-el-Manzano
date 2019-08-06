using System;
using System.Collections.Generic;
using System.Text;

namespace Granja_el_Manzano
{
    class Productos
    {

        #region Atributos

        #endregion

        #region Propiedades

            public string Nombre { get; set; }
            public int Valor_Unitario { get; set; }
            public int Cantidad { get; set; }
            public int Valor_Total{ get; set; }
        

        #endregion

        #region Constructores

        public Productos()
        {


        }

        #endregion

        #region Metodos

        public void insercion()
        {
            Console.WriteLine("Ingresa el Nombre ");
            Nombre = Console.ReadLine();

            Console.WriteLine("ingresa el valor unitario");
            Valor_Unitario = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa la cantidad");
            Cantidad = int.Parse(Console.ReadLine());

        }

        public void calcular()
        {
            Valor_Total = Valor_Unitario * Cantidad;
        }

        public void Imprimir()
        {
            Console.WriteLine($"El nombre del producto es: {Nombre}");
            Console.WriteLine($"El valor unitario es: {Valor_Unitario }");
            Console.WriteLine($"La cantidad es: {Cantidad }");
            Console.WriteLine($"El valor total de este producto es:{Valor_Total}");
        }



        #endregion




    }
}
