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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        MySqlConnection con;
        private void Form15_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server = localhost; user id = root; password = mysqlserver; database = 'sweet_shop';");
            //write = new MySqlConnection("server = localhost; user id = root; password = mysqlserver; database = 'sweet_shop';");
            con.Open();
            // MessageBox.Show(con.State.ToString());
            //create_table();
            MySqlCommand cmd = new MySqlCommand("select p_name from product", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
            dr.Close();
            //label3.Text = "hello";
            datafill();
            con.Close();
        }
        private void datafill()                                                 //yashc
        {
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = new MySqlCommand("select * from product", con);
            DataTable table = new DataTable();
            adap.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand com = new MySqlCommand("delete from product where p_name='"+this.comboBox1.Text+"'",con);
            com.ExecuteNonQuery();
            datafill();

            con.Close();
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void Form15_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
