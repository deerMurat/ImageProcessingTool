using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Drawing.Drawing2D;

namespace ImageProcessingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int imageBit;

        private void GetPixel()
        {
            Color[,] inputImage = new Color[16, 16];
            int imageWidth = 0;
            int imageHeight = 0;

            Color[,] inputImageHist = new Color[16, 16];
            Color rgbColor;

            string[] inputMatRow = richTextBox1.Text.Split('\n');
            string[] inputMatCol;
            int[] pixel;
            Bitmap inputImageMat;
            imageBit = Convert.ToInt32(Math.Pow(Convert.ToDouble(2), Convert.ToDouble(tbImageBit.Text))) - 1;

            try
            {
                int x = 0;
                foreach (string item in inputMatRow)
                {
                    inputMatCol = item.Split(' ');
                    int y = 0;
                    foreach (string dot in inputMatCol)
                    {
                        if (rbGray.Checked) rgbColor = Color.FromArgb(Convert.ToInt32(dot), 0, 0);
                        else
                        {
                            pixel = dot.Split(',').Select(int.Parse).ToArray();
                            rgbColor = Color.FromArgb(pixel[0], pixel[1], pixel[2]);
                        }

                        inputImage[x, y] = rgbColor;
                        y++;
                        imageHeight = y;
                    }
                    x++;
                    imageWidth = x;
                }

                inputImageMat = new Bitmap(imageWidth, imageHeight);

                for (int i = 0; i < imageWidth; i++)
                {
                    for (int j = 0; j < imageHeight; j++)
                    {
                        if (rbGray.Checked)
                        {
                            rgbColor = Color.FromArgb(inputImage[i, j].R, 0, 0);
                            inputImageMat.SetPixel(i, j, rgbColor);
                        }
                    }
                }
                pbInputImage1.Image = inputImageMat;

            }
            catch (Exception)
            {
                MessageBox.Show("Giriş Matrisini Kontrol Ediniz!..");
            }

        }

        private void SetPixel()
        {
            Bitmap resultImageMat;
            resultImageMat = new Bitmap(pbResultImage.Image);
            int imageWidth = resultImageMat.Width;
            int imageHeight = resultImageMat.Height;


            richTextBox2.Text = "";
            for (int i = 0; i < imageWidth; i++)
            {
                for (int j = 0; j < imageHeight; j++)
                {
                    //if (rbGray.Checked) richTextBox2.Text += (String.Format("{0,4} |", resultImageMat.GetPixel(i, j).R.ToString().PadLeft(3,'0'));
                    if (rbGray.Checked) richTextBox2.Text += (String.Format("{0,1} ", resultImageMat.GetPixel(i, j).R.ToString().PadLeft(3, '0')));

                    else richTextBox2.Text += resultImageMat.GetPixel(i, j).R.ToString() + "," + resultImageMat.GetPixel(i, j).G.ToString() + "," + resultImageMat.GetPixel(i, j).B.ToString() + ";";
                }

                richTextBox2.Text += "\n";
            }
        }

        private void btnInputImage1_Click(object sender, EventArgs e)
        {
            OpenImageFile(pbInputImage1, tbInputImage1);
        }

        private void btnInputImage2_Click(object sender, EventArgs e)
        {
            OpenImageFile(pbInputImage2, tbInputImage2);
        }
        private void OpenImageFile(PictureBox pb, TextBox tb)
        {
            string imagePath;
            Bitmap imageFile;
            try
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.ShowDialog();
                imagePath = openFileDialog.FileName;
                pb.Image = System.Drawing.Image.FromFile(imagePath);
                imageFile = new Bitmap(pb.Image);
                tb.Text = System.IO.Path.GetFileName(openFileDialog.FileName) + " (" + imageFile.Width + " x " + imageFile.Height + ") ";
            }
            catch (ApplicationException)
            {
            }
        }

        private void btnRGBComponents_Click(object sender, EventArgs e)
        {
            if (pbInputImage1.Image != null)
            {
                pbResultImage.Image = RGBComponents(pbInputImage1, tbInputImage1);
            }
            else MessageBox.Show("Resim 1 Seçilmedi!");

        }

        private void btnColorToGrayscale_Click(object sender, EventArgs e)
        {
            pbResultImage.Image = ColorToGrayscale(pbInputImage1, tbInputImage1);
        }
        /*
        private void btnArithmeticOp_Click(object sender, EventArgs e)
        {
            if (rbWithConstant.Checked)
            {
                pbResultImage.Image = ArithmeticOperationsWithConstant(pbInputImage1, trackBarConstant, tbResultImage);
            }
            else if (rbWithImage.Checked)
            {
                pbResultImage.Image = ArithmeticOperationsWithImage(pbInputImage1, pbInputImage2, trackBarBlendPer, tbResultImage);
            }
        }
        */
        private Bitmap RGBComponents(PictureBox picBox, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);

            int newR = 0, newG = 0, newB = 0;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    if (rbRGBComponents.Checked)
                    {
                        switch (cbRGBComponents.SelectedIndex)
                        {
                            case 0:
                                newR = rgbColor.R; newG = newB = 0;
                                break;
                            case 1:
                                newG = rgbColor.G; newR = newB = 0;
                                break;
                            case 2:
                                newB = rgbColor.B; newR = newG = 0;
                                break;
                        }
                    }

                    else if (rbArtificialImages.Checked)
                    {
                        switch (cbArtificialImages.SelectedIndex)
                        {
                            case 0:
                                newR = rgbColor.R; newG = rgbColor.G; newB = rgbColor.B;
                                break;
                            case 1:
                                newR = rgbColor.R; newG = rgbColor.B; newB = rgbColor.G;
                                break;
                            case 2:
                                newR = rgbColor.G; newG = rgbColor.R; newB = rgbColor.B;
                                break;
                            case 3:
                                newR = rgbColor.G; newG = rgbColor.B; newB = rgbColor.R;
                                break;
                            case 4:
                                newR = rgbColor.B; newG = rgbColor.R; newB = rgbColor.G;
                                break;
                            case 5:
                                newR = rgbColor.B; newG = rgbColor.G; newB = rgbColor.R;
                                break;
                        }
                    }

                    R = newR; G = newG; B = newB;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            tbResultImage.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap ColorToGrayscale(PictureBox picBox, TextBox txtBox)
        {
            Color rgbColor, grayColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);

            int Gray = 0;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    if (rbSimpleAverage.Checked)
                    {
                        Gray = Convert.ToInt16((rgbColor.R + rgbColor.G + rgbColor.B) / 3);
                    }
                    else if (rbWeightedAverage.Checked)
                    {
                        switch (cbWeightedAverage.SelectedIndex)
                        {
                            case 0:
                                Gray = Convert.ToInt16(0.299 * rgbColor.R + 0.587 * rgbColor.G + 0.114 * rgbColor.B);
                                break;
                            case 1:
                                Gray = Convert.ToInt16(0.2126 * rgbColor.R + 0.7152 * rgbColor.G + 0.0722 * rgbColor.B);
                                break;
                            case 2:
                                Gray = Convert.ToInt16(0.3 * rgbColor.R + 0.59 * rgbColor.G + 0.11 * rgbColor.B);
                                break;
                        }
                    }
                    else if (rbDesaturation.Checked)
                    {
                        Gray = (Math.Max(Math.Max(rgbColor.R, rgbColor.G), rgbColor.B) + Math.Min(Math.Min(rgbColor.R, rgbColor.G), rgbColor.B)) / 2;
                    }
                    else if (rbDecomposition.Checked)
                    {
                        switch (cbDecomposition.SelectedIndex)
                        {
                            case 0:
                                Gray = Math.Max(Math.Max(rgbColor.R, rgbColor.G), rgbColor.B);
                                break;
                            case 1:
                                Gray = Math.Min(Math.Min(rgbColor.R, rgbColor.G), rgbColor.B);
                                break;
                        }
                    }
                    else if (rbSingleColorChannel.Checked)
                    {
                        switch (cbSingleColorChannel.SelectedIndex)
                        {
                            case 0:
                                Gray = rgbColor.R;
                                break;
                            case 1:
                                Gray = rgbColor.G;
                                break;
                            case 2:
                                Gray = rgbColor.B;
                                break;
                        }
                    }
                    R = G = B = Gray;
                    grayColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, grayColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap ArithmeticOperationsWithConstant(PictureBox picBox, int[] trackBarConst, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int constantR = trackBarConst[0];
            int constantG = trackBarConst[1];
            int constantB = trackBarConst[2];

            resultImage = new Bitmap(imageWidth, imageHeight);
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    switch (cbWithConstant.SelectedIndex)
                    {
                        case 0:
                            R = rgbColor.R + constantR;
                            G = rgbColor.G + constantG;
                            B = rgbColor.B + constantB;
                            break;
                        case 1:
                            R = rgbColor.R - constantR;
                            G = rgbColor.G - constantG;
                            B = rgbColor.B - constantB;
                            break;
                        case 2:
                            R = rgbColor.R * constantR;
                            G = rgbColor.G * constantG;
                            B = rgbColor.B * constantB;
                            break;
                        case 3:
                            R = rgbColor.R / constantR;
                            G = rgbColor.G / constantG;
                            B = rgbColor.B / constantB;
                            break;
                    }
                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap ArithmeticOperationsWithImage(PictureBox picBox, PictureBox picBoxSecond, TrackBar txtBlendPercent, TextBox txtBox)
        {
            Color rgbColor, rgbSecondColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, inputSecondImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            inputSecondImage = new Bitmap(picBoxSecond.Image);
            int imageSecondWidth = inputSecondImage.Width;
            int imageSecondHeight = inputSecondImage.Height;
            float blendPercent = Convert.ToSingle(txtBlendPercent.Value) / 100;


            resultImage = new Bitmap(imageWidth, imageHeight);
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    rgbSecondColor = inputSecondImage.GetPixel(x, y);
                    switch (cbWithImage.SelectedIndex)
                    {
                        case 0:
                            R = rgbColor.R + rgbSecondColor.R;
                            G = rgbColor.G + rgbSecondColor.G;
                            B = rgbColor.B + rgbSecondColor.B;
                            break;
                        case 1:
                            R = rgbColor.R - rgbSecondColor.R;
                            G = rgbColor.G - rgbSecondColor.G;
                            B = rgbColor.B - rgbSecondColor.B;
                            break;
                        case 2:
                            R = rgbColor.R * rgbSecondColor.R;
                            G = rgbColor.G * rgbSecondColor.G;
                            B = rgbColor.B * rgbSecondColor.B;
                            break;
                        case 3:
                            R = rgbColor.R / Math.Max(Convert.ToInt32(rgbSecondColor.R), 1);
                            G = rgbColor.G / Math.Max(Convert.ToInt32(rgbSecondColor.G), 1);
                            B = rgbColor.B / Math.Max(Convert.ToInt32(rgbSecondColor.B), 1);
                            break;
                        case 4:
                            R = Convert.ToInt32(rgbColor.R * blendPercent + rgbSecondColor.R * (1 - blendPercent));
                            G = Convert.ToInt32(rgbColor.G * blendPercent + rgbSecondColor.G * (1 - blendPercent));
                            B = Convert.ToInt32(rgbColor.B * blendPercent + rgbSecondColor.B * (1 - blendPercent));
                            break;
                    }

                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap Thresholding(PictureBox picBox, TrackBar trackbarThres, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int threshold = trackbarThres.Value;
            resultImage = new Bitmap(imageWidth, imageHeight);

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    if (rgbColor.R > threshold)
                        R = imageBit;
                    else
                        R = 0;
                    if (rgbColor.G > threshold)
                        G = imageBit;
                    else
                        G = 0;
                    if (rgbColor.B > threshold)
                        B = imageBit;
                    else
                        B = 0;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }


            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap AdaptiveThresholding(PictureBox picBox, ComboBox cbAdapThres, ComboBox cbMatSize, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int sumR, sumG, sumB, meanR, meanG, meanB;
            ArrayList arrayR = new ArrayList();
            ArrayList arrayG = new ArrayList();
            ArrayList arrayB = new ArrayList();
            int medianR, medianG, medianB, minR, maxR, minG, maxG, minB, maxB;
            int matrixSize = Convert.ToInt32(cbMatSize.Text);
            resultImage = new Bitmap(imageWidth, imageHeight);

            switch (cbAdapThres.SelectedIndex)
            {
                case 0: // Mean
                    for (int x = (matrixSize / 2); x < imageWidth - (matrixSize / 2); x++)
                    {
                        for (int y = (matrixSize / 2); y < imageHeight - (matrixSize / 2); y++)
                        {
                            sumR = 0; sumG = 0; sumB = 0;
                            for (int m = -(matrixSize / 2); m <= (matrixSize / 2); m++)
                            {
                                for (int n = -(matrixSize / 2); n <= (matrixSize / 2); n++)
                                {
                                    rgbColor = inputImage.GetPixel(x + m, y + n);
                                    sumR = sumR + rgbColor.R;
                                    sumG = sumG + rgbColor.G;
                                    sumB = sumB + rgbColor.B;
                                }
                            }
                            meanR = sumR / (matrixSize * matrixSize);
                            meanG = sumG / (matrixSize * matrixSize);
                            meanB = sumB / (matrixSize * matrixSize);
                            rgbColor = inputImage.GetPixel(x, y);
                            if (rgbColor.R > meanR)
                                R = imageBit;
                            else
                                R = 0;
                            if (rgbColor.G > meanG)
                                G = imageBit;
                            else
                                G = 0;
                            if (rgbColor.B > meanB)
                                B = imageBit;
                            else
                                B = 0;
                            newColor = Color.FromArgb(R, G, B);
                            resultImage.SetPixel(x, y, newColor);
                        }
                    }
                    break;
                case 1: //Median
                    for (int x = (matrixSize / 2); x < imageWidth - (matrixSize / 2); x++)
                    {
                        for (int y = (matrixSize / 2); y < imageHeight - (matrixSize / 2); y++)
                        {
                            arrayR.Clear(); arrayG.Clear(); arrayB.Clear();
                            for (int m = -(matrixSize / 2); m <= (matrixSize / 2); m++)
                            {
                                for (int n = -(matrixSize / 2); n <= (matrixSize / 2); n++)
                                {
                                    rgbColor = inputImage.GetPixel(x + m, y + n);
                                    arrayR.Add(rgbColor.R);
                                    arrayG.Add(rgbColor.G);
                                    arrayB.Add(rgbColor.B);
                                }
                            }
                            arrayR.Sort(); arrayG.Sort(); arrayB.Sort();
                            medianR = Convert.ToInt32(arrayR[arrayR.Count / 2]);
                            medianG = Convert.ToInt32(arrayG[arrayG.Count / 2]);
                            medianB = Convert.ToInt32(arrayB[arrayB.Count / 2]);
                            rgbColor = inputImage.GetPixel(x, y);
                            if (rgbColor.R > medianR)
                                R = imageBit;
                            else
                                R = 0;
                            if (rgbColor.G > medianG)
                                G = imageBit;
                            else
                                G = 0;
                            if (rgbColor.B > medianB)
                                B = imageBit;
                            else
                                B = 0;
                            newColor = Color.FromArgb(R, G, B);
                            resultImage.SetPixel(x, y, newColor);
                        }
                    }
                    break;
                case 2: //(min+max)/2
                    for (int x = (matrixSize / 2); x < imageWidth - (matrixSize / 2); x++)
                    {
                        for (int y = (matrixSize / 2); y < imageHeight - (matrixSize / 2); y++)
                        {
                            arrayR.Clear(); arrayG.Clear(); arrayB.Clear();
                            for (int m = -(matrixSize / 2); m <= (matrixSize / 2); m++)
                            {
                                for (int n = -(matrixSize / 2); n <= (matrixSize / 2); n++)
                                {
                                    rgbColor = inputImage.GetPixel(x + m, y + n);
                                    arrayR.Add(rgbColor.R);
                                    arrayG.Add(rgbColor.G);
                                    arrayB.Add(rgbColor.B);
                                }
                            }
                            arrayR.Sort(); arrayG.Sort(); arrayB.Sort();
                            minR = Convert.ToInt32(arrayR[0]); maxR = Convert.ToInt32(arrayR[arrayR.Count - 1]);
                            minG = Convert.ToInt32(arrayG[0]); maxG = Convert.ToInt32(arrayG[arrayG.Count - 1]);
                            minB = Convert.ToInt32(arrayB[0]); maxB = Convert.ToInt32(arrayB[arrayB.Count - 1]);
                            R = (minR + maxR) / 2; G = (minG + maxG) / 2; B = (minB + maxB) / 2;
                            rgbColor = inputImage.GetPixel(x, y);
                            if (rgbColor.R > R)
                                R = imageBit;
                            else
                                R = 0;
                            if (rgbColor.G > G)
                                G = imageBit;
                            else
                                G = 0;
                            if (rgbColor.B > B)
                                B = imageBit;
                            else
                                B = 0;
                            newColor = Color.FromArgb(R, G, B);
                            resultImage.SetPixel(x, y, newColor);
                        }
                    }
                    break;
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap Quantization(PictureBox picBox, NumericUpDown txtInter, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0, Tk_1, Tk;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int interval = Convert.ToInt32(txtInter.Text);
            resultImage = new Bitmap(imageWidth, imageHeight);
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    for (int k = 1; k <= interval; k++)
                    {
                        Tk_1 = (k - 1) * imageBit / interval;
                        Tk = k * imageBit / interval;
                        if (Tk_1 <= rgbColor.R & rgbColor.R < Tk)
                            R = (Tk_1 + Tk) / 2;
                        if (Tk_1 <= rgbColor.G & rgbColor.G < Tk)
                            G = (Tk_1 + Tk) / 2;
                        if (Tk_1 <= rgbColor.B & rgbColor.B < Tk)
                            B = (Tk_1 + Tk) / 2;
                    }
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap Convolution(PictureBox picBox, TextBox[,] txtConvMatrix, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k = new int[3, 3];
            resultImage = new Bitmap(imageWidth, imageHeight);

            k[0, 0] = Convert.ToInt32(txtConvMatrix[0, 0].Text); k[0, 1] = Convert.ToInt32(txtConvMatrix[0, 1].Text); k[0, 2] = Convert.ToInt32(txtConvMatrix[0, 2].Text);
            k[1, 0] = Convert.ToInt32(txtConvMatrix[1, 0].Text); k[1, 1] = Convert.ToInt32(txtConvMatrix[1, 1].Text); k[1, 2] = Convert.ToInt32(txtConvMatrix[1, 2].Text);
            k[2, 0] = Convert.ToInt32(txtConvMatrix[2, 0].Text); k[2, 1] = Convert.ToInt32(txtConvMatrix[2, 1].Text); k[2, 2] = Convert.ToInt32(txtConvMatrix[2, 2].Text);

            for (int x = 1; x < imageWidth - 1; x++)
            {
                for (int y = 1; y < imageHeight - 1; y++)
                {
                    sumR = sumG = sumB = 0;
                    for (int m = -1; m <= 1; m++)
                    {
                        for (int n = -1; n <= 1; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k[m + 1, n + 1] * rgbColor.R;
                            sumG = sumG + k[m + 1, n + 1] * rgbColor.G;
                            sumB = sumB + k[m + 1, n + 1] * rgbColor.B;
                        }
                    }
                    R = Convert.ToInt32(((float)1 / 9) * sumR);
                    G = Convert.ToInt32(((float)1 / 9) * sumG);
                    B = Convert.ToInt32(((float)1 / 9) * sumB);
                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap LogarithmOperator(PictureBox picBox, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int cR, cG, cB, maxR, maxG, maxB;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);

            rgbColor = inputImage.GetPixel(0, 0);
            maxR = rgbColor.R; maxG = rgbColor.G; maxB = rgbColor.B;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    if (maxR < rgbColor.R)
                        maxR = rgbColor.R;
                    if (maxG < rgbColor.G)
                        maxG = rgbColor.G;
                    if (maxB < rgbColor.B)
                        maxB = rgbColor.B;
                }
            }
            cR = Convert.ToInt32(imageBit / Math.Log(1 + maxR));
            cG = Convert.ToInt32(imageBit / Math.Log(1 + maxG));
            cB = Convert.ToInt32(imageBit / Math.Log(1 + maxB));

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    R = Convert.ToInt32(cR * Math.Log(1 + rgbColor.R));
                    G = Convert.ToInt32(cG * Math.Log(1 + rgbColor.G));
                    B = Convert.ToInt32(cB * Math.Log(1 + rgbColor.B));
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap HistogramEqualization(PictureBox picBox, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int[] histogramR = new int[(imageBit + 1)];
            int[] histogramG = new int[(imageBit + 1)];
            int[] histogramB = new int[(imageBit + 1)];
            int[] sumHistogramR = new int[(imageBit + 1)];
            int[] sumHistogramG = new int[(imageBit + 1)];
            int[] sumHistogramB = new int[(imageBit + 1)];
            int kR, kG, kB, sumR, sumG, sumB;
            float imageArea;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    kR = rgbColor.R;
                    kG = rgbColor.G;
                    kB = rgbColor.B;
                    histogramR[kR] = histogramR[kR] + 1;
                    histogramG[kG] = histogramG[kG] + 1;
                    histogramB[kB] = histogramB[kB] + 1;
                }
            }

            sumR = sumG = sumB = 0;
            for (int i = 0; i < (imageBit + 1); i++)
            {
                sumR = sumR + histogramR[i];
                sumG = sumG + histogramG[i];
                sumB = sumB + histogramB[i];
                sumHistogramR[i] = sumR;
                sumHistogramG[i] = sumG;
                sumHistogramB[i] = sumB;
            }

            imageArea = imageWidth * imageHeight;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    kR = rgbColor.R;
                    kG = rgbColor.G;
                    kB = rgbColor.B;
                    R = Convert.ToInt32((sumHistogramR[kR] / imageArea) * ((imageBit + 1) - 1));
                    G = Convert.ToInt32((sumHistogramG[kG] / imageArea) * ((imageBit + 1) - 1));
                    B = Convert.ToInt32((sumHistogramB[kB] / imageArea) * ((imageBit + 1) - 1));
                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap Normalization(PictureBox picBox, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int cR, cG, cB, dR, dG, dB, a, b;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);
            rgbColor = inputImage.GetPixel(0, 0);
            cR = dR = rgbColor.R; cG = dG = rgbColor.G; cB = dB = rgbColor.B;

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    if (cR > rgbColor.R)
                        cR = rgbColor.R;
                    if (cG > rgbColor.G)
                        cG = rgbColor.G;
                    if (cB > rgbColor.B)
                        cB = rgbColor.B;
                    if (dR < rgbColor.R)
                        dR = rgbColor.R;
                    if (dG < rgbColor.G)
                        dG = rgbColor.G;
                    if (dB < rgbColor.B)
                        dB = rgbColor.B;
                }
            }
            a = 0; b = imageBit;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    R = (rgbColor.R - cR) * ((b - a) / (dR - cR)) + a;
                    G = (rgbColor.G - cG) * ((b - a) / (dG - cG)) + a;
                    B = (rgbColor.B - cB) * ((b - a) / (dB - cB)) + a;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap Scaling(PictureBox picBox, ComboBox cbSType, ComboBox cbSMethod, NumericUpDown txtFact, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int sumR, sumG, sumB, factor, xR, yR;
            int newR, newG, newB, newRYPlus, newGYPlus, newBYPlus, newRXPlus, newGXPlus, newBXPlus, newRXYPlus, newGXYPlus, newBXYPlus;
            int newRYStep, newGYStep, newBYStep, newRXStep, newGXStep, newBXStep, newRXYStep, newGXYStep, newBXYStep;
            resultImage = new Bitmap(imageWidth, imageHeight);
            factor = Convert.ToInt32(txtFact.Value);

            switch (cbSType.SelectedIndex)
            {
                case 0: // Zoom Out
                    resultImage = new Bitmap(imageWidth / factor, imageHeight / factor);
                    switch (cbSMethod.SelectedIndex)
                    {
                        case 0: // Replacement
                            xR = yR = 0;
                            for (int x = 0; x < imageWidth; x++)
                            {
                                if (x % factor == 0)
                                {
                                    yR = 0;
                                    for (int y = 0; y < imageHeight; y++)
                                    {
                                        if (y % factor == 0)
                                        {
                                            rgbColor = inputImage.GetPixel(x, y);
                                            try
                                            {
                                                resultImage.SetPixel(xR, yR, rgbColor);
                                            }
                                            catch (Exception)
                                            { }

                                            yR = yR + 1;
                                        }
                                    }
                                    xR = xR + 1;
                                }
                            }
                            break;
                        case 1: // Interpolation
                            xR = yR = 0;
                            for (int x = 0; x < imageWidth - factor; x++)
                            {
                                if (x % factor == 0)
                                {
                                    yR = 0;
                                    for (int y = 0; y < imageHeight - factor; y++)
                                    {
                                        if (y % factor == 0)
                                        {
                                            sumR = 0; sumG = 0; sumB = 0;
                                            for (int i = 0; i < factor; i++)
                                            {
                                                for (int j = 0; j < factor; j++)
                                                {
                                                    rgbColor = inputImage.GetPixel(x + i, y + i);
                                                    sumR = sumR + rgbColor.R;
                                                    sumG = sumG + rgbColor.G;
                                                    sumB = sumB + rgbColor.B;
                                                }
                                            }
                                            R = sumR / (factor * factor);
                                            G = sumG / (factor * factor);
                                            B = sumB / (factor * factor);
                                            newColor = Color.FromArgb(R, G, B);
                                            resultImage.SetPixel(xR, yR, newColor);
                                            yR = yR + 1;
                                        }
                                    }
                                    xR = xR + 1;
                                }
                            }
                            break;
                    }
                    break;
                case 1: // Zoom In
                    resultImage = new Bitmap(imageWidth * factor, imageHeight * factor);
                    switch (cbSMethod.SelectedIndex)
                    {
                        case 0: // Replication
                            for (int x = 0; x < imageWidth / factor; x++)
                            {
                                for (int y = 0; y < imageHeight / factor; y++)
                                {
                                    rgbColor = inputImage.GetPixel(x, y);
                                    for (int i = 0; i < factor; i++)
                                    {
                                        for (int j = 0; j < factor; j++)
                                        {
                                            resultImage.SetPixel(x * factor + i, y * factor + j, rgbColor);
                                        }
                                    }
                                }
                            }
                            break;
                        case 1: // Interpolation
                            factor = Convert.ToInt32(tbScalingFactor.Text);
                            for (int x = 0; x < (imageWidth / factor) - 1; x++)
                            {
                                for (int y = 0; y < (imageHeight / factor) - 1; y++)
                                {
                                    rgbColor = inputImage.GetPixel(x, y);
                                    newR = rgbColor.R;
                                    newG = rgbColor.G;
                                    newB = rgbColor.B;
                                    rgbColor = inputImage.GetPixel(x, y + 1);
                                    newRYPlus = rgbColor.R;
                                    newGYPlus = rgbColor.G;
                                    newBYPlus = rgbColor.B;
                                    rgbColor = inputImage.GetPixel(x + 1, y);
                                    newRXPlus = rgbColor.R;
                                    newGXPlus = rgbColor.G;
                                    newBXPlus = rgbColor.B;
                                    rgbColor = inputImage.GetPixel(x + 1, y + 1);
                                    newRXYPlus = rgbColor.R;
                                    newGXYPlus = rgbColor.G;
                                    newBXYPlus = rgbColor.B;
                                    newRYStep = Math.Abs(newR - newRYPlus) / factor;
                                    newGYStep = Math.Abs(newG - newGYPlus) / factor;
                                    newBYStep = Math.Abs(newB - newBYPlus) / factor;
                                    newRXStep = Math.Abs(newR - newRXPlus) / factor;
                                    newGXStep = Math.Abs(newG - newGXPlus) / factor;
                                    newBXStep = Math.Abs(newB - newBXPlus) / factor;
                                    newRXYStep = Math.Abs(newR - newRXYPlus) / factor;
                                    newGXYStep = Math.Abs(newG - newGXYPlus) / factor;
                                    newBXYStep = Math.Abs(newB - newBXYPlus) / factor;
                                    R = newR;
                                    G = newG;
                                    B = newB;
                                    R = Math.Max(Math.Min(R, imageBit), 0);
                                    G = Math.Max(Math.Min(G, imageBit), 0);
                                    B = Math.Max(Math.Min(B, imageBit), 0);
                                    newColor = Color.FromArgb(R, G, B);
                                    resultImage.SetPixel(x * factor, y * factor, newColor);
                                    R = newR + newRYStep;
                                    G = newG + newGYStep;
                                    B = newB + newBYStep;
                                    R = Math.Max(Math.Min(R, imageBit), 0);
                                    G = Math.Max(Math.Min(G, imageBit), 0);
                                    B = Math.Max(Math.Min(B, imageBit), 0);
                                    newColor = Color.FromArgb(R, G, B);
                                    resultImage.SetPixel(x * factor, y * factor + 1, newColor);
                                    R = newR + newRXStep;
                                    G = newG + newGXStep;
                                    B = newB + newBXStep;
                                    R = Math.Max(Math.Min(R, imageBit), 0);
                                    G = Math.Max(Math.Min(G, imageBit), 0);
                                    B = Math.Max(Math.Min(B, imageBit), 0);
                                    newColor = Color.FromArgb(R, G, B);
                                    resultImage.SetPixel(x * factor + 1, y * factor, newColor);
                                    R = newR + newRXYStep;
                                    G = newG + newGXYStep;
                                    B = newB + newBXYStep;
                                    R = Math.Max(Math.Min(R, imageBit), 0);
                                    G = Math.Max(Math.Min(G, imageBit), 0);
                                    B = Math.Max(Math.Min(B, imageBit), 0);
                                    newColor = Color.FromArgb(R, G, B);
                                    resultImage.SetPixel(x * factor + 1, y * factor + 1, newColor);
                                }
                            }
                            break;
                    }
                    break;
            }

            switch (cbSType.SelectedIndex)
            {
                case 0: // Zoom Out
                    txtBox.Text = "ResultImage (" + (resultImage.Width / factor) + " x " + (resultImage.Height / factor) + ")";
                    break;
                case 1: // Zoom In
                    txtBox.Text = "ResultImage (" + (resultImage.Width * factor) + " x " + (resultImage.Height * factor) + ")";
                    break;
            }
            return resultImage;
        }

        private Bitmap Rotation(PictureBox picBox, ComboBox cbRotAlias, TrackBar txtAng, TextBox txtBox)
        {
            Color rgbColor;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int angle, x0, y0, xx, yy;
            double radian, sinTheta, cosTheta, tanTheta;
            resultImage = new Bitmap(imageWidth, imageHeight);

            angle = Convert.ToInt32(txtAng.Value);
            x0 = imageWidth / 2;
            y0 = imageHeight / 2;
            radian = angle * 2 * Math.PI / 360;
            sinTheta = Math.Sin(radian);
            cosTheta = Math.Cos(radian);
            tanTheta = Math.Tan(radian / 2);

            switch (cbRotation.SelectedIndex)
            {
                case 0:  // With Alias
                    for (int x = 0; x < imageWidth; x++)
                    {
                        for (int y = 0; y < imageHeight; y++)
                        {
                            xx = Convert.ToInt32(cosTheta * (x - x0) - sinTheta * (y - y0) + x0);
                            yy = Convert.ToInt32(sinTheta * (x - x0) + cosTheta * (y - y0) + y0);
                            if (xx >= 0 && xx < imageWidth && yy >= 0 && yy < imageHeight)
                            {
                                rgbColor = inputImage.GetPixel(x, y);
                                resultImage.SetPixel(xx, yy, rgbColor);
                            }
                        }
                    }
                    break;
                case 1: // With out Alias
                    for (int x = 0; x < imageWidth; x++)
                    {
                        for (int y = 0; y < imageHeight; y++)
                        {
                            // Right
                            xx = Convert.ToInt32((x - x0) - tanTheta * (y - y0) + x0);
                            yy = Convert.ToInt32((y - y0) + y0);
                            // Down
                            xx = Convert.ToInt32((xx - x0) + x0);
                            yy = Convert.ToInt32(sinTheta * (xx - x0) + (yy - y0) + y0);
                            // Right
                            xx = Convert.ToInt32((xx - x0) - tanTheta * (yy - y0) + x0);
                            yy = Convert.ToInt32((yy - y0) + y0);
                            if (xx >= 0 && xx < imageWidth && yy >= 0 && yy < imageHeight)
                            {
                                rgbColor = inputImage.GetPixel(x, y);
                                resultImage.SetPixel(xx, yy, rgbColor);
                            }
                        }
                    }
                    break;
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Reflection(PictureBox picBox, ComboBox cbRef, TrackBar txtRefAngle, TextBox txtBox)
        {
            Color rgbColor;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int x0, y0, xx, yy, angle;
            double radian, delta, sinTheta, cosTheta;
            resultImage = new Bitmap(imageWidth, imageHeight);
            angle = Convert.ToInt32(txtRefAngle.Value);

            switch (cbRef.SelectedIndex)
            {
                case 0: // Y Axis
                    x0 = imageWidth - 1;
                    for (int x = 0; x < imageWidth; x++)
                    {
                        for (int y = 0; y < imageHeight; y++)
                        {
                            xx = -x + x0;
                            yy = y;
                            rgbColor = inputImage.GetPixel(x, y);
                            resultImage.SetPixel(xx, yy, rgbColor);
                        }
                    }
                    break;
                case 1: // X Axis
                    y0 = imageHeight - 1;
                    for (int x = 0; x < imageWidth; x++)
                    {
                        for (int y = 0; y < imageHeight; y++)
                        {
                            xx = x;
                            yy = -y + y0;
                            rgbColor = inputImage.GetPixel(x, y);
                            resultImage.SetPixel(xx, yy, rgbColor);
                        }
                    }
                    break;
                case 2: // Both
                    x0 = imageWidth - 1;
                    y0 = imageHeight - 1;
                    for (int x = 0; x < imageWidth; x++)
                    {
                        for (int y = 0; y < imageHeight; y++)
                        {
                            xx = -x + x0;
                            yy = -y + y0;
                            rgbColor = inputImage.GetPixel(x, y);
                            resultImage.SetPixel(xx, yy, rgbColor);
                        }
                    }
                    break;
                case 3: // Angle
                    radian = angle * 2 * Math.PI / 360;
                    sinTheta = Math.Sin(radian);
                    cosTheta = Math.Cos(radian);
                    x0 = imageWidth / 2;
                    y0 = imageHeight / 2;
                    for (int x = 0; x < imageWidth; x++)
                    {
                        for (int y = 0; y < imageHeight; y++)
                        {
                            delta = ((x - x0) * sinTheta) - ((y - y0) * cosTheta);
                            xx = Convert.ToInt32(x + 2 * delta * (-sinTheta));
                            yy = Convert.ToInt32(y + 2 * delta * (cosTheta));
                            if (xx >= 0 && xx < imageWidth && yy >= 0 && yy < imageHeight)
                            {
                                rgbColor = inputImage.GetPixel(x, y);
                                resultImage.SetPixel(xx, yy, rgbColor);
                            }
                        }
                    }
                    break;
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Translation(PictureBox picBox, NumericUpDown txtBeX, NumericUpDown txtBeY, TextBox txtBox)
        {
            Color rgbColor;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int betaX, betaY, xx, yy;
            resultImage = new Bitmap(imageWidth, imageHeight);
            betaX = Convert.ToInt32(txtBeX.Value);
            betaY = Convert.ToInt32(txtBeY.Value);

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    xx = x + betaX;
                    yy = y + betaY;
                    if (xx >= 0 && xx < imageWidth && yy >= 0 && yy < imageHeight)
                    {
                        rgbColor = inputImage.GetPixel(x, y);
                        resultImage.SetPixel(xx, yy, rgbColor);
                    }
                }
            }
            txtBox.Text = "ResultImage (" + (resultImage.Width - betaX) + " x " + (resultImage.Height - betaY) + ")";
            return resultImage;
        }
        private Bitmap LogicOperations(PictureBox picBox, PictureBox picBoxSecond, TextBox txtBox)
        {
            Color rgbColor, rgbSecondColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, inputSecondImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            inputSecondImage = new Bitmap(picBoxSecond.Image);
            int imageSecondWidth = inputSecondImage.Width;
            int imageSecondHeight = inputSecondImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    rgbSecondColor = inputSecondImage.GetPixel(x, y);

                    if (rbAND.Checked)
                    {
                        R = rgbColor.R & rgbSecondColor.R;
                        G = rgbColor.G & rgbSecondColor.G;
                        B = rgbColor.B & rgbSecondColor.B;
                    }
                    else if (rbOR.Checked)
                    {
                        R = rgbColor.R | rgbSecondColor.R;
                        G = rgbColor.G | rgbSecondColor.G;
                        B = rgbColor.B | rgbSecondColor.B;
                    }
                    else if (rbXOR.Checked)
                    {
                        R = rgbColor.R ^ rgbSecondColor.R;
                        G = rgbColor.G ^ rgbSecondColor.G;
                        B = rgbColor.B ^ rgbSecondColor.B;
                    }
                    else if (rbNAND.Checked)
                    {
                        R = imageBit - (rgbColor.R & rgbSecondColor.R);
                        G = imageBit - (rgbColor.G & rgbSecondColor.G);
                        B = imageBit - (rgbColor.B & rgbSecondColor.B);
                    }
                    else if (rbNOR.Checked)
                    {
                        R = imageBit - (rgbColor.R | rgbSecondColor.R);
                        G = imageBit - (rgbColor.G | rgbSecondColor.G);
                        B = imageBit - (rgbColor.B | rgbSecondColor.B);
                    }
                    else if (rbXNOR.Checked)
                    {
                        R = imageBit - (rgbColor.R ^ rgbSecondColor.R);
                        G = imageBit - (rgbColor.G ^ rgbSecondColor.G);
                        B = imageBit - (rgbColor.B ^ rgbSecondColor.B);
                    }
                    else if (rbNOT.Checked)
                    {
                        R = imageBit - rgbColor.R;
                        G = imageBit - rgbColor.G;
                        B = imageBit - rgbColor.B;
                    }

                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Mean(PictureBox picBox, ComboBox cbMeanMatSize, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int sumR, sumG, sumB, meanR, meanG, meanB;
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = Convert.ToInt32(cbMeanMatSize.Text);
            int halfSize = matrixSize / 2;

            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + rgbColor.R;
                            sumG = sumG + rgbColor.G;
                            sumB = sumB + rgbColor.B;
                        }
                    }
                    meanR = sumR / (matrixSize * matrixSize);
                    meanG = sumG / (matrixSize * matrixSize);
                    meanB = sumB / (matrixSize * matrixSize);
                    R = meanR;
                    G = meanG;
                    B = meanB;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Median(PictureBox picBox, ComboBox cbMedianMatSize, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int medianR, medianG, medianB;
            ArrayList arrayR = new ArrayList();
            ArrayList arrayG = new ArrayList();
            ArrayList arrayB = new ArrayList();
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = Convert.ToInt32(cbMedianMatSize.Text);
            int halfSize = matrixSize / 2;

            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    arrayR.Clear(); arrayG.Clear(); arrayB.Clear();
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            arrayR.Add(rgbColor.R);
                            arrayG.Add(rgbColor.G);
                            arrayB.Add(rgbColor.B);
                        }
                    }
                    arrayR.Sort(); arrayG.Sort(); arrayB.Sort();
                    medianR = Convert.ToInt32(arrayR[arrayR.Count / 2]);
                    medianG = Convert.ToInt32(arrayG[arrayG.Count / 2]);
                    medianB = Convert.ToInt32(arrayB[arrayB.Count / 2]);
                    R = medianR;
                    G = medianG;
                    B = medianB;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap ConservativeSmoothing(PictureBox picBox, ComboBox cbConservativeMatSize, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int minR, maxR, minG, maxG, minB, maxB;
            ArrayList arrayR = new ArrayList();
            ArrayList arrayG = new ArrayList();
            ArrayList arrayB = new ArrayList();
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = Convert.ToInt32(cbConservativeMatSize.Text);
            int halfSize = matrixSize / 2;

            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    arrayR.Clear(); arrayG.Clear(); arrayB.Clear();
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            if (m != 0 && n != 0)
                            {
                                rgbColor = inputImage.GetPixel(x + m, y + n);
                                arrayR.Add(rgbColor.R);
                                arrayG.Add(rgbColor.G);
                                arrayB.Add(rgbColor.B);
                            }
                        }
                    }
                    arrayR.Sort(); arrayG.Sort(); arrayB.Sort();
                    minR = Convert.ToInt32(arrayR[0]); maxR = Convert.ToInt32(arrayR[arrayR.Count - 1]);
                    minG = Convert.ToInt32(arrayG[0]); maxG = Convert.ToInt32(arrayG[arrayG.Count - 1]);
                    minB = Convert.ToInt32(arrayB[0]); maxB = Convert.ToInt32(arrayB[arrayB.Count - 1]);
                    rgbColor = inputImage.GetPixel(x, y);
                    R = rgbColor.R;
                    G = rgbColor.G;
                    B = rgbColor.B;
                    R = Math.Max(Math.Min(R, maxR), minR);
                    G = Math.Max(Math.Min(G, maxG), minG);
                    B = Math.Max(Math.Min(B, maxB), minB);
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap CrimminsSpeckleRemoval(PictureBox picBox, NumericUpDown txtIter, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int iteration, newR, newG, newB;
            int neighbor1R, neighbor1G, neighbor1B, neighbor2R, neighbor2G, neighbor2B;
            ArrayList arrayR = new ArrayList();
            ArrayList arrayG = new ArrayList();
            ArrayList arrayB = new ArrayList();
            resultImage = new Bitmap(imageWidth, imageHeight);
            iteration = Convert.ToInt32(txtIter.Text);

            for (int i = 1; i <= iteration; i++)
            {
                for (int x = 1; x < imageWidth - 2; x++)
                {
                    for (int y = 1; y < imageHeight - 2; y++)
                    {
                        rgbColor = inputImage.GetPixel(x, y);
                        newR = rgbColor.R;
                        newG = rgbColor.G;
                        newB = rgbColor.B;
                        rgbColor = inputImage.GetPixel(x - 1, y);
                        neighbor1R = rgbColor.R;
                        neighbor1G = rgbColor.G;
                        neighbor1B = rgbColor.B;
                        rgbColor = inputImage.GetPixel(x + 1, y);
                        neighbor2R = rgbColor.R;
                        neighbor2G = rgbColor.G;
                        neighbor2B = rgbColor.B;
                        if (neighbor1R >= newR + 2) newR = newR + 1;
                        if (neighbor1G >= newG + 2) newG = newG + 1;
                        if (neighbor1B >= newB + 2) newB = newB + 1;
                        if (neighbor1R > newR && newR <= neighbor2R) newR = newR + 1;
                        if (neighbor1G > newG && newG <= neighbor2G) newG = newG + 1;
                        if (neighbor1B > newB && newB <= neighbor2B) newB = newB + 1;
                        if (neighbor2R > newR && newR <= neighbor1R) newR = newR + 1;
                        if (neighbor2G > newG && newG <= neighbor1G) newG = newG + 1;
                        if (neighbor2B > newB && newB <= neighbor1B) newB = newB + 1;
                        if (neighbor2R >= newR + 2) newR = newR + 1;
                        if (neighbor2G >= newG + 2) newG = newG + 1;
                        if (neighbor2B >= newB + 2) newB = newB + 1;

                        if (neighbor1R <= newR - 2) newR = newR - 1;
                        if (neighbor1G <= newG - 2) newG = newG - 1;
                        if (neighbor1B <= newB - 2) newB = newB - 1;
                        if (neighbor1R < newR && newR >= neighbor2R) newR = newR - 1;
                        if (neighbor1G < newG && newG >= neighbor2G) newG = newG - 1;
                        if (neighbor1B < newB && newB >= neighbor2B) newB = newB - 1;
                        if (neighbor2R < newR && newR >= neighbor1R) newR = newR - 1;
                        if (neighbor2G < newG && newG >= neighbor1G) newG = newG - 1;
                        if (neighbor2B < newB && newB >= neighbor1B) newB = newB - 1;
                        if (neighbor2R <= newR - 2) newR = newR - 1;
                        if (neighbor2G <= newG - 2) newG = newG - 1;
                        if (neighbor2B <= newB - 2) newB = newB - 1;

                        rgbColor = inputImage.GetPixel(x, y - 1);
                        neighbor1R = rgbColor.R;
                        neighbor1G = rgbColor.G;
                        neighbor1B = rgbColor.B;
                        rgbColor = inputImage.GetPixel(x, y + 1);
                        neighbor2R = rgbColor.R;
                        neighbor2G = rgbColor.G;
                        neighbor2B = rgbColor.B;
                        if (neighbor1R >= newR + 2) newR = newR + 1;
                        if (neighbor1G >= newG + 2) newG = newG + 1;
                        if (neighbor1B >= newB + 2) newB = newB + 1;
                        if (neighbor1R > newR && newR <= neighbor2R) newR = newR + 1;
                        if (neighbor1G > newG && newG <= neighbor2G) newG = newG + 1;
                        if (neighbor1B > newB && newB <= neighbor2B) newB = newB + 1;
                        if (neighbor2R > newR && newR <= neighbor1R) newR = newR + 1;
                        if (neighbor2G > newG && newG <= neighbor1G) newG = newG + 1;
                        if (neighbor2B > newB && newB <= neighbor1B) newB = newB + 1;
                        if (neighbor2R >= newR + 2) newR = newR + 1;
                        if (neighbor2G >= newG + 2) newG = newG + 1;
                        if (neighbor2B >= newB + 2) newB = newB + 1;

                        if (neighbor1R <= newR - 2) newR = newR - 1;
                        if (neighbor1G <= newG - 2) newG = newG - 1;
                        if (neighbor1B <= newB - 2) newB = newB - 1;
                        if (neighbor1R < newR && newR >= neighbor2R) newR = newR - 1;
                        if (neighbor1G < newG && newG >= neighbor2G) newG = newG - 1;
                        if (neighbor1B < newB && newB >= neighbor2B) newB = newB - 1;
                        if (neighbor2R < newR && newR >= neighbor1R) newR = newR - 1;
                        if (neighbor2G < newG && newG >= neighbor1G) newG = newG - 1;
                        if (neighbor2B < newB && newB >= neighbor1B) newB = newB - 1;
                        if (neighbor2R <= newR - 2) newR = newR - 1;
                        if (neighbor2G <= newG - 2) newG = newG - 1;
                        if (neighbor2B <= newB - 2) newB = newB - 1;

                        rgbColor = inputImage.GetPixel(x - 1, y - 1);
                        neighbor1R = rgbColor.R;
                        neighbor1G = rgbColor.G;
                        neighbor1B = rgbColor.B;
                        rgbColor = inputImage.GetPixel(x + 1, y + 1);
                        neighbor2R = rgbColor.R;
                        neighbor2G = rgbColor.G;
                        neighbor2B = rgbColor.B;
                        if (neighbor1R >= newR + 2) newR = newR + 1;
                        if (neighbor1G >= newG + 2) newG = newG + 1;
                        if (neighbor1B >= newB + 2) newB = newB + 1;
                        if (neighbor1R > newR && newR <= neighbor2R) newR = newR + 1;
                        if (neighbor1G > newG && newG <= neighbor2G) newG = newG + 1;
                        if (neighbor1B > newB && newB <= neighbor2B) newB = newB + 1;
                        if (neighbor2R > newR && newR <= neighbor1R) newR = newR + 1;
                        if (neighbor2G > newG && newG <= neighbor1G) newG = newG + 1;
                        if (neighbor2B > newB && newB <= neighbor1B) newB = newB + 1;
                        if (neighbor2R >= newR + 2) newR = newR + 1;
                        if (neighbor2G >= newG + 2) newG = newG + 1;
                        if (neighbor2B >= newB + 2) newB = newB + 1;

                        if (neighbor1R <= newR - 2) newR = newR - 1;
                        if (neighbor1G <= newG - 2) newG = newG - 1;
                        if (neighbor1B <= newB - 2) newB = newB - 1;
                        if (neighbor1R < newR && newR >= neighbor2R) newR = newR - 1;
                        if (neighbor1G < newG && newG >= neighbor2G) newG = newG - 1;
                        if (neighbor1B < newB && newB >= neighbor2B) newB = newB - 1;
                        if (neighbor2R < newR && newR >= neighbor1R) newR = newR - 1;
                        if (neighbor2G < newG && newG >= neighbor1G) newG = newG - 1;
                        if (neighbor2B < newB && newB >= neighbor1B) newB = newB - 1;
                        if (neighbor2R <= newR - 2) newR = newR - 1;
                        if (neighbor2G <= newG - 2) newG = newG - 1;
                        if (neighbor2B <= newB - 2) newB = newB - 1;

                        rgbColor = inputImage.GetPixel(x + 1, y - 1);
                        neighbor1R = rgbColor.R;
                        neighbor1G = rgbColor.G;
                        neighbor1B = rgbColor.B;
                        rgbColor = inputImage.GetPixel(x - 1, y + 1);
                        neighbor2R = rgbColor.R;
                        neighbor2G = rgbColor.G;
                        neighbor2B = rgbColor.B;
                        if (neighbor1R >= newR + 2) newR = newR + 1;
                        if (neighbor1G >= newG + 2) newG = newG + 1;
                        if (neighbor1B >= newB + 2) newB = newB + 1;
                        if (neighbor1R > newR && newR <= neighbor2R) newR = newR + 1;
                        if (neighbor1G > newG && newG <= neighbor2G) newG = newG + 1;
                        if (neighbor1B > newB && newB <= neighbor2B) newB = newB + 1;
                        if (neighbor2R > newR && newR <= neighbor1R) newR = newR + 1;
                        if (neighbor2G > newG && newG <= neighbor1G) newG = newG + 1;
                        if (neighbor2B > newB && newB <= neighbor1B) newB = newB + 1;
                        if (neighbor2R >= newR + 2) newR = newR + 1;
                        if (neighbor2G >= newG + 2) newG = newG + 1;
                        if (neighbor2B >= newB + 2) newB = newB + 1;

                        if (neighbor1R <= newR - 2) newR = newR - 1;
                        if (neighbor1G <= newG - 2) newG = newG - 1;
                        if (neighbor1B <= newB - 2) newB = newB - 1;
                        if (neighbor1R < newR && newR >= neighbor2R) newR = newR - 1;
                        if (neighbor1G < newG && newG >= neighbor2G) newG = newG - 1;
                        if (neighbor1B < newB && newB >= neighbor2B) newB = newB - 1;
                        if (neighbor2R < newR && newR >= neighbor1R) newR = newR - 1;
                        if (neighbor2G < newG && newG >= neighbor1G) newG = newG - 1;
                        if (neighbor2B < newB && newB >= neighbor1B) newB = newB - 1;
                        if (neighbor2R <= newR - 2) newR = newR - 1;
                        if (neighbor2G <= newG - 2) newG = newG - 1;
                        if (neighbor2B <= newB - 2) newB = newB - 1;

                        R = Math.Max(Math.Min(newR, imageBit), 0);
                        G = Math.Max(Math.Min(newG, imageBit), 0);
                        B = Math.Max(Math.Min(newB, imageBit), 0);
                        newColor = Color.FromArgb(R, G, B);
                        resultImage.SetPixel(x, y, newColor);
                    }
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Gaussian(PictureBox picBox, TextBox[,] txtMaskMatrix, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k = new int[3, 3];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = 3;
            int halfSize = matrixSize / 2;
            int k_top = 0;

            k[0, 0] = Convert.ToInt32(txtMaskMatrix[0, 0].Text); k[0, 1] = Convert.ToInt32(txtMaskMatrix[0, 1].Text); k[0, 2] = Convert.ToInt32(txtMaskMatrix[0, 2].Text);
            k[1, 0] = Convert.ToInt32(txtMaskMatrix[1, 0].Text); k[1, 1] = Convert.ToInt32(txtMaskMatrix[1, 1].Text); k[1, 2] = Convert.ToInt32(txtMaskMatrix[1, 2].Text);
            k[2, 0] = Convert.ToInt32(txtMaskMatrix[2, 0].Text); k[2, 1] = Convert.ToInt32(txtMaskMatrix[2, 1].Text); k[2, 2] = Convert.ToInt32(txtMaskMatrix[2, 2].Text);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    k_top += k[i, j];
                }
            }

            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k[m + 1, n + 1] * rgbColor.R;
                            sumG = sumG + k[m + 1, n + 1] * rgbColor.G;
                            sumB = sumB + k[m + 1, n + 1] * rgbColor.B;
                        }
                    }

                    R = Convert.ToInt32(((float)1 / k_top) * sumR);
                    G = Convert.ToInt32(((float)1 / k_top) * sumG);
                    B = Convert.ToInt32(((float)1 / k_top) * sumB);
                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Unsharp(PictureBox picBox, ComboBox cbUnsharpMatSize, NumericUpDown txtScale, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int sumR, sumG, sumB, meanR, meanG, meanB;
            int cR, cG, cB, dR, dG, dB, a, b;
            int[,] smoothR = new int[imageWidth, imageHeight];
            int[,] smoothG = new int[imageWidth, imageHeight];
            int[,] smoothB = new int[imageWidth, imageHeight];
            int[,] edgeR = new int[imageWidth, imageHeight];
            int[,] edgeG = new int[imageWidth, imageHeight];
            int[,] edgeB = new int[imageWidth, imageHeight];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = Convert.ToInt32(cbUnsharpMatSize.Text);
            int halfSize = matrixSize / 2;
            Single scale = Convert.ToSingle(txtScale.Text);


            // Mean Filter
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + rgbColor.R;
                            sumG = sumG + rgbColor.G;
                            sumB = sumB + rgbColor.B;
                        }
                    }
                    meanR = sumR / (matrixSize * matrixSize);
                    meanG = sumG / (matrixSize * matrixSize);
                    meanB = sumB / (matrixSize * matrixSize);
                    R = Math.Max(Math.Min(meanR, imageBit), 0);
                    G = Math.Max(Math.Min(meanG, imageBit), 0);
                    B = Math.Max(Math.Min(meanB, imageBit), 0);
                    smoothR[x, y] = R;
                    smoothG[x, y] = G;
                    smoothB[x, y] = B;
                }
            }

            // Edge Image = f(x, y) fsmooth(x, y)
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    edgeR[x, y] = rgbColor.R - smoothR[x, y];
                    edgeG[x, y] = rgbColor.G - smoothG[x, y];
                    edgeB[x, y] = rgbColor.B - smoothB[x, y];
                }
            }


            cR = dR = edgeR[halfSize, halfSize]; cG = dG = edgeG[halfSize, halfSize]; cB = dB = edgeB[halfSize, halfSize];
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    int RR = edgeR[x, y];
                    int GG = edgeG[x, y];
                    int BB = edgeB[x, y];
                    if (cR > RR) cR = RR;
                    if (cG > GG) cG = GG;
                    if (cB > BB) cB = BB;
                    if (dR < RR) dR = RR;
                    if (dG < GG) dG = GG;
                    if (dB < BB) dB = BB;
                }
            }

            // Normalization
            a = 0; b = imageBit;
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    int RR = edgeR[x, y];
                    int GG = edgeG[x, y];
                    int BB = edgeB[x, y];
                    edgeR[x, y] = (RR - cR) * (b - a) / (dR - cR) + a;
                    edgeG[x, y] = (GG - cG) * (b - a) / (dG - cG) + a;
                    edgeB[x, y] = (BB - cB) * (b - a) / (dB - cB) + a;
                }
            }

            // Unsharp Filter
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);
                    //R = edgeR[x,
                    //G = edgeG[x,
                    //B = edgeB[x,
                    R = Convert.ToInt32(rgbColor.R + scale * edgeR[x, y]);
                    G = Convert.ToInt32(rgbColor.G + scale * edgeG[x, y]);
                    B = Convert.ToInt32(rgbColor.B + scale * edgeB[x, y]);
                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap Sobel(PictureBox picBox, TextBox[,] txtMaskMat1, TextBox[,] txtMaskMat2, TextBox txtSobelThres, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB, sumR1, sumG1, sumB1;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k1 = new int[3, 3];
            int[,] k2 = new int[3, 3];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = 3;
            int halfSize = matrixSize / 2;
            int sobelThreshold;
            k1[0, 0] = Convert.ToInt32(txtMaskMat1[0, 0].Text); k1[0, 1] = Convert.ToInt32(txtMaskMat1[0, 1].Text); k1[0, 2] = Convert.ToInt32(txtMaskMat1[0, 2].Text);
            k1[1, 0] = Convert.ToInt32(txtMaskMat1[1, 0].Text); k1[1, 1] = Convert.ToInt32(txtMaskMat1[1, 1].Text); k1[1, 2] = Convert.ToInt32(txtMaskMat1[1, 2].Text);
            k1[2, 0] = Convert.ToInt32(txtMaskMat1[2, 0].Text); k1[2, 1] = Convert.ToInt32(txtMaskMat1[2, 1].Text); k1[2, 2] = Convert.ToInt32(txtMaskMat1[2, 2].Text);
            k2[0, 0] = Convert.ToInt32(txtMaskMat2[0, 0].Text); k2[0, 1] = Convert.ToInt32(txtMaskMat2[0, 1].Text); k2[0, 2] = Convert.ToInt32(txtMaskMat2[0, 2].Text);
            k2[1, 0] = Convert.ToInt32(txtMaskMat2[1, 0].Text); k2[1, 1] = Convert.ToInt32(txtMaskMat2[1, 1].Text); k2[1, 2] = Convert.ToInt32(txtMaskMat2[1, 2].Text);
            k2[2, 0] = Convert.ToInt32(txtMaskMat2[2, 0].Text); k2[2, 1] = Convert.ToInt32(txtMaskMat2[2, 1].Text); k2[2, 2] = Convert.ToInt32(txtMaskMat2[2, 2].Text);
           
            sobelThreshold = Convert.ToInt32(txtSobelThres.Text);

            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    sumR1 = 0; sumG1 = 0; sumB1 = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k1[m + 1, n + 1] * rgbColor.R;
                            sumG = sumG + k1[m + 1, n + 1] * rgbColor.G;
                            sumB = sumB + k1[m + 1, n + 1] * rgbColor.B;
                            sumR1 = sumR1 + k2[m + 1, n + 1] * rgbColor.R;
                            sumG1 = sumG1 + k2[m + 1, n + 1] * rgbColor.G;
                            sumB1 = sumB1 + k2[m + 1, n + 1] * rgbColor.B;
                        }
                    }
                    R = Convert.ToInt32(Math.Abs(sumR) + Math.Abs(sumR1)) ;
                    G = Convert.ToInt32(Math.Abs(sumG) + Math.Abs(sumG1)) ;
                    B = Convert.ToInt32(Math.Abs(sumB) + Math.Abs(sumB1)) ;
                    if (R > sobelThreshold) R = imageBit;
                    else R = 0;
                    if (G > sobelThreshold) G = imageBit;
                    else G = 0;
                    if (B > sobelThreshold) B = imageBit;
                    else B = 0;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private Bitmap Prewitt(PictureBox picBox, TextBox[,] txtMaskMat1, TextBox[,] txtMaskMat2, TextBox txtPrewittThres, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB, sumR1, sumG1, sumB1;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k1 = new int[3, 3];
            int[,] k2 = new int[3, 3];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = 3;
            int halfSize = matrixSize / 2;
            int prewittThreshold;
            k1[0, 0] = Convert.ToInt32(txtMaskMat1[0, 0].Text); k1[0, 1] = Convert.ToInt32(txtMaskMat1[0, 1].Text); k1[0, 2] =
            Convert.ToInt32(txtMaskMat1[0, 2].Text);
            k1[1, 0] = Convert.ToInt32(txtMaskMat1[1, 0].Text); k1[1, 1] = Convert.ToInt32(txtMaskMat1[1, 1].Text); k1[1, 2] =
            Convert.ToInt32(txtMaskMat1[1, 2].Text);
            k1[2, 0] = Convert.ToInt32(txtMaskMat1[2, 0].Text); k1[2, 1] = Convert.ToInt32(txtMaskMat1[2, 1].Text); k1[2, 2] =
            Convert.ToInt32(txtMaskMat1[2, 2].Text);
            k2[0, 0] = Convert.ToInt32(txtMaskMat2[0, 0].Text); k2[0, 1] = Convert.ToInt32(txtMaskMat2[0, 1].Text); k2[0, 2] =
            Convert.ToInt32(txtMaskMat2[0, 2].Text);
            k2[1, 0] = Convert.ToInt32(txtMaskMat2[1, 0].Text); k2[1, 1] = Convert.ToInt32(txtMaskMat2[1, 1].Text); k2[1, 2] =
            Convert.ToInt32(txtMaskMat2[1, 2].Text);
            k2[2, 0] = Convert.ToInt32(txtMaskMat2[2, 0].Text); k2[2, 1] = Convert.ToInt32(txtMaskMat2[2, 1].Text); k2[2, 2] =
            Convert.ToInt32(txtMaskMat2[2, 2].Text);
            prewittThreshold = Convert.ToInt32(txtPrewittThres.Text);
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    sumR1 = 0; sumG1 = 0; sumB1 = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k1[m + 1, n + 1] * rgbColor.R;
                            sumG = sumG + k1[m + 1, n + 1] * rgbColor.G;
                            sumB = sumB + k1[m + 1, n + 1] * rgbColor.B;
                            sumR1 = sumR1 + k2[m + 1, n + 1] * rgbColor.R;
                            sumG1 = sumG1 + k2[m + 1, n + 1] * rgbColor.G;
                            sumB1 = sumB1 + k2[m + 1, n + 1] * rgbColor.B;
                        }
                    }
                    R = Convert.ToInt32(Math.Abs(sumR) + Math.Abs(sumR1));
                    G = Convert.ToInt32(Math.Abs(sumG) + Math.Abs(sumG1));
                    B = Convert.ToInt32(Math.Abs(sumB) + Math.Abs(sumB1));
                    if (R > prewittThreshold) R = imageBit;
                    else R = 0;
                    if (G > prewittThreshold) G = imageBit;
                    else G = 0;
                    if (B > prewittThreshold) B = imageBit;
                    else B = 0;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Roberts(PictureBox picBox, TextBox[,] txtMaskMat1, TextBox[,] txtMaskMat2, TextBox txtRobertsThres, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB, sumR1, sumG1, sumB1;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k1 = new int[3, 3];
            int[,] k2 = new int[3, 3];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = 2;
            int halfSize = matrixSize / 2;
            int robertsThreshold;
            k1[0, 0] = Convert.ToInt32(txtMaskMat1[0, 0].Text); k1[0, 1] = Convert.ToInt32(txtMaskMat1[0, 1].Text);
            k1[1, 0] = Convert.ToInt32(txtMaskMat1[1, 0].Text); k1[1, 1] = Convert.ToInt32(txtMaskMat1[1, 1].Text);
            k2[0, 0] = Convert.ToInt32(txtMaskMat2[0, 0].Text); k2[0, 1] = Convert.ToInt32(txtMaskMat2[0, 1].Text);
            k2[1, 0] = Convert.ToInt32(txtMaskMat2[1, 0].Text); k2[1, 1] = Convert.ToInt32(txtMaskMat2[1, 1].Text);
            robertsThreshold = Convert.ToInt32(txtRobertsThres.Text);
            for (int x = 0; x < imageWidth - halfSize; x++)
            {
                for (int y = 0; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    sumR1 = 0; sumG1 = 0; sumB1 = 0;
                    for (int m = 0; m <= halfSize; m++)
                    {
                        for (int n = 0; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k1[m, n] * rgbColor.R;
                            sumG = sumG + k1[m, n] * rgbColor.G;
                            sumB = sumB + k1[m, n] * rgbColor.B;
                            sumR1 = sumR1 + k2[m, n] * rgbColor.R;
                            sumG1 = sumG1 + k2[m, n] * rgbColor.G;
                            sumB1 = sumB1 + k2[m, n] * rgbColor.B;
                        }
                    }
                    R = Convert.ToInt32(Math.Abs(sumR) + Math.Abs(sumR1));
                    G = Convert.ToInt32(Math.Abs(sumG) + Math.Abs(sumG1));
                    B = Convert.ToInt32(Math.Abs(sumB) + Math.Abs(sumB1));
                    if (R > robertsThreshold)
                        R = imageBit;
                    else
                        R = 0;
                    if (G > robertsThreshold)
                        G = imageBit;
                    else
                        G = 0;
                    if (B > robertsThreshold)
                        B = imageBit;
                    else
                        B = 0;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Scharr(PictureBox picBox, TextBox[,] txtMaskMat1, TextBox[,] txtMaskMat2, TextBox txtScharrThres, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB, sumR1, sumG1, sumB1;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k1 = new int[3, 3];
            int[,] k2 = new int[3, 3];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = 3;
            int halfSize = matrixSize / 2;
            int scharrThreshold;
            k1[0, 0] = Convert.ToInt32(txtMaskMat1[0, 0].Text); k1[0, 1] = Convert.ToInt32(txtMaskMat1[0, 1].Text); k1[0, 2] = Convert.ToInt32(txtMaskMat1[0, 2].Text);
            k1[1, 0] = Convert.ToInt32(txtMaskMat1[1, 0].Text); k1[1, 1] = Convert.ToInt32(txtMaskMat1[1, 1].Text); k1[1, 2] = Convert.ToInt32(txtMaskMat1[1, 2].Text);
            k1[2, 0] = Convert.ToInt32(txtMaskMat1[2, 0].Text); k1[2, 1] = Convert.ToInt32(txtMaskMat1[2, 1].Text); k1[2, 2] = Convert.ToInt32(txtMaskMat1[2, 2].Text);
            k2[0, 0] = Convert.ToInt32(txtMaskMat2[0, 0].Text); k2[0, 1] = Convert.ToInt32(txtMaskMat2[0, 1].Text); k2[0, 2] = Convert.ToInt32(txtMaskMat2[0, 2].Text);
            k2[1, 0] = Convert.ToInt32(txtMaskMat2[1, 0].Text); k2[1, 1] = Convert.ToInt32(txtMaskMat2[1, 1].Text); k2[1, 2] = Convert.ToInt32(txtMaskMat2[1, 2].Text);
            k2[2, 0] = Convert.ToInt32(txtMaskMat2[2, 0].Text); k2[2, 1] = Convert.ToInt32(txtMaskMat2[2, 1].Text); k2[2, 2] = Convert.ToInt32(txtMaskMat2[2, 2].Text);
            scharrThreshold = Convert.ToInt32(txtScharrThres.Text);
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    sumR1 = 0; sumG1 = 0; sumB1 = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k1[m + 1, n + 1] * rgbColor.R;
                            sumG = sumG + k1[m + 1, n + 1] * rgbColor.G;
                            sumB = sumB + k1[m + 1, n + 1] * rgbColor.B;
                            sumR1 = sumR1 + k2[m + 1, n + 1] * rgbColor.R;
                            sumG1 = sumG1 + k2[m + 1, n + 1] * rgbColor.G;
                            sumB1 = sumB1 + k2[m + 1, n + 1] * rgbColor.B;
                        }
                    }
                    R = Convert.ToInt32(Math.Abs(sumR) + Math.Abs(sumR1));
                    G = Convert.ToInt32(Math.Abs(sumG) + Math.Abs(sumG1));
                    B = Convert.ToInt32(Math.Abs(sumB) + Math.Abs(sumB1));
                    if (R > scharrThreshold) R = imageBit;
                    else R = 0;
                    if (G > scharrThreshold) G = imageBit;
                    else G = 0;
                    if (B > scharrThreshold) B = imageBit;
                    else B = 0;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap Laplacian(PictureBox picBox, TextBox[,] txtMaskMat1, TextBox txtLaplacianThres, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k = new int[3, 3];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = 3;
            int halfSize = matrixSize / 2;
            int laplacianThreshold;
            k[0, 0] = Convert.ToInt32(txtMaskMat1[0, 0].Text); k[0, 1] = Convert.ToInt32(txtMaskMat1[0, 1].Text); k[0, 2] = Convert.ToInt32(txtMaskMat1[0, 2].Text);
            k[1, 0] = Convert.ToInt32(txtMaskMat1[1, 0].Text); k[1, 1] = Convert.ToInt32(txtMaskMat1[1, 1].Text); k[1, 2] = Convert.ToInt32(txtMaskMat1[1, 2].Text);
            k[2, 0] = Convert.ToInt32(txtMaskMat1[2, 0].Text); k[2, 1] = Convert.ToInt32(txtMaskMat1[2, 1].Text); k[2, 2] = Convert.ToInt32(txtMaskMat1[2, 2].Text);
            laplacianThreshold = Convert.ToInt32(txtLaplacianThres.Text);
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k[m + 1, n + 1] * rgbColor.R;
                            sumG = sumG + k[m + 1, n + 1] * rgbColor.G;
                            sumB = sumB + k[m + 1, n + 1] * rgbColor.B;
                        }
                    }
                    R = Math.Abs(sumR);
                    G = Math.Abs(sumG);
                    B = Math.Abs(sumB);
                    if (R > laplacianThreshold)
                        R = imageBit;
                    else
                        R = 0;
                    if (G > laplacianThreshold)
                        G = imageBit;
                    else
                        G = 0;
                    if (B > laplacianThreshold)
                        B = imageBit;
                    else
                        B = 0;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap LaplacianOfGaussian(PictureBox picBox, TextBox[,] txtMaskMat1, TextBox[,] txtMaskMat2, TextBox txtLaplacianOfGaussianThres, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k1 = new int[3, 3];
            int[,] k2 = new int[3, 3];
            int[,] LoGDataR = new int[imageWidth, imageHeight];
            int[,] LoGDataG = new int[imageWidth, imageHeight];
            int[,] LoGDataB = new int[imageWidth, imageHeight];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = 3;
            int halfSize = matrixSize / 2;
            int laplacianOfGaussianThres;
            laplacianOfGaussianThres = Convert.ToInt32(txtLaplacianOfGaussianThres.Text);
            // Gaussian Filter
            k1[0, 0] = Convert.ToInt32(txtMaskMat1[0, 0].Text); k1[0, 1] = Convert.ToInt32(txtMaskMat1[0, 1].Text); k1[0, 2] = Convert.ToInt32(txtMaskMat1[0, 2].Text);
            k1[1, 0] = Convert.ToInt32(txtMaskMat1[1, 0].Text); k1[1, 1] = Convert.ToInt32(txtMaskMat1[1, 1].Text); k1[1, 2] = Convert.ToInt32(txtMaskMat1[1, 2].Text);
            k1[2, 0] = Convert.ToInt32(txtMaskMat1[2, 0].Text); k1[2, 1] = Convert.ToInt32(txtMaskMat1[2, 1].Text); k1[2, 2] = Convert.ToInt32(txtMaskMat1[2, 2].Text);
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k1[m + 1, n + 1] * rgbColor.R;
                            sumG = sumG + k1[m + 1, n + 1] * rgbColor.G;
                            sumB = sumB + k1[m + 1, n + 1] * rgbColor.B;
                        }
                    }
                    R = Convert.ToInt32(((float)1 / 16) * sumR);
                    G = Convert.ToInt32(((float)1 / 16) * sumG);
                    B = Convert.ToInt32(((float)1 / 16) * sumB);
                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    LoGDataR[x, y] = R;
                    LoGDataG[x, y] = G;
                    LoGDataB[x, y] = B;
                }
            }
            // Laplacian Filter
            k2[0, 0] = Convert.ToInt32(txtMaskMat2[0, 0].Text); k2[0, 1] = Convert.ToInt32(txtMaskMat2[0, 1].Text); k2[0, 2] = Convert.ToInt32(txtMaskMat2[0, 2].Text);
            k2[1, 0] = Convert.ToInt32(txtMaskMat2[1, 0].Text); k2[1, 1] = Convert.ToInt32(txtMaskMat2[1, 1].Text); k2[1, 2] = Convert.ToInt32(txtMaskMat2[1, 2].Text);
            k2[2, 0] = Convert.ToInt32(txtMaskMat2[2, 0].Text); k2[2, 1] = Convert.ToInt32(txtMaskMat2[2, 1].Text); k2[2, 2] = Convert.ToInt32(txtMaskMat2[2, 2].Text);
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            sumR = sumR + k2[m + 1, n + 1] * LoGDataR[x + m, y + n];
                            sumG = sumG + k2[m + 1, n + 1] * LoGDataG[x + m, y + n];
                            sumB = sumB + k2[m + 1, n + 1] * LoGDataB[x + m, y + n];
                        }
                    }
                    R = Math.Abs(sumR);
                    G = Math.Abs(sumG);
                    B = Math.Abs(sumB);
                    if (R > laplacianOfGaussianThres)
                        R = imageBit;
                    else
                        R = 0;
                    if (G > laplacianOfGaussianThres)
                        G = imageBit;
                    else
                        G = 0;
                    if (B > laplacianOfGaussianThres)
                        B = imageBit;
                    else
                        B = 0;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private Bitmap DifferenceOfGaussian(PictureBox picBox, TextBox[,] txtMaskMat1, TextBox[,] txtMaskMat2, TextBox txtDifferenceOfGaussianThres, TextBox txtBox)
        {
            Color rgbColor, newColor;
            int R = 0, G = 0, B = 0;
            int sumR, sumG, sumB, sumR1, sumG1, sumB1;
            Bitmap inputImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int[,] k1 = new int[3, 3];
            int[,] k2 = new int[3, 3];
            int[,] LoGDataR1 = new int[imageWidth, imageHeight];
            int[,] LoGDataG1 = new int[imageWidth, imageHeight];
            int[,] LoGDataB1 = new int[imageWidth, imageHeight];
            int[,] LoGDataR2 = new int[imageWidth, imageHeight];
            int[,] LoGDataG2 = new int[imageWidth, imageHeight];
            int[,] LoGDataB2 = new int[imageWidth, imageHeight];
            resultImage = new Bitmap(imageWidth, imageHeight);
            int matrixSize = 3;
            int halfSize = matrixSize / 2;
            int differenceOfGaussianThres;
            k1[0, 0] = Convert.ToInt32(txtMaskMat1[0, 0].Text); k1[0, 1] = Convert.ToInt32(txtMaskMat1[0, 1].Text); k1[0, 2] =
           Convert.ToInt32(txtMaskMat1[0, 2].Text);
            k1[1, 0] = Convert.ToInt32(txtMaskMat1[1, 0].Text); k1[1, 1] = Convert.ToInt32(txtMaskMat1[1, 1].Text); k1[1, 2] =
           Convert.ToInt32(txtMaskMat1[1, 2].Text);
            k1[2, 0] = Convert.ToInt32(txtMaskMat1[2, 0].Text); k1[2, 1] = Convert.ToInt32(txtMaskMat1[2, 1].Text); k1[2, 2] =
           Convert.ToInt32(txtMaskMat1[2, 2].Text);
            k2[0, 0] = Convert.ToInt32(txtMaskMat2[0, 0].Text); k2[0, 1] = Convert.ToInt32(txtMaskMat2[0, 1].Text); k2[0, 2] =
           Convert.ToInt32(txtMaskMat2[0, 2].Text);
            k2[1, 0] = Convert.ToInt32(txtMaskMat2[1, 0].Text); k2[1, 1] = Convert.ToInt32(txtMaskMat2[1, 1].Text); k2[1, 2] =
           Convert.ToInt32(txtMaskMat2[1, 2].Text);
            k2[2, 0] = Convert.ToInt32(txtMaskMat2[2, 0].Text); k2[2, 1] = Convert.ToInt32(txtMaskMat2[2, 1].Text); k2[2, 2] =
           Convert.ToInt32(txtMaskMat2[2, 2].Text);
            differenceOfGaussianThres = Convert.ToInt32(txtDifferenceOfGaussianThres.Text);
            for (int x = halfSize; x < imageWidth - halfSize; x++)
            {
                for (int y = halfSize; y < imageHeight - halfSize; y++)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    sumR1 = 0; sumG1 = 0; sumB1 = 0;
                    for (int m = -halfSize; m <= halfSize; m++)
                    {
                        for (int n = -halfSize; n <= halfSize; n++)
                        {
                            rgbColor = inputImage.GetPixel(x + m, y + n);
                            sumR = sumR + k1[m + 1, n + 1] * rgbColor.R;
                            sumG = sumG + k1[m + 1, n + 1] * rgbColor.G;
                            sumB = sumB + k1[m + 1, n + 1] * rgbColor.B;
                            sumR1 = sumR1 + k2[m + 1, n + 1] * rgbColor.R;
                            sumG1 = sumG1 + k2[m + 1, n + 1] * rgbColor.G;
                            sumB1 = sumB1 + k2[m + 1, n + 1] * rgbColor.B;
                        }
                    }
                    LoGDataR1[x, y] = Convert.ToInt32(((float)1 / 16) * sumR);
                    LoGDataG1[x, y] = Convert.ToInt32(((float)1 / 16) * sumG);
                    LoGDataB1[x, y] = Convert.ToInt32(((float)1 / 16) * sumB);
                    LoGDataR2[x, y] = Convert.ToInt32(((float)1 / 25) * sumR1);
                    LoGDataG2[x, y] = Convert.ToInt32(((float)1 / 25) * sumG1);
                    LoGDataB2[x, y] = Convert.ToInt32(((float)1 / 25) * sumB1);
                    R = Math.Abs(LoGDataR1[x, y] - LoGDataR2[x, y]);
                    G = Math.Abs(LoGDataG1[x, y] - LoGDataG2[x, y]);
                    B = Math.Abs(LoGDataB1[x, y] - LoGDataB2[x, y]);
                    R = Math.Max(Math.Min(R, imageBit), 0);
                    G = Math.Max(Math.Min(G, imageBit), 0);
                    B = Math.Max(Math.Min(B, imageBit), 0);
                    if (R > differenceOfGaussianThres)
                        R = imageBit;
                    else
                        R = 0;
                    if (G > differenceOfGaussianThres)
                        G = imageBit;
                    else
                        G = 0;
                    if (B > differenceOfGaussianThres)
                        B = imageBit;
                    else
                        B = 0;
                    newColor = Color.FromArgb(R, G, B);
                    resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }
        private void trackBarBlendPer_ValueChanged(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            lblBlendPer.Text = trackBarBlendPer.Value.ToString();
            pbResultImage.Image = ArithmeticOperationsWithImage(pbInputImage1, pbInputImage2, trackBarBlendPer, tbResultImage);

            if (rbMatrix.Checked) SetPixel();
        }
        private void trackBarRGB_ValueChanged(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            if (cbWithConstant.SelectedIndex == 2 || cbWithConstant.SelectedIndex == 3)
            {
                trackBarR.Maximum = 10;
                trackBarG.Maximum = 10;
                trackBarB.Maximum = 10;
            }
            else
            {
                trackBarR.Maximum = 100;
                trackBarG.Maximum = 100;
                trackBarB.Maximum = 100;
            }
            if (checkBox1.Checked)
            {
                trackBarG.Enabled = false;
                trackBarB.Enabled = false;
                trackBarG.Value = trackBarB.Value = trackBarR.Value;
            }
            int[] trackBar = new int[3];

            trackBar[0] = trackBarR.Value;
            lblConstantR.Text = trackBarR.Value.ToString();
            trackBar[1] = trackBarG.Value;
            lblConstantG.Text = trackBarG.Value.ToString();
            trackBar[2] = trackBarB.Value;
            lblConstantB.Text = trackBarB.Value.ToString();

            pbResultImage.Image = ArithmeticOperationsWithConstant(pbInputImage1, trackBar, tbResultImage);

            if (rbMatrix.Checked) SetPixel();
        }
        private void RadioButton_Checked(object sender, EventArgs e)
        {
            if (rbRGBComponents.Checked) cbRGBComponents.Enabled = true;
            else cbRGBComponents.Enabled = false;
            if (rbArtificialImages.Checked) cbArtificialImages.Enabled = true;
            else cbArtificialImages.Enabled = false;
            if (rbWeightedAverage.Checked) cbWeightedAverage.Enabled = true;
            else cbWeightedAverage.Enabled = false;
            if (rbDecomposition.Checked) cbDecomposition.Enabled = true;
            else cbDecomposition.Enabled = false;
            if (rbSingleColorChannel.Checked) cbSingleColorChannel.Enabled = true;
            else cbSingleColorChannel.Enabled = false;
            if (rbAdaptiveThresholding.Checked)
            {
                cbAdaptiveThres.Enabled = true;
                cbAdaptiveThresMatrix.Enabled = true;
            }
            else
            {
                cbAdaptiveThres.Enabled = false;
                cbAdaptiveThresMatrix.Enabled = false;
            }
            if (rbThresholding.Checked)
            {
                tbThresholding.Enabled = true;
                trackBarThresholding.Enabled = true;
            }
            else
            {
                tbThresholding.Enabled = false;
                trackBarThresholding.Enabled = false;
            }

            if (rbWithConstant.Checked)
            {
                cbWithConstant.Enabled = true;
                trackBarR.Enabled = true;
                trackBarG.Enabled = true;
                trackBarB.Enabled = true;
            }
            else
            {
                cbWithConstant.Enabled = false;
                trackBarR.Enabled = false;
                trackBarG.Enabled = false;
                trackBarB.Enabled = false;
            }
            if (rbWithImage.Checked)
            {
                cbWithImage.Enabled = true;
                trackBarBlendPer.Enabled = true;
            }
            else
            {
                cbWithImage.Enabled = false;
                trackBarBlendPer.Enabled = false;
            }
            if (rbScaling.Checked)
            {
                cbScaling.Enabled = true;
                cbScalingMethod.Enabled = true;
                tbScalingFactor.Enabled = true;
            }
            else
            {
                cbScaling.Enabled = false;
                cbScalingMethod.Enabled = false;
                tbScalingFactor.Enabled = false;
            }
            if (rbRotation.Checked)
            {
                cbRotation.Enabled = true;
                trackBarRotation.Enabled = true;
            }
            else
            {
                cbRotation.Enabled = false;
                trackBarRotation.Enabled = false;
            }
            if (rbReflection.Checked)
            {
                cbReflection.Enabled = true;
                trackBarReflection.Enabled = true;
            }
            else
            {
                cbReflection.Enabled = false;
                trackBarReflection.Enabled = false;
            }
            if (rbTranslation.Checked)
            {
                tbTransY.Enabled = true;
                tbTransX.Enabled = true;
            }
            else
            {
                tbTransY.Enabled = false;
                tbTransX.Enabled = false;
            }

            if (rbImage.Checked)
            {
                rbGray.Enabled = false;
                rbRGB.Enabled = false;
                tbImageBit.Enabled = false;
                richTextBox1.Visible = false;
                richTextBox2.Visible = false;
            }
            else
            {
                rbGray.Enabled = true;
                rbRGB.Enabled = true;
                tbImageBit.Enabled = true;
                richTextBox1.Visible = true;
                richTextBox2.Visible = true;
            }

            if (rbMean.Checked) cbMean.Enabled = true;
            else cbMean.Enabled = false;

            if (rbMedian.Checked) cbMedian.Enabled = true;
            else cbMedian.Enabled = false;

            if (rbConservativeSmoothing.Checked) cbConservativeSmoothing.Enabled = true;
            else cbConservativeSmoothing.Enabled = false;

            if (rbCrimminsSpeckleRemoval.Checked) tbCrimmins.Enabled = true;
            else tbCrimmins.Enabled = false;

            if (rbUnsharpFilter.Checked)
            {
                cbUnsharpFilter.Enabled = true;
                tbUnsharpScaling.Enabled = true;
            }
            else
            {
                cbUnsharpFilter.Enabled = false;
                tbUnsharpScaling.Enabled = false;
            }


            if (rbGaussianSmoothing.Checked) gbGausMatrix.Enabled = true;
            else gbGausMatrix.Enabled = false;


            if (rbLaplacian.Checked)
            {
                tbLaplacian.Enabled = true;

            }
            else
            {
                tbLaplacian.Enabled = false;

            }

            if (rbLaplacianOfGaussaian.Checked)
            {
                tbLaplacianOfGaussaian.Enabled = true;

                textBox11.Text = "1"; textBox15.Text = "2"; textBox10.Text = "1";
                textBox12.Text = "2"; textBox17.Text = "4"; textBox16.Text = "2";
                textBox14.Text = "1"; textBox18.Text = "2"; textBox13.Text = "1";
            }
            else
            {
                tbLaplacianOfGaussaian.Enabled = false;
            }

            if (rbDifferenceOfGaussian.Checked)
            {
                tbDifferenceOfGaussian.Enabled = true;


                textBox11.Text = "1"; textBox15.Text = "2"; textBox10.Text = "1";
                textBox12.Text = "2"; textBox17.Text = "4"; textBox16.Text = "2";
                textBox14.Text = "1"; textBox18.Text = "2"; textBox13.Text = "1";


                textBox20.Text = "1"; textBox24.Text = "3"; textBox19.Text = "1";
                textBox21.Text = "3"; textBox26.Text = "9"; textBox25.Text = "3";
                textBox23.Text = "1"; textBox27.Text = "3"; textBox22.Text = "1";

            }
            else
            {
                tbDifferenceOfGaussian.Enabled = false;
            }

            if (rbSobel.Checked)
            {
                tbSobel.Enabled = true;


                textBox11.Text = "-1"; textBox15.Text = "0"; textBox10.Text = "1";
                textBox12.Text = "-2"; textBox17.Text = "0"; textBox16.Text = "2";
                textBox14.Text = "-1"; textBox18.Text = "0"; textBox13.Text = "1";


                textBox20.Text = "1"; textBox24.Text = "2"; textBox19.Text = "1";
                textBox21.Text = "0"; textBox26.Text = "0"; textBox25.Text = "0";
                textBox23.Text = "-1"; textBox27.Text = "-2"; textBox22.Text = "-1";

            }
            else
            {
                tbSobel.Enabled = false;
            }


            if (rbPrewitt.Checked)
            {
                tbPrewitt.Enabled = true;

                textBox11.Text = "-1"; textBox15.Text = "0"; textBox10.Text = "1";
                textBox12.Text = "-1"; textBox17.Text = "0"; textBox16.Text = "1";
                textBox14.Text = "-1"; textBox18.Text = "0"; textBox13.Text = "1";


                textBox20.Text = "1"; textBox24.Text = "1"; textBox19.Text = "1";
                textBox21.Text = "0"; textBox26.Text = "0"; textBox25.Text = "0";
                textBox23.Text = "-1"; textBox27.Text = "-1"; textBox22.Text = "-1";

            }
            else
            {
                tbPrewitt.Enabled = false;
            }

            if (rbScharr.Checked)
            {
                tbScharr.Enabled = true;

                textBox11.Text = "3"; textBox15.Text = "0"; textBox10.Text = "-3";
                textBox12.Text = "10"; textBox17.Text = "0"; textBox16.Text = "-10";
                textBox14.Text = "3"; textBox18.Text = "0"; textBox13.Text = "-3";


                textBox20.Text = "3"; textBox24.Text = "10"; textBox19.Text = "3";
                textBox21.Text = "0"; textBox26.Text = "0"; textBox25.Text = "0";
                textBox23.Text = "-3"; textBox27.Text = "-10"; textBox22.Text = "-3";

            }
            else
            {
                tbScharr.Enabled = false;
            }

            if (rbRoberts.Checked)
            {
                tbRoberts.Enabled = true;

                textBox11.Text = "1"; textBox15.Text = "0"; textBox10.Text = null;
                textBox12.Text = "0"; textBox17.Text = "-1"; textBox16.Text = null;
                textBox14.Text = null; textBox18.Text = null; textBox13.Text = null;


                textBox20.Text = "0"; textBox24.Text = "1"; textBox19.Text = null;
                textBox21.Text = "-1"; textBox26.Text = "0"; textBox25.Text = null;
                textBox23.Text = null; textBox27.Text = null; textBox22.Text = null;

            }
            else
            {
                tbRoberts.Enabled = false;
            }


        }
        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            Form2 HistogramForm = new Form2();
            HistogramForm.ImageHistogram = pbInputImage1.Image;
            HistogramForm.Show();


        }
        private void btnPointOp_Click(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            TextBox[,] tbConvolutionMatrix = new TextBox[3, 3] {
                { tbConvolution00, tbConvolution01, tbConvolution02 },
                { tbConvolution10, tbConvolution11, tbConvolution12 },
                { tbConvolution20, tbConvolution21, tbConvolution22 } };

            if (pbInputImage1.Image != null)
            {
                if (rbThresholding.Checked)
                {
                    pbResultImage.Image = Thresholding(pbInputImage1, trackBarThresholding, tbResultImage);
                }
                if (rbAdaptiveThresholding.Checked)
                {
                    pbResultImage.Image = AdaptiveThresholding(pbInputImage1, cbAdaptiveThres, cbAdaptiveThresMatrix, tbResultImage);
                }
                if (rbConvolution.Checked)
                {
                    pbResultImage.Image = Convolution(pbInputImage1, tbConvolutionMatrix, tbResultImage);
                }
                if (rbQuantiation.Checked)
                {
                    pbResultImage.Image = Quantization(pbInputImage1, tbQuantization, tbResultImage);
                }
                if (rbLogarithmOperator.Checked)
                {
                    pbResultImage.Image = LogarithmOperator(pbInputImage1, tbResultImage);
                }
                if (rbHistogramEq.Checked)
                {
                    pbResultImage.Image = HistogramEqualization(pbInputImage1, tbResultImage);
                }
            }
            else MessageBox.Show("Resim 1 Seçilmedi!");

            if (rbMatrix.Checked) SetPixel();
        }
        private void trackPointOperators_ValueChanged(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            imageBit = 255;

            lblThresholdingValue.Text = trackBarThresholding.Value.ToString();
            if (rbThresholding.Checked)
            {
                pbResultImage.Image = Thresholding(pbInputImage1, trackBarThresholding, tbResultImage);

            }

            if (rbMatrix.Checked) SetPixel();
        }
        private void tbThresholding_TextChanged(object sender, EventArgs e)
        {
            trackBarThresholding.Maximum = Convert.ToInt32(tbThresholding.Text);

        }
        private void cbScaling_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbScaling.SelectedIndex)
            {
                case 0:
                    cbScalingMethod.Items.Clear();
                    cbScalingMethod.Items.Add("Replacement");
                    cbScalingMethod.Items.Add("Interpolation");
                    break;
                case 1:
                    cbScalingMethod.Items.Clear();
                    cbScalingMethod.Items.Add("Replication");
                    cbScalingMethod.Items.Add("Interpolation");
                    break;
            }
        }
        private void btnGeometricOp_Click(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            if (pbInputImage1.Image != null)
            {
                if (rbScaling.Checked)
                {
                    pbResultImage.Image = Scaling(pbInputImage1, cbScaling, cbScalingMethod, tbScalingFactor, tbResultImage);
                }
                if (rbRotation.Checked)
                {
                    pbResultImage.Image = Rotation(pbInputImage1, cbRotation, trackBarRotation, tbResultImage);
                }
                if (rbReflection.Checked)
                {
                    pbResultImage.Image = Reflection(pbInputImage1, cbReflection, trackBarReflection, tbResultImage);
                }
                if (rbTranslation.Checked)
                {
                    pbResultImage.Image = Translation(pbInputImage1, tbTransX, tbTransY, tbResultImage);
                }
            }
            else MessageBox.Show("Resim 1 Seçilmedi!");

            if (rbMatrix.Checked) SetPixel();
        }
        private void trackBarRotation_Scroll(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;
            lblRotationAng.Text = "Angle: " + trackBarRotation.Value.ToString();
            pbResultImage.Image = Rotation(pbInputImage1, cbRotation, trackBarRotation, tbResultImage);
            if (rbMatrix.Checked) SetPixel();
        }
        private void trackBarReflection_Scroll(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;
            lblReflectionAng.Text = "Angle: " + trackBarReflection.Value.ToString();
            pbResultImage.Image = Reflection(pbInputImage1, cbReflection, trackBarReflection, tbResultImage);
            if (rbMatrix.Checked) SetPixel();
        }
        private void btnLogicOperator_Click(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            pbResultImage.Image = LogicOperations(pbInputImage1, pbInputImage2, tbResultImage);

            if (rbMatrix.Checked) SetPixel();
        }
        private void tbTransX_ValueChanged(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;
            pbResultImage.Image = Translation(pbInputImage1, tbTransX, tbTransY, tbResultImage);
            if (rbMatrix.Checked) SetPixel();
        }
        private void tbScalingFactor_ValueChanged(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;
            pbResultImage.Image = Scaling(pbInputImage1, cbScaling, cbScalingMethod, tbScalingFactor, tbResultImage);
            if (rbMatrix.Checked) SetPixel();
        }
        private void cbMean_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            if (rbMean.Checked) pbResultImage.Image = Mean(pbInputImage1, cbMean, tbResultImage);
            if (rbMedian.Checked) pbResultImage.Image = Median(pbInputImage1, cbMedian, tbResultImage);
            if (rbConservativeSmoothing.Checked) pbResultImage.Image = ConservativeSmoothing(pbInputImage1, cbConservativeSmoothing, tbResultImage);
            if (rbCrimminsSpeckleRemoval.Checked) pbResultImage.Image = CrimminsSpeckleRemoval(pbInputImage1, tbCrimmins, tbResultImage);

            if (rbMatrix.Checked) SetPixel();
        }
        private void btnResultImage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbResultImage.Image.Save(saveFileDialog.FileName);
                }
            }

        }
        private void btnDigitalFilters_Click(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            TextBox[,] tbGaussianMatrix = new TextBox[3, 3] {
                { textBox1, textBox4, textBox7 },
                { textBox2, textBox5, textBox8 },
                { textBox3, textBox6, textBox9 } };

            if (rbGaussianSmoothing.Checked)
            {
                pbResultImage.Image = Gaussian(pbInputImage1, tbGaussianMatrix, tbResultImage);
            }

            if (rbUnsharpFilter.Checked)
            {
                pbResultImage.Image = Unsharp(pbInputImage1, cbUnsharpFilter, tbUnsharpScaling, tbResultImage);
            }

            if (rbMatrix.Checked) SetPixel();
        }
        private void btnEdgeDetectors_Click(object sender, EventArgs e)
        {
            if (rbMatrix.Checked) GetPixel();
            else imageBit = 255;

            TextBox[,] tbEdgeDMatrix1 = new TextBox[3, 3] {
                { textBox11, textBox15, textBox10 },
                { textBox12, textBox17, textBox16 },
                { textBox14, textBox18, textBox13 } };

            TextBox[,] tbEdgeDMatrix2 = new TextBox[3, 3] {
                { textBox20, textBox24, textBox19 },
                { textBox21, textBox26, textBox25 },
                { textBox23, textBox27, textBox22 } };

            if (rbSobel.Checked)
            {
                pbResultImage.Image = Sobel(pbInputImage1, tbEdgeDMatrix1, tbEdgeDMatrix2, tbSobel, tbResultImage);
            }
            if (rbPrewitt.Checked)
            {
                pbResultImage.Image = Prewitt(pbInputImage1, tbEdgeDMatrix1, tbEdgeDMatrix2, tbPrewitt, tbResultImage);
            }
            if (rbRoberts.Checked)
            {
                pbResultImage.Image = Roberts(pbInputImage1, tbEdgeDMatrix1, tbEdgeDMatrix2, tbRoberts, tbResultImage);
            }
            if (rbScharr.Checked)
            {
                pbResultImage.Image = Scharr(pbInputImage1, tbEdgeDMatrix1, tbEdgeDMatrix2, tbScharr, tbResultImage);
            }
            if (rbLaplacian.Checked)
            {
                pbResultImage.Image = Laplacian(pbInputImage1, tbEdgeDMatrix1, tbLaplacian, tbResultImage);
            }
            if (rbLaplacianOfGaussaian.Checked)
            {
                pbResultImage.Image = LaplacianOfGaussian(pbInputImage1, tbEdgeDMatrix1, tbEdgeDMatrix2, tbLaplacianOfGaussaian, tbResultImage);
            }
            if (rbDifferenceOfGaussian.Checked)
            {
                pbResultImage.Image = DifferenceOfGaussian(pbInputImage1, tbEdgeDMatrix1, tbEdgeDMatrix2, tbDifferenceOfGaussian, tbResultImage);
            }

            if (rbMatrix.Checked) SetPixel();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (rbLaplacian.Checked)
            {
                switch (udEdgeDetectors1.SelectedIndex)
                {
                    case 0:
                        {
                            textBox11.Text = "0"; textBox15.Text = "1"; textBox10.Text = "0";
                            textBox12.Text = "1"; textBox17.Text = "-4"; textBox16.Text = "1";
                            textBox14.Text = "0"; textBox18.Text = "1"; textBox13.Text = "0";
                            break;
                        }
                    case 1:
                        {
                            textBox11.Text = "1"; textBox15.Text = "1"; textBox10.Text = "1";
                            textBox12.Text = "1"; textBox17.Text = "-8"; textBox16.Text = "1";
                            textBox14.Text = "1"; textBox18.Text = "1"; textBox13.Text = "1";
                            break;
                        }

                    case 2:
                        {
                            textBox11.Text = "-1"; textBox15.Text = "2"; textBox10.Text = "-1";
                            textBox12.Text = "2"; textBox17.Text = "-4"; textBox16.Text = "2";
                            textBox14.Text = "-1"; textBox18.Text = "2"; textBox13.Text = "-1";
                            break;
                        }
                }
            }

            else if (rbLaplacianOfGaussaian.Checked)
            {
                textBox11.Text = "1"; textBox15.Text = "2"; textBox10.Text = "1";
                textBox12.Text = "2"; textBox17.Text = "4"; textBox16.Text = "2";
                textBox14.Text = "1"; textBox18.Text = "2"; textBox13.Text = "1";
            }
        }


        private void rbLaplacianOfGaussaian_CheckedChanged(object sender, EventArgs e)
        {
            textBox20.Text = "1"; textBox24.Text = "2"; textBox19.Text = "1";
            textBox21.Text = "2"; textBox26.Text = "4"; textBox25.Text = "2";
            textBox23.Text = "1"; textBox27.Text = "2"; textBox22.Text = "1";
        }

        private void rbDifferenceOfGaussian_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Text = "1"; textBox15.Text = "2"; textBox10.Text = "1";
            textBox12.Text = "2"; textBox17.Text = "4"; textBox16.Text = "2";
            textBox14.Text = "1"; textBox18.Text = "2"; textBox13.Text = "1";

            textBox20.Text = "1"; textBox24.Text = "3"; textBox19.Text = "1";
            textBox21.Text = "3"; textBox26.Text = "9"; textBox25.Text = "3";
            textBox23.Text = "1"; textBox27.Text = "3"; textBox22.Text = "1";



        }

        private void udEdgeDetectors2_SelectedItemChanged(object sender, EventArgs e)
        {
            if (rbLaplacianOfGaussaian.Checked)
            {
                switch (udEdgeDetectors2.SelectedIndex)
                {
                    case 0:
                        {
                            textBox20.Text = "0"; textBox24.Text = "1"; textBox19.Text = "0";
                            textBox21.Text = "1"; textBox26.Text = "-4"; textBox25.Text = "1";
                            textBox23.Text = "0"; textBox27.Text = "1"; textBox22.Text = "0";
                            break;
                        }
                    case 1:
                        {
                            textBox20.Text = "1"; textBox24.Text = "1"; textBox19.Text = "1";
                            textBox21.Text = "1"; textBox26.Text = "-8"; textBox25.Text = "1";
                            textBox23.Text = "1"; textBox27.Text = "1"; textBox22.Text = "1";
                            break;
                        }

                    case 2:
                        {
                            textBox20.Text = "-1"; textBox24.Text = "2"; textBox19.Text = "-1";
                            textBox21.Text = "2"; textBox26.Text = "-4"; textBox25.Text = "2";
                            textBox23.Text = "-1"; textBox27.Text = "2"; textBox22.Text = "-1";
                            break;
                        }
                }
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}



