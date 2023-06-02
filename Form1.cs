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
    }
}
