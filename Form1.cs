﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recip6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                  MessageBox.Show("Kullanıcı adını giriniz.", "Uyarı");
            }
            if(string.IsNullOrEmpty(textBox2.Text))
            {
                  MessageBox.Show("Şifreyi giriniz.", "Uyarı");
            } 
        }
    }
}
