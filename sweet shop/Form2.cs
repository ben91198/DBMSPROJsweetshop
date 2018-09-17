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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(con!=null && con.State==ConnectionState.Closed)
                    con.Open();
                string str = "insert into customer(C_name,c_phno,c_addr) values('" + this.textBox1.Text + "'," + this.textBox2.Text + ",'" + this.textBox3.Text + "')";
                //MessageBox.Show(str);
                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted information");
                con.Close();
                Form4 obj = new Form4(this.textBox1.Text);
                obj.Show();
            }
            catch(MySqlException exep)
            {
                var mess = "enter valid information ";
                MessageBox.Show(mess);
            }
            
        }
        MySqlConnection con;
        private void Form2_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;user id=root;password=mysqlserver;database='sweet_shop'");
        }
    }
}
