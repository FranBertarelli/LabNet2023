using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExceptionH
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string message) : base("Ocurrió un error: " + message) { }

        public override string Message
        {
            get
            {
                return base.Message;
            }
        }
    }
}