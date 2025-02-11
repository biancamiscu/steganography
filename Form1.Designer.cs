namespace Steganography_Program
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
            this.pictureBoxBefore = new System.Windows.Forms.PictureBox();
            this.pictureBoxStego = new System.Windows.Forms.PictureBox();
            this.labelImageBefore = new System.Windows.Forms.Label();
            this.labelImageAfter = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.routeBox = new System.Windows.Forms.TextBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.embedButton = new System.Windows.Forms.Button();
            this.embedLabel = new System.Windows.Forms.Label();
            this.textToEmbed = new System.Windows.Forms.RichTextBox();
            this.imageRouteLabel = new System.Windows.Forms.Label();
            this.decodeButton = new System.Windows.Forms.Button();
            this.StegoLabel = new System.Windows.Forms.Label();
            this.stegobox = new System.Windows.Forms.TextBox();
            this.openStegoBtn = new System.Windows.Forms.Button();
            this.saveStegoBtn = new System.Windows.Forms.Button();
            this.Lsb1Button = new System.Windows.Forms.RadioButton();
            this.Lsb2Button = new System.Windows.Forms.RadioButton();
            this.Lsb4Button = new System.Windows.Forms.RadioButton();
            this.Lsb3Button = new System.Windows.Forms.RadioButton();
            this.decodedLabel = new System.Windows.Forms.Label();
            this.decodedText = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStego)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBefore
            // 
            this.pictureBoxBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxBefore.Location = new System.Drawing.Point(614, 43);
            this.pictureBoxBefore.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxBefore.Name = "pictureBoxBefore";
            this.pictureBoxBefore.Size = new System.Drawing.Size(358, 221);
            this.pictureBoxBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBefore.TabIndex = 0;
            this.pictureBoxBefore.TabStop = false;
            // 
            // pictureBoxStego
            // 
            this.pictureBoxStego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxStego.Location = new System.Drawing.Point(614, 341);
            this.pictureBoxStego.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxStego.Name = "pictureBoxStego";
            this.pictureBoxStego.Size = new System.Drawing.Size(358, 240);
            this.pictureBoxStego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStego.TabIndex = 1;
            this.pictureBoxStego.TabStop = false;
            // 
            // labelImageBefore
            // 
            this.labelImageBefore.AutoSize = true;
            this.labelImageBefore.Location = new System.Drawing.Point(625, 9);
            this.labelImageBefore.Name = "labelImageBefore";
            this.labelImageBefore.Size = new System.Drawing.Size(90, 16);
            this.labelImageBefore.TabIndex = 2;
            this.labelImageBefore.Text = "Image before:";
            // 
            // labelImageAfter
            // 
            this.labelImageAfter.AutoSize = true;
            this.labelImageAfter.Location = new System.Drawing.Point(625, 309);
            this.labelImageAfter.Name = "labelImageAfter";
            this.labelImageAfter.Size = new System.Drawing.Size(77, 16);
            this.labelImageAfter.TabIndex = 3;
            this.labelImageAfter.Text = "Image after:";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(84, 71);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // routeBox
            // 
            this.routeBox.Location = new System.Drawing.Point(12, 43);
            this.routeBox.Name = "routeBox";
            this.routeBox.Size = new System.Drawing.Size(263, 22);
            this.routeBox.TabIndex = 5;
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(773, 302);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(100, 23);
            this.pBar1.TabIndex = 11;
            this.pBar1.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // embedButton
            // 
            this.embedButton.Location = new System.Drawing.Point(281, 348);
            this.embedButton.Name = "embedButton";
            this.embedButton.Size = new System.Drawing.Size(75, 23);
            this.embedButton.TabIndex = 12;
            this.embedButton.Text = "Embed";
            this.embedButton.UseVisualStyleBackColor = true;
            this.embedButton.Click += new System.EventHandler(this.embedButton_Click);
            // 
            // embedLabel
            // 
            this.embedLabel.AutoSize = true;
            this.embedLabel.Location = new System.Drawing.Point(9, 113);
            this.embedLabel.Name = "embedLabel";
            this.embedLabel.Size = new System.Drawing.Size(96, 16);
            this.embedLabel.TabIndex = 13;
            this.embedLabel.Text = "Text to embed:";
            // 
            // textToEmbed
            // 
            this.textToEmbed.Location = new System.Drawing.Point(12, 132);
            this.textToEmbed.Name = "textToEmbed";
            this.textToEmbed.Size = new System.Drawing.Size(385, 88);
            this.textToEmbed.TabIndex = 15;
            this.textToEmbed.Text = "";
            // 
            // imageRouteLabel
            // 
            this.imageRouteLabel.AutoSize = true;
            this.imageRouteLabel.Location = new System.Drawing.Point(9, 24);
            this.imageRouteLabel.Name = "imageRouteLabel";
            this.imageRouteLabel.Size = new System.Drawing.Size(81, 16);
            this.imageRouteLabel.TabIndex = 16;
            this.imageRouteLabel.Text = "Image route:";
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(362, 348);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(75, 23);
            this.decodeButton.TabIndex = 17;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // StegoLabel
            // 
            this.StegoLabel.AutoSize = true;
            this.StegoLabel.Location = new System.Drawing.Point(15, 412);
            this.StegoLabel.Name = "StegoLabel";
            this.StegoLabel.Size = new System.Drawing.Size(79, 16);
            this.StegoLabel.TabIndex = 18;
            this.StegoLabel.Text = "Stego route:";
            // 
            // stegobox
            // 
            this.stegobox.Location = new System.Drawing.Point(12, 431);
            this.stegobox.Name = "stegobox";
            this.stegobox.Size = new System.Drawing.Size(263, 22);
            this.stegobox.TabIndex = 19;
            // 
            // openStegoBtn
            // 
            this.openStegoBtn.Location = new System.Drawing.Point(12, 459);
            this.openStegoBtn.Name = "openStegoBtn";
            this.openStegoBtn.Size = new System.Drawing.Size(75, 23);
            this.openStegoBtn.TabIndex = 20;
            this.openStegoBtn.Text = "Open";
            this.openStegoBtn.UseVisualStyleBackColor = true;
            this.openStegoBtn.Click += new System.EventHandler(this.openStegoBtn_Click);
            // 
            // saveStegoBtn
            // 
            this.saveStegoBtn.Location = new System.Drawing.Point(111, 459);
            this.saveStegoBtn.Name = "saveStegoBtn";
            this.saveStegoBtn.Size = new System.Drawing.Size(75, 23);
            this.saveStegoBtn.TabIndex = 21;
            this.saveStegoBtn.Text = "Save";
            this.saveStegoBtn.UseVisualStyleBackColor = true;
            this.saveStegoBtn.Click += new System.EventHandler(this.saveStegoBtn_Click);
            // 
            // Lsb1Button
            // 
            this.Lsb1Button.AutoSize = true;
            this.Lsb1Button.Location = new System.Drawing.Point(334, 244);
            this.Lsb1Button.Name = "Lsb1Button";
            this.Lsb1Button.Size = new System.Drawing.Size(63, 20);
            this.Lsb1Button.TabIndex = 24;
            this.Lsb1Button.TabStop = true;
            this.Lsb1Button.Text = "1 LSB";
            this.Lsb1Button.UseVisualStyleBackColor = true;
            // 
            // Lsb2Button
            // 
            this.Lsb2Button.AutoSize = true;
            this.Lsb2Button.Location = new System.Drawing.Point(334, 270);
            this.Lsb2Button.Name = "Lsb2Button";
            this.Lsb2Button.Size = new System.Drawing.Size(63, 20);
            this.Lsb2Button.TabIndex = 25;
            this.Lsb2Button.TabStop = true;
            this.Lsb2Button.Text = "2 LSB";
            this.Lsb2Button.UseVisualStyleBackColor = true;
            // 
            // Lsb4Button
            // 
            this.Lsb4Button.AutoSize = true;
            this.Lsb4Button.Location = new System.Drawing.Point(334, 322);
            this.Lsb4Button.Name = "Lsb4Button";
            this.Lsb4Button.Size = new System.Drawing.Size(63, 20);
            this.Lsb4Button.TabIndex = 26;
            this.Lsb4Button.TabStop = true;
            this.Lsb4Button.Text = "4 LSB";
            this.Lsb4Button.UseVisualStyleBackColor = true;
            // 
            // Lsb3Button
            // 
            this.Lsb3Button.AutoSize = true;
            this.Lsb3Button.Location = new System.Drawing.Point(334, 296);
            this.Lsb3Button.Name = "Lsb3Button";
            this.Lsb3Button.Size = new System.Drawing.Size(63, 20);
            this.Lsb3Button.TabIndex = 27;
            this.Lsb3Button.TabStop = true;
            this.Lsb3Button.Text = "3 LSB";
            this.Lsb3Button.UseVisualStyleBackColor = true;
            // 
            // decodedLabel
            // 
            this.decodedLabel.AutoSize = true;
            this.decodedLabel.Location = new System.Drawing.Point(15, 517);
            this.decodedLabel.Name = "decodedLabel";
            this.decodedLabel.Size = new System.Drawing.Size(90, 16);
            this.decodedLabel.TabIndex = 28;
            this.decodedLabel.Text = "Decoded text:";
            // 
            // decodedText
            // 
            this.decodedText.Location = new System.Drawing.Point(12, 545);
            this.decodedText.Name = "decodedText";
            this.decodedText.Size = new System.Drawing.Size(385, 88);
            this.decodedText.TabIndex = 29;
            this.decodedText.Text = "";
            this.decodedText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 244);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 20);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Symetric";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Encrypt key (8 characters)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(12, 314);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 33;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(111, 314);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 34;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 654);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.decodedText);
            this.Controls.Add(this.decodedLabel);
            this.Controls.Add(this.Lsb3Button);
            this.Controls.Add(this.Lsb4Button);
            this.Controls.Add(this.Lsb2Button);
            this.Controls.Add(this.Lsb1Button);
            this.Controls.Add(this.saveStegoBtn);
            this.Controls.Add(this.openStegoBtn);
            this.Controls.Add(this.stegobox);
            this.Controls.Add(this.StegoLabel);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.imageRouteLabel);
            this.Controls.Add(this.textToEmbed);
            this.Controls.Add(this.embedLabel);
            this.Controls.Add(this.embedButton);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.routeBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.labelImageAfter);
            this.Controls.Add(this.labelImageBefore);
            this.Controls.Add(this.pictureBoxStego);
            this.Controls.Add(this.pictureBoxBefore);
            this.Name = "Form1";
            this.Text = "V";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBefore;
        private System.Windows.Forms.PictureBox pictureBoxStego;
        private System.Windows.Forms.Label labelImageBefore;
        private System.Windows.Forms.Label labelImageAfter;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox routeBox;
        private System.Windows.Forms.ProgressBar pBar1;
        private System.Windows.Forms.Button embedButton;
        private System.Windows.Forms.Label embedLabel;
        private System.Windows.Forms.RichTextBox textToEmbed;
        private System.Windows.Forms.Label imageRouteLabel;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Label StegoLabel;
        private System.Windows.Forms.TextBox stegobox;
        private System.Windows.Forms.Button openStegoBtn;
        private System.Windows.Forms.Button saveStegoBtn;
        private System.Windows.Forms.RadioButton Lsb1Button;
        private System.Windows.Forms.RadioButton Lsb2Button;
        private System.Windows.Forms.RadioButton Lsb4Button;
        private System.Windows.Forms.RadioButton Lsb3Button;
        private System.Windows.Forms.Label decodedLabel;
        private System.Windows.Forms.RichTextBox decodedText;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
    }
}

