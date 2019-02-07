using System;
using BibliotecaFiguras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFiguras
{
    [TestClass]
    public class ProductosPrefabricadosTest
    {
        [TestMethod]
        public void TestearAlba()
        {
            IDirectorProducto DirectorDeProducto = new DirectorProducto(new ProductoAlbaBuilder());
            IProducto MiProducto = DirectorDeProducto.DameProducto();
            float superficie = MiProducto.dameSuperficie();
            float perimetro = MiProducto.damePerimetroTotal();

            //resultado
            Assert.AreEqual(superficie, 253.53981634, 0.001, "Producto Alba no calcula bien el area");
            Assert.AreEqual(perimetro, 121.415926536, 0.001, "Producto Alba no calcula bien el perimetro");
        }

        [TestMethod]
        public void TestearManana()
        {
            IDirectorProducto DirectorDeProducto = new DirectorProducto(new ProductoMananaBuilder());
            IProducto MiProducto3 = DirectorDeProducto.DameProducto();
            //Ejecución
            float superficie = MiProducto3.dameSuperficie();
            float perimetro = MiProducto3.damePerimetroTotal();
            //resultado
            Assert.AreEqual(superficie, 392.699081699, 0.001, "Producto Manana no calcula bien la superficie");
            Assert.AreEqual(perimetro, 94.2477796077, 0.001, "Producto Manana no calcula bien el perimetro");
        }

        [TestMethod]
        public void TestearAcabadoPlus()
        {
            IDirectorProducto DirectorDeProducto = new DirectorProducto(new ProductoAcabadoPlusBuilder());
            IProducto MiProducto3 = DirectorDeProducto.DameProducto();

            //Ejecución
            float superficie = MiProducto3.dameSuperficie();
            float perimetro = MiProducto3.damePerimetroTotal();
            //resultado
            Assert.AreEqual(superficie, 2603.53981634, 0.001, "ProductoAcabadoPlus no calcula bien la superficie");
            Assert.AreEqual(perimetro, 251.415926536, 0.001, "ProductoAcabadoPlus no calcula bien el perimetro");

        }


    }
}
