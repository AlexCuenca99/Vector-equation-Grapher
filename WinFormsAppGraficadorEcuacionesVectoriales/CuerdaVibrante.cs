namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    internal class CuerdaVibrante : Vector
    {
        public double varT;
        public double varL;
        public Color color;

        public CuerdaVibrante()
        {

        }
        ~CuerdaVibrante()
        { }

        public void Fourier(double x, out double fou)
        {
            double sumF, varC, varAK, varBK;
            int varK = 1;
            sumF = 0;
            varC = 2;

            do
            {
                varAK = 2 / varL * (varL / 6) * ((FuncionF(0) * Math.Sin(varK * Math.PI * 0 / varL)) + ((4 * FuncionF(varL / 2) * Math.Sin(varK * Math.PI / 2)) + (FuncionF(varL) * Math.Sin(varK * Math.PI))));
                varBK = 2 / (varK * Math.PI * varC) * (varL / 6) * ((FuncionG(0) * Math.Sin(varK * Math.PI * 0 / varL)) + (4 * FuncionG(varL / 2) * Math.Sin(varK * Math.PI / 2)) + (FuncionG(varL) * Math.Sin(varK * Math.PI)));

                sumF += ((varAK * Math.Cos(varK * Math.PI * varC * varT / varL)) + (varBK * Math.Sin(varK * Math.PI * varC * varT / varL))) * Math.Sin(varK * Math.PI * x / varL);

                varK++;
            } while (varK <= 25);

            fou = sumF;
        }

        public double FuncionF(double valIn)
        {
            double aux = valIn / 25 * (valIn - varL);
            return -aux;
        }
        public double FuncionG(double valIn)
        {
            return valIn;
        }

        public void Grafico(Bitmap pantalla)
        {
            double x;
            x = 0;

            Vector objVector = new()
            {
                color = Color.Red
            };

            do
            {
                objVector.varX0 = x;
                Fourier(x, out double fou);
                objVector.varY0 = fou;
                objVector.Encender(pantalla);
                x += .004;
            } while (x <= varL);
        }
    }
}
