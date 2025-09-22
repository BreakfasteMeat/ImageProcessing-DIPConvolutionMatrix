using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessingActivity {
    public partial class part2 : UserControl {
        public part2() {
            InitializeComponent();
        }

        int threshold = 0;
        Bitmap loadedImg1,loadedImg2,processedImg;

        private void loadImage1_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
        }

        private void loadImage2_Click(object sender, EventArgs e) {
            openFileDialog2.ShowDialog();
        }

        private void subtract_Click(object sender, EventArgs e) {
            if(loadedImg1 == null || loadedImg2 == null ) {
                MessageBox.Show("Foreground and Background Image should not be null");
                return;
            }
            Color green = Color.FromArgb(0,255,0);
            
            processedImg = new Bitmap(loadedImg1.Width, loadedImg1.Height);

            for(int x = 0;x < loadedImg1.Width ; x++ ) {
                for(int y = 0;y < loadedImg1.Height ; y++ ) {
                    Color pixel = loadedImg1.GetPixel(x,y);
                    Color backpixel = loadedImg2.GetPixel(x,y);
                    int dr = pixel.R - 0;
                    int dg = pixel.G - 255;
                    int db = pixel.B - 0;

                    //See how far from the "Green" corner
                    double distance = Math.Sqrt((dr*dr)+(dg*dg)+(db*db));

                    if(distance < threshold) {
                        processedImg.SetPixel(x,y,backpixel);
                    } else {
                        processedImg.SetPixel(x,y,pixel);
                    }
                }
            }
            processedImage.SizeMode = PictureBoxSizeMode.Zoom;
            processedImage.Image = processedImg;
        }

        private void save_Click(object sender, EventArgs e) {
            saveFileDialog1.FileName = "image.png"; 
            saveFileDialog1.ShowDialog();
        }


        private void trackBar1_Scroll(object sender, EventArgs e) {
            threshold = trackBar1.Value;
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
            processedImg.Save(saveFileDialog1.FileName, format);
            MessageBox.Show("Image saved successfully!");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
            loadedImg1 = new Bitmap(openFileDialog1.FileName);
            loadedImage1.SizeMode = PictureBoxSizeMode.Zoom;
            loadedImage1.Image = loadedImg1;

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e) {
            loadedImg2 = new Bitmap(openFileDialog2.FileName);
            loadedImage2.SizeMode = PictureBoxSizeMode.Zoom;
            loadedImage2.Image = loadedImg2;
        }
    }
}
