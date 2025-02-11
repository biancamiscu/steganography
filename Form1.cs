using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Steganography_Program
{
    public partial class Form1 : Form
    {
        TextEmbedder embedder;
        TextExtractor retriever;
        int maxInputLength;
        double time = 0;
        Stopwatch sw;
        Cryptog cry = new Cryptog();

        public Form1()
        {
            InitializeComponent();
            embedder = new TextEmbedder(pBar1);
            retriever = new TextExtractor(pBar1);
        }


        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)

                {
                    routeBox.Text = open.FileName.ToString();
                    pictureBoxBefore.ImageLocation = open.FileName;
                    //get max potential length
                    Bitmap bmp = new Bitmap(routeBox.Text);
                    int length = (bmp.Width * bmp.Height); //-1 for the final pixel which stores the length.

                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void embedButton_Click(object sender, EventArgs e)
        {
            sw = Stopwatch.StartNew();
            //Error handling
            if (routeBox.Text == "")
            {
                MessageBox.Show("ERROR: no input image selected, see 'Image route' section.");
            }
            else if (textToEmbed.Text == "")
            {
                MessageBox.Show("ERROR: no input text available, see 'Text to embed' box.");
            }
            else if (!Lsb1Button.Checked && !Lsb2Button.Checked && !Lsb3Button.Checked && !Lsb4Button.Checked)
            {
                MessageBox.Show("ERROR: no byte-density selected, please select one of the available options (i.e: '1LSB').");
            }

            //sw and different LSBs.
            else if (Lsb1Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed1lsb(routeBox.Text, textToEmbed.Text);
            }
            else if (Lsb2Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed2lsb(routeBox.Text, textToEmbed.Text);
            }
            else if (Lsb3Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed3lsb(routeBox.Text, textToEmbed.Text);
            }
            else if (Lsb4Button.Checked)
            {
                pictureBoxStego.Image = embedder.Embed4lsb(routeBox.Text, textToEmbed.Text);
            }
            long timed = sw.ElapsedMilliseconds;
            MessageBox.Show("Elapsed time in milliseconds: " + timed);
            this.sw.Stop();
            saveStegoBtn.Enabled = true;
        
    }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stegobox.Text))
            {
                if (Lsb1Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve1lsb(stegobox.Text);
                }
                else if (Lsb2Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve2lsb(stegobox.Text);
                }
                else if (Lsb3Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve3lsb(stegobox.Text);
                }
                else if (Lsb4Button.Checked)
                {
                    decodedText.Text = retriever.Retrieve4lsb(stegobox.Text);
                }

            }
            else
            {
                MessageBox.Show("No path specified, please assign a path using the textbox or 'open...' button");
            }
        }

        private void saveStegoBtn_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBoxStego.Image);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                stegobox.Text = saveFile.FileName.ToString();
                pictureBoxStego.ImageLocation = stegobox.Text;
                bmp.Save(stegobox.Text);
                bmp.Dispose();
            }
        }

        private void openStegoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                open.InitialDirectory = @"C:\Users\User\Desktop\UNI\1920\productionProject\outputFiles";
                if (open.ShowDialog() == DialogResult.OK)

                {
                    stegobox.Text = open.FileName.ToString();
                    pictureBoxStego.ImageLocation = open.FileName;
                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 8)
            {
                encryptBtn.Enabled = true;
                decryptBtn.Enabled = true;
            }
            else
            {
                encryptBtn.Enabled = false;
                decryptBtn.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //allow encryption button.
            if (textBox1.TextLength >= 8 && textToEmbed.TextLength > 0)
            {
                encryptBtn.Enabled = true;
            }
            else
            {
                encryptBtn.Enabled = false;
            }

            //allow decryption button.
            if (textBox1.TextLength >= 8 && decodedText.TextLength > 0)
            {
                decryptBtn.Enabled = true;
            }
            else
            {
                decryptBtn.Enabled = false;
            }
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textToEmbed.Text = cry.Crypt(textToEmbed.Text, textBox1.Text);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
                decodedText.Text = cry.Decrypt(decodedText.Text, textBox1.Text);
            
        }
    }
}