using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simulador de Transportes";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("¡            Simulador de        ");
            Console.WriteLine("             Transportes                !");
            Console.WriteLine("------------------------------------------");

            Console.ResetColor();
            Console.WriteLine();

            List<TransportePublico> transportes = GenerarTransportes();

            MostrarTransportes(transportes);

            Console.WriteLine("\nPresiona Enter para salir...gracias por usarme");
            Console.ReadLine();
        }

        static List<TransportePublico> GenerarTransportes()
        {
            List<TransportePublico> transportes = new List<TransportePublico>();

            for (int i = 0; i < 5; i++)
            {
                Omnibus omnibus = new Omnibus();
                int pasajeros;
                while (true)
                {
                    Console.Write($"Ingresa el número de pasajeros para el ómnibus {omnibus.Numero} (máximo 100): ");
                    if (int.TryParse(Console.ReadLine(), out pasajeros) && pasajeros >= 0 && pasajeros <= 100)
                    {
                        omnibus.Pasajeros = pasajeros;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ingresa un número entero positivo entre 0 y 100. dale...");
                    }
                }
                transportes.Add(omnibus);
            }

            for (int i = 0; i < 5; i++)
            {
                Taxi taxi = new Taxi();
                int pasajeros;
                while (true)
                {
                    Console.Write($"Ingresa el número de pasajeros para el taxi {taxi.Numero} (máximo 4): ");
                    if (int.TryParse(Console.ReadLine(), out pasajeros) && pasajeros >= 0 && pasajeros <= 4)
                    {
                        taxi.Pasajeros = pasajeros;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ingresa un número entero positivo entre 0 y 4. Entende");
                    }
                }
                transportes.Add(taxi);
            }

            return transportes;
        }

        static void MostrarTransportes(List<TransportePublico> transportes)
        {
            foreach (var transporte in transportes)
            {
                string tipo = (transporte is Omnibus) ? "Omnibus" : "Taxi";

                if (tipo == "Omnibus")
                {
                    Omnibus omnibus = (Omnibus)transporte;
                    Console.WriteLine($"\n{tipo} {omnibus.Numero}: {transporte.Pasajeros} pasajeros");
                }
                else if (tipo == "Taxi")
                {
                    Taxi taxi = (Taxi)transporte;
                    Console.WriteLine($"\n{tipo} {taxi.Numero}: {transporte.Pasajeros} pasajeros");
                }

                transporte.Avanzar();
                transporte.Detenerse();
            }
        }
    }
}