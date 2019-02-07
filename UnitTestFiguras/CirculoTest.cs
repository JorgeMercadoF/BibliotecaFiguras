using System;
using BibliotecaFiguras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFiguras
{
    [TestClass]
    public class CirculoTest
    {
        [TestMethod]
        public void TestearNegativo()
        {
            //Preparación
            Circulo miCirculo = new Circulo(8,4)
            {
                Radio = -5
            };

            //Ejecución
            float superficie = miCirculo.DameSuperficie();
            float perimetro = miCirculo.DamePerimetro();

            //resultado
            Assert.AreEqual(superficie, 0, 0.001, "Los valores negativos no funcionan correctamente en el area");
            Assert.AreEqual(perimetro, 0, 0.001, "Los valores negativos no funcionan bien en perimetro");
        }

        [TestMethod]
        public void TestearPositivo()
        {
            //Preparación
            Circulo miCirculo = new Circulo(8,9)
            {
                Radio = 5
            };

            //Ejecución
            float superficie = miCirculo.DameSuperficie();
            float perimetro = miCirculo.DamePerimetro();
            //resultado
            Assert.AreEqual(superficie, 78.5398163397, 0.001, "Los valores positivos no funcionan correctamente");
            Assert.AreEqual(perimetro, 31.4159265359, 0.001, "Los valores positivos no van bien para el perimetro");
        }

        [TestMethod]
        public void TestearCero()
        {
            //Preparación
            Circulo miCuadrado = new Circulo(10,5)
            {
                Radio = 0
            };

            //Ejecución
            float superficie = miCuadrado.DameSuperficie();
            float perimetro = miCuadrado.DamePerimetro();
            //resultado
            Assert.AreEqual(superficie, 0, 0.001, "Los valores cero no funcionan correctamente");
            Assert.AreEqual(perimetro, 0, 0.001, "Los valores cero no funcionan bien en perimetro");

        }


    }
}
