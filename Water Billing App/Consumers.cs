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
            CCatCb.SelectedIndex = -1;
            CJDate.Value = DateTime.Now;
            CRateTbl.Text = "";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (CNameTbl.Text == "" || CPhoneTbl.Text == "" || CAddTbl.Text == "" || CCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Informations!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ConsumerTbl(CName, CPhone, CAddress, CCategory, CJDate, CRate) values(@CN, @CP, @CA, @CC, @CJD, @CR)", con);
                    cmd.Parameters.AddWithValue("@CN", CNameTbl.Text);
                    cmd.Parameters.AddWithValue("@CP", CPhoneTbl.Text);
                    cmd.Parameters.AddWithValue("@CA", CAddTbl.Text);
                    cmd.Parameters.AddWithValue("@CC", CCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CJD", CJDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CR", CRateTbl.Text);
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

        private void getRate()
        {
            if (CCatCb.SelectedIndex == 0)
            {
                CRateTbl.Text = "70";
            }
            else if (CCatCb.SelectedIndex == 1)
            {
                CRateTbl.Text = "95";
            }
            else
            {
                CRateTbl.Text = "120";
            }
        }

        private void CCatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getRate();
        }

        int key = 0;
        private void ConsumersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTbl.Text = ConsumersDGV.SelectedRows[0].Cells[1].Value.ToString();
            CPhoneTbl.Text = ConsumersDGV.SelectedRows[0].Cells[2].Value.ToString();
            CAddTbl.Text = ConsumersDGV.SelectedRows[0].Cells[3].Value.ToString();
            CCatCb.SelectedItem = ConsumersDGV.SelectedRows[0].Cells[4].Value.ToString();
            CJDate.Value = (DateTime)ConsumersDGV.SelectedRows[0].Cells[5].Value;
            CRateTbl.Text = ConsumersDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (CNameTbl.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ConsumersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CNameTbl.Text == "" || CPhoneTbl.Text == "" || CAddTbl.Text == "" || CCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Informations!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update ConsumerTbl set CName=@CN, CPhone=@CP, CAddress=@CA, CCategory=@CC, CJDate=@CJD, CRate=@CR where CID=@CID", con);
                    cmd.Parameters.AddWithValue("@CID", key);
                    cmd.Parameters.AddWithValue("@CN", CNameTbl.Text);
                    cmd.Parameters.AddWithValue("@CP", CPhoneTbl.Text);
                    cmd.Parameters.AddWithValue("@CA", CAddTbl.Text);
                    cmd.Parameters.AddWithValue("@CC", CCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CJD", CJDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CR", CRateTbl.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consumer Updated Successfully!");
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Consumer to Delete!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ConsumerTbl where CID=@CID", con);
                    cmd.Parameters.AddWithValue("@CID", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Consumer Deleted Successfully!");
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

        private void label2_Click(object sender, EventArgs e)
        {
            Consumers cons = new Consumers();
            cons.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Agents age = new Agents();
            age.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Billings bil = new Billings();
            bil.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
