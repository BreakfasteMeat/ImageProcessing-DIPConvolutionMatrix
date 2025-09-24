namespace ImageProcessingActivity {
    partial class part2 {
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processedImage = new System.Windows.Forms.PictureBox();
            this.loadedImage2 = new System.Windows.Forms.PictureBox();
            this.loadedImage1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loadImage1 = new System.Windows.Forms.Button();
            this.loadImage2 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedImage1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.tableLayoutPanel1.Controls.Add(this.processedImage, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadedImage2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadedImage1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.32143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.67857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 477);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // processedImage
            // 
            this.processedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedImage.Location = new System.Drawing.Point(822, 4);
            this.processedImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.processedImage.Name = "processedImage";
            this.processedImage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.processedImage.Size = new System.Drawing.Size(325, 235);
            this.processedImage.TabIndex = 5;
            this.processedImage.TabStop = false;
            // 
            // loadedImage2
            // 
            this.loadedImage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadedImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadedImage2.Location = new System.Drawing.Point(413, 4);
            this.loadedImage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadedImage2.Name = "loadedImage2";
            this.loadedImage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadedImage2.Size = new System.Drawing.Size(401, 235);
            this.loadedImage2.TabIndex = 4;
            this.loadedImage2.TabStop = false;
            // 
            // loadedImage1
            // 
            this.loadedImage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadedImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadedImage1.Location = new System.Drawing.Point(4, 4);
            this.loadedImage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadedImage1.Name = "loadedImage1";
            this.loadedImage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadedImage1.Size = new System.Drawing.Size(401, 235);
            this.loadedImage1.TabIndex = 3;
            this.loadedImage1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.loadImage1);
            this.flowLayoutPanel1.Controls.Add(this.loadImage2);
            this.flowLayoutPanel1.Controls.Add(this.subtract);
            this.flowLayoutPanel1.Controls.Add(this.save);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 245);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1027, 89);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // loadImage1
            // 
            this.loadImage1.Location = new System.Drawing.Point(2, 2);
            this.loadImage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadImage1.Name = "loadImage1";
            this.loadImage1.Size = new System.Drawing.Size(136, 79);
            this.loadImage1.TabIndex = 0;
            this.loadImage1.Text = "Load Foreground Image";
            this.loadImage1.UseVisualStyleBackColor = true;
            this.loadImage1.Click += new System.EventHandler(this.loadImage1_Click);
            // 
            // loadImage2
            // 
            this.loadImage2.Location = new System.Drawing.Point(142, 2);
            this.loadImage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadImage2.Name = "loadImage2";
            this.loadImage2.Size = new System.Drawing.Size(136, 79);
            this.loadImage2.TabIndex = 1;
            this.loadImage2.Text = "Load Background Image";
            this.loadImage2.UseVisualStyleBackColor = true;
            this.loadImage2.Click += new System.EventHandler(this.loadImage2_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(282, 2);
            this.subtract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(136, 79);
            this.subtract.TabIndex = 2;
            this.subtract.Text = "Subtract";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(422, 2);
            this.save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(136, 79);
            this.save.TabIndex = 3;
            this.save.Text = "Save Processed Image";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.trackBar1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(562, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(238, 79);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Green Threshold";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(2, 15);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(236, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // flowLayoutPanel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel3, 3);
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 338);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1027, 85);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Subtract Once";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 79);
            this.button3.TabIndex = 2;
            this.button3.Text = "Start Continuous Subtraction";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "part2";
            this.Size = new System.Drawing.Size(1151, 477);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedImage1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox processedImage;
        private System.Windows.Forms.PictureBox loadedImage2;
        private System.Windows.Forms.PictureBox loadedImage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button loadImage1;
        private System.Windows.Forms.Button loadImage2;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}
