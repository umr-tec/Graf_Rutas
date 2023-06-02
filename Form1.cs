using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Graf_Rutas
{
    /*
        Actividad: 1. Dibujar una cruz en el ceentro del Form y esta cruz deberá actualizar su posición si es que el tamaño del Form se redimensionado. 
     *                Dibujar una representación de una ciudad.
     *                Crear la clase para dibujar rectangulos y agregarlos a la lista (recordar que para crear un rectangulo este no tiene radio; los rectangulos tienen ancho y alto).
     *                Cuando se pase por un objetivo especifico (a eleccion del alumno, ej. Plaza de armas.), 
     *                pintar ese elemento de un color distinto al color del Form.  
     */
    public partial class Form1 : Form
    {
        //Crear una lista para cargar todas las figuras
        List<ReglasFiguras> figuras = new List<ReglasFiguras>();
        public Form1()
        {
            InitializeComponent();
            figuras.Add(new Circulos(20, new Point(150, 200), "Plaza armas"));
            figuras.Add(new Circulos(30, new Point(230, 200), "Plaza sin nombre"));
            figuras.Add(new Circulos(10, new Point(150, 120), "Plaza sin existencia"));
            figuras.Add(new Circulos(43, new Point(150, 280), "Plaza Seasmo"));
            figuras.Add(new Circulos(28, new Point(70, 200), "Plaza Compuertas"));
            figuras.Add(new Circulos(115, new Point(150, 200), "Perimetro Estadio Baseball"));
            figuras.Add(new Circulos(20, new Point(100, 150), "Nieves Guerrero"));
        }

        /// <summary>
        /// Se usa el método OnPaint para dibujar las fuguras contenidas en la lista
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Se trabaja con un foreach para recorrer la lista, cada que se encuentre
            //un elemento en la lista, se mandará llamar el método Dibujar
            //por lo que si la lista contiene 10 objetos, se mandará llamar 
            //10 veces el método Dibujar.
            foreach (ReglasFiguras figura in figuras)
            {
                figura.Dibujar(e.Graphics);

            }           
        }

        /// <summary>
        /// Este método permite obtener la distancia del cursor con respexto al centro
        /// </summary>
        /// <param name="loc">Se obtiene la locacion del cursor en el Form</param>
        /// <returns></returns>
        double DistanciaCentro(Point loc)
        {
            Point centroF = new Point(ClientSize.Width / 2, ClientSize.Height / 2);

            int x = loc.X - centroF.X;
            int y = loc.Y - centroF.Y;

            return Math.Sqrt((x * x) + (y + y));
        }

        /// <summary>
        /// Establece el nombre de las figuras y distancia con respecto al centro del Form, en las etiquetas del control StatusStrip1
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            toolStripStatusLabel2.Text = string.Format("{0:N2} del centro", DistanciaCentro(e.Location));

            foreach (ReglasFiguras figs in figuras)
            {
                if (figs.ProbarPosicion(e.Location))
                {
                    toolStripStatusLabel1.Text = "Sobre:  " + figs.NombreFigura();
                }
            }

        }
    }
}
