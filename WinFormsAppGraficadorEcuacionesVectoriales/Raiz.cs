using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    class Raiz : Circunferencia
    {
        public override void Encender(Bitmap pixelVector)
        {
            {
                double varT = 0;
                double varDt = 0.001;
                Vector objVector = new (0, 0, color);

                do
                {
                    objVector.varX0 = varX0 + varRad * Math.Sin(2 * varT);
                    objVector.varY0 = varY0 + varRad * Math.Cos(3 * varT);

                    objVector.Encender(pixelVector);
                    varT += varDt;
                } while (varT <= 2 * (Math.PI));
            }
        }
    }
}
