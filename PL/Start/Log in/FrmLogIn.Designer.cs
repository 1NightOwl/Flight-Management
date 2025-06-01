namespace FlightManagement.PL.Start.Log_in
{
    partial class FrmLogIn
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
            lblEmail = new Label();
            lblPassword = new Label();
            lblTextTop = new Label();
            lblTextBot = new Label();
            txtEmUsr = new TextBox();
            txtPassword = new TextBox();
            pnlLogIn = new Panel();
            btnShow = new Button();
            lblRegister = new LinkLabel();
            btnLogin = new Button();
            pnlRegister = new Panel();
            lblUsername = new Label();
            txtUsername1 = new TextBox();
            btnShow1 = new Button();
            lblLogin = new LinkLabel();
            rbTermsAndConds = new RadioButton();
            btnRegister = new Button();
            lblEmail1 = new Label();
            txtPassword1 = new TextBox();
            txtEmail1 = new TextBox();
            lblPassword1 = new Label();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            pnlLogIn.SuspendLayout();
            pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 12F);
            lblEmail.Location = new Point(38, 28);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(151, 22);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Username / Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 12F);
            lblPassword.Location = new Point(38, 133);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 22);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblTextTop
            // 
            lblTextTop.AutoSize = true;
            lblTextTop.BackColor = Color.Transparent;
            lblTextTop.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextTop.ForeColor = Color.Teal;
            lblTextTop.Location = new Point(792, 323);
            lblTextTop.Name = "lblTextTop";
            lblTextTop.Size = new Size(435, 46);
            lblTextTop.TabIndex = 2;
            lblTextTop.Text = "Fluturimi yt, mënyra jonë.";
            // 
            // lblTextBot
            // 
            lblTextBot.AutoSize = true;
            lblTextBot.BackColor = Color.Transparent;
            lblTextBot.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextBot.ForeColor = Color.Teal;
            lblTextBot.Location = new Point(792, 381);
            lblTextBot.Name = "lblTextBot";
            lblTextBot.Size = new Size(678, 33);
            lblTextBot.TabIndex = 3;
            lblTextBot.Text = "Një përvojë udhëtimi që flet vetë — me kujdes në çdo detaj.";
            // 
            // txtEmUsr
            // 
            txtEmUsr.BackColor = Color.LightGray;
            txtEmUsr.BorderStyle = BorderStyle.FixedSingle;
            txtEmUsr.Font = new Font("Times New Roman", 12F);
            txtEmUsr.Location = new Point(38, 67);
            txtEmUsr.Name = "txtEmUsr";
            txtEmUsr.PlaceholderText = "Emri i përdoruesit, ose email-i";
            txtEmUsr.Size = new Size(247, 30);
            txtEmUsr.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightGray;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Times New Roman", 12F);
            txtPassword.Location = new Point(38, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Fjalëkalimi…";
            txtPassword.Size = new Size(247, 30);
            txtPassword.TabIndex = 2;
            // 
            // pnlLogIn
            // 
            pnlLogIn.BackColor = Color.Transparent;
            pnlLogIn.BorderStyle = BorderStyle.FixedSingle;
            pnlLogIn.Controls.Add(btnShow);
            pnlLogIn.Controls.Add(lblRegister);
            pnlLogIn.Controls.Add(btnLogin);
            pnlLogIn.Controls.Add(lblEmail);
            pnlLogIn.Controls.Add(txtPassword);
            pnlLogIn.Controls.Add(txtEmUsr);
            pnlLogIn.Controls.Add(lblPassword);
            pnlLogIn.Location = new Point(244, 328);
            pnlLogIn.Name = "pnlLogIn";
            pnlLogIn.Size = new Size(340, 370);
            pnlLogIn.TabIndex = 6;
            // 
            // btnShow
            // 
            btnShow.AutoSize = true;
            btnShow.BackgroundImage = Properties.Resources.eye;
            btnShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow.Cursor = Cursors.Hand;
            btnShow.Location = new Point(291, 172);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(32, 30);
            btnShow.TabIndex = 10;
            toolTip1.SetToolTip(btnShow, "Shfaq/fsheh fjalëkalimin");
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Times New Roman", 10.8F);
            lblRegister.LinkColor = Color.Teal;
            lblRegister.Location = new Point(57, 336);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(278, 20);
            lblRegister.TabIndex = 7;
            lblRegister.TabStop = true;
            lblRegister.Text = "Don't have an account? Register now";
            lblRegister.Click += lblRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Times New Roman", 12F);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(107, 239);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(124, 53);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogIn_Click;
            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.Transparent;
            pnlRegister.BorderStyle = BorderStyle.FixedSingle;
            pnlRegister.Controls.Add(lblUsername);
            pnlRegister.Controls.Add(txtUsername1);
            pnlRegister.Controls.Add(btnShow1);
            pnlRegister.Controls.Add(lblLogin);
            pnlRegister.Controls.Add(rbTermsAndConds);
            pnlRegister.Controls.Add(btnRegister);
            pnlRegister.Controls.Add(lblEmail1);
            pnlRegister.Controls.Add(txtPassword1);
            pnlRegister.Controls.Add(txtEmail1);
            pnlRegister.Controls.Add(lblPassword1);
            pnlRegister.Location = new Point(244, 328);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(340, 421);
            pnlRegister.TabIndex = 7;
            pnlRegister.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 12F);
            lblUsername.Location = new Point(26, 18);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(88, 22);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "Username";
            // 
            // txtUsername1
            // 
            txtUsername1.BackColor = Color.LightGray;
            txtUsername1.BorderStyle = BorderStyle.FixedSingle;
            txtUsername1.Font = new Font("Times New Roman", 12F);
            txtUsername1.Location = new Point(26, 52);
            txtUsername1.Name = "txtUsername1";
            txtUsername1.PlaceholderText = "Emri i përdoruesit…";
            txtUsername1.Size = new Size(247, 30);
            txtUsername1.TabIndex = 1;
            // 
            // btnShow1
            // 
            btnShow1.BackgroundImage = Properties.Resources.eye;
            btnShow1.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow1.Cursor = Cursors.Hand;
            btnShow1.Location = new Point(279, 192);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(32, 29);
            btnShow1.TabIndex = 5;
            toolTip1.SetToolTip(btnShow1, "Shfaq/fsheh fjalëkalimin");
            btnShow1.UseVisualStyleBackColor = true;
            btnShow1.Click += btnShow1_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 10.8F);
            lblLogin.LinkColor = Color.Teal;
            lblLogin.Location = new Point(26, 389);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(282, 20);
            lblLogin.TabIndex = 7;
            lblLogin.TabStop = true;
            lblLogin.Text = "Already have an account? Log in here";
            lblLogin.Click += lblLogin_Click;
            // 
            // rbTermsAndConds
            // 
            rbTermsAndConds.AutoSize = true;
            rbTermsAndConds.Location = new Point(26, 252);
            rbTermsAndConds.Name = "rbTermsAndConds";
            rbTermsAndConds.Size = new Size(235, 24);
            rbTermsAndConds.TabIndex = 4;
            rbTermsAndConds.TabStop = true;
            rbTermsAndConds.Text = "Agree to Terms and Conditions";
            rbTermsAndConds.UseVisualStyleBackColor = true;
            rbTermsAndConds.CheckedChanged += rbTermsAndConds_CheckedChanged;
            rbTermsAndConds.Click += rbTermsAndConds_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Teal;
            btnRegister.Enabled = false;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Times New Roman", 12F);
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(95, 304);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(124, 53);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblEmail1
            // 
            lblEmail1.AutoSize = true;
            lblEmail1.Font = new Font("Times New Roman", 12F);
            lblEmail1.Location = new Point(26, 92);
            lblEmail1.Name = "lblEmail1";
            lblEmail1.Size = new Size(57, 22);
            lblEmail1.TabIndex = 0;
            lblEmail1.Text = "Email";
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = Color.LightGray;
            txtPassword1.BorderStyle = BorderStyle.FixedSingle;
            txtPassword1.Font = new Font("Times New Roman", 12F);
            txtPassword1.Location = new Point(26, 192);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '*';
            txtPassword1.PlaceholderText = "Fjalëkalimi…";
            txtPassword1.Size = new Size(247, 30);
            txtPassword1.TabIndex = 3;
            // 
            // txtEmail1
            // 
            txtEmail1.BackColor = Color.LightGray;
            txtEmail1.BorderStyle = BorderStyle.FixedSingle;
            txtEmail1.Font = new Font("Times New Roman", 12F);
            txtEmail1.Location = new Point(26, 125);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.PlaceholderText = "Email-i juaj…";
            txtEmail1.Size = new Size(247, 30);
            txtEmail1.TabIndex = 2;
            // 
            // lblPassword1
            // 
            lblPassword1.AutoSize = true;
            lblPassword1.Font = new Font("Times New Roman", 12F);
            lblPassword1.Location = new Point(26, 162);
            lblPassword1.Name = "lblPassword1";
            lblPassword1.Size = new Size(88, 22);
            lblPassword1.TabIndex = 1;
            lblPassword1.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(284, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 258);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.FotoBackLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 853);
            Controls.Add(pictureBox1);
            Controls.Add(lblTextBot);
            Controls.Add(lblTextTop);
            Controls.Add(pnlLogIn);
            Controls.Add(pnlRegister);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  Log In";
            Load += FrmLogIn_Load;
            pnlLogIn.ResumeLayout(false);
            pnlLogIn.PerformLayout();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private Label lblTextTop;
        private Label lblTextBot;
        private TextBox txtEmUsr;
        private TextBox txtPassword;
        private Panel pnlLogIn;
        private Button btnLogin;
        private Panel pnlRegister;
        private RadioButton rbTermsAndConds;
        private Button btnRegister;
        private Label lblEmail1;
        private TextBox txtPassword1;
        private TextBox txtEmail1;
        private Label lblPassword1;
        private LinkLabel lblRegister;
        private LinkLabel lblLogin;
        private PictureBox pictureBox1;
        private Button btnShow;
        private Button btnShow1;
        private Label lblUsername;
        private TextBox txtUsername1;
        private ToolTip toolTip1;
    }
}