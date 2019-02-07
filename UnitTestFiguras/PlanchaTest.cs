using System;
using BibliotecaFiguras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFiguras
{
    [TestClass]
    public class PlanchaTest
    {
        [TestMethod]
        public void VerificaSuperficieYPerimetro()
        {
            //Preparación
            FactoryCuadrado factoryCua = new FactoryCuadrado(1000,500);
            IFigura miCuadrado = factoryCua.DameFigura(5,10,15);
            IFigura miCuadrado2 = factoryCua.DameFigura(10, 10, 15);
            FactoryRectangulo factoryRectangulo = new FactoryRectangulo(1000,500);
            IFigura miRectangulo = factoryRectangulo.DameFigura(5,10,10,15);
            IFigura miRectangulo2 = factoryRectangulo.DameFigura(5, 10, 10, 15);
            FactoryCirculo factoryCirculo = new FactoryCirculo(1000, 500);
            IFigura miCirculo = factoryCirculo.DameFigura(5, 10, 15);
            
            Plancha miPlancha = new Plancha();
            miPlancha.addFigura(miCuadrado); //20
            miPlancha.addFigura(miCuadrado2); //40
            miPlancha.addFigura(miRectangulo); //30
            miPlancha.addFigura(miRectangulo2); //30
            miPlancha.addFigura(miCirculo); //31
            float supTotal = miPlancha.dameSuperficie();
            float perTotal = miPlancha.damePerimetro();
            Assert.AreEqual(supTotal, 78.5398163397+225, 0.001, "El calculo de la superficie total no es correcto");
            Assert.AreEqual(perTotal, 151.415926536, 0.001, "El calculo del perimetro a cortar no es correcto");
        }
    }
}
