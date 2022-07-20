using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    class Segmento3D : Vector3D
    {
        public Segmento3D(double x0, double y0, double z0, Color color) : base(x0, y0, z0, color)
        {
        }

        public double VarXf { get; set; }
        public double VarYf { get; set; }

        public double VarZf { get; set; }

        public override void Encender3D(Bitmap pixelVector)
        {
            double varT = 0;
            double varDt = 0.0001;

            Vector3D objVector3D = new (0, 0, 0, color);

            do
            {
                objVector3D.varX0 = varX0 + (VarXf - varX0) * varT;
                objVector3D.varY0 = varY0 + (VarYf - varY0) * varT;
                objVector3D.varZ0 = varZ0 + (VarZf - varZ0) * varT;

                objVector3D.Encender3D(pixelVector);
                varT += varDt;
            } while (varT <= 1);
        }
    }
}
