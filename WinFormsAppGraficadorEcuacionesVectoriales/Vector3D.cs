using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    class Vector3D : Vector
    {
        public double varZ0;
        public double varAx;
        public double varAy;

        public Vector3D(double x0, double y0, double z0, Color color)
        {
            varX0 = x0;
            varY0 = y0;
            varZ0 = z0;
            this.color = color;
        }
        public Vector3D() { }

        public virtual void Encender3D(Bitmap pixelVector)
        {
            varAx = (varY0 - (varX0 / 2) * (Math.Cos(Math.PI / 4)));
            varAy = (varZ0 - (varX0 / 2) * (Math.Sin(Math.PI / 4)));

            Pantalla(varAx, varAy, out int varSx, out int varSy);

            if ((varSx >= 0 && varSx < 650) && (varSy >= 0 && varSy < 500))
            {
                try
                {
                    // Establecer los puntos anteriores en el objeto BITMAP
                    pixelVector.SetPixel(varSx, varSy, color);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }
    }
}
