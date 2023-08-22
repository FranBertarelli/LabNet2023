using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDeClase
{
    public class Persona : Animal
    {
        public Persona(int CantidadPatas) : base(CantidadPatas)
        {
        }

        public override string Caminar()
        {
            throw new NotImplementedException();
        }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
