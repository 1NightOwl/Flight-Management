namespace FlightManagement.PL.User.FluturimetPerdorues
{
    partial class UcFlightCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuy = new Button();
            pnlBuy = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlInformation = new Panel();
            lblStops = new Label();
            cbClass = new ComboBox();
            lblTotalPrice = new Label();
            lblPrice = new Label();
            lblTimes = new Label();
            lblDate = new Label();
            lblRoute = new Label();
            pnlBuy.SuspendLayout();
            pnlInformation.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(52, 196, 174);
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(59, 52);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(132, 46);
            btnBuy.TabIndex = 5;
            btnBuy.Text = "Bli";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // pnlBuy
            // 
            pnlBuy.BackColor = Color.FromArgb(228, 250, 244);
            pnlBuy.Controls.Add(label3);
            pnlBuy.Controls.Add(label4);
            pnlBuy.Controls.Add(label2);
            pnlBuy.Controls.Add(label1);
            pnlBuy.Controls.Add(btnBuy);
            pnlBuy.Dock = DockStyle.Left;
            pnlBuy.Location = new Point(0, 0);
            pnlBuy.Name = "pnlBuy";
            pnlBuy.Size = new Size(250, 151);
            pnlBuy.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(235, 111);
            label3.Name = "label3";
            label3.Size = new Size(26, 38);
            label3.TabIndex = 9;
            label3.Text = "I";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.Location = new Point(235, 75);
            label4.Name = "label4";
            label4.Size = new Size(26, 38);
            label4.TabIndex = 8;
            label4.Text = "I";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(235, 35);
            label2.Name = "label2";
            label2.Size = new Size(26, 38);
            label2.TabIndex = 7;
            label2.Text = "I";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(235, -1);
            label1.Name = "label1";
            label1.Size = new Size(26, 38);
            label1.TabIndex = 6;
            label1.Text = "I";
            // 
            // pnlInformation
            // 
            pnlInformation.BackColor = Color.FromArgb(247, 251, 250);
            pnlInformation.BackgroundImageLayout = ImageLayout.Stretch;
            pnlInformation.Controls.Add(lblStops);
            pnlInformation.Controls.Add(cbClass);
            pnlInformation.Controls.Add(lblTotalPrice);
            pnlInformation.Controls.Add(lblPrice);
            pnlInformation.Controls.Add(lblTimes);
            pnlInformation.Controls.Add(lblDate);
            pnlInformation.Controls.Add(lblRoute);
            pnlInformation.Dock = DockStyle.Fill;
            pnlInformation.Location = new Point(250, 0);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(940, 151);
            pnlInformation.TabIndex = 7;
            // 
            // lblStops
            // 
            lblStops.AutoSize = true;
            lblStops.BackColor = Color.Transparent;
            lblStops.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStops.ForeColor = Color.FromArgb(16, 94, 85);
            lblStops.Location = new Point(180, 52);
            lblStops.Name = "lblStops";
            lblStops.Size = new Size(49, 20);
            lblStops.TabIndex = 12;
            lblStops.Text = "Stops";
            // 
            // cbClass
            // 
            cbClass.BackColor = Color.FromArgb(52, 196, 174);
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.FlatStyle = FlatStyle.Flat;
            cbClass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbClass.ForeColor = Color.FromArgb(16, 94, 85);
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(503, 89);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(151, 30);
            cbClass.TabIndex = 11;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Times New Roman", 13.8F);
            lblTotalPrice.ForeColor = Color.FromArgb(16, 94, 85);
            lblTotalPrice.Location = new Point(371, 61);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(111, 26);
            lblTotalPrice.TabIndex = 10;
            lblTotalPrice.Text = "Total Price";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Times New Roman", 13.8F);
            lblPrice.ForeColor = Color.FromArgb(16, 94, 85);
            lblPrice.Location = new Point(377, 87);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(51, 26);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "€ 39";
            // 
            // lblTimes
            // 
            lblTimes.AutoSize = true;
            lblTimes.BackColor = Color.Transparent;
            lblTimes.Font = new Font("Times New Roman", 13.8F);
            lblTimes.ForeColor = Color.FromArgb(16, 94, 85);
            lblTimes.Location = new Point(225, 89);
            lblTimes.Name = "lblTimes";
            lblTimes.Size = new Size(142, 26);
            lblTimes.TabIndex = 7;
            lblTimes.Text = "08:20 – 10:05 ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Times New Roman", 13.8F);
            lblDate.ForeColor = Color.FromArgb(16, 94, 85);
            lblDate.Location = new Point(41, 89);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(178, 26);
            lblDate.TabIndex = 6;
            lblDate.Text = "Tue, 27 May 2025";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.BackColor = Color.Transparent;
            lblRoute.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoute.ForeColor = Color.FromArgb(16, 94, 85);
            lblRoute.Location = new Point(27, 14);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(222, 45);
            lblRoute.TabIndex = 5;
            lblRoute.Text = "TIA → VIE";
            // 
            // UcFlightCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInformation);
            Controls.Add(pnlBuy);
            DoubleBuffered = true;
            Name = "UcFlightCard";
            Size = new Size(1190, 151);
            Load += UcFlightCard_Load;
            pnlBuy.ResumeLayout(false);
            pnlBuy.PerformLayout();
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBuy;
        private Panel pnlBuy;
        private Panel pnlInformation;
        private Label lblTotalPrice;
        private Label lblPrice;
        private Label lblTimes;
        private Label lblDate;
        private Label lblRoute;
        private ComboBox cbClass;
        private Label lblStops;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
