using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_POO_clases
{
    public abstract class Animal
    {
        public int CantidadPatas { get; set; }

        public Animal(int CantidadPatas)
        {
            this.CantidadPatas = CantidadPatas;


        }

        public abstract string Caminar();

        public abstract string Descripcion();
    }
}
