namespace ImageProcessingActivity {
    partial class part1 {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.processedImageBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loadedImageBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loadImage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.greyscale = new System.Windows.Forms.Button();
            this.invert = new System.Windows.Forms.Button();
            this.Sepia = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.processedImageBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadedImageBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // processedImageBox
            // 
            this.processedImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processedImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedImageBox.Location = new System.Drawing.Point(509, 25);
            this.processedImageBox.Margin = new System.Windows.Forms.Padding(5);
            this.processedImageBox.Name = "processedImageBox";
            this.processedImageBox.Padding = new System.Windows.Forms.Padding(5);
            this.processedImageBox.Size = new System.Drawing.Size(474, 396);
            this.processedImageBox.TabIndex = 1;
            this.processedImageBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tableLayoutPanel1.Controls.Add(this.loadedImageBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processedImageBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1417, 872);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // loadedImageBox
            // 
            this.loadedImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadedImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadedImageBox.Location = new System.Drawing.Point(25, 25);
            this.loadedImageBox.Margin = new System.Windows.Forms.Padding(5);
            this.loadedImageBox.Name = "loadedImageBox";
            this.loadedImageBox.Padding = new System.Windows.Forms.Padding(5);
            this.loadedImageBox.Size = new System.Drawing.Size(474, 396);
            this.loadedImageBox.TabIndex = 2;
            this.loadedImageBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.greyscale);
            this.flowLayoutPanel1.Controls.Add(this.invert);
            this.flowLayoutPanel1.Controls.Add(this.Sepia);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 82);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // loadImage
            // 
            this.loadImage.Location = new System.Drawing.Point(3, 91);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(477, 69);
            this.loadImage.TabIndex = 0;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // greyscale
            // 
            this.greyscale.Location = new System.Drawing.Point(153, 3);
            this.greyscale.Name = "greyscale";
            this.greyscale.Size = new System.Drawing.Size(144, 69);
            this.greyscale.TabIndex = 2;
            this.greyscale.Text = "Greyscale";
            this.greyscale.UseVisualStyleBackColor = true;
            this.greyscale.Click += new System.EventHandler(this.greyscale_Click);
            // 
            // invert
            // 
            this.invert.Location = new System.Drawing.Point(303, 3);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(144, 69);
            this.invert.TabIndex = 3;
            this.invert.Text = "Invert Color";
            this.invert.UseVisualStyleBackColor = true;
            this.invert.Click += new System.EventHandler(this.invert_Click);
            // 
            // Sepia
            // 
            this.Sepia.Location = new System.Drawing.Point(453, 3);
            this.Sepia.Name = "Sepia";
            this.Sepia.Size = new System.Drawing.Size(144, 69);
            this.Sepia.TabIndex = 4;
            this.Sepia.Text = "Sepia";
            this.Sepia.UseVisualStyleBackColor = true;
            this.Sepia.Click += new System.EventHandler(this.Sepia_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.chart1);
            this.flowLayoutPanel2.Controls.Add(this.chart2);
            this.flowLayoutPanel2.Controls.Add(this.chart3);
            this.flowLayoutPanel2.Controls.Add(this.chart4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(991, 23);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel2, 2);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(402, 582);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(402, 136);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(3, 145);
            this.chart2.Name = "chart2";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(402, 136);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea11.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart3.Legends.Add(legend11);
            this.chart3.Location = new System.Drawing.Point(3, 287);
            this.chart3.Name = "chart3";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chart3.Series.Add(series11);
            this.chart3.Size = new System.Drawing.Size(402, 136);
            this.chart3.TabIndex = 5;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea12.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart4.Legends.Add(legend12);
            this.chart4.Location = new System.Drawing.Point(3, 429);
            this.chart4.Name = "chart4";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chart4.Series.Add(series12);
            this.chart4.Size = new System.Drawing.Size(402, 136);
            this.chart4.TabIndex = 6;
            this.chart4.Text = "chart4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479F));
            this.tableLayoutPanel2.Controls.Add(this.save, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.loadImage, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 429);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(962, 177);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(486, 91);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(473, 69);
            this.save.TabIndex = 4;
            this.save.Text = "Save Processed Image";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // part1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "part1";
            this.Size = new System.Drawing.Size(1423, 878);
            ((System.ComponentModel.ISupportInitialize)(this.processedImageBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadedImageBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox processedImageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox loadedImageBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button greyscale;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.Button Sepia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
