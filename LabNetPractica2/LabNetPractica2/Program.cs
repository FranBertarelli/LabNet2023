using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DivisionException
{
    public class DivisionPorCerop : Exception
    {

        class DivisionPorCero : Exception
        {
            public DivisionPorCero() : base("Error: División por cero. Vas a romper todo") { }
        }

        class Program
        {
            static void DivisionConExcepcion(double valor)
            {
                try
                {
                    if (valor == 0)
                    {
                        throw new DivisionPorCero();
                    }

                    double resultado = 2 / valor;
                    Console.WriteLine("La operación de división fue exitosa. Resultado: " + resultado);
                }
                catch (DivisionPorCero e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Operación Terminada.");
                }
            }

            static void Main(string[] args)
            {
                Console.Write("Ingresa un valor para la división:  ");
                double valorIngresado = double.Parse(Console.ReadLine());
                DivisionConExcepcion(valorIngresado);

                Console.WriteLine("Presiona cualquier tecla para salir. Gracias por usarme");
                Console.ReadKey();
            }
        }
    }
}