using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExceptionH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionH.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ExceptionH;

    
    
        [TestClass]
        public class LogicTests
        {
            [TestMethod]
            public void TestLanzarExcepcionPersonalizada()
            {
                try
                {
                    Logic.LanzarExcepcionPersonalizada();
                }
                catch (MiExcepcion ex)
                {
                    Assert.AreEqual(" Ocurrió un error: ¡Esta es una excepción mia desde la lógica!", ex.Message);
                }
            }
        }
}
