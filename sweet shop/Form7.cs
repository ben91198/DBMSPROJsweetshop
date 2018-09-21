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
    public partial class Form7 : Form
    {
        string tab,i;
        public Form7(string tb,string tot)
        {
            InitializeComponent();
            tab = tb;
            i = tot;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void datafill()
        {
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = new MySqlCommand("select * from " + tab, con);
            DataTable table = new DataTable();
            adap.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }
        MySqlConnection con;
        private void Form7_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;user id=root;password=mysqlserver;database='sweet_shop'");
            con.Open();
            datafill();
            con.Close();
            label3.Text = i;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            con.Open();
            MySqlCommand com = new MySqlCommand("drop table "+tab,con);
            com.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
