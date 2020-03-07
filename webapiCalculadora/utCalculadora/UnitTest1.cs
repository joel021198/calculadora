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


        [TestMethod]
        public void TestAddGet2()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numres = -7;


            //Act = Ejecucion
            int result = calc.Add(numa, numb);
            // Assert = Verificacion
            Assert.AreEqual(numres, result);
        }


        [TestMethod]
        public void TestMultGet1()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 12;


            //Act = Ejecucion
            int result = calc.Mult(numa, numb);
            // Assert = Verificacion
            Assert.AreEqual(numres, result);

        }

        [TestMethod]
        public void TestMultGet2()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = 4;
            int numres = -12;


            //Act = Ejecucion
            int result = calc.Mult(numa, numb);
            // Assert = Verificacion
            Assert.AreEqual(numres, result);
        }






        [TestMethod]
        public void TestAdddecGet1()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            double numas = 0.3;
            double numbs = 0.4;
            double numress = 0.7;


            //Act = Ejecucion
            double result = calc.Adddec(numas, numbs);
            // Assert = Verificacion
            Assert.AreEqual(numress, result);
        }




        [TestMethod]
        public void TestAdd3Get1()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 5;
            int numres = 12;


            //Act = Ejecucion
            int result = calc.Add3(numa, numb,numc);
            // Assert = Verificacion
            Assert.AreEqual(numres, result);
        }




        [TestMethod]
        public void TestAdd3Get2()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb =- 4;
            int numc = -5;
            int numres = -12;


            //Act = Ejecucion
            int result = calc.Add3(numa, numb, numc);
            // Assert = Verificacion
            Assert.AreEqual(numres, result);
        }





        [TestMethod]
        public void TestMult3Get1()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 2;
            int numres = 24;


            //Act = Ejecucion
            int result = calc.Mult3(numa, numb, numc);
            // Assert = Verificacion
            Assert.AreEqual(numres, result);

        }





        [TestMethod]
        public void TestMult3Get2()
        {
            //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numc = -2;
            int numres = -24;


            //Act = Ejecucion
            int result = calc.Mult3(numa, numb, numc);
            // Assert = Verificacion
            Assert.AreEqual(numres, result);

        }
    }
}
