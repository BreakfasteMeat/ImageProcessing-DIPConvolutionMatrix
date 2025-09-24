using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebCamLib;

namespace ImageProcessingActivity {
    public partial class part2 : UserControl {
        public part2() {
            InitializeComponent();
        }

        Boolean isRecording = false;
        Boolean isContinuousSubtracting = false;
        Device[] devices;

        int threshold = 0;
        Bitmap loadedImg1,loadedImg2,processedImg;

        private void loadImage1_Click(object sender, EventArgs e) {
            if ( isRecording ) {
                MessageBox.Show("Stop Recording Before adding static image!");
                return;
            }
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
            
            processedImg = new Bitmap(loadedImg2.Width, loadedImg2.Height);
            Bitmap resizedForeground = ResizeImage(loadedImg1,loadedImg2);

            for(int y = 0;y < loadedImg2.Height ; y++ ) {
                for(int x = 0;x < loadedImg2.Width ; x++ ) {

                    Color pixel = resizedForeground.GetPixel(x,y);
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if ( !isRecording ) {
                devices = DeviceManager.GetAllDevices();
                loadedImage1.Image = null;
                devices[0].ShowWindow(loadedImage1);
                button1.Text = "Stop Recording";
                isRecording = true;
            } else {
                devices[0].Stop();
                isRecording = false;
                button1.Text = "Start Recording";
            }
        }

        private Bitmap ResizeImage(Bitmap original, Bitmap target) {
            Bitmap result = new Bitmap(target.Width, target.Height);
            for(int i = 0; i < target.Height ; i++ ) {
                for(int j = 0;j < target.Width ; j++ ) {
                    int xSource = j * original.Width / target.Width;
                    int ySource = i * original.Height / target.Height;

                    Color pixel = original.GetPixel(xSource, ySource);

                    result.SetPixel(j, i, pixel);
                }
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e) {
            if( !isRecording ) { 
                MessageBox.Show("No Camera Recording!");
                return;
            } else if (loadedImage2.Image == null) {
                MessageBox.Show("No Background Image!");
                return;
            }
            IDataObject data;
            Image bmap;
            Device d = DeviceManager.GetDevice(0);
            d.Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap",true));
            Bitmap original_fg = new Bitmap(bmap);
            Bitmap bg = new Bitmap(loadedImage2.Image);

            Bitmap fg = ResizeImage(original_fg,bg);

            Color green = Color.FromArgb(0,255,0);
            
            processedImg = new Bitmap(fg.Width, fg.Height);

            Console.WriteLine("Foreground Resolution: " + fg.Width + "x" + fg.Height);
            Console.WriteLine("Background Resolution: " + bg.Width + "x" + bg.Height);

            for(int x = 0;x < fg.Width ; x++ ) {
                for(int y = 0;y < fg.Height ; y++ ) {
                    Color pixel = fg.GetPixel(x,y);
                    Color backpixel = bg.GetPixel(x,y);
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

        private void button3_Click(object sender, EventArgs e) {
            if( !isRecording ) { 
                MessageBox.Show("No Camera Recording!");
                return;
            } else if (loadedImage2.Image == null) {
                MessageBox.Show("No Background Image!");
                return;
            }
            if ( !isContinuousSubtracting ) { 

                timer1.Enabled = true;
                
                isContinuousSubtracting = true;
            } else {
                timer1.Enabled = false;
                isContinuousSubtracting = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            button2_Click(sender, e);
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
