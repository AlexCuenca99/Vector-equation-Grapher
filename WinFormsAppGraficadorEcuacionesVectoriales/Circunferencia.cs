using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    class Circunferencia : Vector
    {
        public double varRad;
        public override void Encender(Bitmap pixelVector)
        {
            double varT = 0;
            double varDt = 0.001;
            Vector objVector = new (0, 0, color);

            do
            {
                objVector.varX0 = varX0 + varRad * Math.Cos(varT);
                objVector.varY0 = varY0 + varRad * Math.Sin(varT);

                int primerTercioR = (int)(37 * (varT - Math.PI)/-Math.PI + 140 * varT / Math.PI);
                int segundoTercioG = (int)(93 * (varT - Math.PI) / -Math.PI + 150 * varT / Math.PI);
                int tercerTercioB = (int)(140 * (varT - Math.PI) / -Math.PI + 30 * varT / Math.PI);

                int primerTercioR2 = (int)(140 * (varT - Math.PI * 2) / -Math.PI + 180 * (varT - Math.PI) / Math.PI);
                int segundoTercioG2 = (int)(150 * (varT - Math.PI * 2) / -Math.PI + 50 * (varT - Math.PI) / Math.PI);
                int tercerTercioB2 = (int)(30 * (varT - Math.PI * 2) / -Math.PI + 10 * (varT - Math.PI) / Math.PI);

                if (varT <= Math.PI)
                {
                    objVector.color = Color.FromArgb(primerTercioR, segundoTercioG, tercerTercioB);
                }
                else
                {
                    objVector.color = Color.FromArgb(primerTercioR2, segundoTercioG2, tercerTercioB2);
                }

                objVector.Encender(pixelVector);

                varT += varDt;
            } while (varT <= 2 * Math.PI);
        }
    }
}
