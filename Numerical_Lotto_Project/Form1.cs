﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_Lotto_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int n1, n2, n3, n4;
            n1 = random.Next(1, 5);
            n2 = random.Next(1, 5);
            n3 = random.Next(1, 5);
            n4 = random.Next(1, 5);

            label1.Text = n1.ToString();
            label2.Text = n2.ToString();
            label3.Text = n3.ToString();
            label4.Text = n4.ToString();

            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }
    }
}
