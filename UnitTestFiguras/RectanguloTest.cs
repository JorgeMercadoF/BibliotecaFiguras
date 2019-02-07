using System;
using BibliotecaFiguras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFiguras
{
    [TestClass]
    public class RectanguloTest
    {
        [TestMethod]
        public void TestearNegativos()
        {
            //Preparación
            Rectangulo miRectangulo = new Rectangulo(10,5);
            miRectangulo.LadoCorto = -5;
            miRectangulo.LadoLargo = -5;
            

            //Ejecución
            float superficie = miRectangulo.DameSuperficie();

            //resultado
            Assert.AreEqual(superficie, 0, 0.001, "Los dos valores negativos no funcionan correctamente");
        }

        [TestMethod]
        public void TestearNegativoPositivo()
        {
            //Preparación
            Rectangulo miRectangulo = new Rectangulo(5,6);
            miRectangulo.LadoCorto = -5;
            miRectangulo.LadoLargo = 5;


            //Ejecución
            float superficie = miRectangulo.DameSuperficie();
            float perimetro = miRectangulo.DamePerimetro();

            //resultado
            Assert.AreEqual(superficie, 0, 0.001, "Un  valor negativo tiene que dar cero en area");
            Assert.AreEqual(perimetro, 0, 0.001, "Los valores negativos no funcionan bien en perimetro");

        }
        [TestMethod]
        public void TestearPositivos()
        {
            //Preparación
            Rectangulo miRectangulo = new Rectangulo(5,56);
            miRectangulo.LadoCorto = 5;
            miRectangulo.LadoLargo = 5;


            //Ejecución
            float superficie = miRectangulo.DameSuperficie();
            float perimetro = miRectangulo.DamePerimetro();
            //resultado
            Assert.AreEqual(superficie, 25, 0.001, "Los valores positivos no funcionan bien");
            Assert.AreEqual(perimetro, 20, 0.001, "Los valores positivos no funcionan bien en perimetro");

        }

        [TestMethod]
        public void TestearCero()
        {
            //Preparación
            Rectangulo miRectangulo = new Rectangulo(67,8);
            miRectangulo.LadoCorto = 0;
            miRectangulo.LadoLargo = 0;


            //Ejecución
            float superficie = miRectangulo.DameSuperficie();
            float perimetro = miRectangulo.DamePerimetro();

            //resultado
            Assert.AreEqual(superficie, 0, 0.001, "Los valores cero no funcionan bien");
            Assert.AreEqual(perimetro, 0, 0.001, "Los valores cero no funcionan bien en perimetro");

        }


    }
}
