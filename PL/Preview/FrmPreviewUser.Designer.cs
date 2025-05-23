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
            pnlControls = new Panel();
            pnlLogo = new Panel();
            btnFlights = new Button();
            pnlDashboard = new Panel();
            pnlFlights = new Panel();
            btnTicket = new Button();
            pnlTicket = new Panel();
            panel2 = new Panel();
            btnPresentUsers = new Button();
            pnlUser = new Panel();
            btnPendingTicket = new Button();
            btnTicketNr = new Button();
            btnPresentFlights = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnLogOut = new Button();
            panel1 = new Panel();
            btnAddFlight = new Button();
            pictureBox1 = new PictureBox();
            btnUsers = new Button();
            pnlLogo.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlFlights.SuspendLayout();
            pnlTicket.SuspendLayout();
            pnlUser.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlControls
            // 
            pnlControls.BackColor = Color.FromArgb(202, 209, 193);
            pnlControls.Dock = DockStyle.Fill;
            pnlControls.Location = new Point(0, 0);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(1482, 853);
            pnlControls.TabIndex = 3;
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
            // btnFlights
            // 
            btnFlights.BackColor = Color.Teal;
            btnFlights.Dock = DockStyle.Top;
            btnFlights.FlatStyle = FlatStyle.Popup;
            btnFlights.Location = new Point(0, 188);
            btnFlights.Name = "btnFlights";
            btnFlights.Size = new Size(268, 60);
            btnFlights.TabIndex = 10;
            btnFlights.Text = "Fluturimet";
            btnFlights.UseVisualStyleBackColor = false;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.FromArgb(118, 166, 169);
            pnlDashboard.Controls.Add(panel1);
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
            pnlDashboard.TabIndex = 2;
            // 
            // pnlFlights
            // 
            pnlFlights.BackColor = Color.FromArgb(231, 216, 182);
            pnlFlights.Controls.Add(button1);
            pnlFlights.Controls.Add(btnPresentFlights);
            pnlFlights.Controls.Add(btnAddFlight);
            pnlFlights.Dock = DockStyle.Top;
            pnlFlights.Location = new Point(0, 248);
            pnlFlights.Name = "pnlFlights";
            pnlFlights.Size = new Size(268, 0);
            pnlFlights.TabIndex = 11;
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
            btnTicket.Text = "Biletat";
            btnTicket.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(0, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 2);
            panel2.TabIndex = 11;
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
            // btnPresentFlights
            // 
            btnPresentFlights.BackColor = Color.FromArgb(186, 188, 165);
            btnPresentFlights.Dock = DockStyle.Top;
            btnPresentFlights.FlatStyle = FlatStyle.Flat;
            btnPresentFlights.Location = new Point(0, 46);
            btnPresentFlights.Name = "btnPresentFlights";
            btnPresentFlights.Size = new Size(268, 46);
            btnPresentFlights.TabIndex = 1;
            btnPresentFlights.Text = "Fluturimet Aktuale";
            btnPresentFlights.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(186, 188, 165);
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 92);
            button1.Name = "button1";
            button1.Size = new Size(268, 46);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(26, 62);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 1;
            label2.Text = "test@gmail.com";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 2);
            panel3.TabIndex = 12;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(156, 21);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 13;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 748);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 105);
            panel1.TabIndex = 16;
            // 
            // btnAddFlight
            // 
            btnAddFlight.BackColor = Color.FromArgb(186, 188, 165);
            btnAddFlight.Dock = DockStyle.Top;
            btnAddFlight.FlatStyle = FlatStyle.Flat;
            btnAddFlight.Location = new Point(0, 0);
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new Size(268, 46);
            btnAddFlight.TabIndex = 0;
            btnAddFlight.Text = "Shto Fluturim";
            btnAddFlight.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(55, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 146);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
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
            btnUsers.Text = "Perdoruesit";
            btnUsers.UseVisualStyleBackColor = false;
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
            pnlLogo.ResumeLayout(false);
            pnlDashboard.ResumeLayout(false);
            pnlFlights.ResumeLayout(false);
            pnlTicket.ResumeLayout(false);
            pnlUser.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlControls;
        private Panel pnlLogo;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnFlights;
        private Panel pnlDashboard;
        private Panel panel1;
        private Button btnLogOut;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel pnlUser;
        private Button btnPresentUsers;
        private Button btnUsers;
        private Panel pnlTicket;
        private Button btnTicketNr;
        private Button btnPendingTicket;
        private Button btnTicket;
        private Panel pnlFlights;
        private Button button1;
        private Button btnPresentFlights;
        private Button btnAddFlight;
    }
}