using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using QRCoder;

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void BillingsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.BillingsDGV.Rows[e.RowIndex];

                // Populate the form fields with the selected row data
                CIdCb.SelectedValue = row.Cells["CId"].Value.ToString();
                getConsRate();
                ConsTb.Text = row.Cells["Consumption"].Value.ToString();
                RateTb.Text = row.Cells["Rate"].Value.ToString();
                TaxTb.Text = row.Cells["Tax"].Value.ToString();

                // Disable the Save button and enable the Edit button
                // SaveBtn.Enabled = false;
                EditBtn.Enabled = true;
                DeleteBtn.Enabled = true;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("update BillTbl set CId = @CId, Agent = @Ag, BPeriod = @BP, Consumption = @BC, Rate = @BR, Tax = @BTa, Total = @BTo where BNum = @BId", con);
                    cmd.Parameters.AddWithValue("@BId", BillingsDGV.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@CId", CIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Ag", AgentLbl.Text);
                    cmd.Parameters.AddWithValue("@BP", Period);
                    cmd.Parameters.AddWithValue("@BC", ConsTb.Text);
                    cmd.Parameters.AddWithValue("@BR", RateTb.Text);
                    cmd.Parameters.AddWithValue("@BTa", TaxTb.Text);
                    cmd.Parameters.AddWithValue("@BTo", Total);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Updated Successfully");
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (BillingsDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM BillTbl WHERE BNum = @BId", con);
                        cmd.Parameters.AddWithValue("@BId", BillingsDGV.SelectedRows[0].Cells["BNum"].Value.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill Deleted Successfully");
                        con.Close();
                        showBills();
                        Reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a bill to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            int startX = 10;
            int startY = 10;
            int lineHeight = (int)font.GetHeight();

            // Retrieve the selected bill details
            string billNumber = BillingsDGV.SelectedRows[0].Cells["BNum"].Value.ToString();
            string customerId = CIdCb.SelectedValue.ToString();
            string agent = AgentLbl.Text;
            string period = BPeriod.Value.Month + " / " + BPeriod.Value.Year;
            string consumption = ConsTb.Text;
            string rate = RateTb.Text;
            string tax = TaxTb.Text;
            double total = Convert.ToDouble(rate) * Convert.ToDouble(consumption);

            // Load images
            Image logoImage = Image.FromFile("C:\\Users\\oussa\\source\\repos\\Water Billing App\\Water Billing App\\images\\logo.jpg");
            Image watermarkImage = Image.FromFile("C:\\Users\\oussa\\source\\repos\\Water Billing App\\Water Billing App\\images\\watermark.jpg");

            // Set the position and size of the images
            Rectangle logoRect = new Rectangle(startX, startY, 100, 100);
            Rectangle watermarkRect = new Rectangle(e.PageBounds.Width - 150, e.PageBounds.Height - 150, 100, 100);

            // Draw the logo image
            graphics.DrawImage(logoImage, logoRect);

            // Draw the watermark image
            graphics.DrawImage(watermarkImage, watermarkRect);

            // Generate the bill content
            StringBuilder billContent = new StringBuilder();
            billContent.AppendLine("Bill Number: " + billNumber);
            billContent.AppendLine("Customer ID: " + customerId);
            billContent.AppendLine("Agent: " + agent);
            billContent.AppendLine("Period: " + period);
            billContent.AppendLine("Consumption: " + consumption + "m3");
            billContent.AppendLine("Rate: " + rate);
            billContent.AppendLine("Tax: " + tax + "%");
            billContent.AppendLine("Total: " + total + "DHs");

            // Draw the bill content
            graphics.DrawString(billContent.ToString(), font, brush, startX + 10, startY + 150);

            // Draw a line separator
            int lineSeparatorY = startY + 120 + lineHeight * 9;
            graphics.DrawLine(new Pen(brush), startX, lineSeparatorY, e.PageBounds.Width - startX, lineSeparatorY);

            // Draw additional text or images as needed

            // Example: Draw a message
            string message = "Thank you for your payment!";
            SizeF messageSize = graphics.MeasureString(message, font);
            int messageX = startX;
            int messageY = lineSeparatorY + lineHeight;
            graphics.DrawString(message, font, brush, messageX, messageY);

            // Example: Draw a QR code
            string qrCodeContent = "https://example.com";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrCodeContent, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5);
            Rectangle qrCodeRect = new Rectangle(startX, messageY + (int)messageSize.Height, 200, 200);
            graphics.DrawImage(qrCodeImage, qrCodeRect);
        }
    }
}
