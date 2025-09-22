using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ImageProcessingActivity {
    public partial class part1 : UserControl {

        
        Bitmap loadedImage;
        Bitmap processedImage;
        public part1() {
            InitializeComponent();
            foreach (Chart c in new Chart[] { chart1, chart2, chart3, chart4 })
            {
                initializeChart(c);
            }
        }

        private void loadImage_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
            loadedImage = new Bitmap(openFileDialog1.FileName);
            loadedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            loadedImageBox.Image = loadedImage;
        }

        private void button1_Click(object sender, EventArgs e) {
            if(loadedImage == null ) {
                MessageBox.Show("Load an image first");
                return;
            }
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            for(int x = 0;x < loadedImage.Width ; x++ ) {
                for(int y = 0;y < loadedImage.Height ; y++ ) {
                    processedImage.SetPixel(x,y,loadedImage.GetPixel(x,y));
                }
            }
            processedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            processedImageBox.Image = processedImage;

            loadHistogram();
        }

        private void loadHistogram() {
            int[] histogram = new int[256];
            int[] r_histogram = new int[256];
            int[] g_histogram = new int[256];
            int[] b_histogram = new int[256];
            
            for(int x = 0;x < loadedImage.Width ; x++ ) {
                for(int y = 0;y < loadedImage.Height ; y++ ) {
                    Color pixel = processedImage.GetPixel(x,y);
                    int avg = (int)((pixel.R + pixel.G + pixel.B) / 3);
                    histogram[avg]++;
                    r_histogram[pixel.R]++;
                    g_histogram[pixel.G]++;
                    b_histogram[pixel.B]++;
                }
            }

            initializeHistogram(chart1,"Gray",histogram, Color.Gray);
            initializeHistogram(chart2,"Red",r_histogram, Color.Red);
            initializeHistogram(chart3,"Green",g_histogram, Color.Green);
            initializeHistogram(chart4,"Blue",b_histogram, Color.Blue);

        }

        private void initializeHistogram(Chart c, string name, int[] histogram, Color color) { 
            c.Series.Clear();
            Series series = new Series("Gray");
            series.ChartType = SeriesChartType.Column;
            series.Color = color;
            for(int i = 0;i < 256 ; i++ ) {
                series.Points.AddXY(i, histogram[i]);
            }
            c.Series.Add(series);
            c.ChartAreas[0].RecalculateAxesScale();
        }
        private void initializeChart(Chart chart) {
            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 255;
            chart.ChartAreas[0].AxisY.Title = "Pixel Count";
            chart.ChartAreas[0].AxisX.Title = "Intensity";




            
            chart.Legends.Clear();
        }

        private void greyscale_Click(object sender, EventArgs e) {
            if(loadedImage == null ) {
                MessageBox.Show("Load an image first");
                return;
            }
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            for(int x = 0;x < loadedImage.Width ; x++ ) {
                for(int y = 0;y < loadedImage.Height ; y++ ) {
                    Color pixel = loadedImage.GetPixel(x,y);
                    int avg = (int)((pixel.R + pixel.G + pixel.B) / 3);
                    Color newPixel = Color.FromArgb(avg,avg,avg);
                    processedImage.SetPixel(x,y,newPixel);
                }
            }
            processedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            processedImageBox.Image = processedImage;

            loadHistogram();

        }

        private void invert_Click(object sender, EventArgs e) {
            if(loadedImage == null ) {
                MessageBox.Show("Load an image first");
                return;
            }
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            for(int x = 0;x < loadedImage.Width ; x++ ) {
                for(int y = 0;y < loadedImage.Height ; y++ ) {
                    Color pixel = loadedImage.GetPixel(x,y);
                    Color newPixel = Color.FromArgb(255 - pixel.R,255 - pixel.G,255 - pixel.B);
                    processedImage.SetPixel(x,y,newPixel);
                }
            }
            processedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            processedImageBox.Image = processedImage;

            loadHistogram();

        }

        private void Sepia_Click(object sender, EventArgs e) {
            if(loadedImage == null ) {
                MessageBox.Show("Load an image first");
                return;
            }
            processedImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            for(int x = 0;x < loadedImage.Width ; x++ ) {
                for(int y = 0;y < loadedImage.Height ; y++ ) {
                    Color pixel = loadedImage.GetPixel(x,y);
                    int newRed =   (int)(0.393*pixel.R + 0.769*pixel.G + 0.189*pixel.B);
                    int newGreen = (int)(0.349*pixel.R + 0.686*pixel.G + 0.168*pixel.B);
                    int newBlue =  (int)(0.272*pixel.R + 0.534*pixel.G + 0.131*pixel.B);
                    if(newRed > 255) newRed = 255;
                    if(newGreen> 255) newGreen = 255;
                    if(newBlue > 255) newBlue = 255;

                    Color newPixel = Color.FromArgb(newRed,newGreen,newBlue);
                    processedImage.SetPixel(x,y,newPixel);
                }
            }
            processedImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            processedImageBox.Image = processedImage;

            loadHistogram();

        }

        private void save_Click(object sender, EventArgs e) {
            saveFileDialog1.FileName = "image.png"; 
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) {
            string filePath = saveFileDialog1.FileName;
            ImageFormat format = ImageFormat.Png;
            switch (saveFileDialog1.FilterIndex)
            {
                case 1: format = ImageFormat.Png; break;
                case 2: format = ImageFormat.Jpeg; break;
                case 3: format = ImageFormat.Bmp; break;
            }
            processedImage.Save(saveFileDialog1.FileName, format);
            MessageBox.Show("Image saved successfully!");
        }
    }
}
