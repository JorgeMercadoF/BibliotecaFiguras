using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaFiguras
{
    public class FactoryCuadrado : FactoriaBaseFiguras, IFactoryFiguras
    {
        public FactoryCuadrado(int anchuraPlancha, int alturaPlancha): base (anchuraPlancha,alturaPlancha)
        {}
        public IFigura DameFigura(int lado, int x, int y)
        {
            Cuadrado MiCuadrado = new Cuadrado(x,y);
            if (
                (x < 0) ||
                (x + lado > anchuraPlancha) ||
                (y < 0) ||
                (y + lado > alturaPlancha))
            {
                return default(Cuadrado);
            }
            else
            {
                MiCuadrado.Lado = lado;
                return MiCuadrado;
            }
        }
    }
}
