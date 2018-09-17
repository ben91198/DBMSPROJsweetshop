using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace sweet_shop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4(this.textBox1.Text);
            obj.Show();
        }
        MySqlConnection con;
        private void updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "update customer set C_name='" + this.textBox2.Text + "',c_phno='" + this.textBox3.Text + "' where C_id=" + this.textBox1.Text;
            //MessageBox.Show(str);
            
            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.ExecuteNonQuery();
            if(this.textBox4.Text!="")
            {
                str = "update customer set c_addr='" + this.textBox4.Text + "' where C_id=" + this.textBox1.Text;
                cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("updated");
            con.Close();
        }
        private void autocomplete()
        {
            //con.Open();
            string[] str = new string[] {"select C_id from customer", "select c_name from customer", "select c_phno from customer" };
            //for(var i=0;i<2;i++)
            {
                ext atcmp = new ext();
                this.textBox1.AutoCompleteCustomSource = atcmp.addcollection(str[0],ref con);
                this.textBox2.AutoCompleteCustomSource = atcmp.addcollection(str[1],ref con);
                this.textBox3.AutoCompleteCustomSource = atcmp.addcollection(str[2], ref con);
            }
            //con.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;user id=root;password=mysqlserver;database='sweet_shop'");
            autocomplete();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            var temp = " ";
            if (this.textBox1.Text == "")
                this.textBox1.Text = temp.ToString();
            string str = "delete from customer  where C_id=" + this.textBox1.Text+" or (C_name='" + this.textBox2.Text + "'and c_phno='" + this.textBox3.Text + "')" ;
            //MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");
            con.Close();
        }
    }
}
