using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaFiguras
{
    public class FactoriaBaseFiguras
    {
        protected int anchuraPlancha, alturaPlancha;
        public FactoriaBaseFiguras(int anchuraPlancha, int alturaPlancha)
        {
            this.anchuraPlancha = anchuraPlancha;
            this.alturaPlancha = alturaPlancha;
        }

    }
}
