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
    public partial class frmUndressPeanut : Form
    {
        public static frmUndressPeanut instance;
        public frmUndressPeanut()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUndressPeanut_Load(object sender, EventArgs e)
        {

        }
    }
}
