﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndressPeanutApp
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
