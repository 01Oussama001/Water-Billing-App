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
    public partial class Consumers : Form
    {
        public Consumers()
        {
            InitializeComponent();
            showConsumers();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oussa\OneDrive\Documents\WaterBillingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void showConsumers()
        {
            con.Open();
            string Query = "select CID as CID, CName as Name, CPhone as Phone, CAddress as Address, CCategory as Category, CJDate as Date, CRate as Rate from ConsumerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ConsumersDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            CNameTbl.Text = "";
            CPhoneTbl.Text = "";
            CAddTbl.Text = "";
            CCatCb.Text = "";
            CJDate.Text = "";
            CRate.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (CNameTbl.Text == "" || CPhoneTbl.Text == "" || CAddTbl.Text == "" || CCatCb.Text == "" || CJDate.Text == "" || CRate.Text == "")
            {
                MessageBox.Show("Missing Informations!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ConsumerTbl(CName, CPhone, CAddress, CCategory, CJDate, CRate) values(@CN, @CP, @CA, @CC, @CJ, @CR)", con);
                    cmd.Parameters.AddWithValue("@CN", CNameTbl.Text);
                    cmd.Parameters.AddWithValue("@CP", CPhoneTbl.Text);
                    cmd.Parameters.AddWithValue("@CA", CAddTbl.Text);
                    cmd.Parameters.AddWithValue("@CC", CCatCb.Text);
                    cmd.Parameters.AddWithValue("@CJ", CJDate.Text);
                    cmd.Parameters.AddWithValue("@CR", CRate.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consumer Saved Successfully!");
                    con.Close();
                    showConsumers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Consumers_Load(object sender, EventArgs e)
        {

        }

    }
}
