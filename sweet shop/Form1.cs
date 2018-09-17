using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
        }

        private void staffin_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 obj = new Form6();
            obj.Show();
            
        }
    }
}
