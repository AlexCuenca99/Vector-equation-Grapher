namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    public class Vector
    {
        private readonly int varSx1 = 0;
        private readonly int varSx2 = 700;
        private readonly int varSy1 = 0;
        private readonly int varSy2 = 420;
        private readonly double varX1 = -10;
        private readonly double varX2 = 10;
        private readonly double varY1 = -5.99;
        private readonly double varY2 = 5.99;

        public Color color;

        public double varX0;
        public double varY0;

        public static int XPmin = 0;
        public static int XPmax = 700;
        public static int YPmin = 0;
        public static int YPmax = 420;

        // Coordenadas de la pantalla real
        public static double Xmin = -10;
        public static double Xmax = 10;
        public static double Ymin = -5.98;
        public static double Ymax = 5.98;

        // Constructor sin valores
        public Vector() { }

        // Constructor con valores de X0 varY Y0
        public Vector(double x0, double y0, Color color)
        {
            varX0 = x0;
            varY0 = y0;
            this.color = color;
        }

        public void Pantalla(double varX, double varY, out int varSx, out int varSy)
        {
            varSx = (int)(((varX - varX1) / (varX1 - varX2) * (varSx1 - varSx2)) + varSx1);
            varSy = (int)(((varY - varY2) / (varY2 - varY1) * (varSy1 - varSy2)) + varSy1);
        }

        public void VReal(int varSx, int varSy, out double varX, out double varY)
        {
            varX = ((varSx - varSx1) / (varSx1 - varSx2) * (varX1 - varX2)) + varX1;
            varY = ((varSy - varSy1) / (varSy1 - varSy2) * (varY2 - varY1)) + varY2;
        }
        public void Transforma(int px, int py, out double x, out double y)
        {
            x = ((px - XPmax) * (Xmin - Xmax) / (XPmin - XPmax)) + Xmax;
            y = ((py - YPmax) * (Ymax - Ymin) / (XPmin - YPmax)) + Ymin;
        }

        public virtual void Encender(Bitmap pixelVector)
        {
            Pantalla(varX0, varY0, out int varSx, out int varSy);

            if (varSx >= 0 && varSy >= 0)
            {
                try
                {
                    // Establecer los puntos anteriores en el objeto BITMAP
                    pixelVector.SetPixel(varSx, varSy, color);
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }

        public virtual void Apagar(Bitmap pixelVector)
        {
            for (int Px = 0; Px < 700; Px++)
            {
                for (int Py = 0; Py < 420; Py++)
                {
                    pixelVector.SetPixel(Px, Py, Color.White);
                }
            }

        }
    }
}
