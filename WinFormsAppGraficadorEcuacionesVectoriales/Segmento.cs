using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    class Segmento : Vector
    {
        // Getters y setters
        public double VarXf { get; set; }
        public double VarYf { get; set; }

        // Constructor sin valores
        public Segmento()
        {

        }

        public override void Encender(Bitmap pixelVector)
        {
            double varT = 0;
            double varDt = 0.001;

            Vector objVector = new (0, 0, color);

            do
            {
                objVector.varX0 = varX0 + (VarXf - varX0) * varT;
                objVector.varY0 = varY0 + (VarYf - varY0) * varT;

                objVector.Encender(pixelVector);
                varT += varDt;
            } while (varT <= 1);
        }
    }
}
