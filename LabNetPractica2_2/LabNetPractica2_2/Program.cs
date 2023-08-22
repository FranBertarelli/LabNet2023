using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DivisionExceptionExample
{
    public class DivisionPorCeroException : Exception
    {
        public DivisionPorCeroException() : base("AH NOOO, QUIEN SOS OPPENJEIMER O COMO SE ESCRIBA????" +
            "")
        { }
    }

    public class Calculator
    {
        public static double RealizarDivision(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivisionPorCeroException();
            }

            return dividendo / divisor;
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingresa el dividendo: ");
                double dividendo = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el divisor: ");
                double divisor = double.Parse(Console.ReadLine());

                double resultado = RealizarDivision(dividendo, divisor);
                Console.WriteLine($"La división {dividendo} / {divisor} es igual a {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine(" pusiste una letra o no ingresaste nada GENIOUS");
            }
            catch (DivisionPorCeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presiona cualquier tecla para salir del test");
                Console.ReadKey();
            }
        }
    }
}
