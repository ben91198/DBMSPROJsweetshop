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
    public partial class dailysales : Form
    {
        public dailysales()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        MySqlConnection con;
        string thisDate,Nextdate;
        private void datafill()                                                 //yashc
        {
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = new MySqlCommand("select payment.c_id, payment.trans_id, t_date, t_time, amt, p_qty  from payment left outer join purchase on payment.trans_id = purchase.trans_id where t_date >='"+thisDate+"' and t_date<='"+Nextdate+"'", con);
            DataTable table = new DataTable();
            adap.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }
        /*private void join()
        {
            con.Open();
            MySqlCommand com = new MySqlCommand("select payment.c_id, payment.trans_id, t_date, t_time, amt, p_qty  from payment left outer join purchase on payment.trans_id = purchase.trans_id where t_date = '2018-09-21'", con);
            com.ExecuteNonQuery();
            con.Close();
        }*/
        private void cal()
        {
            con.Open();
            MySqlCommand com = new MySqlCommand(" select sum(amt) from (select payment.c_id,payment.trans_id,t_date,t_time,amt,p_qty  from payment left outer join purchase on  payment.trans_id=purchase.trans_id where t_date >='" + thisDate + "' and t_date<='" + Nextdate + "') as t",con);

            using (MySqlDataReader dr = com.ExecuteReader())
            {
                dr.Read();
                label1.Text = dr[0].ToString();
            }
            con.Close();
        }
        private void dailysales_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Format= dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat=dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            con = new MySqlConnection("server = localhost; user id = root; password = mysqlserver; database = 'sweet_shop';");
            con.Open();
            thisDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Nextdate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            datafill();
            con.Close();
            cal();
        }

        private void dailysales_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            con.Open();
            thisDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            datafill();
            con.Close();
            cal();
        }
    }
}
