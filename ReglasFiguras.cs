using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Rutas
{
    abstract class ReglasFiguras
    {
        public abstract void Dibujar(Graphics graphics);
        public abstract bool ProbarPosicion(Point location);
        // public abstract void toString(string nombreFigura);
        public abstract string NombreFigura();
    }
}
