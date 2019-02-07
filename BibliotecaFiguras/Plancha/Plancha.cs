using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaFiguras
{
    public class Plancha
    {
        List<IFigura> misFiguras;
        public Plancha()
        {
            misFiguras = new List<IFigura>();
        }
        /// <summary>
        /// Añade un objeto que hereda de IFigura
        /// </summary>
        /// <param name="FiguraAPasar">Triangulo, Cuadrado</param>
        public void addFigura(IFigura FiguraAPasar)
        {
            misFiguras.Add(FiguraAPasar);
        }
        public float dameSuperficie()
        {
            float superficie = 0;
            foreach (var miFigura in this.misFiguras)
            {
                superficie += miFigura.DameSuperficie();
            }
            return superficie;
        }
    }
}
