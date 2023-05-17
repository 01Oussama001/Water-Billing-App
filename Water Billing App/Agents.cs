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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            showAgents();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oussa\OneDrive\Documents\WaterBillingDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void showAgents()
        {
            con.Open();
            string Query = "select AgNum as ID, AgName as Name, AgPhone as Phone, AgAdd as Address, AgPass as Password from AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
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
                    showAgents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void AgentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgNameTb.Text = AgentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            AgPhoneTb.Text = AgentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AgAddTb.Text = AgentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgPassTb.Text = AgentsDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (AgNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AgentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("update AgentTbl set AgName=@AN, AgPhone=@AP, AgAdd=@AA, AgPass=@APa where AgNum=@AKey", con);
                    cmd.Parameters.AddWithValue("@AN", AgNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AgPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AgAddTb.Text);
                    cmd.Parameters.AddWithValue("@APa", AgPassTb.Text);
                    cmd.Parameters.AddWithValue("@AKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Edited Successfully!");
                    con.Close();
                    showAgents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Reset()
        {
            AgNameTb.Text = "";
            AgAddTb.Text = "";
            AgPhoneTb.Text = "";
            AgPassTb.Text = "";
            key = 0;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Agent to Delete!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AgentTbl where AgNum=@AKey", con);
                    cmd.Parameters.AddWithValue("@AKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Deleted Successfully!");
                    con.Close();
                    showAgents();
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

        private void label4_Click(object sender, EventArgs e)
        {
            Billings bill = new Billings();
            bill.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Agents ag = new Agents();
            ag.Show();
            this.Hide();
        }
    }
}
