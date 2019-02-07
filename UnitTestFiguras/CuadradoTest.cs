using System;
using BibliotecaFiguras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFiguras
{
    [TestClass]
    public class CuadradoTest
    {


        [TestMethod]
        public void TestearNegativo()
        {
            //Preparación
            Cuadrado miCuadrado = new Cuadrado (5,5)
            {
                Lado = -5
            };

            //Ejecución
            float superficie = miCuadrado.DameSuperficie();
            float perimetro = miCuadrado.DamePerimetro();

            //resultado
            Assert.AreEqual(superficie, 0, 0.001, "Los valores negativos no funcionan correctamente en area");
            Assert.AreEqual(perimetro, 0, 0.001, "Los valores negativos no funcionan bien en perimetro");
        }

        [TestMethod]
        public void TestearPositivo()
        {
            //Preparación
            Cuadrado miCuadrado = new Cuadrado (10,5)
            {
                Lado = 5
            };

            //Ejecución
            float superficie = miCuadrado.DameSuperficie();
            float perimetro = miCuadrado.DamePerimetro();

            //resultado
            Assert.AreEqual(superficie, 25, 0.001, "Los valores positivos no funcionan correctamente en area");
            Assert.AreEqual(perimetro, 20, 0.001, "Los valores positivos no funcionan bien en perimetro");
        }

        [TestMethod]
        public void TestearCero()
        {
            //Preparación
            Cuadrado miCuadrado = new Cuadrado(10, 8)
            {
                Lado = 0
            };


            //Ejecución
            float superficie = miCuadrado.DameSuperficie();
            float perimetro = miCuadrado.DamePerimetro();

            //resultado
            Assert.AreEqual(superficie, 0, 0.001, "Los valores cero no funcionan correctamente en area");
            Assert.AreEqual(perimetro, 0, 0.001, "Los valores negativos no funcionan bien en perimetro");
        }


    }
}
