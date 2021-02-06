using NUnit.Framework;

namespace NunitTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNumeroGet1()
        {
            //Arange=Preparaci�n
            string num1 = "0";
            string esperado = "cero";

            literalController lit = new literalController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroGet(num1);
            
            //Assert.AreEqual(esperado,resultado);

        }

        [Test]
        public void TestNumeroGet2()
        {
            //Arange=Preparaci�n
            string num1 = "5";
            string esperado = "cinco";

            literalController lit = new literalController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroGet(num1);

            //Assert.AreEqual(esperado,resultado);

        }

        [Test]
        public void TestNumeroGet3()
        {
            //Arange=Preparaci�n
            string num1 = "10";
            string esperado = "diez";

            literalController lit = new literalController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroGet(num1);

            //Assert.AreEqual(esperado,resultado);

        }

        [Test]
        public void TestNumeroGet4()
        {
            //Arange=Preparaci�n
            string num1 = "2";
            string esperado = "dos";

            literalController lit = new literalController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroGet(num1);

            //Assert.AreEqual(esperado,resultado);

        }

        [Test]
        public void TestNumeroGet5()
        {
            //Arange=Preparaci�n
            string num1 = "-3";
            string esperado = "menos tres";

            literalController lit = new literalController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroGet(num1);

            //Assert.AreEqual(esperado,resultado);

        }

        [Test]
        public void TestNumeroGet()
        {
            //Arange=Preparaci�n
            string num1 = "1234567,89";
            string esperado = "um mill�n doscientos treinta y cuatro mil quiniento sesenta y siete coma ochenta y nueve";

            literalController lit = new literalController();
            //Act=Ejecuci�n
            string resultado = lit.NumeroGet(num1);

            //Assert.AreEqual(esperado,resultado);

        }

    }
}