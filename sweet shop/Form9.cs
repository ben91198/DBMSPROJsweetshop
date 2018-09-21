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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void datafill()
        {
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = new MySqlCommand("select p_name,p_price from product", con);
            DataTable table = new DataTable();
            adap.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MySqlConnection con;
        private void Form9_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server = localhost; user id = root; password = mysqlserver; database = 'sweet_shop';");
            con.Open();
            // MessageBox.Show(con.State.ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand com = new MySqlCommand("update product set p_price="+textBox1.Text+" where p_name='"+this.comboBox1.Text+"'",con);
            com.ExecuteNonQuery();
            MessageBox.Show("price updated");
            datafill();
            for(int i=0;i<dataGridView1.RowCount-1;i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString()==this.comboBox1.Text)
                {
                    dataGridView1.Rows[i].Selected = true;
                }
                else
                    dataGridView1.CurrentRow.Selected = false;
            }
            con.Close();
        }
    }
}
