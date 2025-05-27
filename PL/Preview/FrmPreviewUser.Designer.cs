namespace FlightManagement.PL.Preview
{
    partial class FrmPreviewUser
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
            pictureBox1 = new PictureBox();
            pnlDetails = new Panel();
            btnLogOut = new Button();
            panel3 = new Panel();
            lblEmail = new Label();
            lblUsername = new Label();
            panel2 = new Panel();
            pnlDashboard = new Panel();
            btnAccount = new Button();
            btnMyTrips = new Button();
            btnFlights = new Button();
            pnlLogo = new Panel();
            pnlControls = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDetails.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(55, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 168);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(btnLogOut);
            pnlDetails.Controls.Add(panel3);
            pnlDetails.Controls.Add(lblEmail);
            pnlDetails.Controls.Add(lblUsername);
            pnlDetails.Dock = DockStyle.Bottom;
            pnlDetails.Location = new Point(0, 748);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(268, 105);
            pnlDetails.TabIndex = 16;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Teal;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.ControlText;
            btnLogOut.Location = new Point(158, 11);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(104, 29);
            btnLogOut.TabIndex = 13;
            btnLogOut.Text = "🚪Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 2);
            panel3.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 12F);
            lblEmail.Location = new Point(26, 62);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(137, 22);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "test@gmail.com";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 12F);
            lblUsername.Location = new Point(26, 24);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(88, 22);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(0, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 2);
            panel2.TabIndex = 11;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.FromArgb(118, 166, 169);
            pnlDashboard.Controls.Add(pnlDetails);
            pnlDashboard.Controls.Add(btnAccount);
            pnlDashboard.Controls.Add(btnMyTrips);
            pnlDashboard.Controls.Add(btnFlights);
            pnlDashboard.Controls.Add(pnlLogo);
            pnlDashboard.Dock = DockStyle.Left;
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(268, 853);
            pnlDashboard.TabIndex = 2;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Teal;
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatStyle = FlatStyle.Popup;
            btnAccount.Location = new Point(0, 308);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(268, 60);
            btnAccount.TabIndex = 14;
            btnAccount.Text = "⚙  Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnMyTrips
            // 
            btnMyTrips.BackColor = Color.Teal;
            btnMyTrips.Dock = DockStyle.Top;
            btnMyTrips.FlatStyle = FlatStyle.Popup;
            btnMyTrips.Location = new Point(0, 248);
            btnMyTrips.Name = "btnMyTrips";
            btnMyTrips.Size = new Size(268, 60);
            btnMyTrips.TabIndex = 12;
            btnMyTrips.Text = "🎟  My Trips";
            btnMyTrips.UseVisualStyleBackColor = false;
            btnMyTrips.Click += btnMyTrips_Click;
            // 
            // btnFlights
            // 
            btnFlights.BackColor = Color.Teal;
            btnFlights.Dock = DockStyle.Top;
            btnFlights.FlatStyle = FlatStyle.Popup;
            btnFlights.Location = new Point(0, 188);
            btnFlights.Name = "btnFlights";
            btnFlights.Size = new Size(268, 60);
            btnFlights.TabIndex = 10;
            btnFlights.Text = "✈  Flights";
            btnFlights.UseVisualStyleBackColor = false;
            btnFlights.Click += btnFlights_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(118, 166, 169);
            pnlLogo.Controls.Add(panel2);
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(268, 188);
            pnlLogo.TabIndex = 0;
            // 
            // pnlControls
            // 
            pnlControls.BackColor = Color.FromArgb(202, 209, 193);
            pnlControls.BorderStyle = BorderStyle.FixedSingle;
            pnlControls.Location = new Point(268, 0);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(1214, 853);
            pnlControls.TabIndex = 3;
            // 
            // FrmPreviewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlControls);
            DoubleBuffered = true;
            Name = "FrmPreviewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPreviewUser";
            Load += FrmPreviewUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel pnlDetails;
        private Button btnLogOut;
        private Panel panel3;
        private Label lblEmail;
        private Label lblUsername;
        private Panel panel2;
        private Panel pnlDashboard;
        private Panel pnlLogo;
        private Panel pnlControls;
        private Button btnAccount;
        private Button btnMyTrips;
        private Button btnFlights;
    }
}