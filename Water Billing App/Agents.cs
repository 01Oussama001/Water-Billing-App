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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AgNameTb.Text == "" || AgAddTb.Text == "" || AgPhoneTb.Text == "" || AgPassTb.Text == "") {
                MessageBox.Show("Missing Informations!!!");
            }else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new("insert into AgentTbl values('" + AgNameTb.Text + "','" + AgAddTb.Text + "','" + AgPhoneTb.Text + "','" + AgPassTb.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Saved Successfully");
                    con.Close();
                    AgNameTb.Text = "";
                    AgAddTb.Text = "";
                    AgPhoneTb.Text = "";
                    AgPassTb.Text = "";
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
