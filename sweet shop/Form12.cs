using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sweet_shop
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con != null && con.State == ConnectionState.Closed)
                    con.Open();
                string str = "insert into product(p_name,p_qty,p_price) values('" + this.textBox1.Text + "'," + this.textBox3.Text + ",'" + this.textBox2.Text + "')";
                //MessageBox.Show(str);
                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted information");
                con.Close();
            }
            catch (MySqlException exep)
            {
                var mess = "enter valid information ";
                MessageBox.Show(mess);
            }
        }
        MySqlConnection con;
        private void Form12_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server = localhost; user id = root; password = mysqlserver; database = 'sweet_shop';");
        }
    }
}
