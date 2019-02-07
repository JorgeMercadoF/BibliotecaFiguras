using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaFiguras
{
    public class Cuadrado : IFigura
    {
        private int lado = 0;
        private int x = 0;
        private int y = 0;

        public Cuadrado(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public int Lado
        {
            get
            {
                return this.lado;
            }
            set
            {
                if (value < 0)
                {
                    this.lado = 0;
                }
                else
                {
                    this.lado = value;
                }
            }
        }

        public float DameSuperficie()
        {
            return lado * lado;
        }
    }
}
