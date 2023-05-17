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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oussa\OneDrive\Documents\WaterBillingDB.mdf;Integrated Security=True;Connect Timeout=30");
        public static string User;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AgentTbl WHERE AgName='" + UsernameTb.Text + "' and AgPass='" + PasswordTb.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                User = UsernameTb.Text;
                this.Hide();
                Home home = new Home();
                home.Show();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
            con.Close();
        }
    }
}
