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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountAgents();
            CountConsumers();
            CountBills();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oussa\OneDrive\Documents\WaterBillingDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void CountAgents()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AgentTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AgNumlbl.Text = dt.Rows[0][0].ToString() + " Agents";
            con.Close();
        }

        private void CountConsumers()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ConsumerTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ConsLbl.Text = dt.Rows[0][0].ToString() + " Consumers";
            con.Close();
        }

        private void CountBills()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(Total) from BillTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BillLbl.Text = dt.Rows[0][0].ToString() + " DHs"; 
            con.Close();
        }

        private void ConsLbl_Click(object sender, EventArgs e)
        {

        }

        private void BillMonthLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
