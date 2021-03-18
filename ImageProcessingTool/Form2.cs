using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessingTool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public Image ImageHistogram;

        private void Form2_Load(object sender, EventArgs e)
        {
            pbHistogram.Image = ImageHistogram;
            graphicsSettings();
        }

        void graphicsSettings()
        {
            chartHistogram.ChartAreas[0].AxisX.Minimum = 0;
            chartHistogram.ChartAreas[0].AxisX.Maximum = 255;
            chartHistogram.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Auto;
            //chartHistogram.ChartAreas[0].AxisX.Interval = 50;
            chartHistogram.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartHistogram.ChartAreas[0].AxisX.MinorGrid.IntervalType = DateTimeIntervalType.Auto;
            //chartHistogram.ChartAreas[0].AxisX.MinorGrid.Interval = 2;
            chartHistogram.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.LightGray;
            chartHistogram.ChartAreas[0].AxisX.MinorGrid.Enabled = true;
            chartHistogram.ChartAreas[0].AxisX.Title = "Pixel Value";
            chartHistogram.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("", 10);
            chartHistogram.ChartAreas[0].AxisY.Minimum = 0;
            //cahrtHistogram.ChartAreas[0].AxisY.Maximum =100;
            chartHistogram.ChartAreas[0].AxisY.IntervalType = DateTimeIntervalType.Auto;
            //cahrtHistogram.ChartAreas[0].AxisY.Interval = 500;
            chartHistogram.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkGray;
            chartHistogram.ChartAreas[0].AxisY.MinorGrid.IntervalType = DateTimeIntervalType.Auto; ;
            //chartHistogram.ChartAreas[0].AxisY.MinorGrid.Interval = 5;
            chartHistogram.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.LightGray;
            chartHistogram.ChartAreas[0].AxisY.MinorGrid.Enabled = true;
            chartHistogram.ChartAreas[0].AxisY.Title = "Number of Pixels";
            chartHistogram.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("", 10);
            chartHistogram.Series.Clear();
            chartHistogram.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            drawHistogram(pbHistogram);
        }


        private void drawHistogram(PictureBox picBox)
        {
            Color rgbColor;
            int[] histogramR = new int[256];
            int[] histogramG = new int[256];
            int[] histogramB = new int[256];
            int kR, kG, kB;
            Bitmap inputImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;

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

            chartHistogram.Series.Clear();

            if (cbRComp.Checked)
            {
                var serieR = new Series("R Component");
                if (rbColumn.Checked) serieR.ChartType = SeriesChartType.Column;
                else serieR.ChartType = SeriesChartType.FastLine;
                serieR.BorderWidth = 1;
                serieR.Color = Color.Red;
                chartHistogram.Series.Add(serieR);
            }

            if (cbGComp.Checked)
            {
                var serieG = new Series("G Component");
                if (rbColumn.Checked) serieG.ChartType = SeriesChartType.Column;
                else serieG.ChartType = SeriesChartType.FastLine;
                serieG.BorderWidth = 1;
                serieG.Color = Color.Green;
                chartHistogram.Series.Add(serieG);
            }

            if (cbBComp.Checked)
            {
                var serieB = new Series("B Component");
                if (rbColumn.Checked) serieB.ChartType = SeriesChartType.Column;
                else serieB.ChartType = SeriesChartType.FastLine;
                serieB.BorderWidth = 1;
                serieB.Color = Color.Blue;
                chartHistogram.Series.Add(serieB);
            }

            for (int i = 0; i < 256; i++)
            {
                if (cbRComp.Checked)
                    chartHistogram.Series["R Component"].Points.AddXY(i, histogramR[i]);
                if (cbGComp.Checked)
                    chartHistogram.Series["G Component"].Points.AddXY(i, histogramG[i]);
                if (cbBComp.Checked)
                    chartHistogram.Series["B Component"].Points.AddXY(i, histogramB[i]);
            }
        }
    }
}

  