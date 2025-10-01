using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace ImageProcessingActivity {
    public partial class Form1 : Form {

        part1 part1 = null;
        part2 part2 = null;
        DIPConvolutionMatrix dipconvmatr = null;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            panel1.Controls.Clear();
            panel1.Controls.Add(new part1());
        }
        private void changePanel(UserControl control) {

            
            if(control.GetType() == panel1.Controls[0].GetType() ) {
                return;
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }
        private void imageProcessingToolStripMenuItem_Click(object sender, EventArgs e) {
            if(part1 == null ) {
                part1 = new part1();
            }
            changePanel(part1);
        }

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e) {
            if(part2 == null ) { 
                part2 = new part2();
            }
            changePanel(part2);
        }

        private void bitmapFiltersToolStripMenuItem_Click(object sender, EventArgs e) {
            if(dipconvmatr == null ) {
                dipconvmatr = new DIPConvolutionMatrix();
            }
            changePanel(dipconvmatr);
        }
    }
}
