namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    internal class Onda : Vector
    {
        public double varT, varW, varV;

        // Paleta 1
        private readonly Color[] paleta1 = new Color[16]
        {
            Color.Black,
            Color.Navy,
            Color.Green,
            Color.Aqua,
            Color.Red,
            Color.Purple,
            Color.Maroon,
            Color.LightGray,
            Color.DarkGray,
            Color.Blue,
            Color.Lime,
            Color.Silver,
            Color.Teal,
            Color.Fuchsia,
            Color.Yellow,
            Color.White,
        };

        // Paleta 3
        private readonly Color[] paleta3 = new Color[16]
        {
            ColorTranslator.FromHtml("#f72585"),
            ColorTranslator.FromHtml("#b5179e"),
            ColorTranslator.FromHtml("#7209b7"),
            ColorTranslator.FromHtml("#7400b8"),
            ColorTranslator.FromHtml("#6930c3"),
            ColorTranslator.FromHtml("#5e60ce"),
            ColorTranslator.FromHtml("#5390d9"),
            ColorTranslator.FromHtml("#4ea8de"),
            ColorTranslator.FromHtml("#48bfe3"),
            ColorTranslator.FromHtml("#56cfe1"),
            ColorTranslator.FromHtml("#64dfdf"),
            ColorTranslator.FromHtml("#72efdd"),
            ColorTranslator.FromHtml("#80ffdb"),
            ColorTranslator.FromHtml("#d8f3dc"),
            ColorTranslator.FromHtml("#b7e4c7"),
            ColorTranslator.FromHtml("#95d5b2"),
        };

        // Paleta 4
        private readonly Color[] paleta6 = new Color[16] {
            ColorTranslator.FromHtml("#d9ed92"),
            ColorTranslator.FromHtml("#b5e48c"),
            ColorTranslator.FromHtml("#99d98c"),
            ColorTranslator.FromHtml("#76c893"),
            ColorTranslator.FromHtml("#52b69a"),
            ColorTranslator.FromHtml("#34a0a4"),
            ColorTranslator.FromHtml("#168aad"),
            ColorTranslator.FromHtml("#1a759f"),
            ColorTranslator.FromHtml("#1e6091"),
            ColorTranslator.FromHtml("#184e77"),
            ColorTranslator.FromHtml("#240046"),
            ColorTranslator.FromHtml("#3c096c"),
            ColorTranslator.FromHtml("#5a189a"),
            ColorTranslator.FromHtml("#7b2cbf"),
            ColorTranslator.FromHtml("#9d4edd"),
            ColorTranslator.FromHtml("#c77dff"),
        };

        public void GrafOnda(Bitmap objLienzo)
        {
            int i, j, color0;
            double varZ, varW, varV, varM;

            varW = 1.5;
            varV = 4;
            varM = .5;

            _ = new Color[16];

            Color[] paleta2 = new Color[16];

            for (int contI = 0; contI < 16; contI++)
            {
                paleta2[contI] = Color.FromArgb(0, (int)((-1.33 * (contI - 15)) + (17 * contI)), (-2 * (contI - 15)) + (17 * contI));
            }

            Color[] paleta4 = new Color[16];


            for (int contI = 0; contI < 16; contI++)
            {
                paleta4[contI] = Color.FromArgb(17 * contI, 17 * contI, -17 * (contI - 15));
            }

            Color colorC;

            Color[] paleta5 = new Color[16];

            for (int k = 0; k <= 15; k++)
            {
                // coloresOnda1[k] = Color.FromArgb(0, 17 * k, (int)((-6.66 * (k - 15)) + 17* k));
                paleta5[k] = Color.FromArgb(0, 17 * k, (int)((-6.66 * (k - 15)) + (17 * k)));
            }

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 420; j++)
                {
                    Transforma(i, j, out double varX, out double varY);

                    // Math.Sqrt(varX * varX + varY * varY) Hallar la distancia entre dos puntos
                    varZ = (varW * Math.Sqrt((varX * varX) + (varY * varY))) - (varV * varT);
                    varZ = (varM * Math.Sin(varZ)) + 1;
                    // varZ = varM * Math.Sin(varZ);
                    color0 = (int)(varZ * 7.5);
                    colorC = paleta3[color0];
                    objLienzo.SetPixel(i, j, colorC);
                }
            }
        }

        public void GrafOnda3D(Bitmap objLienzo)
        {
            Vector3D v3d = new();

            double varZ, varM, varY, varDt, varH, varDh;
            varM = .9; // Alto de la onda
            varY = -10; // Punto desde el cual comienza a graficar
            varDt = .15; // Cantidad de particulas (detalle)

            do
            {
                varH = -5;
                varDh = 0.1;

                do
                {
                    v3d.varX0 = varY;
                    v3d.varY0 = varH;
                    v3d.color = Color.Red;
                    varZ = (varW * Math.Sqrt(Math.Pow(varY - 0, 2) + Math.Pow(varH + 0, 2))) - (varT * varV);

                    varZ = varM * Math.Sin(varZ);

                    v3d.varZ0 = varM * Math.Sin(varZ);

                    v3d.color = Color.BlueViolet;

                    v3d.Encender3D(objLienzo);

                    varH += varDh;
                } while (varH < 5);
                varY += varDt;
            } while (varY < 8);
        }

        public void GrafOnda3D2Fuentes(Bitmap objLienzo)
        {
            Vector3D v3d = new();

            double varZ, varZ1, varM, varY, varDt, varH, varDh;
            varM = .9;
            varY = -8;
            varDt = .15;

            do
            {
                varH = -5;
                varDh = 0.1;

                do
                {
                    v3d.varX0 = varY;
                    v3d.varY0 = varH;
                    v3d.color = Color.BlueViolet;

                    // 2 FUENTES
                    varZ = (varW * Math.Sqrt(Math.Pow(varY - 1, 2) + Math.Pow(varH - 2, 2))) - (varT * varV);
                    varZ1 = (varW * Math.Sqrt(Math.Pow(varY + 1, 2) + Math.Pow(varH + 2, 2))) - (varT * varV);

                    varZ = varM * Math.Sin(varZ);
                    varZ1 = varM * Math.Sin(varZ1);

                    double varZAux = varZ + varZ1;

                    v3d.varZ0 = varZAux;

                    v3d.Encender3D(objLienzo);

                    varH += varDh;
                } while (varH < 5);
                varY += varDt;
            } while (varY < 8);
        }

        public void Interferencia(Bitmap objLienzo)
        {
            int i, j, colorO;
            double z, z1, z2;

            _ = new Color[16];

            Color[] paleta2 = new Color[16];

            for (int contI = 0; contI < 16; contI++)
            {
                paleta2[contI] = Color.FromArgb(0, (int)((-1.33 * (contI - 15)) + (17 * contI)), (-2 * (contI - 15)) + (17 * contI));
            }

            Color c;

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 420; j++)
                {
                    Transforma(i, j, out double x, out double y);
                    // Original
                    //z1 = (varW * Math.Sqrt(Math.Pow(x - 5, 2) + Math.Pow(y - 0, 2))) - (varV * varT);
                    //z2 = (varW * Math.Sqrt(Math.Pow(x + 5, 2) + Math.Pow(y + 0, 2))) - (varV * varT); 

                    z1 = (varW * Math.Sqrt(Math.Pow(x - 2, 2) + Math.Pow(y - 3, 2))) - (varV * varT);
                    z2 = (varW * Math.Sqrt(Math.Pow(x + 2, 2) + Math.Pow(y - 3, 2))) - (varV * varT);
                    // z3 = varW * (Math.Sqrt((x + 4) * (x + 4) + (y + 5) * (y + 5)) - varV * varT);

                    z1 = Math.Sin(z1) + 1;
                    z2 = Math.Sin(z2) + 1;
                    // z3 = Math.Sin(z3) + 1;

                    // z = z1 + z2 + z3;
                    z = z1 + z2;

                    colorO = (int)(z * 3.6);
                    c = paleta3[colorO];
                    objLienzo.SetPixel(i, j, c);
                }
            }
        }

        public void Huyguens(Bitmap objLienzo)
        {
            int i, j, color0;
            double z, z1;
            Color c;

            //Paleta 2
            _ = new Color[16];

            Color[] paleta2 = new Color[16];

            for (int contI = 0; contI < 16; contI++)
            {
                paleta2[contI] = Color.FromArgb(0, (int)((-1.33 * (contI - 15)) + (17 * contI)), (-2 * (contI - 15)) + (17 * contI));
            }

            for (i = 0; i < 700; i++)
            {
                for (j = 0; j < 420; j++)
                {
                    Transforma(i, j, out double varX, out double varY);
                    z = 0;

                    for (int l = 0; l <= 13; l++)
                    {
                        //z1 = varW * (Math.Sqrt(Math.Sqrt(varX - 6 + l) + Math.Sqrt(varY) - varV * varT));
                        //z = varM * Math.Sin(z1) + z;
                        z1 = varW * (Math.Sqrt(Math.Pow(varX - 6 + l, 2) + Math.Pow(varY + 0, 2)) - (varV * varT));
                        z1 = Math.Sin(z1) + 1;
                        z += z1;
                    }

                    // 15/26
                    color0 = (int)((7 + z) * 15 / 26);
                    c = paleta2[color0];
                    objLienzo.SetPixel(i, j, c);
                }
            }
        }
    }
}
