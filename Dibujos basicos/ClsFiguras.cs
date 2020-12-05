using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Dibujos_basicos
{
    class ClsFiguras
    {
        Graphics areaDibujo;
        Pen pluma = new Pen(Color.Red);
        SolidBrush brocha = new SolidBrush(Color.Black);
        int x = 400;
        int y=300;
        Random alea = new Random();
        public ClsFiguras(Graphics areaDibujo)
        {
            this.areaDibujo = areaDibujo;
        }
        public void linea()
        {
            pluma.Color = generarColorRandom();
            areaDibujo.DrawLine(pluma, alea.Next(x), alea.Next(x), alea.Next(y), alea.Next(y));
        }

        public void circulo()
        {
            brocha.Color = generarColorRandom();
            areaDibujo.FillEllipse(brocha, alea.Next(200), alea.Next(150), (200), (200));
        }

        public void triangulo()
        {
            brocha.Color = generarColorRandom();
            pluma.Color = generarColorRandom();
            x = alea.Next(400);
            y = alea.Next(200) ;
            Point[] Puntos = { new Point(x, y + 200), new Point(x + 100 / 2, y), new Point(x + 100, y + 200) };
            areaDibujo.FillPolygon(brocha, Puntos);
            areaDibujo.DrawPolygon(pluma, Puntos);
        }

        public void cuadrado()
        {
            x=y=alea.Next(200);
            pluma.Color = generarColorRandom();
            areaDibujo.DrawRectangle(pluma, alea.Next(200), alea.Next(200), x, y);
        }

        public void elipse()
        {
            brocha.Color = generarColorRandom();
            areaDibujo.FillEllipse(brocha, alea.Next(200), alea.Next(150), alea.Next(200), alea.Next(200));
        }

        Color generarColorRandom()
        {
            return Color.FromArgb( alea.Next(255) ,alea.Next(255) ,alea.Next(255) );
        }

    }
}
