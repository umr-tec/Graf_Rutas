using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graf_Rutas
{
    class Circulos : ReglasFiguras
    {
        //Variables gloabales
        int radio;
        Point centro;
        string nombreFigura;

        //Constructor
        /// <summary>
        /// Constructor para inicializar una instancia de tipo Circulos.
        /// </summary>
        /// <param name="radio">Valor entero para determinar el radio de un circulo</param>
        /// <param name="centro">Valor de tipo Point para deyerminar el origen del radio de un circulo</param>
        /// <param name="nombreFigura">Valor string para asignar un nombre representativo a la figura dibujada</param>
        public Circulos(int radio, Point centro, string nombreFigura) {
            //Asignar los valores de los params a las variables globales (campos)
            this.radio = radio;
            this.centro = centro;
            this.nombreFigura = nombreFigura;
        }

        public override void Dibujar(Graphics graphics)
        {
            //Dibujar el curculo o elipse

            graphics.DrawEllipse(Pens.Black, centro.X, centro.Y, radio * 2, radio * 2);
            graphics.DrawString(nombreFigura, new Font("Arial", 7), Brushes.Black, 10, 10);
        }
    }
}
