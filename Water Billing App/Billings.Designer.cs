namespace Water_Billing_App
{
    partial class Billings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billings));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            RateTb = new TextBox();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            label9 = new Label();
            label8 = new Label();
            ConsTb = new TextBox();
            label6 = new Label();
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            CIdCb = new ComboBox();
            BPeriod = new DateTimePicker();
            bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(components);
            TaxTb = new TextBox();
            label10 = new Label();
            TotalTb = new TextBox();
            label11 = new Label();
            BillingsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillingsDGV).BeginInit();
            SuspendLayout();
            // 
            // RateTb
            // 
            RateTb.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RateTb.Location = new Point(69, 360);
            RateTb.Name = "RateTb";
            RateTb.Size = new Size(194, 27);
            RateTb.TabIndex = 88;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 30;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 5;
            bunifuElipse2.TargetControl = this;
            // 
            // DeleteBtn
            // 
            DeleteBtn.ActiveBorderThickness = 1;
            DeleteBtn.ActiveCornerRadius = 20;
            DeleteBtn.ActiveFillColor = Color.SeaGreen;
            DeleteBtn.ActiveForecolor = Color.White;
            DeleteBtn.ActiveLineColor = Color.SeaGreen;
            DeleteBtn.BackColor = Color.White;
            DeleteBtn.BackgroundImage = (Image)resources.GetObject("DeleteBtn.BackgroundImage");
            DeleteBtn.ButtonText = "Delete";
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.SeaGreen;
            DeleteBtn.IdleBorderThickness = 1;
            DeleteBtn.IdleCornerRadius = 20;
            DeleteBtn.IdleFillColor = Color.Blue;
            DeleteBtn.IdleForecolor = Color.White;
            DeleteBtn.IdleLineColor = Color.SeaGreen;
            DeleteBtn.Location = new Point(108, 595);
            DeleteBtn.Margin = new Padding(5);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(96, 44);
            DeleteBtn.TabIndex = 86;
            DeleteBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditBtn
            // 
            EditBtn.ActiveBorderThickness = 1;
            EditBtn.ActiveCornerRadius = 20;
            EditBtn.ActiveFillColor = Color.SeaGreen;
            EditBtn.ActiveForecolor = Color.White;
            EditBtn.ActiveLineColor = Color.SeaGreen;
            EditBtn.BackColor = Color.White;
            EditBtn.BackgroundImage = (Image)resources.GetObject("EditBtn.BackgroundImage");
            EditBtn.ButtonText = "Edit";
            EditBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.SeaGreen;
            EditBtn.IdleBorderThickness = 1;
            EditBtn.IdleCornerRadius = 20;
            EditBtn.IdleFillColor = Color.Blue;
            EditBtn.IdleForecolor = Color.White;
            EditBtn.IdleLineColor = Color.SeaGreen;
            EditBtn.Location = new Point(167, 541);
            EditBtn.Margin = new Padding(5);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(96, 44);
            EditBtn.TabIndex = 85;
            EditBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(69, 338);
            label9.Name = "label9";
            label9.Size = new Size(46, 19);
            label9.TabIndex = 83;
            label9.Text = "Rate:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(69, 274);
            label8.Name = "label8";
            label8.Size = new Size(151, 19);
            label8.TabIndex = 82;
            label8.Text = "Consumption in m3:";
            // 
            // ConsTb
            // 
            ConsTb.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConsTb.Location = new Point(69, 296);
            ConsTb.Name = "ConsTb";
            ConsTb.Size = new Size(194, 27);
            ConsTb.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(69, 215);
            label6.Name = "label6";
            label6.Size = new Size(88, 19);
            label6.TabIndex = 80;
            label6.Text = "Bill Period:";
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 5;
            bunifuElipse3.TargetControl = this;
            // 
            // SaveBtn
            // 
            SaveBtn.ActiveBorderThickness = 1;
            SaveBtn.ActiveCornerRadius = 20;
            SaveBtn.ActiveFillColor = Color.SeaGreen;
            SaveBtn.ActiveForecolor = Color.White;
            SaveBtn.ActiveLineColor = Color.SeaGreen;
            SaveBtn.BackColor = Color.White;
            SaveBtn.BackgroundImage = (Image)resources.GetObject("SaveBtn.BackgroundImage");
            SaveBtn.ButtonText = "Save";
            SaveBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.SeaGreen;
            SaveBtn.IdleBorderThickness = 1;
            SaveBtn.IdleCornerRadius = 20;
            SaveBtn.IdleFillColor = Color.Blue;
            SaveBtn.IdleForecolor = Color.White;
            SaveBtn.IdleLineColor = Color.SeaGreen;
            SaveBtn.Location = new Point(61, 541);
            SaveBtn.Margin = new Padding(5);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(96, 44);
            SaveBtn.TabIndex = 84;
            SaveBtn.TextAlign = ContentAlignment.MiddleCenter;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 25;
            bunifuElipse4.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(69, 153);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 78;
            label1.Text = "Consumer Id:";
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(1128, 661);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 76;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1111, 652);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 75;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(90, 30);
            label7.Name = "label7";
            label7.Size = new Size(44, 19);
            label7.TabIndex = 74;
            label7.Text = "WDC";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1015, 30);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 72;
            label5.Text = "DashBoard";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(939, 30);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 71;
            label4.Text = "Billing";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(851, 30);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 70;
            label3.Text = "Agents";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(748, 30);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 69;
            label2.Text = "Consumer";
            // 
            // CIdCb
            // 
            CIdCb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CIdCb.FormattingEnabled = true;
            CIdCb.Location = new Point(69, 175);
            CIdCb.Name = "CIdCb";
            CIdCb.Size = new Size(194, 23);
            CIdCb.TabIndex = 89;
            // 
            // BPeriod
            // 
            BPeriod.AccessibleRole = AccessibleRole.None;
            BPeriod.Location = new Point(69, 236);
            BPeriod.Margin = new Padding(3, 2, 3, 2);
            BPeriod.Name = "BPeriod";
            BPeriod.Size = new Size(194, 23);
            BPeriod.TabIndex = 90;
            // 
            // bunifuElipse5
            // 
            bunifuElipse5.ElipseRadius = 25;
            bunifuElipse5.TargetControl = this;
            // 
            // TaxTb
            // 
            TaxTb.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TaxTb.Location = new Point(69, 420);
            TaxTb.Name = "TaxTb";
            TaxTb.Size = new Size(194, 27);
            TaxTb.TabIndex = 92;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(69, 398);
            label10.Name = "label10";
            label10.Size = new Size(37, 19);
            label10.TabIndex = 91;
            label10.Text = "Tax:";
            // 
            // TotalTb
            // 
            TotalTb.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TotalTb.Location = new Point(69, 480);
            TotalTb.Name = "TotalTb";
            TotalTb.Size = new Size(194, 27);
            TotalTb.TabIndex = 94;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(69, 458);
            label11.Name = "label11";
            label11.Size = new Size(48, 19);
            label11.TabIndex = 93;
            label11.Text = "Total:";
            // 
            // BillingsDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            BillingsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BillingsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BillingsDGV.ColumnHeadersHeight = 28;
            BillingsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            BillingsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            BillingsDGV.GridColor = Color.FromArgb(231, 229, 255);
            BillingsDGV.Location = new Point(337, 92);
            BillingsDGV.Name = "BillingsDGV";
            BillingsDGV.RowHeadersVisible = false;
            BillingsDGV.RowTemplate.Height = 24;
            BillingsDGV.Size = new Size(841, 547);
            BillingsDGV.TabIndex = 95;
            BillingsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            BillingsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            BillingsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            BillingsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            BillingsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            BillingsDGV.ThemeStyle.BackColor = Color.White;
            BillingsDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            BillingsDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            BillingsDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BillingsDGV.ThemeStyle.HeaderStyle.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BillingsDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BillingsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BillingsDGV.ThemeStyle.HeaderStyle.Height = 28;
            BillingsDGV.ThemeStyle.ReadOnly = false;
            BillingsDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            BillingsDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BillingsDGV.ThemeStyle.RowsStyle.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BillingsDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            BillingsDGV.ThemeStyle.RowsStyle.Height = 24;
            BillingsDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Blue;
            BillingsDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // Billings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1194, 663);
            Controls.Add(BillingsDGV);
            Controls.Add(TotalTb);
            Controls.Add(label11);
            Controls.Add(TaxTb);
            Controls.Add(label10);
            Controls.Add(BPeriod);
            Controls.Add(CIdCb);
            Controls.Add(RateTb);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(ConsTb);
            Controls.Add(label6);
            Controls.Add(SaveBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billings";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillingsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RateTb;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Label label9;
        private Label label8;
        private TextBox ConsTb;
        private Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private ComboBox CIdCb;
        private DateTimePicker BPeriod;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private TextBox TaxTb;
        private Label label10;
        private TextBox TotalTb;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView BillingsDGV;
    }
}