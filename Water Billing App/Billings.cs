using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Billing_App
{
    public partial class Billings : Form
    {
        public Billings()
        {
            InitializeComponent();
            showBills();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oussa\OneDrive\Documents\WaterBillingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void showBills()
        {
            con.Open();
            string Query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillingsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void getCons()
        {
            con.Open();
            string Query = "select * from ConsTbl where ConsNum = '" + ConsTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillingsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            BPeriod.Text = "";
            ConsTb.Text = "";
            RateTb.Text = "";
            TaxTb.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
