namespace FlightManagement.PL.Preview
{
    partial class FrmPreviewAdmin
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
            pnlDashboard = new Panel();
            pnlDetails = new Panel();
            btnLogOut = new Button();
            panel3 = new Panel();
            lblEmail = new Label();
            lblUsername = new Label();
            pnlUser = new Panel();
            btnPresentUsers = new Button();
            btnUsers = new Button();
            pnlTicket = new Panel();
            btnTicketNr = new Button();
            btnPendingTicket = new Button();
            btnTicket = new Button();
            pnlFlights = new Panel();
            btnActiveFlights = new Button();
            btnAssignRoute = new Button();
            btnRegisterPlane = new Button();
            btnFlights = new Button();
            pnlLogo = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pnlControls = new Panel();
            pnlDashboard.SuspendLayout();
            pnlDetails.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlTicket.SuspendLayout();
            pnlFlights.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.FromArgb(118, 166, 169);
            pnlDashboard.Controls.Add(pnlDetails);
            pnlDashboard.Controls.Add(pnlUser);
            pnlDashboard.Controls.Add(btnUsers);
            pnlDashboard.Controls.Add(pnlTicket);
            pnlDashboard.Controls.Add(btnTicket);
            pnlDashboard.Controls.Add(pnlFlights);
            pnlDashboard.Controls.Add(btnFlights);
            pnlDashboard.Controls.Add(pnlLogo);
            pnlDashboard.Dock = DockStyle.Left;
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(268, 853);
            pnlDashboard.TabIndex = 0;
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
            // pnlUser
            // 
            pnlUser.BackColor = Color.FromArgb(231, 216, 182);
            pnlUser.Controls.Add(btnPresentUsers);
            pnlUser.Dock = DockStyle.Top;
            pnlUser.Location = new Point(0, 368);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(268, 0);
            pnlUser.TabIndex = 15;
            // 
            // btnPresentUsers
            // 
            btnPresentUsers.BackColor = Color.FromArgb(186, 188, 165);
            btnPresentUsers.Dock = DockStyle.Top;
            btnPresentUsers.FlatStyle = FlatStyle.Flat;
            btnPresentUsers.Location = new Point(0, 0);
            btnPresentUsers.Name = "btnPresentUsers";
            btnPresentUsers.Size = new Size(268, 46);
            btnPresentUsers.TabIndex = 3;
            btnPresentUsers.Text = "Perdoruesit aktual";
            btnPresentUsers.UseVisualStyleBackColor = false;
            btnPresentUsers.Click += btnPresentUsers_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Teal;
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatStyle = FlatStyle.Popup;
            btnUsers.Location = new Point(0, 308);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(268, 60);
            btnUsers.TabIndex = 14;
            btnUsers.Text = "👥Perdoruesit";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // pnlTicket
            // 
            pnlTicket.BackColor = Color.FromArgb(231, 216, 182);
            pnlTicket.Controls.Add(btnTicketNr);
            pnlTicket.Controls.Add(btnPendingTicket);
            pnlTicket.Dock = DockStyle.Top;
            pnlTicket.Location = new Point(0, 308);
            pnlTicket.Name = "pnlTicket";
            pnlTicket.Size = new Size(268, 0);
            pnlTicket.TabIndex = 13;
            // 
            // btnTicketNr
            // 
            btnTicketNr.BackColor = Color.FromArgb(186, 188, 165);
            btnTicketNr.Dock = DockStyle.Top;
            btnTicketNr.FlatStyle = FlatStyle.Flat;
            btnTicketNr.Location = new Point(0, 46);
            btnTicketNr.Name = "btnTicketNr";
            btnTicketNr.Size = new Size(268, 46);
            btnTicketNr.TabIndex = 3;
            btnTicketNr.Text = "Nr i biletave ";
            btnTicketNr.UseVisualStyleBackColor = false;
            // 
            // btnPendingTicket
            // 
            btnPendingTicket.BackColor = Color.FromArgb(186, 188, 165);
            btnPendingTicket.Dock = DockStyle.Top;
            btnPendingTicket.FlatStyle = FlatStyle.Flat;
            btnPendingTicket.Location = new Point(0, 0);
            btnPendingTicket.Name = "btnPendingTicket";
            btnPendingTicket.Size = new Size(268, 46);
            btnPendingTicket.TabIndex = 2;
            btnPendingTicket.Text = "Biletat ne pritje";
            btnPendingTicket.UseVisualStyleBackColor = false;
            btnPendingTicket.Click += btnPendingTicket_Click;
            // 
            // btnTicket
            // 
            btnTicket.BackColor = Color.Teal;
            btnTicket.Dock = DockStyle.Top;
            btnTicket.FlatStyle = FlatStyle.Popup;
            btnTicket.Location = new Point(0, 248);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(268, 60);
            btnTicket.TabIndex = 12;
            btnTicket.Text = "🎟️Biletat";
            btnTicket.UseVisualStyleBackColor = false;
            btnTicket.Click += btnTicket_Click;
            // 
            // pnlFlights
            // 
            pnlFlights.BackColor = Color.FromArgb(231, 216, 182);
            pnlFlights.Controls.Add(btnActiveFlights);
            pnlFlights.Controls.Add(btnAssignRoute);
            pnlFlights.Controls.Add(btnRegisterPlane);
            pnlFlights.Dock = DockStyle.Top;
            pnlFlights.Location = new Point(0, 248);
            pnlFlights.Name = "pnlFlights";
            pnlFlights.Size = new Size(268, 0);
            pnlFlights.TabIndex = 11;
            // 
            // btnActiveFlights
            // 
            btnActiveFlights.BackColor = Color.FromArgb(186, 188, 165);
            btnActiveFlights.Dock = DockStyle.Top;
            btnActiveFlights.FlatStyle = FlatStyle.Flat;
            btnActiveFlights.Location = new Point(0, 92);
            btnActiveFlights.Name = "btnActiveFlights";
            btnActiveFlights.Size = new Size(268, 46);
            btnActiveFlights.TabIndex = 2;
            btnActiveFlights.Text = "⏱️✈️Fluturimet Aktive";
            btnActiveFlights.UseVisualStyleBackColor = false;
            btnActiveFlights.Click += btnActiveFlights_Click;
            // 
            // btnAssignRoute
            // 
            btnAssignRoute.BackColor = Color.FromArgb(186, 188, 165);
            btnAssignRoute.Dock = DockStyle.Top;
            btnAssignRoute.FlatStyle = FlatStyle.Flat;
            btnAssignRoute.Location = new Point(0, 46);
            btnAssignRoute.Name = "btnAssignRoute";
            btnAssignRoute.Size = new Size(268, 46);
            btnAssignRoute.TabIndex = 1;
            btnAssignRoute.Text = "🗺️Cakto Itinerar";
            btnAssignRoute.UseVisualStyleBackColor = false;
            btnAssignRoute.Click += btnAssignRoute_Click;
            // 
            // btnRegisterPlane
            // 
            btnRegisterPlane.BackColor = Color.FromArgb(186, 188, 165);
            btnRegisterPlane.Dock = DockStyle.Top;
            btnRegisterPlane.FlatStyle = FlatStyle.Flat;
            btnRegisterPlane.Location = new Point(0, 0);
            btnRegisterPlane.Name = "btnRegisterPlane";
            btnRegisterPlane.Size = new Size(268, 46);
            btnRegisterPlane.TabIndex = 0;
            btnRegisterPlane.Text = "➕✈️Regjistro Aeroplan";
            btnRegisterPlane.UseVisualStyleBackColor = false;
            btnRegisterPlane.Click += btnAddFlight_Click;
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
            btnFlights.Text = "✈️Fluturimet";
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
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(0, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 2);
            panel2.TabIndex = 11;
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
            // pnlControls
            // 
            pnlControls.BackColor = Color.FromArgb(202, 209, 193);
            pnlControls.BorderStyle = BorderStyle.FixedSingle;
            pnlControls.Dock = DockStyle.Fill;
            pnlControls.Location = new Point(268, 0);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(1214, 853);
            pnlControls.TabIndex = 1;
            // 
            // FrmPreviewAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            Controls.Add(pnlControls);
            Controls.Add(pnlDashboard);
            DoubleBuffered = true;
            Name = "FrmPreviewAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPreviewAdmin";
            Load += FrmPreviewAdmin_Load;
            pnlDashboard.ResumeLayout(false);
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlTicket.ResumeLayout(false);
            pnlFlights.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDashboard;
        private Panel pnlControls;
        private Button btnFlights;
        private Panel pnlLogo;
        private PictureBox pictureBox1;
        private Panel pnlUser;
        private Button btnUsers;
        private Panel pnlTicket;
        private Button btnTicket;
        private Panel pnlFlights;
        private Button btnRegisterPlane;
        private Button btnAssignRoute;
        private Button btnTicketNr;
        private Button btnPendingTicket;
        private Button btnPresentUsers;
        private Button btnActiveFlights;
        private Panel pnlDetails;
        private Label lblEmail;
        private Label lblUsername;
        private Panel panel2;
        private Panel panel3;
        private Button btnLogOut;
    }
}