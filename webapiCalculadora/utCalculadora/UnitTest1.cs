using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapiCalculadora.Controllers;

namespace utCalculadora
{
    [TestClass]
    public class UnitTest1Calculadora
    {
        [TestMethod]
        public void TestAddGet1()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;


            //Act = Ejecucion
            int result = calc.Add(numa, numb);
            // Assert = Verificacion
            Assert.AreEqual(numres, result);
        }
    }
}
