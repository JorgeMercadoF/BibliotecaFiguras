using System;
using BibliotecaFiguras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFiguras
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void Comprueba()
        {
            IDirectorProducto DirectorDeProducto = new DirectorProducto(new ProductoAlbaBuilder());
            ProductoAlba MiProducto = (ProductoAlba) DirectorDeProducto.DameProducto();
            ProductoAlba MiProducto2 = (ProductoAlba)DirectorDeProducto.DameProducto();
            DirectorDeProducto.EstableceConstructor(new ProductoMananaBuilder());
            ProductoManana MiProducto3 = (ProductoManana)DirectorDeProducto.DameProducto();
            DirectorDeProducto.EstableceConstructor(new ProductoAcabadoPlusBuilder());
            ProductoAcabadoPlus MiProducto4 = (ProductoAcabadoPlus)DirectorDeProducto.DameProducto();
            //ProductoAlba: Perimetro: 121.415926536 
            //ProductoAlba: Superficie: 253.53981634
            //ProductoManana: Perimetro: 94.2477796077
            //ProductoManana: Superficie: 392.699081699
            //ProductoAcabadoPlus: Perimetro: 231.415926536
            //ProductoAcabadoPlus: Superficie: 2603.53981634



        }
    }
}
