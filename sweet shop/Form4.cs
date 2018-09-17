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
    public partial class Form4 : Form
    {
        public Form4(string str)
        {
            InitializeComponent();
            this.label4.Text = str;
        }
        MySqlConnection con;
        string tab;
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trial1DataSet.customer' table. You can move, or remove it, as needed.
            con = new MySqlConnection("server = localhost; user id = root; password = mysqlserver; database = 'sweet_shop'");

            con.Open();
            // MessageBox.Show(con.State.ToString());
            create_table();
            MySqlCommand cmd = new MySqlCommand("select p_name from product" ,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
            dr.Close();
            label3.Text = "hello";
            
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void datafill()
        {
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = new MySqlCommand("select * from "+tab, con);
            DataTable table = new DataTable();
            adap.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }
        private void create_table()
        {
            MySqlCommand com = new MySqlCommand("select max(trans_id)+1 from payment",con);
            MySqlDataReader dr = com.ExecuteReader();
            dr.Read();
            tab = dr[0].ToString();
            if (tab == "")
                tab = "1";
            MessageBox.Show(tab);
            tab="t"+tab;
            dr.Close();
            com = new MySqlCommand("create table "+tab+"(pr_id int,p_name varchar(40),p_qty int,p_price float )",con);
            com.ExecuteNonQuery();
            label3.Text = tab;
        }
        
        private void add_Click(object sender, EventArgs e)
        {

            con.Open();
            
            MySqlCommand com = new MySqlCommand("insert into "+tab+"(pr_id,p_name,p_qty) values("+this.textBox1.Text+",'"+this.comboBox1.Text+"',"+this.textBox2.Text+")",con);
            com.ExecuteNonQuery();
            datafill();
            con.Close();
        }
    }
}
