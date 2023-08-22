using System;

namespace ExceptionHandlingExample
{
    public class Logic
    {
        public static void DispararExcepcion()
        {
            try
            {
                throw new Exception("¡Esta es una excepción provocada desde la lógica!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepción capturada en la lógica:");
                Console.WriteLine("Mensaje: " + ex.Message);
                Console.WriteLine("Tipo de Excepción: " + ex.GetType().FullName);
            }
        }
    }
}}