using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaFiguras
{
    public class Rectangulo : IFigura
    {
        private int x, y = 0;
        public Rectangulo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        private int ladoLargo, ladoCorto = 0;
        public int LadoLargo
        {
            get
            {
                return this.ladoLargo;
            }
            set
            {
                if (value < 0)
                {
                    this.ladoLargo = 0;
                }
                else
                {
                    this.ladoLargo = value;
                }
            }
        }
        public int LadoCorto
        {
            get
            {
                return this.ladoCorto;
            }
            set
            {
                if (value < 0)
                {
                    this.ladoCorto = 0;
                }
                else
                {
                    this.ladoCorto = value;
                }
            }
        }

        public float DameSuperficie()
        {
            return this.ladoCorto * this.ladoLargo;
        }
    }
}
