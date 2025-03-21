﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography_Program
{
    internal class TextEmbedder
    {
        Operations ops = new Operations();
        Bitmap bmp;
        private ProgressBar pBar1;
        public TextEmbedder(ProgressBar pBar1)
        {
            this.pBar1 = pBar1;
            pBar1.Visible = false;
        }


        public Bitmap Embed1lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            //setLength MUST be after new bmp or it will be wiped.
            SetLength(inText_.Length);

            //EMBED LETTER 
            inText_.Insert(0, "0");

            //for each letter in the message.
            for (int i = 0; i < inText_.Length; i++)
            {
                //get the binary value of current letter in message
                string newBit = ops.convLetterToBits(inText_.Substring(i, 1));
                //append bitstream with new byte
                bitString = bitString + newBit;
            }

            //calculate how many pixels are needed for length of message
            int noOfPixels = (inText_.Length * 8) / 3;

            pBarSetup(noOfPixels);

            //for each pixel in image.
            for (int i = 0; i < noOfPixels; i++)
            {

                //increase progress bar
                pBar1.PerformStep();
                //retrieve pixel at index
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                int finalR = 0, finalG = 0, finalB = 0;
                //loop through R/G/B of pixel
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R 
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get first 7 digit of R
                                    string rFirstFour = rBitString.Substring(0, 7);
                                    //get first digit from bitStream
                                    string lFirstFour = bitString.Substring(0, 1);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge and convert to back to int
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 7 digit of G
                                    string gFirstFour = gBitString.Substring(0, 7);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 1);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 7 digit of B
                                    string bFirstFour = bBitString.Substring(0, 7);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 1);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(1, bitString.Length - 1);
                                    //merge 
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }


            }
            pBar1.Visible = false;
            return bmp;
        }

        public Bitmap Embed2lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            //setLength MUST be after new bmp or it will be wiped.
            SetLength(inText_.Length);

            //EMBED LETTER 
            inText_.Insert(0, "0");

            //for each letter in the message.
            for (int i = 0; i < inText_.Length; i++)
            {
                //get the binary value of current letter in message
                string newBit = ops.convLetterToBits(inText_.Substring(i, 1));
                //append bitstream with new byte
                bitString = bitString + newBit;
            }

            //calculate how many pixels are needed for length of message
            int noOfPixels = ((inText_.Length * 8) / 3) / 2;

            pBarSetup(noOfPixels);

            //for each pixel in image.
            for (int i = 0; i < noOfPixels; i++)
            {
                pBar1.PerformStep();
                //retrieve pixel at index
                Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                int finalR = 0, finalG = 0, finalB = 0;
                //loop through R/G/B of pixel
                for (int rgb = 0; rgb < 3; rgb++)
                {
                    if (!String.IsNullOrEmpty(bitString))
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R 
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get first 7 digit of R
                                    string rFirstFour = rBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lFirstFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(2, bitString.Length - 2);
                                    //merge and convert to back to int
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 7 digit of G
                                    string gFirstFour = gBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(2, bitString.Length - 2);
                                    //merge 
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                            //B
                            case 2:
                                {
                                    //get the binary values of B
                                    string bBitString = ops.convNumberToBits(pixelCol.B);
                                    //get first 7 digit of B
                                    string bFirstFour = bBitString.Substring(0, 6);
                                    //get first digit from bitStream
                                    string lLastFour = bitString.Substring(0, 2);
                                    //remove first digit bitstring
                                    bitString = bitString.Substring(2, bitString.Length - 2);
                                    //merge 
                                    int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                    finalB = ops.binaryToDecimal(newB);
                                    break;
                                }
                        }
                    }
                }
                bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, finalB));

                pixelIndex.X++;
                if (pixelIndex.X >= bmp.Width)
                {
                    pixelIndex.X = 1;
                    pixelIndex.Y++;
                }


            }
            pBar1.Visible = false;
            return bmp;
        }

        public Bitmap Embed3lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            string bitString = "";
            Point pixelIndex = new Point(1, 0);
            //setLength MUST be after new bmp or it will be wiped.
            SetLength(inText_.Length);

            //EMBED LETTER 

            //convert string to binary.
            for (int i = 0; i < inText_.Length; i++)
            {
                //get the binary value of current letter in message
                string newBit = ops.convLetterToBits(inText_.Substring(i, 1));
                //append bitstream with new byte
                bitString = bitString + newBit;
            }

            //calculate how many pixels are needed for length of message, each char has 8 bits, each pixel has 3 colours, each colour can fit 3 LSB
            int noOfPixels = ((inText_.Length * 8) / 3) / 3;
            //12/5/20
            //int noOfPixels = (inText_.Length * 16) / 3;

            pBarSetup(noOfPixels);
            //for each pixel in image.
            for (int i = 0; i < noOfPixels; i++)
            {
                pBar1.PerformStep();
                if (i < noOfPixels)
                {
                    //retrieve pixel at index
                    Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                    int finalR = 0, finalG = 0, finalB = 0;
                    //loop through R/G/B of pixel
                    for (int rgb = 0; rgb < 3; rgb++)
                    {
                        if (bitString.Length >= 3)
                        {
                            switch (rgb)
                            {
                                //R
                                case 0:
                                    {
                                        //get the binary values of R 
                                        string rBitString = ops.convNumberToBits(pixelCol.R);
                                        //get first 7 digit of R
                                        string rFirstFour = rBitString.Substring(0, 5);
                                        //get first digit from bitStream
                                        string lFirstFour = bitString.Substring(0, 3);
                                        //remove first digit bitstring
                                        bitString = bitString.Substring(3, bitString.Length - 3);
                                        //merge and convert to back to int
                                        int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                        finalR = ops.binaryToDecimal(newR);
                                        break;
                                    }
                                //G
                                case 1:
                                    {
                                        //get the binary values of G
                                        string gBitString = ops.convNumberToBits(pixelCol.G);
                                        //get first 7 digit of G
                                        string gFirstFour = gBitString.Substring(0, 5);
                                        //get first digit from bitStream
                                        string lLastFour = bitString.Substring(0, 3);
                                        //remove first digit bitstring
                                        bitString = bitString.Substring(3, bitString.Length - 3);
                                        //merge 
                                        int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                        finalG = ops.binaryToDecimal(newG);
                                        break;
                                    }
                                //B
                                case 2:
                                    {
                                        //get the binary values of B
                                        string bBitString = ops.convNumberToBits(pixelCol.B);
                                        //get first 7 digit of B
                                        string bFirstFour = bBitString.Substring(0, 5);
                                        //get first digit from bitStream
                                        string lLastFour = bitString.Substring(0, 3);
                                        //remove first digit bitstring
                                        bitString = bitString.Substring(3, bitString.Length - 3);
                                        //merge 
                                        int newB = Convert.ToInt32(bFirstFour + lLastFour);

                                        finalB = ops.binaryToDecimal(newB);
                                        break;
                                    }
                            }
                        }
                    }
                    if (bitString.Length >= 3)
                    {
                        bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, finalB));
                    }
                    pixelIndex.X++;
                    if (pixelIndex.X >= bmp.Width - 1)
                    {
                        pixelIndex.X = 1;
                        pixelIndex.Y++;
                    }

                }
            }
            pBar1.Visible = false;
            return bmp;
        }


        public Bitmap Embed4lsb(string inRoute_, string inText_)
        {
            bmp = new Bitmap(inRoute_);
            Point pixelIndex = new Point(1, 0);

            //setLength MUST be after new bmp or it will be wiped.
            SetLength(inText_.Length);

            //EMBED LETTER 
            int counter = 0;
            inText_.Insert(0, "0");

            pBarSetup(inText_.Length);
            //columns
            for (int i = 0; i < inText_.Length; i++)
            {
                if (counter < inText_.Length)
                {
                    //retrieve pixel at index
                    Color pixelCol = bmp.GetPixel(pixelIndex.X, pixelIndex.Y);

                    //get the binary value of current letter in message
                    string bitString = ops.convLetterToBits(inText_.Substring(counter, 1));
                    int finalR = 0, finalG = 0;
                    //loop through R/G/B
                    for (int rgb = 0; rgb < 2; rgb++)
                    {
                        switch (rgb)
                        {
                            //R
                            case 0:
                                {
                                    //get the binary values of R (notice the "2" param)
                                    string rBitString = ops.convNumberToBits(pixelCol.R);
                                    //get first 4 digit of R
                                    string rFirstFour = ops.getFromStart(rBitString, 4);
                                    //get first 4 digits of letter
                                    string lFirstFour = ops.getFromStart(bitString, 4);
                                    //merge and convert to back to int
                                    int newR = Convert.ToInt32(rFirstFour + lFirstFour);

                                    finalR = ops.binaryToDecimal(newR);
                                    break;
                                }
                            //G
                            case 1:
                                {
                                    //get the binary values of G
                                    string gBitString = ops.convNumberToBits(pixelCol.G);
                                    //get first 4 digit of G
                                    string gFirstFour = ops.getFromStart(gBitString, 4);
                                    //get last 4 digits of letter
                                    string lLastFour = ops.removeFromStart(bitString, 4);
                                    //merge 
                                    int newG = Convert.ToInt32(gFirstFour + lLastFour);

                                    finalG = ops.binaryToDecimal(newG);
                                    break;
                                }
                        }
                    }
                    //store new length value(s) in final pixel of image
                    bmp.SetPixel(pixelIndex.X, pixelIndex.Y, Color.FromArgb(finalR, finalG, pixelCol.B));

                    counter++;
                    pixelIndex.X++;
                    if (pixelIndex.X >= bmp.Width)
                    {
                        pixelIndex.X = 1;
                        pixelIndex.Y++;
                    }
                }
            }
            pBar1.Visible = false;
            return bmp;
        }
        private void SetLength(int inLength_)
        {
            //set length in the final pixel
            //get the binary value of the length
            string lengthBitString = ops.convNumberToBits(inLength_);
            int loopCount = 0;

            Color lengthPixelCol = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);

            while (lengthBitString.Length < 24)
            {
                lengthBitString = lengthBitString.Insert(0, "0");
            }
            string[] splitInto8s = ops.splitLengthInParts(lengthBitString).Split(' ');


            int lengthR = 0, lengthG = 0, lengthB = 0;

            for (int rgb = 0; rgb < 3; rgb++)
            {
                switch (rgb)
                {
                    //R
                    case 0:
                        {
                            lengthR = ops.binaryToDecimal(Int32.Parse(splitInto8s[1]));
                            break;
                        }
                    //G
                    case 1:
                        {
                            lengthG = ops.binaryToDecimal(Int32.Parse(splitInto8s[2]));
                            break;
                        }
                    case 2:
                        {
                            lengthB = ops.binaryToDecimal(Int32.Parse(splitInto8s[3]));
                            break;
                        }
                }
            }
            bmp.SetPixel(bmp.Width - 1, bmp.Height - 1, Color.FromArgb(lengthR, lengthG, lengthB));

            //end of setting length
        }

        private void pBarSetup(int max_)
        {
            // Display the ProgressBar control.
            pBar1.Visible = true;
            // Set Minimum to 1 to represent the first file being copied.
            pBar1.Minimum = 1;
            // Set Maximum to the total number of files to copy.
            pBar1.Maximum = max_ / 8;
            // Set the initial value of the ProgressBar.
            pBar1.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            pBar1.Step = 1;
        }

    }
}
