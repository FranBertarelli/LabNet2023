using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    using System;

    public abstract class TransportePublico
    {
        private int pasajeros;

        public int Pasajeros
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }

    public class Omnibus : TransportePublico
    {
        private bool avanzando = false;
        private static int contador = 1;
        private int numero;

        public int Numero
        {
            get { return numero; }
        }

        public Omnibus()
        {
            numero = contador++;
        }

        public override void Avanzar()
        {
            if (!avanzando)
            {
                Console.WriteLine("Presiona 'Enter' para avanzar el ómnibus.");
                Console.ReadLine();
                Console.WriteLine($"El ómnibus {numero} está avanzando.");
                avanzando = true;
            }
            else
            {
                Console.WriteLine($"\nEl ómnibus {numero} ya está avanzando.");
            }
        }

        public override void Detenerse()
        {
            if (avanzando)
            {
                Console.WriteLine("Presiona 'enter' para detener el ómnibus.");
                Console.ReadLine();
                Console.WriteLine($"El ómnibus {numero} se ha detenido.");
                avanzando = false;
            }
            else
            {
                Console.WriteLine($"\nEl ómnibus {numero} ya está detenido.");
            }
        }
    }

    public class Taxi : TransportePublico
    {
        private bool avanzando = false;
        private static int contador = 1;
        private int numero;

        public int Numero
        {
            get { return numero; }
        }

        public Taxi()
        {
            numero = contador++;
        }

        public override void Avanzar()
        {
            if (!avanzando)
            {
                Console.WriteLine("Presiona 'Enter' para avanzar el taxi.");
                Console.ReadLine();
                Console.WriteLine($"El taxi {numero} está avanzando.");
                avanzando = true;
            }
            else
            {
                Console.WriteLine($"\nEl taxi {numero} ya está avanzando.");
            }
        }

        public override void Detenerse()
        {
            if (avanzando)
            {
                Console.WriteLine("Presione 'Enter' para detener el taxi.");
                Console.ReadLine();
                Console.WriteLine($"El taxi {numero} se ha detenido.");
                avanzando = false;
            }
            else
            {
                Console.WriteLine($"\nEl taxi {numero} ya está detenido.");
            }
        }
    }    
}