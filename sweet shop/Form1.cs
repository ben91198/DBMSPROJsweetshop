﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace sweet_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void billingbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 obj = new Form4();
            obj.ShowDialog();
            this.Visible = true;
            
        }
    }
}
