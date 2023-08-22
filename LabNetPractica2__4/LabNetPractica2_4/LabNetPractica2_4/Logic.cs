using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionH
{
    public class Logic
    {
        public static void LanzarExcepcionPersonalizada()
        {
            throw new MiExcepcion("Excepcion personalizada!");
        }
    }
}