namespace howto_rgb_to_hls
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.picSample = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudG = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudR = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(525, 156);
            this.txtS.Margin = new System.Windows.Forms.Padding(4);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(65, 22);
            this.txtS.TabIndex = 28;
            this.txtS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtS.TextChanged += new System.EventHandler(this.txtHLS_TextChanged);
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(525, 124);
            this.txtL.Margin = new System.Windows.Forms.Padding(4);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(65, 22);
            this.txtL.TabIndex = 27;
            this.txtL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtL.TextChanged += new System.EventHandler(this.txtHLS_TextChanged);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(525, 92);
            this.txtH.Margin = new System.Windows.Forms.Padding(4);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(65, 22);
            this.txtH.TabIndex = 26;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtH.TextChanged += new System.EventHandler(this.txtHLS_TextChanged);
            // 
            // picSample
            // 
            this.picSample.Location = new System.Drawing.Point(63, 211);
            this.picSample.Margin = new System.Windows.Forms.Padding(4);
            this.picSample.Name = "picSample";
            this.picSample.Size = new System.Drawing.Size(255, 173);
            this.picSample.TabIndex = 25;
            this.picSample.TabStop = false;
            this.picSample.Click += new System.EventHandler(this.picSample_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "S:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "L:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "H:";
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(160, 159);
            this.nudB.Margin = new System.Windows.Forms.Padding(4);
            this.nudB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(67, 22);
            this.nudB.TabIndex = 21;
            this.nudB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudB.ValueChanged += new System.EventHandler(this.nudRGB_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "B:";
            // 
            // nudG
            // 
            this.nudG.Location = new System.Drawing.Point(160, 127);
            this.nudG.Margin = new System.Windows.Forms.Padding(4);
            this.nudG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudG.Name = "nudG";
            this.nudG.Size = new System.Drawing.Size(67, 22);
            this.nudG.TabIndex = 19;
            this.nudG.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudG.ValueChanged += new System.EventHandler(this.nudRGB_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "G:";
            // 
            // nudR
            // 
            this.nudR.Location = new System.Drawing.Point(160, 95);
            this.nudR.Margin = new System.Windows.Forms.Padding(4);
            this.nudR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR.Name = "nudR";
            this.nudR.Size = new System.Drawing.Size(67, 22);
            this.nudR.TabIndex = 17;
            this.nudR.ValueChanged += new System.EventHandler(this.nudRGB_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "R:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Convert RGB to HSI";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Convert HSI to RGB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(422, 211);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 173);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.picSample);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudR);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Hw3-61080500262";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.PictureBox picSample;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

