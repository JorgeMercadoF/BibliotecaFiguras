namespace BibliotecaFiguras
{
    public class FactoryCirculo : FactoriaBaseFiguras, IFactoryFiguras
    {
        public FactoryCirculo(int anchuraPlancha, int alturaPlancha) : base(anchuraPlancha, alturaPlancha)
        { 
        }
        public IFigura DameFigura(int radio, int x, int y)
        {
            Circulo MiCirculo = new Circulo(x, y);
            if (
                (x < 0) ||
                (x + radio > anchuraPlancha) ||
                (y < 0) ||
                (y + radio > alturaPlancha))
            {
                return default(Circulo);
            }
            else
            {
                MiCirculo.Radio = radio;
                return MiCirculo;
            }
        }
    }
}
