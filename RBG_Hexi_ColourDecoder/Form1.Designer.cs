namespace RBG_Hexi_ColourDecoder
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
            this.previewBtn = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.TextBox();
            this.colourBlue = new System.Windows.Forms.TrackBar();
            this.green = new System.Windows.Forms.TextBox();
            this.colourGreen = new System.Windows.Forms.TrackBar();
            this.red = new System.Windows.Forms.TextBox();
            this.colourRed = new System.Windows.Forms.TrackBar();
            this.result = new System.Windows.Forms.GroupBox();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.displayTxt = new System.Windows.Forms.TextBox();
            this.hex = new System.Windows.Forms.RadioButton();
            this.rgb = new System.Windows.Forms.RadioButton();
            this.argb = new System.Windows.Forms.RadioButton();
            this.rgba = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.greyScale = new System.Windows.Forms.RadioButton();
            this.colour = new System.Windows.Forms.RadioButton();
            this.explination = new System.Windows.Forms.TextBox();
            this.alpha = new System.Windows.Forms.TextBox();
            this.colourAlpha = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.colourBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourRed)).BeginInit();
            this.result.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colourAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // previewBtn
            // 
            this.previewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previewBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.previewBtn.Location = new System.Drawing.Point(6, 19);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(182, 91);
            this.previewBtn.TabIndex = 18;
            this.previewBtn.UseVisualStyleBackColor = true;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.SystemColors.Window;
            this.blue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blue.Location = new System.Drawing.Point(6, 176);
            this.blue.Name = "blue";
            this.blue.ReadOnly = true;
            this.blue.Size = new System.Drawing.Size(226, 13);
            this.blue.TabIndex = 17;
            this.blue.Text = "Blue";
            this.blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colourBlue
            // 
            this.colourBlue.LargeChange = 10;
            this.colourBlue.Location = new System.Drawing.Point(6, 144);
            this.colourBlue.Maximum = 255;
            this.colourBlue.Name = "colourBlue";
            this.colourBlue.Size = new System.Drawing.Size(226, 45);
            this.colourBlue.TabIndex = 16;
            this.colourBlue.TickFrequency = 20;
            this.colourBlue.Scroll += new System.EventHandler(this.colourBlue_Scroll);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.SystemColors.Window;
            this.green.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.green.Location = new System.Drawing.Point(6, 115);
            this.green.Name = "green";
            this.green.ReadOnly = true;
            this.green.Size = new System.Drawing.Size(226, 13);
            this.green.TabIndex = 15;
            this.green.Text = "Green";
            this.green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colourGreen
            // 
            this.colourGreen.LargeChange = 10;
            this.colourGreen.Location = new System.Drawing.Point(6, 83);
            this.colourGreen.Maximum = 255;
            this.colourGreen.Name = "colourGreen";
            this.colourGreen.Size = new System.Drawing.Size(226, 45);
            this.colourGreen.TabIndex = 14;
            this.colourGreen.TickFrequency = 20;
            this.colourGreen.Scroll += new System.EventHandler(this.colourGreen_Scroll);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.SystemColors.Window;
            this.red.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.red.Location = new System.Drawing.Point(6, 51);
            this.red.Name = "red";
            this.red.ReadOnly = true;
            this.red.Size = new System.Drawing.Size(226, 13);
            this.red.TabIndex = 13;
            this.red.Text = "Red";
            this.red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colourRed
            // 
            this.colourRed.BackColor = System.Drawing.SystemColors.Window;
            this.colourRed.LargeChange = 10;
            this.colourRed.Location = new System.Drawing.Point(6, 19);
            this.colourRed.Maximum = 255;
            this.colourRed.Name = "colourRed";
            this.colourRed.Size = new System.Drawing.Size(226, 45);
            this.colourRed.TabIndex = 12;
            this.colourRed.TickFrequency = 20;
            this.colourRed.Scroll += new System.EventHandler(this.colourRed_Scroll);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Window;
            this.result.Controls.Add(this.outputTxt);
            this.result.Controls.Add(this.displayTxt);
            this.result.Controls.Add(this.hex);
            this.result.Controls.Add(this.rgb);
            this.result.Controls.Add(this.argb);
            this.result.Controls.Add(this.rgba);
            this.result.Controls.Add(this.previewBtn);
            this.result.Location = new System.Drawing.Point(256, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(194, 351);
            this.result.TabIndex = 20;
            this.result.TabStop = false;
            this.result.Text = "Preview";
            // 
            // outputTxt
            // 
            this.outputTxt.BackColor = System.Drawing.SystemColors.Window;
            this.outputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTxt.Location = new System.Drawing.Point(6, 298);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(182, 13);
            this.outputTxt.TabIndex = 23;
            this.outputTxt.Text = "Colour RGBA";
            this.outputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayTxt
            // 
            this.displayTxt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.displayTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTxt.Location = new System.Drawing.Point(6, 313);
            this.displayTxt.Name = "displayTxt";
            this.displayTxt.ReadOnly = true;
            this.displayTxt.Size = new System.Drawing.Size(182, 30);
            this.displayTxt.TabIndex = 23;
            this.displayTxt.Text = "0, 0, 0, 255";
            this.displayTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Location = new System.Drawing.Point(6, 213);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(82, 17);
            this.hex.TabIndex = 22;
            this.hex.Text = "Hexidecimal";
            this.hex.UseVisualStyleBackColor = true;
            this.hex.CheckedChanged += new System.EventHandler(this.hex_CheckedChanged);
            // 
            // rgb
            // 
            this.rgb.AutoSize = true;
            this.rgb.Location = new System.Drawing.Point(6, 190);
            this.rgb.Name = "rgb";
            this.rgb.Size = new System.Drawing.Size(48, 17);
            this.rgb.TabIndex = 21;
            this.rgb.Text = "RGB";
            this.rgb.UseVisualStyleBackColor = true;
            this.rgb.CheckedChanged += new System.EventHandler(this.rgb_CheckedChanged);
            // 
            // argb
            // 
            this.argb.AutoSize = true;
            this.argb.Location = new System.Drawing.Point(6, 167);
            this.argb.Name = "argb";
            this.argb.Size = new System.Drawing.Size(55, 17);
            this.argb.TabIndex = 20;
            this.argb.Text = "ARGB";
            this.argb.UseVisualStyleBackColor = true;
            this.argb.CheckedChanged += new System.EventHandler(this.argb_CheckedChanged);
            // 
            // rgba
            // 
            this.rgba.AutoSize = true;
            this.rgba.Checked = true;
            this.rgba.Location = new System.Drawing.Point(6, 144);
            this.rgba.Name = "rgba";
            this.rgba.Size = new System.Drawing.Size(55, 17);
            this.rgba.TabIndex = 19;
            this.rgba.TabStop = true;
            this.rgba.Text = "RGBA";
            this.rgba.UseVisualStyleBackColor = true;
            this.rgba.CheckedChanged += new System.EventHandler(this.rgba_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.greyScale);
            this.groupBox1.Controls.Add(this.colour);
            this.groupBox1.Controls.Add(this.explination);
            this.groupBox1.Controls.Add(this.alpha);
            this.groupBox1.Controls.Add(this.colourAlpha);
            this.groupBox1.Controls.Add(this.blue);
            this.groupBox1.Controls.Add(this.green);
            this.groupBox1.Controls.Add(this.red);
            this.groupBox1.Controls.Add(this.colourRed);
            this.groupBox1.Controls.Add(this.colourGreen);
            this.groupBox1.Controls.Add(this.colourBlue);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 351);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sliders";
            // 
            // greyScale
            // 
            this.greyScale.AutoSize = true;
            this.greyScale.Location = new System.Drawing.Point(77, 238);
            this.greyScale.Name = "greyScale";
            this.greyScale.Size = new System.Drawing.Size(77, 17);
            this.greyScale.TabIndex = 22;
            this.greyScale.Text = "Grey Scale";
            this.greyScale.UseVisualStyleBackColor = true;
            this.greyScale.CheckedChanged += new System.EventHandler(this.greyScale_CheckedChanged);
            // 
            // colour
            // 
            this.colour.AutoSize = true;
            this.colour.Checked = true;
            this.colour.Location = new System.Drawing.Point(77, 215);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(55, 17);
            this.colour.TabIndex = 21;
            this.colour.TabStop = true;
            this.colour.Text = "Colour";
            this.colour.UseVisualStyleBackColor = true;
            this.colour.CheckedChanged += new System.EventHandler(this.colour_CheckedChanged);
            // 
            // explination
            // 
            this.explination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.explination.Location = new System.Drawing.Point(6, 285);
            this.explination.Name = "explination";
            this.explination.Size = new System.Drawing.Size(226, 13);
            this.explination.TabIndex = 20;
            this.explination.Text = "Only for use with RGBA / ARGB";
            this.explination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alpha
            // 
            this.alpha.BackColor = System.Drawing.SystemColors.Window;
            this.alpha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alpha.Location = new System.Drawing.Point(6, 330);
            this.alpha.Name = "alpha";
            this.alpha.ReadOnly = true;
            this.alpha.Size = new System.Drawing.Size(226, 13);
            this.alpha.TabIndex = 19;
            this.alpha.Text = "Alpha";
            this.alpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colourAlpha
            // 
            this.colourAlpha.LargeChange = 10;
            this.colourAlpha.Location = new System.Drawing.Point(6, 298);
            this.colourAlpha.Maximum = 255;
            this.colourAlpha.Name = "colourAlpha";
            this.colourAlpha.Size = new System.Drawing.Size(226, 45);
            this.colourAlpha.TabIndex = 18;
            this.colourAlpha.TickFrequency = 20;
            this.colourAlpha.Value = 255;
            this.colourAlpha.Scroll += new System.EventHandler(this.colourAlpha_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(468, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 418);
            this.MinimumSize = new System.Drawing.Size(484, 418);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RGB/Hexi Colour Decoder";
            ((System.ComponentModel.ISupportInitialize)(this.colourBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourRed)).EndInit();
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colourAlpha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.TextBox blue;
        private System.Windows.Forms.TrackBar colourBlue;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.TrackBar colourGreen;
        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.TrackBar colourRed;
        private System.Windows.Forms.GroupBox result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox explination;
        private System.Windows.Forms.TextBox alpha;
        private System.Windows.Forms.TrackBar colourAlpha;
        private System.Windows.Forms.RadioButton greyScale;
        private System.Windows.Forms.RadioButton colour;
        private System.Windows.Forms.RadioButton hex;
        private System.Windows.Forms.RadioButton rgb;
        private System.Windows.Forms.RadioButton argb;
        private System.Windows.Forms.RadioButton rgba;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.TextBox displayTxt;
    }
}

