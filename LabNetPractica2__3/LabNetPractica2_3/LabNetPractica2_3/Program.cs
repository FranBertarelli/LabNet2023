using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Llamando al método de lógica...");
                Logic.DispararExcepcion();
            }
            catch (CustomException ex)
            {
                Console.WriteLine("\nExcepción personalizada capturada en la presentación:");
                Console.WriteLine("Mensaje: " + ex.Message);
                Console.WriteLine("Tipo de Excepción: " + ex.GetType().FullName);
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}