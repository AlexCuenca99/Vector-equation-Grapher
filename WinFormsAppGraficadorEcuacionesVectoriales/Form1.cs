namespace WinFormsAppGraficadorEcuacionesVectoriales
{
    public partial class Form1 : Form
    {
        // Instancia de un objeto Bitmap que se usará en toda la app.
        private readonly Bitmap objBitmap = new(700, 420);
        private Bitmap objBitmap2 = new(700, 420);
        public Form1()
        {
            InitializeComponent();
        }

        // Combinar dos objetos BMP
        public static Bitmap Combine(params Bitmap[] sources)
        {
            List<int> imageHeights = new();
            List<int> imageWidths = new();
            foreach (Bitmap img in sources)
            {
                imageHeights.Add(img.Height);
                imageWidths.Add(img.Width);
            }
            Bitmap result = new(imageWidths.Max(), imageHeights.Max());
            using (Graphics g = Graphics.FromImage(result))
            {
                foreach (Bitmap img in sources)
                {
                    g.DrawImage(img, Point.Empty);
                }
            }
            return result;
        }

        // Función para crear un plano
        private void Plano()
        {
            Segmento s = new()
            {
                varX0 = 0,
                varY0 = 5.98,
                VarXf = 0,
                VarYf = -5.98,
                color = Color.Blue
            };

            s.Encender(objBitmap2);

            s.varX0 = 9.99;
            s.varY0 = 0;
            s.VarXf = -9.99;
            s.VarYf = 0;

            s.Encender(objBitmap2);
            pictureBox1.Image = objBitmap2;
        }

        private void btnEjercicioI_Click(object sender, EventArgs e)
        {
            Vector vec1 = new(0, 1, Color.Red);
            Vector vec2 = new(-1, 0, Color.Red);
            Vector vec3 = new(1, 0, Color.Red);
            Vector vec4 = new(0, 0, Color.Red);
            Vector vec5 = new(0, 3, Color.Red);
            Vector vec6 = new(5, 0, Color.Red);

            vec1.Encender(objBitmap);
            vec2.Encender(objBitmap);
            vec3.Encender(objBitmap);
            vec4.Encender(objBitmap);
            vec5.Encender(objBitmap);
            vec6.Encender(objBitmap);

            pictureBox1.Image = objBitmap;
        }

        private void btnEjercicioII_Click(object sender, EventArgs e)
        {
            Segmento objSegmento = new()
            {
                varX0 = -7,
                varY0 = -2,
                VarXf = 3,
                VarYf = 4,
                color = Color.Red
            };

            Circunferencia objCircunferencia = new()
            {
                color = Color.Red,
                varRad = 3,
                varX0 = 6,
                varY0 = 1
            };

            objSegmento.Encender(objBitmap);
            objCircunferencia.Encender(objBitmap);

            pictureBox1.Image = objBitmap;
        }

        private void btnApagarPicBox_Click(object sender, EventArgs e)
        {
            /*
            Vector objVector = new();

            objVector.Apagar(objBitmap);
            */

            // Usando las propiedades de la clase PictureBox
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                pictureBox1.Update();
            }
        }

        private void btnEjes2D_Click(object sender, EventArgs e)
        {
            Segmento objSegmento = new();
            Segmento objSegmento2 = new();

            objSegmento.varX0 = -10;
            objSegmento.varY0 = 0;
            objSegmento.VarXf = 10;
            objSegmento.VarYf = 0;
            objSegmento.color = Color.Red;

            objSegmento2.varX0 = 0;
            objSegmento2.varY0 = -5.98;
            objSegmento2.VarXf = 0;
            objSegmento2.VarYf = 5.98;
            objSegmento2.color = Color.Blue;

            objSegmento.Encender(objBitmap);
            objSegmento2.Encender(objBitmap);

            pictureBox1.Image = objBitmap;
        }

        private void btnEjercicioIII_Click(object sender, EventArgs e)
        {
            // Segmento de la parte de arriba
            Segmento objSegmentoArr = new()
            {
                VarXf = -3,
                VarYf = -5,
                varX0 = 6,
                varY0 = 1,
                color = Color.Gray
            };

            // Segmento de la parte de abajo
            Segmento objSegmentoAb = new()
            {
                VarXf = -5,
                VarYf = 5,
                varX0 = 6,
                varY0 = 1,
                color = Color.Gray
            };

            // Grafica de la circuferencia pequeña
            Circunferencia objCircunferenciaPeque = new()
            {
                varRad = 2,
                varX0 = 6,
                varY0 = 1,
                color = Color.Gray
            };

            // Grafica de la circuferencia grande
            Circunferencia objCircunferenciaGrande = new()
            {
                varRad = 4,
                varX0 = -4,
                varY0 = 0,
                color = Color.Gray
            };

            // Grafica del lazo pequeño
            Lazo objLazoPeque = new()
            {
                varRad = 1,
                varX0 = -4,
                varY0 = 0,
                color = Color.Blue
            };

            // Grafica del lazo grande
            Lazo objLazoGrande = new()
            {
                varRad = 1.3,
                varX0 = 8.5,
                varY0 = -3,
                color = Color.Gray
            };

            // Gráfica de raíz
            Raiz objRaiz = new()
            {
                varRad = 1,
                varX0 = 4,
                varY0 = 4,
                color = Color.Red
            };

            objSegmentoArr.Encender(objBitmap);
            objSegmentoAb.Encender(objBitmap);
            objCircunferenciaPeque.Encender(objBitmap);
            objCircunferenciaGrande.Encender(objBitmap);
            objLazoPeque.Encender(objBitmap);
            objLazoGrande.Encender(objBitmap);
            objRaiz.Encender(objBitmap);

            pictureBox1.Image = objBitmap;
        }

        private void btnVector3DEjerII_Click(object sender, EventArgs e)
        {
            Vector3D objVector3D = new(0, 0, 0, Color.Blue);
            double varH = 0;

            do
            {
                objVector3D.varX0 = 2 + (2 * Math.Cos(varH));
                objVector3D.varY0 = 1 + (2 * Math.Sin(varH));
                objVector3D.varZ0 = -2 + (varH / 5);

                objVector3D.color = Color.Blue;
                objVector3D.Encender3D(objBitmap);

                pictureBox1.Image = objBitmap;

                varH += 0.002;
            } while (varH < 18);
        }

        private void btnSegmento3D_Click(object sender, EventArgs e)
        {
            Segmento3D objSegmento3D = new(0, 0, 0, Color.Blue)
            {
                varX0 = 4,
                varY0 = -8,
                varZ0 = 3,
                VarXf = 7,
                VarYf = 10,
                VarZf = -2,
                color = Color.Blue
            };

            objSegmento3D.Encender3D(objBitmap);

            pictureBox1.Image = objBitmap;
        }

        private void btnEjes3D_Click(object sender, EventArgs e)
        {
            //Segemento objSeg3DEje1 Z
            Segmento3D objSeg3DEje1 = new(0, 0, 0, Color.Red)
            {
                varX0 = 0,
                varY0 = 0,
                varZ0 = 0,
                VarXf = 0,
                VarYf = 0,
                VarZf = 5,
                color = Color.Red
            };

            //EJE Y 
            Segmento3D objSeg3DEje2 = new(0, 0, 0, Color.Red)
            {
                varX0 = 0,
                varY0 = 0,
                varZ0 = 0,
                VarXf = 0,
                VarYf = 5,
                VarZf = 0,
                color = Color.Red
            };

            //EJE X 
            Segmento3D objSeg3DEje3 = new(0, 0, 0, Color.Red)
            {
                varX0 = 0,
                varY0 = 0,
                varZ0 = 0,
                VarXf = 8,
                VarYf = 0,
                VarZf = 0,
                color = Color.Red,
            };

            //EJE 4
            Segmento3D objSeg3DEje4 = new(0, 0, 0, Color.Red)
            {
                varX0 = 8,
                varY0 = 0,
                varZ0 = 0,
                VarXf = 8,
                VarYf = 5,
                VarZf = 0,
                color = Color.Red,
            };

            //EJE 5
            Segmento3D objSeg3DEje5 = new(0, 0, 0, Color.Red)
            {
                varX0 = 0,
                varY0 = 5,
                varZ0 = 0,
                VarXf = 8,
                VarYf = 5,
                VarZf = 0,
                color = Color.Red,
            };

            //EJE 6 
            Segmento3D objSeg3DEje6 = new(0, 0, 0, Color.Red)
            {
                varX0 = 0,
                varY0 = 5,
                varZ0 = 5,
                VarXf = 0,
                VarYf = 5,
                VarZf = 0,
                color = Color.Red,
            };

            //EJE 7 
            Segmento3D objSeg3DEje7 = new(0, 0, 0, Color.Red)
            {
                varX0 = 0,
                varY0 = 0,
                varZ0 = 5,
                VarXf = 0,
                VarYf = 5,
                VarZf = 5,
                color = Color.Red,
            };

            //EJE 8 
            Segmento3D objSeg3DEje8 = new(0, 0, 0, Color.Red)
            {
                varX0 = 0,
                varY0 = 0,
                varZ0 = 5,
                VarXf = 8,
                VarYf = 0,
                VarZf = 5,
                color = Color.Red,
            };

            //EJE 9
            Segmento3D objSeg3DEje9 = new(0, 0, 0, Color.Red)
            {
                varX0 = 8,
                varY0 = 0,
                varZ0 = 0,
                VarXf = 8,
                VarYf = 0,
                VarZf = 5,
                color = Color.Red,
            };

            ///////////////////////////////////////////////////
            // Gráfica de espirales 1

            Vector3D objVector3D = new(0, 0, 0, Color.Blue);
            double varH = 0;

            do
            {
                objVector3D.varX0 = 2 + (1 * Math.Cos(varH));
                objVector3D.varY0 = 1 + (2 * Math.Sin(varH));
                objVector3D.varZ0 = -2 + (varH / 7);

                objVector3D.Encender3D(objBitmap);
                pictureBox1.Image = objBitmap;

                varH += 0.0001;
            } while (varH < 15);

            ///////////////////////////////////////////////////
            // Gráfica de espirales 2

            Vector3D espi2 = new(0, 0, 0, Color.Blue);
            double h2 = 0;

            do
            {
                espi2.varX0 = -2 + (1 * Math.Cos(h2));
                espi2.varY0 = 1 + (1 * Math.Sin(h2));
                espi2.varZ0 = h2 / 14;

                espi2.color = Color.Green;

                espi2.Encender3D(objBitmap);
                pictureBox1.Image = objBitmap;

                h2 += 0.0001;
            } while (h2 < 15);

            ///////////////////////////////////////////////////
            // Gráfica de espirales 3

            Vector3D espi3 = new(0, 0, 0, Color.Blue);
            double h3 = 0;

            do
            {
                espi3.varX0 = -2 + (3 * Math.Cos(h3));
                espi3.varY0 = 1 + (2 * Math.Sin(h3));
                espi3.varZ0 = -2 + (h3 / 6);

                espi3.color = Color.HotPink;

                espi3.Encender3D(objBitmap);
                pictureBox1.Image = objBitmap;

                h3 += 0.0001;
            } while (h3 < 11);

            objSeg3DEje1.Encender3D(objBitmap);
            objSeg3DEje2.Encender3D(objBitmap);
            objSeg3DEje3.Encender3D(objBitmap);
            objSeg3DEje5.Encender3D(objBitmap);
            objSeg3DEje4.Encender3D(objBitmap);
            objSeg3DEje6.Encender3D(objBitmap);
            objSeg3DEje7.Encender3D(objBitmap);
            objSeg3DEje8.Encender3D(objBitmap);
            objSeg3DEje9.Encender3D(objBitmap);

            pictureBox1.Image = objBitmap;
        }

        private void btnPractica1805_Click(object sender, EventArgs e)
        {
            // Blue --> Green
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    objBitmap.SetPixel(i, j, Color.FromArgb(0, 255 * i / 700, -255 * (i - 700) / 700));
                }
            }

            // Red -->  Blue
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    objBitmap.SetPixel(i, j, Color.FromArgb(255 * (i - 700) / -700, 0, 255 * i / 700));
                }
            }

            pictureBox1.Image = objBitmap;
        }

        private void btnPrac2505_Click(object sender, EventArgs e)
        {
            // Blue --> Aqua
            /*
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    // objBitmap.SetPixel(i, j, Color.FromArgb(255, 0, 245 * i / 700, 255));
                    objBitmap.SetPixel(i, j, Color.FromArgb(0, (245*i)/700, 255));
                }
            }
            */

            // Blue --> Blanco --> Aqua
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    if (i <= 350)
                    {
                        objBitmap.SetPixel(i, j, Color.FromArgb(0, 0, 255 * (i - 350) / -350));
                    }
                    else
                    {
                        objBitmap.SetPixel(i, j, Color.FromArgb(0, 245 * (i - 350) / 350, 255 * (i - 350) / 350));
                    }
                }
            }

            pictureBox1.Image = objBitmap;
        }

        private void btnPrac2505III_Click(object sender, EventArgs e)
        {
            Vector3D objVector3D = new(0, 0, 0, Color.FromArgb(51, 181, 181));

            double varT = -5;

            do
            {
                double varH = -4;
                do
                {
                    objVector3D.varX0 = varT;
                    objVector3D.varY0 = varH;

                    // Gráfica de la copa
                    // objVector3D.VarZ0 = 0.15 * (Math.Pow(varT, 2) + Math.Pow(varH, 2)) - 5; // 0.262 es el valor de apertura de la copa. Max: 0.2

                    // Gráfica del paraboloide hiperbólico
                    objVector3D.varZ0 = (.15 * (Math.Pow(varT, 2) - Math.Pow(varH, 2))) - 3; // 0.262 es el valor de apertura de la copa. Max: 0.2

                    objVector3D.Encender3D(objBitmap);

                    varH += .08;

                } while (varH <= 4);

                varT += .08;

            } while (varT <= 5);

            pictureBox1.Image = objBitmap;
        }

        private void btnMovParabolico_Click(object sender, EventArgs e)
        {
            Bitmap objBitmapCircunferencia = new(700, 420);
            Bitmap[] sources = new Bitmap[] { objBitmapCircunferencia, objBitmap };

            Circunferencia objCircunferencia = new()
            {
                color = Color.DarkOrange,
                varRad = .35,
            };

            Vector objVectorCurva = new()
            {
                color = Color.Black
            };

            double varT = -3;
            double varTAux = -3;

            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varTAux;
                objVectorCurva.varY0 = (-Math.Pow(varTAux, 2) + (5 * varTAux) + 24) / 6.2;

                objVectorCurva.Encender(objBitmap);

                pictureBox1.Image = objBitmap;

                varTAux += .04;
            } while (varTAux < 8);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT;
                objCircunferencia.varY0 = (-Math.Pow(varT, 2) + (5 * varT) + 24) / 6.2;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);
                varT += .25;
            } while (varT < 8);

        }

        private void btnParabolicoRep_Click(object sender, EventArgs e)
        {
            Bitmap objBitmapCircunferencia = new(700, 420);
            Bitmap[] sources = new Bitmap[] { objBitmapCircunferencia, objBitmap };

            Vector objVectorCurva = new()
            {
                color = Color.Black
            };

            Circunferencia objCircunferencia = new()
            {
                color = Color.DarkOrange,
                varRad = .35,
            };

            double varT = -8, varTAux = -8;
            double varT2 = -4, varT2Aux = -4;
            double varT3 = 0, varT3Aux = 0;
            double varT4 = 4, varT4Aux = 4;

            ////////////////////////////////////////////////////
            /////// SALTO 1
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varTAux;
                objVectorCurva.varY0 = (-Math.Pow(varTAux, 2) - (12 * varTAux) - 32) / 1;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varTAux += .04;

            } while (varTAux < -4);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT;
                objCircunferencia.varY0 = (-Math.Pow(varT, 2) - (12 * varT) - 32) / 1;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT += .25;

            } while (varT < -4);

            ////////////////////////////////////////////////////
            /////// SALTO 2
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varT2Aux;
                objVectorCurva.varY0 = (-Math.Pow(varT2Aux, 2) - (4 * varT2Aux)) / 1.2;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varT2Aux += .04;

            } while (varT2Aux < 0);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT2;
                objCircunferencia.varY0 = (-Math.Pow(varT2, 2) - (4 * varT2)) / 1.2;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT2 += .25;

            } while (varT2 < 0);

            ////////////////////////////////////////////////////
            /////// SALTO 3
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varT3Aux;
                objVectorCurva.varY0 = (-Math.Pow(varT3Aux, 2) + (4 * varT3Aux)) / 1.2;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varT3Aux += .04;

            } while (varT3Aux < 4);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT3;
                objCircunferencia.varY0 = (-Math.Pow(varT3, 2) + (4 * varT3)) / 1.2;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();
                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT3 += .25;
            } while (varT3 < 4);


            ////////////////////////////////////////////////////
            /////// SALTO 4
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varT4Aux;
                objVectorCurva.varY0 = (-Math.Pow(varT4Aux, 2) + (12 * varT4Aux) - 32) / 1.9;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varT4Aux += .04;

            } while (varT4Aux < 8);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT4;
                objCircunferencia.varY0 = (-Math.Pow(varT4, 2) + (12 * varT4) - 32) / 1.9;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();
                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT4 += .25;

            } while (varT4 < 8);
        }

        private void btnCurvaParabolica_Click(object sender, EventArgs e)
        {
            Vector objVectorCurva = new()
            {
                color = Color.Red
            };

            double varT = -3;

            do
            {
                // Dibujo del objeto animado
                objVectorCurva.varX0 = varT;
                objVectorCurva.varY0 = (-Math.Pow(varT, 2) + (5 * varT) + 24) / 6.2;

                objVectorCurva.Encender(objBitmap);

                varT += .25;

            } while (varT < 8);

            pictureBox1.Image = objBitmap;
        }

        private void btnInterpolaciones_Click(object sender, EventArgs e)
        {
            // Degradado de circunferencia
            /*
            Circunferencia objCircunferencia = new()
            {
                varRad = 4,
                varX0 = -4,
                varY0 = 0,
                //color = Color.Gray
            };

            objCircunferencia.Encender(objBitmap);
            pictureBox1.Image = objBitmap
            */

            /*
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    if (i <= 350)
                    {
                        int compR = 138 * (i - 350) / -350 + 255 * i / 350;
                        int compG = 43 * (i - 350) / -350 + 255 * i / 350;
                        int compB = 226 * (i - 350) / -350 + 255 * i / 350;

                        objBitmap.SetPixel(i, j, Color.FromArgb(compR, compG, compB));
                    }
                    else
                    {
                        int comp2R = 255* (i - 700) / -350;
                        int comp2G = 255 * (i - 700) / -350 + 191 * (i-350)/350;

                        objBitmap.SetPixel(i, j, Color.FromArgb(comp2R, comp2G, 255));
                    }
                }
            }
            */

            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {

                    int compG = (255 * (i - 700) / -700) + (165 * i / 700);

                    objBitmap.SetPixel(i, j, Color.FromArgb(255, compG, 0));

                }
            }
            pictureBox1.Image = objBitmap;
        }

        private void btnRepHiperbolico_Click(object sender, EventArgs e)
        {
            Bitmap objBitmapCircunferencia = new(700, 420);

            Bitmap[] sources = new Bitmap[] { objBitmapCircunferencia, objBitmap };

            Vector objVectorCurva = new()
            {
                color = Color.Black
            };

            Circunferencia objCircunferencia = new()
            {
                color = Color.DarkOrange,
                varRad = .25,
            };

            double varT = -7, varTAux = -7;
            double varT2 = -2, varT2Aux = -2;
            double varT3 = 4, varT3Aux = 4;

            /*
            ////////////////////////////////////////////////////
            /////// SALTO 1
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varTAux;
                objVectorCurva.varY0 = (-Math.Pow(varTAux, 2) -5 * varTAux) / 1.22;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varTAux += .04;

            } while (varTAux < 0);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT;
                objCircunferencia.varY0 = (-Math.Pow(varT, 2) -5 * varT) / 1.22;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT += .25;

            } while (varT < 0);

            ////////////////////////////////////////////////////
            /////// SALTO 2
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varT2Aux;
                objVectorCurva.varY0 = (-Math.Pow(varT2Aux, 2) + 4 * varT2Aux) /.88;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varT2Aux += .04;

            } while (varT2Aux < 4);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT2;
                objCircunferencia.varY0 = (-Math.Pow(varT2, 2) +4 * varT2) / 0.88;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT2 += .25;

            } while (varT2 < 4);

            ////////////////////////////////////////////////////
            /////// SALTO 3
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varT3Aux;
                objVectorCurva.varY0 = (-Math.Pow(varT3Aux, 2) + 11 * varT3Aux -28) / .75;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varT3Aux += .04;

            } while (varT3Aux < 7);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT3;
                objCircunferencia.varY0 = (-Math.Pow(varT3, 2) + 11 * varT3 - 28) / .75;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT3 += .25;

            } while (varT3 < 7);
            */

            ////////////////////////////////////////////////////
            /////// SALTO 1
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varTAux;
                objVectorCurva.varY0 = (-Math.Pow(varTAux, 2) - (9 * varTAux) - 14) / 1.23;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varTAux += .04;

            } while (varTAux < -2);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT;
                objCircunferencia.varY0 = (-Math.Pow(varT, 2) - (9 * varT) - 14) / 1.23;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT += .25;

            } while (varT < -2);

            ////////////////////////////////////////////////////
            /////// SALTO 2
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varT2Aux;
                objVectorCurva.varY0 = (Math.Pow(varT2Aux, 2) - 4) / .88;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varT2Aux += .04;

            } while (varT2Aux < 2);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT2;
                objCircunferencia.varY0 = (Math.Pow(varT2, 2) - 4) / 0.88;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT2 += .25;

            } while (varT2 < 2);

            ////////////////////////////////////////////////////
            /////// SALTO 3
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varT3Aux;
                objVectorCurva.varY0 = (-Math.Pow(varT3Aux, 2) + (11 * varT3Aux) - 28) / .75;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varT3Aux += .04;

            } while (varT3Aux < 7);

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT3;
                objCircunferencia.varY0 = (-Math.Pow(varT3, 2) + (11 * varT3) - 28) / .75;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT3 += .25;

            } while (varT3 < 7);
        }

        private void btnPruebaParcialII_Click(object sender, EventArgs e)
        {

        }

        private void btnCorreccion_Click(object sender, EventArgs e)
        {
            double t = -2;

            Vector vector = new()
            {
                color = Color.Blue
            };

            do
            {
                vector.varX0 = t;
                vector.varY0 = 1 / (t + 3);

                vector.color = Color.Blue;

                vector.Encender(objBitmap);

                vector.varY0 = (double)0.3333 - (t / 9) + (Math.Pow(t, 2) / 27);

                t += 0.01;

                vector.color = Color.Red;
                vector.Encender(objBitmap);

            } while (t < 10);

            pictureBox1.Image = objBitmap;
        }

        private void btnOnda_Click(object sender, EventArgs e)
        {
            Onda objOnda = new();
            objOnda.GrafOnda(objBitmap);
            pictureBox1.Image = objBitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onda objOnda = new()
            {
                varW = 2.5
            };

            objOnda.GrafOnda3D(objBitmap);
            pictureBox1.Image = objBitmap;
        }

        private void btnInterferencia_Click(object sender, EventArgs e)
        {
            Onda objOnda = new();
            objOnda.Interferencia(objBitmap);
            pictureBox1.Image = objBitmap;
        }

        private void btnAnimacionOnda_Click(object sender, EventArgs e)
        {
            Onda O = new();
            double h = 0;
            pictureBox1.Image = objBitmap;

            do
            {
                O.GrafOnda(objBitmap);
                pictureBox1.Image = objBitmap;
                pictureBox1.Refresh();
                Thread.Sleep(20);
                h += .06;
                O.varT = h;
            } while (h <= 50);
        }

        private void groupBoxParcial1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxEjes_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAnimacionInterferencia_Click(object sender, EventArgs e)
        {
            Onda objOnda = new();
            double varT = 0;

            double varW = 2;
            double varV = 8.5;

            do
            {
                objOnda.varV = varV;
                objOnda.varW = varW;
                objOnda.Interferencia(objBitmap);
                pictureBox1.Image = objBitmap;
                pictureBox1.Refresh();
                varT += .04;
                objOnda.varT = varT;
            } while (varT < 4);
        }

        private void btnOnda_Click_1(object sender, EventArgs e)
        {
            Onda O = new();
            O.GrafOnda(objBitmap);
            pictureBox1.Image = objBitmap;
        }

        private void btnAnimacionOnda3D1Fuente_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new(700, 420);
            double t = 0;
            Onda o = new()
            {
                varW = 1.5, // Cantidad de ondas
                varV = 3, // Suavidad de animación
            };

            do
            {
                o.varT = t;
                o.GrafOnda3D2Fuentes(bitmap);
                o.Encender(bitmap);
                pictureBox1.Image = bitmap;
                pictureBox1.Refresh();
                bitmap = new Bitmap(700, 420);
                Thread.Sleep(50);
                t += 0.02;
            } while (t <= 7);
        }

        private void btnHuyguens_Click(object sender, EventArgs e)
        {
            Onda o = new()
            {
                varV = 12,
                varW = 2.5,
                varT = 0
            };
            o.Huyguens(objBitmap);
            pictureBox1.Image = objBitmap;
        }

        private void btnPractica0704_Click(object sender, EventArgs e)
        {
            Bitmap objBitmapCircunferencia = new(700, 420);
            Bitmap[] sources = new Bitmap[] { objBitmapCircunferencia, objBitmap };

            Vector objVectorCurva = new()
            {
                color = Color.Red
            };

            Circunferencia objCircunferencia = new()
            {
                color = Color.DarkOrange,
                varRad = .4,
            };

            Vector objVectorLinea = new() { color = Color.Red };

            double varX = -7;

            do
            {
                objVectorLinea.varX0 = varX;
                objVectorLinea.varY0 = (1.2 * varX) + 5.4;

                objVectorLinea.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varX += .06;
            } while (varX < -2);

            double varT = -7;

            do
            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT;
                objCircunferencia.varY0 = (1.2 * varT) + 5.4;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT += .2;

            } while (varT < -2);

            varT = -2;

            double varTAux = -2;

            ////////////////////////////////////////////////////
            /////// SALTO 1
            ///
            do
            {
                // Dibujo de la curva
                objVectorCurva.varX0 = varTAux;
                objVectorCurva.varY0 = ((-Math.Pow(varTAux, 2) + (2 * varTAux) + 8) / 4.5) + 3;

                objVectorCurva.Encender(objBitmap);
                pictureBox1.Image = objBitmap;

                varTAux += .06;

            } while (varTAux < 4);

            do

            {
                // Dibujo del objeto animado
                objCircunferencia.varX0 = varT;
                objCircunferencia.varY0 = ((-Math.Pow(varT, 2) + (2 * varT) + 8) / 4.5) + 3;

                objCircunferencia.Encender(objBitmapCircunferencia);

                pictureBox1.Refresh();

                Thread.Sleep(20);

                pictureBox1.Image = Combine(sources);

                objCircunferencia.Apagar(objBitmapCircunferencia);

                varT += .05;

            } while (varT < 4);
        }

        private void btnEjercicioII_Click_1(object sender, EventArgs e)
        {
            Segmento objSegmento = new()
            {
                varX0 = -7,
                varY0 = -2,
                VarXf = 3,
                VarYf = 4,
                color = Color.Red
            };

            Circunferencia objCircunferencia = new()
            {
                color = Color.Red,
                varRad = 3,
                varX0 = 6,
                varY0 = 1
            };

            objSegmento.Encender(objBitmap);
            objCircunferencia.Encender(objBitmap);

            pictureBox1.Image = objBitmap;
        }

        private void btnEjercicioIII_Click_1(object sender, EventArgs e)
        {
            // Segmento de la parte de arriba
            Segmento objSegmentoArr = new()
            {
                VarXf = -3,
                VarYf = -5,
                varX0 = 6,
                varY0 = 1,
                color = Color.Gray
            };

            // Segmento de la parte de abajo
            Segmento objSegmentoAb = new()
            {
                VarXf = -5,
                VarYf = 5,
                varX0 = 6,
                varY0 = 1,
                color = Color.Gray
            };

            // Grafica de la circuferencia pequeña
            Circunferencia objCircunferenciaPeque = new()
            {
                varRad = 2,
                varX0 = 6,
                varY0 = 1,
                color = Color.Gray
            };

            // Grafica de la circuferencia grande
            Circunferencia objCircunferenciaGrande = new()
            {
                varRad = 4,
                varX0 = -4,
                varY0 = 0,
                color = Color.Gray
            };

            // Grafica del lazo pequeño
            Lazo objLazoPeque = new()
            {
                varRad = 1,
                varX0 = -4,
                varY0 = 0,
                color = Color.Blue
            };

            // Grafica del lazo grande
            Lazo objLazoGrande = new()
            {
                varRad = 1.3,
                varX0 = 8.5,
                varY0 = -3,
                color = Color.Gray
            };

            // Gráfica de raíz
            Raiz objRaiz = new()
            {
                varRad = 1,
                varX0 = 4,
                varY0 = 4,
                color = Color.Red
            };

            objSegmentoArr.Encender(objBitmap);
            objSegmentoAb.Encender(objBitmap);
            objCircunferenciaPeque.Encender(objBitmap);
            objCircunferenciaGrande.Encender(objBitmap);
            objLazoPeque.Encender(objBitmap);
            objLazoGrande.Encender(objBitmap);
            objRaiz.Encender(objBitmap);

            pictureBox1.Image = objBitmap;
        }

        private void btnCuerdaVibrante_Click(object sender, EventArgs e)
        {
            CuerdaVibrante cv = new();
            double t = 0;
            cv.varL = 5;

            do
            {
                cv.Grafico(objBitmap2);
                pictureBox1.Image = objBitmap2;
                Refresh();
                objBitmap2 = null;
                objBitmap2 = new Bitmap(700, 420);
                Plano();
                Thread.Sleep(50);
                cv.varT = t;
                t += .009;
            } while (t <= 2 * Math.PI);
        }

        private void btnPrac0607_Click(object sender, EventArgs e)
        {
            Circunferencia objCircunferencia = new()
            {
                varRad = .4,
                varX0 = -7,
                varY0 = -3
            };

            objCircunferencia.Encender(objBitmap);
            pictureBox1.Image = objBitmap;

            objCircunferencia.varX0 = -2;
            objCircunferencia.varY0 = 3;

            objCircunferencia.Encender(objBitmap);
            pictureBox1.Image = objBitmap;

            objCircunferencia.varX0 = 1;
            objCircunferencia.varY0 = 5;

            objCircunferencia.Encender(objBitmap);
            pictureBox1.Image = objBitmap;

            objCircunferencia.varX0 = 4;
            objCircunferencia.varY0 = 3;

            objCircunferencia.Encender(objBitmap);
            pictureBox1.Image = objBitmap;
        }
    }
}