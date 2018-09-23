using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace sweet_shop
{
    public partial class Form14 : Form
    {
        string table,total,tid;
        public Form14(string tab,string sum,string t_id)
        {
            InitializeComponent();
            table = tab;
            total = sum;
            tid = t_id;

        }
        string conStr = "server=localhost;user id = root; password=mysqlserver;database='sweet_shop'";
        private void Form14_Load(object sender, EventArgs e)
        {
            MySqlConnection cnn;
            //string connectionString = null;
            string sql = null;

            cnn = new MySqlConnection(conStr);
            cnn.Open();
            sql = "select p_name, p_qty,p_price from "+table;
            MySqlDataAdapter dscmd = new MySqlDataAdapter(sql, cnn);
            cnn.Close();
            DataSet1 ds = new DataSet1();
            dscmd.Fill(ds, "DataTable1");
            CrystalReport1 objRpt = new CrystalReport1();
            objRpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = objRpt;
            objRpt.DataDefinition.FormulaFields["UnboundString1"].Text = total;
            objRpt.DataDefinition.FormulaFields["UnboundString2"].Text = tid;
            crystalReportViewer1.Refresh();
        }
    }
}
