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

            graphics.DrawEllipse(Pens.Black, centro.X-radio, centro.Y-radio, radio * 2, radio * 2);
            //Con el siguiente metodo se dibujará el nombre que se le asigne a cada
            //Figura, y se dibujará bajo la misma
            graphics.DrawString(nombreFigura, new Font("SimSun", 7), Brushes.Black, new RectangleF(new PointF(centro.X - (radio - 8), centro.Y),
                new SizeF(radio * 2, radio * 2)));
        }

        /// <summary>
        /// Método que validará si el cursor esta sobre alguna figura, este método deberá implementarse en algún evento de tipo Move
        /// </summary>
        /// <param name="location">Obtener la ubicación que se esta sobre el Form</param>
        /// <returns></returns>
        public override bool ProbarPosicion(Point location) {
            Point validar = new Point(location.X - centro.X, location.Y - centro.Y);            
            return validar.X * validar.X + validar.Y * validar.Y <= (radio * radio);
        }

        /// <summary>
        /// Método que regresará el nombre de la Figura sobre la cual esta posicionado el cursor, y obtener el nombre para mostrarlo en un Form u objeto. 
        /// </summary>
        /// <returns></returns>
        public override string NombreFigura() {
            return this.nombreFigura;
        }
    }
}
