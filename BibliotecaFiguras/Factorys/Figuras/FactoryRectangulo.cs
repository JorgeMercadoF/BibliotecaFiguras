using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaFiguras
{
    public class FactoryRectangulo : FactoriaBaseFiguras, IFactoryFiguras
    {

        public FactoryRectangulo(int anchuraPlancha, int alturaPlancha) : base(anchuraPlancha, alturaPlancha)
        {}
        public IFigura DameFigura(int ladoHorizontal, int ladoVertical, int x, int y)
        {
            Rectangulo MiRectangulo = new Rectangulo(x, y);
            if (
                (x < 0) ||
                (x + ladoHorizontal > anchuraPlancha) ||
                (y < 0) ||
                (y + ladoVertical > alturaPlancha))
            {
                return default(Rectangulo);
            }
            else
            {
                MiRectangulo.LadoCorto = ladoHorizontal;
                MiRectangulo.LadoLargo = ladoVertical;
                return MiRectangulo;
            }
        }
    }
    
    
}
