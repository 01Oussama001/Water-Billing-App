using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;

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

        private void BPeriod_ValueChanged(object sender, EventArgs e)
        {
            string BPer = BPeriod.Value.Month + " / " + BPeriod.Value.Year;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(Total) from BillTbl where BPeriod='" + BPer + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BillMonthLbl.Text = dt.Rows[0][0].ToString() + " DHs";
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Billings obj = new Billings();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Consumers obj = new Consumers();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
