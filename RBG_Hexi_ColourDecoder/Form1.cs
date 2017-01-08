using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBG_Hexi_ColourDecoder
{
    public partial class Form1 : Form
    {
        //Variables
        private int cRed;
        private int cGreen;
        private int cBlue;
        private int cAlpha;
        private Boolean grey;
        private string check;
        
        public Form1()
        {
            InitializeComponent();
            cRed = 0;
            cGreen = 0;
            cBlue = 0;
            cAlpha = 255;
            grey = false;
            check = "RGBA";
            updateALL();


        }//end Constructor

        private void colourRed_Scroll(object sender, EventArgs e)
        {
            cRed = (int)colourRed.Value;
            if (grey == true)
            {
                updateALL(cRed);
                colourBlue.Value = cRed;
                colourGreen.Value = cRed;
            }
            else {
                updateALL();
            }
        }//end colourRed_Scroll

        private void colourGreen_Scroll(object sender, EventArgs e)
        {
            cGreen = (int)colourGreen.Value;
            if (grey == true)
            {
                colourRed.Value = cGreen;
                updateALL(cGreen);
                colourBlue.Value = cGreen;
            }
            else {
                updateALL();
            }
        }//end colourGreen_Scroll

        private void colourBlue_Scroll(object sender, EventArgs e)
        {
            cBlue = (int)colourBlue.Value;
            if (grey == true)
            {
                colourRed.Value = cBlue;
                colourGreen.Value = cBlue;
                updateALL(cBlue);
            }
            else {
                updateALL();
            }

        }//end colourBlue_Scroll

        private void colourAlpha_Scroll(object sender, EventArgs e)
        {
            cAlpha = (int)colourAlpha.Value;
            updateALL();
        }//end colourAlpha_Scroll

        private void updateALL()
        {
            updateText();
            previewBtn.BackColor = Color.FromArgb(cAlpha, cRed, cGreen, cBlue);
        }//end updateALL

        private void updateALL(int value)
        {
            cRed = value;
            cGreen = value;
            cBlue = value;
            updateText();
            previewBtn.BackColor = Color.FromArgb(cAlpha, cRed, cGreen, cBlue);
        }//end updateALL

        private void updateText()
        {
            switch (check)
            {
                case "ARGB":
                    outputTxt.Text = "Colour ARGB";
                    displayTxt.Text = cAlpha + ", " + cRed + ", " + cGreen + ", " + cBlue;
                    break;
                case "RGBA":
                    outputTxt.Text = "Colour RGBA";
                    displayTxt.Text = cRed + ", " + cGreen + ", " + cBlue + ", " + cAlpha;
                    break;
                case "RGB":
                    outputTxt.Text = "Colour RGB";
                    displayTxt.Text = cRed + ", " + cGreen + ", " + cBlue;
                    break;
                case "Hexidecimal":
                    outputTxt.Text = "Colour Hexidecimal";
                    Color myColor = Color.FromArgb(cAlpha, cRed, cGreen, cBlue);
                    string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                    displayTxt.Text = hex;
                    break;
            }
        }

        private void greyScale_CheckedChanged(object sender, EventArgs e)
        {
            grey = true;
        }//end greyScale_CheckedChanged

        private void colour_CheckedChanged(object sender, EventArgs e)
        {
            grey = false;
        }//end colour_CheckChanged

        private void rgba_CheckedChanged(object sender, EventArgs e)
        {
            check = "RGBA";
            updateText();
        }

        private void argb_CheckedChanged(object sender, EventArgs e)
        {
            check = "ARGB";
            updateText();
        }

        private void rgb_CheckedChanged(object sender, EventArgs e)
        {
            check = "RGB";
            updateText();
        }

        private void hex_CheckedChanged(object sender, EventArgs e)
        {
            check = "Hexidecimal";
            updateText();
        }
        
    }//end Form1
}
