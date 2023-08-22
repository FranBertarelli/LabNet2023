using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExceptionEjemplo
{
    public class Logic
    {
        public static void DispararExcepcion()
        {
            try
            {
                throw new CustomException("¡Esta es una excepción personalizada desde la lógica!");
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Excepción personalizada capturada en la lógica:");
                Console.WriteLine("Mensaje: " + ex.Message);
                Console.WriteLine("Tipo de Excepción: " + ex.GetType().FullName);
            }
        }
    }
}