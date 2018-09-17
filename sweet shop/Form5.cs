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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        private void Form5_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;user id=root;password=mysqlserver;database='sweet_shop'");
        }



        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (con != null && con.State == ConnectionState.Closed)
                    con.Open();
                string str = "insert into staff(s_name,s_sal,password) values('" + this.textBox1.Text + "'," + this.textBox2.Text + ",'" + this.textBox3.Text + "')";
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            var temp = 0;
            if (this.textBox1.Text == "")
                this.textBox1.Text = temp.ToString();
            string str = "delete from staff  where s_id=" + this.id.Text + " or (s_name='" + this.textBox1.Text + "'and password='" + this.textBox3.Text + "')";
            //MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            con.Close();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "update staff set s_name='" + this.textBox1.Text + "',s_sal='" + this.textBox2.Text + "' where s_id=" + this.id.Text;
            //MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            con.Close();
        }
    }
}
