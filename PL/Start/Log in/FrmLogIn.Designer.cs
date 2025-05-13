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
            lblEmail = new Label();
            lblPassword = new Label();
            lblTextTop = new Label();
            lblTextBot = new Label();
            txtEmUsr = new TextBox();
            txtPassword = new TextBox();
            pnlLogIn = new Panel();
            btnShow = new Button();
            lbRegister = new LinkLabel();
            btnLogIn = new Button();
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
            cbSelector = new ComboBox();
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
            txtPassword.Size = new Size(247, 30);
            txtPassword.TabIndex = 2;
            // 
            // pnlLogIn
            // 
            pnlLogIn.BackColor = Color.Transparent;
            pnlLogIn.BorderStyle = BorderStyle.FixedSingle;
            pnlLogIn.Controls.Add(btnShow);
            pnlLogIn.Controls.Add(lbRegister);
            pnlLogIn.Controls.Add(btnLogIn);
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
            btnShow.BackgroundImage = Properties.Resources.eye;
            btnShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow.Location = new Point(291, 172);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(32, 30);
            btnShow.TabIndex = 10;
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Font = new Font("Times New Roman", 10.8F);
            lbRegister.LinkColor = Color.Teal;
            lbRegister.Location = new Point(57, 336);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(278, 20);
            lbRegister.TabIndex = 7;
            lbRegister.TabStop = true;
            lbRegister.Text = "Don't have an account? Register now";
            lbRegister.Click += lbRegister_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Teal;
            btnLogIn.Enabled = false;
            btnLogIn.FlatStyle = FlatStyle.Popup;
            btnLogIn.Font = new Font("Times New Roman", 12F);
            btnLogIn.ForeColor = SystemColors.Control;
            btnLogIn.Location = new Point(107, 239);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(124, 53);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            btnLogIn.MouseHover += btnLogIn_MouseHover;
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
            txtUsername1.Size = new Size(247, 30);
            txtUsername1.TabIndex = 1;
            // 
            // btnShow1
            // 
            btnShow1.BackgroundImage = Properties.Resources.eye;
            btnShow1.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow1.Location = new Point(279, 192);
            btnShow1.Name = "btnShow1";
            btnShow1.Size = new Size(32, 29);
            btnShow1.TabIndex = 5;
            btnShow1.UseVisualStyleBackColor = true;
            btnShow1.Click += btnShow1_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 10.8F);
            lblLogin.LinkColor = Color.Teal;
            lblLogin.Location = new Point(45, 394);
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
            btnRegister.MouseHover += btnLogIn_MouseHover;
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
            pictureBox1.Location = new Point(301, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 198);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // cbSelector
            // 
            cbSelector.BackColor = Color.Teal;
            cbSelector.FlatStyle = FlatStyle.Flat;
            cbSelector.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelector.FormattingEnabled = true;
            cbSelector.Items.AddRange(new object[] { "User", "Admin" });
            cbSelector.Location = new Point(325, 277);
            cbSelector.Name = "cbSelector";
            cbSelector.Size = new Size(151, 30);
            cbSelector.TabIndex = 9;
            cbSelector.SelectedIndexChanged += cbSelector_SelectedIndexChanged;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.FotoBackLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 853);
            Controls.Add(cbSelector);
            Controls.Add(pictureBox1);
            Controls.Add(pnlRegister);
            Controls.Add(pnlLogIn);
            Controls.Add(lblTextBot);
            Controls.Add(lblTextTop);
            DoubleBuffered = true;
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogIn";
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
        private Button btnLogIn;
        private Panel pnlRegister;
        private RadioButton rbTermsAndConds;
        private Button btnRegister;
        private Label lblEmail1;
        private TextBox txtPassword1;
        private TextBox txtEmail1;
        private Label lblPassword1;
        private LinkLabel lbRegister;
        private LinkLabel lblLogin;
        private PictureBox pictureBox1;
        private Button btnShow;
        private Button btnShow1;
        private Label lblUsername;
        private TextBox txtUsername1;
        private ComboBox cbSelector;
    }
}