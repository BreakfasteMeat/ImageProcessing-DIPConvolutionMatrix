using ConvolutionManip;
using Emgu.CV;
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
    public partial class DIPConvolutionMatrix : UserControl {
        Bitmap source;
        Bitmap result;
        private Mat sourceMat;
        VideoCapture videoCapture;
        Bitmap camCapture;
        Boolean isRecording = false;

        enum FilterMode {
            picture, video
        }
        enum Filter {
            sharpen,
            gaussianBlur,
            embossLaplascian,
            none,
            meanRemoval,
            embossLossy,
            horizontalEmboss,
            customMatrix
        }

        FilterMode filterMode = FilterMode.picture;
        Filter currentFilter = Filter.none;
        public DIPConvolutionMatrix() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if ( isRecording ) {
                MessageBox.Show("Stop Recording before uploading image!");
                return;
            }
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
            sourceMat = new Mat(openFileDialog1.FileName);
            Bitmap bmp = sourceMat.ToBitmap();
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
    {
        if (!isRecording)
        {
            videoCapture = new VideoCapture(0);
            if (!videoCapture.IsOpened)
            {
                MessageBox.Show("Cannot open camera.");
                return;
            }

            timer1.Start();
            button2.Text = "Stop Camera";
        }
        else
        {
            timer1.Stop();
            videoCapture?.Stop();
            videoCapture?.Dispose();
            videoCapture = null;

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;
            pictureBox3.Image?.Dispose();
            pictureBox3.Image = null;

            button2.Text = "Start Camera";
        }

        isRecording = !isRecording;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (videoCapture == null || !videoCapture.IsOpened)
            return;

        using (Mat frame = new Mat())
        {
            videoCapture.Read(frame);
            if (!frame.IsEmpty)
            {
                try
                {
                        Bitmap newBmp = frame.ToBitmap();
                        Bitmap oldBmp = (Bitmap)pictureBox1.Image;
                        Bitmap filteredBmp = new Bitmap(newBmp);
                        pictureBox1.Image = newBmp;
                        oldBmp?.Dispose();
                        switch ( currentFilter ) {
                            case Filter.none:
                                break;
                            case Filter.sharpen:
                                ConvolutionFilter.Sharpen(filteredBmp,2);
                                break;
                            case Filter.gaussianBlur:
                                ConvolutionFilter.GaussianBlur(filteredBmp,1);
                                break;
                            case Filter.embossLaplascian:
                                ConvolutionFilter.EmbossLaplascian(filteredBmp,1);
                                break;
                            case Filter.meanRemoval:
                                ConvolutionFilter.MeanRemoval(filteredBmp,1);
                                break;
                            case Filter.embossLossy:
                                ConvolutionFilter.EmbossLossy(filteredBmp,1);
                                break;
                            case Filter.horizontalEmboss:
                                ConvolutionFilter.HorizontalEmboss(filteredBmp,1);
                                break;
                            case Filter.customMatrix:
                                ConvMatrix m = new ConvMatrix();
                                try { 
                                    m.TopLeft = int.Parse(textBox1.Text);
                                    m.TopMid = int.Parse(textBox2.Text);
                                    m.TopRight = int.Parse(textBox3.Text);
                                    m.MidLeft = int.Parse(textBox4.Text);
                                    m.Pixel = int.Parse(textBox5.Text);
                                    m.MidRight= int.Parse(textBox6.Text);
                                    m.BottomLeft = int.Parse(textBox7.Text);
                                    m.BottomMid = int.Parse(textBox8.Text);
                                    m.BottomRight = int.Parse(textBox9.Text);
                                } catch (FormatException exc) {
                                    button2_Click(sender, e);
                                    MessageBox.Show("Must input values inside matrix!");
                                }
                                if(textBox10.Text != "") m.Factor = int.Parse(textBox10.Text);

                                if(textBox11.Text != "") m.Offset = int.Parse(textBox11.Text);
                                if(m.Factor == 0) m.Factor = 1;
                                ConvolutionFilter.CustomMatrix(filteredBmp, m);
                                break;
                                

                        }
                        Bitmap oldFiltered = (Bitmap)pictureBox3.Image;
                        pictureBox3.Image = filteredBmp;
                        oldFiltered?.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Frame skipped: " + ex.Message);
                }
            }
        }
    }

        private void button3_Click(object sender, EventArgs e) {
            if(pictureBox1.Image == null) return;
            if(!isRecording) { 
                result = new Bitmap(pictureBox1.Image);
                ConvolutionFilter.Sharpen(result,2);
                pictureBox3.Image = result;
            } else if(isRecording){
                currentFilter = Filter.sharpen;
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            if(pictureBox1.Image == null) return;
            if(!isRecording) {
                result = new Bitmap(pictureBox1.Image);
                ConvolutionFilter.GaussianBlur(result,1);
                pictureBox3.Image = result;
            } else {
                currentFilter = Filter.gaussianBlur;
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            if(pictureBox1.Image == null) return;

            if(!isRecording) {
                result = new Bitmap(pictureBox1.Image);
                ConvolutionFilter.EmbossLaplascian(result,1);
                pictureBox3.Image = result;
            } else {
                currentFilter = Filter.embossLaplascian;
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            if(pictureBox1.Image == null) return;

            if(!isRecording) {
                result = new Bitmap(pictureBox1.Image);
                ConvolutionFilter.MeanRemoval(result,1);
                pictureBox3.Image = result;
            } else {
                currentFilter = Filter.meanRemoval;
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            if(pictureBox1.Image == null) return;

            if(!isRecording) {
                result = new Bitmap(pictureBox1.Image);
                ConvolutionFilter.EmbossLossy(result,1);
                pictureBox3.Image = result;
            } else {
                currentFilter = Filter.embossLossy;
            }
        }

        private void button8_Click(object sender, EventArgs e) {
            if(pictureBox1.Image == null) return;

            if(!isRecording) {
                result = new Bitmap(pictureBox1.Image);
                ConvolutionFilter.HorizontalEmboss(result,1);
                pictureBox3.Image = result;
            } else {
                currentFilter = Filter.horizontalEmboss;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBoxKeyPressOnlyDecimals(object sender, KeyPressEventArgs e){
            TextBox textBox = sender as TextBox;

            // allows 0-9, backspace, decimal, and negative sign
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 45))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if (textBox.Text.IndexOf('.') != -1)
                    e.Handled = true;
            }

            // checks to make sure '-' is only at the start and only once
            if (e.KeyChar == 45) // '-'
            {
                if (textBox.SelectionStart != 0 || textBox.Text.IndexOf('-') != -1)
                    e.Handled = true;
            }
        }


        private void button10_Click(object sender, EventArgs e) {

            if(textBox12.Text == "" ) {
                return;
            }
            textBox1.Text = textBox12.Text;
            textBox2.Text = textBox12.Text;
            textBox3.Text = textBox12.Text;
            textBox4.Text = textBox12.Text;
            textBox5.Text = textBox12.Text;
            textBox6.Text = textBox12.Text;
            textBox7.Text = textBox12.Text;
            textBox8.Text = textBox12.Text;
            textBox9.Text = textBox12.Text;

        }

        private void button9_Click(object sender, EventArgs e) {
            if(pictureBox1.Image == null) return;

            ConvMatrix m = new ConvMatrix();
            try { 
                m.TopLeft = int.Parse(textBox1.Text);
                m.TopMid = int.Parse(textBox2.Text);
                m.TopRight = int.Parse(textBox3.Text);
                m.MidLeft = int.Parse(textBox4.Text);
                m.Pixel = int.Parse(textBox5.Text);
                m.MidRight= int.Parse(textBox6.Text);
                m.BottomLeft = int.Parse(textBox7.Text);
                m.BottomMid = int.Parse(textBox8.Text);
                m.BottomRight = int.Parse(textBox9.Text);
            } catch (FormatException exc) {
                MessageBox.Show("Must input values inside matrix!");
            }
            if(textBox10.Text != "") m.Factor = int.Parse(textBox10.Text);

            if(textBox11.Text != "") m.Offset = int.Parse(textBox11.Text);
            if(m.Factor == 0) m.Factor = 1;

            if(!isRecording) {
                result = new Bitmap(pictureBox1.Image);
                ConvolutionFilter.CustomMatrix(result,m);
                pictureBox3.Image = result;
            } else {
                currentFilter = Filter.customMatrix;
            }
        }

        private void button11_Click(object sender, EventArgs e) {
            if(pictureBox3.Image == null) { 
                MessageBox.Show("No image / video being processed!");
                return ;
            }
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
            using (Bitmap bmp = new Bitmap(pictureBox3.Image)) {
                bmp.Save(filePath, format);
            }
            MessageBox.Show("Image saved successfully!");
        }
    }
}
