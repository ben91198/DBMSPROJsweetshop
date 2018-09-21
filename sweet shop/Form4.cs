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
        public Form4()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        string tab;
        MySqlConnection write;
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trial1DataSet.customer' table. You can move, or remove it, as needed.
            con = new MySqlConnection("server = localhost; user id = root; password = mysqlserver; database = 'sweet_shop';");
            write = new MySqlConnection("server = localhost; user id = root; password = mysqlserver; database = 'sweet_shop';");
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
            //label3.Text = "hello";
            
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void datafill()                                                 //yashc
        {
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = new MySqlCommand("select * from "+tab, con);
            DataTable table = new DataTable();
            adap.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }
        string t_id;
        private void create_table()
        {

            MySqlCommand com = new MySqlCommand("call ret_id()",con);
            MySqlDataReader dr = com.ExecuteReader();
            dr.Read();
            t_id=tab = dr[0].ToString();
            //if (tab == "")
            //    tab = "1";
            //MessageBox.Show(tab);
            tab="t"+tab;
            dr.Close();
            com = new MySqlCommand("create table "+tab+"(p_id int,p_name varchar(40),p_qty float,p_price float )",con);
            com.ExecuteNonQuery();
            //label3.Text = tab;
        }

        
        private void add_Click(object sender, EventArgs e)
        {
            
            con.Open();
            MySqlCommand com = new MySqlCommand("select p_name from "+tab+" where p_name='"+this.comboBox1.Text+"'",con);
            MySqlDataReader de = com.ExecuteReader();
            if (!de.Read())
            {
                de.Close();
                MySqlCommand temp = new MySqlCommand("select p_id from product where p_name='" + this.comboBox1.Text + "'", con);
                
                de = temp.ExecuteReader();
                de.Read();

                var query = "insert into " + tab + "(p_id,p_name,p_qty,p_price) values("+de[0].ToString()+",'" + this.comboBox1.Text + "'," + this.textBox2.Text + "," + this.costlab.Text + ")";
                MessageBox.Show(query);
                de.Close();
                com = new MySqlCommand(query, con);
                com.ExecuteNonQuery();
                datafill();


                com = new MySqlCommand("select sum(p_price) from " + tab, con);
                MySqlDataReader dr = com.ExecuteReader();
                dr.Read();
                this.label6.Text = dr[0].ToString();
            }
            else
            {
                de.Close();
                DialogResult res = MessageBox.Show("Duplicate entry. Do you wish to overwrite?", "Confirm", MessageBoxButtons.YesNo);
                if(res==DialogResult.Yes)
                {
                    var query = "update " + tab + " set p_qty=" + this.textBox2.Text + ", p_price=" + this.costlab.Text + " where p_name='" + this.comboBox1.Text+"'";
                    MessageBox.Show(query);
                    com = new MySqlCommand(query, con);
                    com.ExecuteNonQuery();
                    datafill();
                    com = new MySqlCommand("select sum(p_price) from " + tab, con);
                    MySqlDataReader dr = com.ExecuteReader();
                    dr.Read();
                    this.label6.Text = dr[0].ToString();
                }
            }
            con.Close();
            this.comboBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void costlab_TextChanged(object sender, EventArgs e)
        {
            
        }
        string cst;
        private void calculate()
        {
            if (this.textBox2.Text == "")
            {
                this.label6.Text = "0";
                this.costlab.Text = "";
                return;
            }
            var cost = float.Parse(cst);
            var qty = float.Parse(this.textBox2.Text);
            var str1 = cost * qty;
            this.costlab.Text = str1.ToString();
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            var flag = true;
            
            if(textBox2.Text!="")
            {
                if(textBox2.Text==".")
                {
                    textBox2.Text = "0.";
                    textBox2.Focus();
                    textBox2.SelectionStart = textBox2.Text.Length;
                }
                if (comboBox1.Text != "")
                {
                    //MessageBox.Show(dr[0].ToString());
                    calculate();
                    flag = false;
                }
            }
            if(flag)
            {
                this.costlab.Text = "0";
            }
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                var str = "select p_price from product where p_name='" + this.comboBox1.Text + "'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                cst = dr[0].ToString();
                con.Close();
            }
        }
        string cid;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("Customer name or phone number not entered");
                return;
            }
            if(dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("Nothing been sold");
                return;
            }
            var val = new validate();
            if(!val.valname(this.textBox1.Text)||!val.mob_no(this.textBox3.Text))
            {
                MessageBox.Show("Invalid customer information");
                return;
            }
            //else if()
            {

            }
            con.Open();
            MySqlCommand com = new MySqlCommand("insert into customer(C_name,c_phno) values('"+this.textBox1.Text+"',"+this.textBox3.Text+")",con);
            com.ExecuteNonQuery();
            com = new MySqlCommand("select LAST_INSERT_ID()", con);
            MySqlDataReader dr = com.ExecuteReader();
            dr.Read();
            cid = dr[0].ToString();
            dr.Close();
            var func = "call process_trans(" + cid + "," + this.label6.Text + "," + t_id + ")";
            MessageBox.Show(func);
            com = new MySqlCommand(func,con);
            com.ExecuteNonQuery();
            
            con.Close();
            updat_tab();
            //com = new MySqlCommand("drop table "+tab,con);
            this.Visible = false;
            Form7 fobj = new Form7(tab,this.label6.Text);
            fobj.ShowDialog();
            this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void updat_tab()
        {
            if (con != null && con.State == ConnectionState.Closed)
                con.Open();
            MySqlCommand com = new MySqlCommand("select p_id,p_qty,p_price from " + tab, con);
            MySqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                var p_id = dr[0].ToString();
                var qty = dr[1].ToString();
                var price = dr[2].ToString();
                //dr.Close();
                var str = "insert into purchase(p_id,p_qty,amt,c_id) values(" + p_id + "," + qty + "," + price + "," + cid + ")";
                MessageBox.Show(str);
                write.Open();
                MySqlCommand temp1 = new MySqlCommand(str,write);
                temp1.ExecuteNonQuery();
                write.Close();
                
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var i = dataGridView1.SelectedCells[0].RowIndex;
            con.Open();
            MySqlCommand cmd;
            if (dataGridView1.Rows.Count > 1 && i != dataGridView1.Rows.Count-1)
            {
                cmd = new MySqlCommand("delete from "+tab+" where p_name='"+ dataGridView1.SelectedRows[i].Cells[1].Value.ToString()+"'", con);
                cmd.ExecuteNonQuery();
                datafill();

            }
            calculate();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
