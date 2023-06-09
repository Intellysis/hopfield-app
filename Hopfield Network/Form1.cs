﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Hopfield_Network
{
    public partial class Form1 : Form
    {
        int[] pattern;
        int[] w1, w2, w3, w4, w5, w6, w7, w8, w9;

        Network h1;
        public Form1()
        {
            InitializeComponent();
            pattern = new int[]{ -1, -1, -1, -1, -1, -1, -1, -1, -1 };

            w1 = new int[] { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
            w2 = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
            w3 = new int[] { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
            w4 = new int[] { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
            w5 = new int[] { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
            w6 = new int[] { 2, 0, -2, 2, 2, 0, -2, 0, 2 };
            w7 = new int[] { 2, 0, 2, -2, -2, -2, 2, 0, 2 };
            w8 = new int[] { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
            w9 = new int[] { 2, 0, 2, -2, -2, -2, 2, 0, 0 };
            h1 = new Network(w1, w2, w3, w4, w5, w6, w7, w8, w9);
            ResetPictureBox();
        }

        public void ResetPictureBox()
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
            pictureBox7.BackColor = Color.White;
            pictureBox8.BackColor = Color.White;
            pictureBox9.BackColor = Color.White;

        }

        public void ResetButton()
        {
            var buttons = new List<Button> { button1, button10, button11, button18, button13, button12, button25, button20, button19 };

            for (int i = 0; i < 9; i++)
            {
                buttons[i].BackColor = SystemColors.ButtonFace;
                buttons[i].ForeColor = default;
                buttons[i].UseVisualStyleBackColor = true;

                pattern[i] = -1;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ResetPictureBox();
            h1.Activation(pattern);

            var pictureBox = new List<PictureBox>() 
            { 
                pictureBox1, 
                pictureBox2, 
                pictureBox3, 
                pictureBox4, 
                pictureBox5, 
                pictureBox6, 
                pictureBox7, 
                pictureBox8, 
                pictureBox9 
            };

            for (int i = 0; i < 9; i++)
            {
                if (h1.output[i] == pattern[i])
                {
                    if (h1.output[i] == 1)
                        pictureBox[i].BackColor = Color.Black;
                }
                else
                {
                    Debug.WriteLine("pattern= " + pattern[i] + " output = " + h1.output[i] + " discrepancy occured");
                }
            }

            ResetButton();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (pattern[0] == -1)
            {
                button1.BackColor = Color.Black;
                pattern[0] = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pattern[1] == -1)
            {
                button10.BackColor = Color.Black;
                pattern[1] = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pattern[2] == -1)
            {
                button11.BackColor = Color.Black;
                pattern[2] = 1;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (pattern[3] == -1)
            {
                button18.BackColor = Color.Black;
                pattern[3] = 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pattern[4] == -1)
            {
                button13.BackColor = Color.Black;
                pattern[4] = 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (pattern[5] == -1)
            {
                button12.BackColor = Color.Black;
                pattern[5] = 1;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (pattern[6] == -1)
            {
                button25.BackColor = Color.Black;
                pattern[6] = 1;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (pattern[7] == -1)
            {
                button20.BackColor = Color.Black;
                pattern[7] = 1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (pattern[8] == -1)
            {
                button19.BackColor = Color.Black;
                pattern[8] = 1;
            }
        }
    }
}
