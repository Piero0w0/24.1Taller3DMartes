using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Rectangulo
    {
        private int baseRectangulo;
        private int alturaRectangulo;

        public Rectangulo(int baseRectangulo, int alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public int CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }
    }
}
