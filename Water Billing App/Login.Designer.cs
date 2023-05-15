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
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 100);
            panel1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 30;
            bunifuElipse1.TargetControl = this;
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
            // textBox4
            // 
            textBox4.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(317, 371);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 27);
            textBox4.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(317, 349);
            label9.Name = "label9";
            label9.Size = new Size(85, 19);
            label9.TabIndex = 71;
            label9.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(317, 285);
            label8.Name = "label8";
            label8.Size = new Size(88, 19);
            label8.TabIndex = 70;
            label8.Text = "Username:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(317, 307);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 27);
            textBox3.TabIndex = 69;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.SeaGreen;
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.SeaGreen;
            bunifuThinButton21.BackColor = Color.White;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Login";
            bunifuThinButton21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.Blue;
            bunifuThinButton21.IdleForecolor = Color.White;
            bunifuThinButton21.IdleLineColor = Color.SeaGreen;
            bunifuThinButton21.Location = new Point(406, 416);
            bunifuThinButton21.Margin = new Padding(5);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(96, 44);
            bunifuThinButton21.TabIndex = 85;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(428, 465);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 86;
            label2.Text = "Admin";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(370, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 87;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 612);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(bunifuThinButton21);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Label label1;
        private TextBox textBox4;
        private Label label9;
        private Label label8;
        private TextBox textBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Label label2;
        private PictureBox pictureBox3;
    }
}