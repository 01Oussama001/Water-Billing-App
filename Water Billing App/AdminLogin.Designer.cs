namespace Water_Billing_App
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            pictureBox3 = new PictureBox();
            label2 = new Label();
            LoginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            PasswordTb = new TextBox();
            label9 = new Label();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 100);
            panel1.TabIndex = 88;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.back;
            pictureBox5.Location = new Point(812, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 88;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(317, 20);
            label1.Name = "label1";
            label1.Size = new Size(198, 19);
            label1.TabIndex = 90;
            label1.Text = "Water Distribution Agency";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 30;
            bunifuElipse1.TargetControl = this;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(370, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 95;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(428, 441);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 94;
            label2.Text = "Back";
            label2.Click += label2_Click;
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
            LoginBtn.Location = new Point(406, 392);
            LoginBtn.Margin = new Padding(5);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(96, 44);
            LoginBtn.TabIndex = 93;
            LoginBtn.TextAlign = ContentAlignment.MiddleCenter;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTb.Location = new Point(317, 347);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(256, 27);
            PasswordTb.TabIndex = 92;
            PasswordTb.TextChanged += PasswordTb_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(317, 325);
            label9.Name = "label9";
            label9.Size = new Size(85, 19);
            label9.TabIndex = 91;
            label9.Text = "Password:";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(5F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(867, 573);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(label9);
            Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox5;
        private Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox pictureBox3;
        private Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBtn;
        private TextBox PasswordTb;
        private Label label9;
    }
}