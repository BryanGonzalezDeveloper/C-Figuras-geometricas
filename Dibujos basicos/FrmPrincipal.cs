using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dibujos_basicos
{
    public partial class FrmPrincipal : Form
    {
        ClsFiguras objDibujo;
        public FrmPrincipal()
        {
            InitializeComponent();
            objDibujo = new ClsFiguras(pbZonaDibujo.CreateGraphics());
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            objDibujo.linea();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            objDibujo.circulo();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            objDibujo.triangulo();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            objDibujo.cuadrado();
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            objDibujo.elipse();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pbZonaDibujo.Image = null;
        }
    }
}
