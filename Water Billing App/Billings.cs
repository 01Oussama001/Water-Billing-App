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
            getCons();
            AgentLbl.Text = Login.User;
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
            string Query = "select CId from ConsumerTbl";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CId", typeof(int));
            dt.Load(rdr);
            CIdCb.ValueMember = "CId";
            CIdCb.DataSource = dt;
            con.Close();
        }

        private void getConsRate()
        {
            con.Open();
            string Query = "select * from ConsumerTbl where CId = " + CIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                RateTb.Text = dr["CRate"].ToString();
            }
            con.Close();
        }

        private void Reset()
        {
            CIdCb.SelectedIndex = -1;
            ConsTb.Text = "";
            RateTb.Text = "";
            TaxTb.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ConsTb.Text == "" || RateTb.Text == "" || TaxTb.Text == "")
            {
                MessageBox.Show("Missing Informations!!!");
            }
            else
            {
                try
                {
                    int R = Convert.ToInt32(RateTb.Text);
                    int Consumption = Convert.ToInt32(ConsTb.Text);
                    double Tax = (R * Consumption) * (Convert.ToDouble(TaxTb.Text) / 100);
                    double Total = (R * Consumption) + Tax;
                    string Period = BPeriod.Value.Month + " / " + BPeriod.Value.Year;

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BillTbl(CId, Agent, BPeriod, Consumption, Rate, Tax, Total) values(@CId, @Ag, @BP, @BC, @BR, @BTa, @BTo)", con);
                    cmd.Parameters.AddWithValue("@CId", CIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Ag", AgentLbl.Text);
                    cmd.Parameters.AddWithValue("@BP", Period);
                    cmd.Parameters.AddWithValue("@BC", ConsTb.Text);
                    cmd.Parameters.AddWithValue("@BR", RateTb.Text);
                    cmd.Parameters.AddWithValue("@BTa", TaxTb.Text);
                    cmd.Parameters.AddWithValue("@BTo", Total);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    con.Close();
                    showBills();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getConsRate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Consumers cons = new Consumers();
            cons.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Agents ag = new Agents();
            ag.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Billings bill = new Billings();
            bill.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
