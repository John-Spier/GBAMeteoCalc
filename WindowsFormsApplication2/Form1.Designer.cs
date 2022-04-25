namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblNoRounding = new System.Windows.Forms.Label();
            this.lblBittrateToUse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbThirtytwo = new System.Windows.Forms.RadioButton();
            this.rbTwentyfour = new System.Windows.Forms.RadioButton();
            this.rbSixteen = new System.Windows.Forms.RadioButton();
            this.rbTwelve = new System.Windows.Forms.RadioButton();
            this.rbEight = new System.Windows.Forms.RadioButton();
            this.rbKilobytes = new System.Windows.Forms.RadioButton();
            this.lblAvBitrate = new System.Windows.Forms.Label();
            this.mskLength = new System.Windows.Forms.MaskedTextBox();
            this.mskCustomKilos = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(179, 213);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(93, 40);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "GO";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblNoRounding
            // 
            this.lblNoRounding.AutoSize = true;
            this.lblNoRounding.Location = new System.Drawing.Point(12, 243);
            this.lblNoRounding.Name = "lblNoRounding";
            this.lblNoRounding.Size = new System.Drawing.Size(81, 13);
            this.lblNoRounding.TabIndex = 1;
            this.lblNoRounding.Text = "Kbytes/s to use";
            // 
            // lblBittrateToUse
            // 
            this.lblBittrateToUse.AutoSize = true;
            this.lblBittrateToUse.Location = new System.Drawing.Point(12, 227);
            this.lblBittrateToUse.Name = "lblBittrateToUse";
            this.lblBittrateToUse.Size = new System.Drawing.Size(93, 13);
            this.lblBittrateToUse.TabIndex = 2;
            this.lblBittrateToUse.Text = "Unrounded Bitrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Length (minutes:seconds)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbThirtytwo
            // 
            this.rbThirtytwo.AutoSize = true;
            this.rbThirtytwo.Location = new System.Drawing.Point(12, 52);
            this.rbThirtytwo.Name = "rbThirtytwo";
            this.rbThirtytwo.Size = new System.Drawing.Size(53, 17);
            this.rbThirtytwo.TabIndex = 5;
            this.rbThirtytwo.TabStop = true;
            this.rbThirtytwo.Text = "32MB";
            this.rbThirtytwo.UseVisualStyleBackColor = true;
            this.rbThirtytwo.CheckedChanged += new System.EventHandler(this.rbThirtytwo_CheckedChanged);
            // 
            // rbTwentyfour
            // 
            this.rbTwentyfour.AutoSize = true;
            this.rbTwentyfour.Location = new System.Drawing.Point(12, 75);
            this.rbTwentyfour.Name = "rbTwentyfour";
            this.rbTwentyfour.Size = new System.Drawing.Size(53, 17);
            this.rbTwentyfour.TabIndex = 6;
            this.rbTwentyfour.TabStop = true;
            this.rbTwentyfour.Text = "24MB";
            this.rbTwentyfour.UseVisualStyleBackColor = true;
            this.rbTwentyfour.CheckedChanged += new System.EventHandler(this.rbTwentyfour_CheckedChanged);
            // 
            // rbSixteen
            // 
            this.rbSixteen.AutoSize = true;
            this.rbSixteen.Location = new System.Drawing.Point(12, 98);
            this.rbSixteen.Name = "rbSixteen";
            this.rbSixteen.Size = new System.Drawing.Size(53, 17);
            this.rbSixteen.TabIndex = 7;
            this.rbSixteen.TabStop = true;
            this.rbSixteen.Text = "16MB";
            this.rbSixteen.UseVisualStyleBackColor = true;
            this.rbSixteen.CheckedChanged += new System.EventHandler(this.rbSixteen_CheckedChanged);
            // 
            // rbTwelve
            // 
            this.rbTwelve.AutoSize = true;
            this.rbTwelve.Location = new System.Drawing.Point(12, 121);
            this.rbTwelve.Name = "rbTwelve";
            this.rbTwelve.Size = new System.Drawing.Size(53, 17);
            this.rbTwelve.TabIndex = 8;
            this.rbTwelve.TabStop = true;
            this.rbTwelve.Text = "12MB";
            this.rbTwelve.UseVisualStyleBackColor = true;
            this.rbTwelve.CheckedChanged += new System.EventHandler(this.rbTwelve_CheckedChanged);
            // 
            // rbEight
            // 
            this.rbEight.AutoSize = true;
            this.rbEight.Location = new System.Drawing.Point(12, 144);
            this.rbEight.Name = "rbEight";
            this.rbEight.Size = new System.Drawing.Size(47, 17);
            this.rbEight.TabIndex = 9;
            this.rbEight.TabStop = true;
            this.rbEight.Text = "8MB";
            this.rbEight.UseVisualStyleBackColor = true;
            this.rbEight.CheckedChanged += new System.EventHandler(this.rbEight_CheckedChanged);
            // 
            // rbKilobytes
            // 
            this.rbKilobytes.AutoSize = true;
            this.rbKilobytes.Location = new System.Drawing.Point(12, 167);
            this.rbKilobytes.Name = "rbKilobytes";
            this.rbKilobytes.Size = new System.Drawing.Size(86, 17);
            this.rbKilobytes.TabIndex = 10;
            this.rbKilobytes.TabStop = true;
            this.rbKilobytes.Text = "Custom (KB):";
            this.rbKilobytes.UseVisualStyleBackColor = true;
            this.rbKilobytes.CheckedChanged += new System.EventHandler(this.rbKilobytes_CheckedChanged);
            // 
            // lblAvBitrate
            // 
            this.lblAvBitrate.AutoSize = true;
            this.lblAvBitrate.Location = new System.Drawing.Point(6, 213);
            this.lblAvBitrate.Name = "lblAvBitrate";
            this.lblAvBitrate.Size = new System.Drawing.Size(99, 13);
            this.lblAvBitrate.TabIndex = 12;
            this.lblAvBitrate.Text = "Audio/Video Bitrate";
            // 
            // mskLength
            // 
            this.mskLength.AsciiOnly = true;
            this.mskLength.Location = new System.Drawing.Point(144, 12);
            this.mskLength.Mask = "09:09";
            this.mskLength.Name = "mskLength";
            this.mskLength.Size = new System.Drawing.Size(128, 20);
            this.mskLength.TabIndex = 13;
            // 
            // mskCustomKilos
            // 
            this.mskCustomKilos.AsciiOnly = true;
            this.mskCustomKilos.Location = new System.Drawing.Point(141, 166);
            this.mskCustomKilos.Mask = "00009";
            this.mskCustomKilos.Name = "mskCustomKilos";
            this.mskCustomKilos.Size = new System.Drawing.Size(131, 20);
            this.mskCustomKilos.TabIndex = 14;
            this.mskCustomKilos.Text = "04096";
            this.mskCustomKilos.TextChanged += new System.EventHandler(this.mskCustomKilos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "<-- ROM SIZE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "<-- ROM SIZE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCustomKilos);
            this.Controls.Add(this.mskLength);
            this.Controls.Add(this.lblAvBitrate);
            this.Controls.Add(this.rbKilobytes);
            this.Controls.Add(this.rbEight);
            this.Controls.Add(this.rbTwelve);
            this.Controls.Add(this.rbSixteen);
            this.Controls.Add(this.rbTwentyfour);
            this.Controls.Add(this.rbThirtytwo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBittrateToUse);
            this.Controls.Add(this.lblNoRounding);
            this.Controls.Add(this.btnCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GBA Meteo Bitrate Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblNoRounding;
        private System.Windows.Forms.Label lblBittrateToUse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbThirtytwo;
        private System.Windows.Forms.RadioButton rbTwentyfour;
        private System.Windows.Forms.RadioButton rbSixteen;
        private System.Windows.Forms.RadioButton rbTwelve;
        private System.Windows.Forms.RadioButton rbEight;
        private System.Windows.Forms.RadioButton rbKilobytes;
        private System.Windows.Forms.Label lblAvBitrate;
        private System.Windows.Forms.MaskedTextBox mskLength;
        private System.Windows.Forms.MaskedTextBox mskCustomKilos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

