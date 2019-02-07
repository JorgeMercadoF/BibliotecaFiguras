using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaFiguras
{
    public class Circulo : IFigura
    {
        int x, y = 0;
        public Circulo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        private int radio = 0;
        public int Radio
        {
            get { return radio; }
            set
            {
                if (value < 0)
                {
                    this.radio = 0;
                }
                else
                {
                    this.radio = value;
                }
            }
        }
        public float DameSuperficie()
        {
            return (float)(Math.PI * radio * radio);
        }

    }
}

// Comentario para probar GitHub