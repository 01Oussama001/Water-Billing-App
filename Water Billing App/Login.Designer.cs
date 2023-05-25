namespace Water_Billing_App
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            PasswordTb = new TextBox();
            label9 = new Label();
            label8 = new Label();
            UsernameTb = new TextBox();
            LoginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 133);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(931, 16);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 88;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(362, 27);
            label1.Name = "label1";
            label1.Size = new Size(246, 24);
            label1.TabIndex = 90;
            label1.Text = "Water Distribution Agency";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 30;
            bunifuElipse1.TargetControl = this;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTb.Location = new Point(362, 495);
            PasswordTb.Margin = new Padding(3, 4, 3, 4);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(292, 32);
            PasswordTb.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(362, 465);
            label9.Name = "label9";
            label9.Size = new Size(104, 24);
            label9.TabIndex = 71;
            label9.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(362, 380);
            label8.Name = "label8";
            label8.Size = new Size(108, 24);
            label8.TabIndex = 70;
            label8.Text = "Username:";
            // 
            // UsernameTb
            // 
            UsernameTb.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameTb.Location = new Point(362, 409);
            UsernameTb.Margin = new Padding(3, 4, 3, 4);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(292, 32);
            UsernameTb.TabIndex = 69;
            // 
            // LoginBtn
            // 
            LoginBtn.ActiveBorderThickness = 1;
            LoginBtn.ActiveCornerRadius = 20;
            LoginBtn.ActiveFillColor = Color.SeaGreen;
            LoginBtn.ActiveForecolor = Color.White;
            LoginBtn.ActiveLineColor = Color.SeaGreen;
            LoginBtn.BackColor = Color.White;
            LoginBtn.BackgroundImage = (Image)resources.GetObject("LoginBtn.BackgroundImage");
            LoginBtn.ButtonText = "Login";
            LoginBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.SeaGreen;
            LoginBtn.IdleBorderThickness = 1;
            LoginBtn.IdleCornerRadius = 20;
            LoginBtn.IdleFillColor = Color.Blue;
            LoginBtn.IdleForecolor = Color.White;
            LoginBtn.IdleLineColor = Color.SeaGreen;
            LoginBtn.Location = new Point(464, 555);
            LoginBtn.Margin = new Padding(6, 7, 6, 7);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(110, 59);
            LoginBtn.TabIndex = 85;
            LoginBtn.TextAlign = ContentAlignment.MiddleCenter;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(489, 620);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 86;
            label2.Text = "Admin";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(423, 157);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 159);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 87;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(989, 816);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(UsernameTb);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label label1;
        private TextBox PasswordTb;
        private Label label9;
        private Label label8;
        private TextBox UsernameTb;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBtn;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
    }
}