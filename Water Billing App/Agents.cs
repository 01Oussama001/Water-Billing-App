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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oussa\OneDrive\Documents\WaterBillingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void showAgents()
        {
            con.Open();
            string Query = "select * from AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            /*sda.Fill(ds);*/
            AgentsDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AgNameTb.Text == "" || AgAddTb.Text == "" || AgPhoneTb.Text == "" || AgPassTb.Text == "")
            {
                MessageBox.Show("Missing Informations!!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTbl(AgName, AgPhone, AgAdd, AgPass) values(@AN, @AP, @AA, @APa)", con);
                    cmd.Parameters.AddWithValue("@AN", AgNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AgPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AgAddTb.Text);
                    cmd.Parameters.AddWithValue("@APa", AgPassTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Saved Successfully!");
                    con.Close();
                    AgNameTb.Text = "";
                    AgAddTb.Text = "";
                    AgPhoneTb.Text = "";
                    AgPassTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
