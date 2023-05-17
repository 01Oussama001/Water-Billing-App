namespace Water_Billing_App
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Consumers cons = new Consumers();
            cons.Show();
            this.Hide();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Agents agent = new Agents();
            agent.Show();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}