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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (con != null && con.State == ConnectionState.Closed)
                    con.Open();
                string str = "insert into product(p_name,p_qty,p_price) values('" + this.textBox2.Text + "'," + this.textBox3.Text + ",'" + this.textBox4.Text + "')";
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

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            var temp = " ";
            if (this.textBox2.Text == "")
                this.textBox2.Text = temp.ToString();
            string str = "delete from product  where p_id=" + this.textBox1.Text + " or (p_name='" + this.textBox2.Text + "')";
            //MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            con.Close();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "update product set p_qty='" + this.textBox3.Text + "',p_price='" + this.textBox4.Text + "' where p_id=" + this.textBox1.Text;
            //MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            con.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;user id=root;password=mysqlserver;database='sweet_shop'");
        }
    }
}
