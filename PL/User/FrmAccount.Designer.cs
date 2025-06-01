namespace FlightManagement.PL.User
{
    partial class FrmAccount
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
            lblTitle = new Label();
            pnlSearch = new Panel();
            pnlSettings = new Panel();
            pnlChangeData = new Panel();
            btnShowRepeat = new Button();
            btnShowNew = new Button();
            btnShowOld = new Button();
            label6 = new Label();
            btnDelete = new Button();
            btnSavePassword = new Button();
            txtRepeat = new TextBox();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pnlAccountInformation = new Panel();
            label1 = new Label();
            btnSave = new Button();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            lblEmail = new Label();
            lblName = new Label();
            pnlSearch.SuspendLayout();
            pnlSettings.SuspendLayout();
            pnlChangeData.SuspendLayout();
            pnlAccountInformation.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(34, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Akaunti personal";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(138, 167, 159);
            pnlSearch.Controls.Add(lblTitle);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1214, 84);
            pnlSearch.TabIndex = 4;
            // 
            // pnlSettings
            // 
            pnlSettings.BackColor = Color.FromArgb(202, 209, 193);
            pnlSettings.Controls.Add(pnlChangeData);
            pnlSettings.Controls.Add(pnlAccountInformation);
            pnlSettings.Dock = DockStyle.Fill;
            pnlSettings.Location = new Point(0, 84);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.Size = new Size(1214, 769);
            pnlSettings.TabIndex = 5;
            // 
            // pnlChangeData
            // 
            pnlChangeData.BackColor = Color.FromArgb(202, 209, 193);
            pnlChangeData.Controls.Add(btnShowRepeat);
            pnlChangeData.Controls.Add(btnShowNew);
            pnlChangeData.Controls.Add(btnShowOld);
            pnlChangeData.Controls.Add(label6);
            pnlChangeData.Controls.Add(btnDelete);
            pnlChangeData.Controls.Add(btnSavePassword);
            pnlChangeData.Controls.Add(txtRepeat);
            pnlChangeData.Controls.Add(txtNewPassword);
            pnlChangeData.Controls.Add(txtOldPassword);
            pnlChangeData.Controls.Add(label2);
            pnlChangeData.Controls.Add(label5);
            pnlChangeData.Controls.Add(label4);
            pnlChangeData.Controls.Add(label3);
            pnlChangeData.Dock = DockStyle.Fill;
            pnlChangeData.Location = new Point(0, 250);
            pnlChangeData.Name = "pnlChangeData";
            pnlChangeData.Padding = new Padding(0, 20, 0, 0);
            pnlChangeData.Size = new Size(1214, 519);
            pnlChangeData.TabIndex = 1;
            // 
            // btnShowRepeat
            // 
            btnShowRepeat.AutoSize = true;
            btnShowRepeat.BackgroundImage = Properties.Resources.eye;
            btnShowRepeat.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowRepeat.Cursor = Cursors.Hand;
            btnShowRepeat.Location = new Point(536, 195);
            btnShowRepeat.Name = "btnShowRepeat";
            btnShowRepeat.Size = new Size(32, 30);
            btnShowRepeat.TabIndex = 25;
            btnShowRepeat.UseVisualStyleBackColor = true;
            btnShowRepeat.Click += btnShowRepeat_Click;
            // 
            // btnShowNew
            // 
            btnShowNew.AutoSize = true;
            btnShowNew.BackgroundImage = Properties.Resources.eye;
            btnShowNew.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowNew.Cursor = Cursors.Hand;
            btnShowNew.Location = new Point(536, 141);
            btnShowNew.Name = "btnShowNew";
            btnShowNew.Size = new Size(32, 30);
            btnShowNew.TabIndex = 24;
            btnShowNew.UseVisualStyleBackColor = true;
            btnShowNew.Click += btnShowNew_Click;
            // 
            // btnShowOld
            // 
            btnShowOld.AutoSize = true;
            btnShowOld.BackgroundImage = Properties.Resources.eye;
            btnShowOld.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowOld.Cursor = Cursors.Hand;
            btnShowOld.Location = new Point(536, 87);
            btnShowOld.Name = "btnShowOld";
            btnShowOld.Size = new Size(32, 30);
            btnShowOld.TabIndex = 23;
            btnShowOld.UseVisualStyleBackColor = true;
            btnShowOld.Click += btnShowOld_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(12, 397);
            label6.Name = "label6";
            label6.Size = new Size(648, 25);
            label6.TabIndex = 22;
            label6.Text = "Kujdes! Fshirja e llogarisë do të heqë të gjitha te dhenat e tuaja!";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Times New Roman", 12F);
            btnDelete.Location = new Point(25, 434);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 54);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Fshi akauntin";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSavePassword
            // 
            btnSavePassword.BackColor = Color.Teal;
            btnSavePassword.FlatStyle = FlatStyle.Popup;
            btnSavePassword.Font = new Font("Times New Roman", 12F);
            btnSavePassword.Location = new Point(363, 243);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(138, 54);
            btnSavePassword.TabIndex = 20;
            btnSavePassword.Text = "Ruaj";
            btnSavePassword.UseVisualStyleBackColor = false;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // txtRepeat
            // 
            txtRepeat.BackColor = Color.FromArgb(217, 231, 225);
            txtRepeat.BorderStyle = BorderStyle.FixedSingle;
            txtRepeat.Font = new Font("Times New Roman", 12F);
            txtRepeat.Location = new Point(332, 195);
            txtRepeat.Name = "txtRepeat";
            txtRepeat.PasswordChar = '*';
            txtRepeat.Size = new Size(198, 30);
            txtRepeat.TabIndex = 19;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(217, 231, 225);
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Times New Roman", 12F);
            txtNewPassword.Location = new Point(332, 141);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(198, 30);
            txtNewPassword.TabIndex = 18;
            // 
            // txtOldPassword
            // 
            txtOldPassword.BackColor = Color.FromArgb(217, 231, 225);
            txtOldPassword.BorderStyle = BorderStyle.FixedSingle;
            txtOldPassword.Font = new Font("Times New Roman", 12F);
            txtOldPassword.Location = new Point(332, 87);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(198, 30);
            txtOldPassword.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(450, 20);
            label2.Name = "label2";
            label2.Size = new Size(324, 38);
            label2.TabIndex = 16;
            label2.Text = "Ndrysho fjalekalimin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(62, 203);
            label5.Name = "label5";
            label5.Size = new Size(229, 22);
            label5.TabIndex = 4;
            label5.Text = "Konfirmo fjalekalimin e ri :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(62, 146);
            label4.Name = "label4";
            label4.Size = new Size(146, 22);
            label4.TabIndex = 3;
            label4.Text = "Fjalekalimi i ri : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(62, 92);
            label3.Name = "label3";
            label3.Size = new Size(174, 22);
            label3.TabIndex = 2;
            label3.Text = "Fjalekalimi i vjeter :";
            // 
            // pnlAccountInformation
            // 
            pnlAccountInformation.BackColor = Color.FromArgb(202, 209, 193);
            pnlAccountInformation.Controls.Add(label1);
            pnlAccountInformation.Controls.Add(btnSave);
            pnlAccountInformation.Controls.Add(txtEmail);
            pnlAccountInformation.Controls.Add(txtUsername);
            pnlAccountInformation.Controls.Add(lblEmail);
            pnlAccountInformation.Controls.Add(lblName);
            pnlAccountInformation.Dock = DockStyle.Top;
            pnlAccountInformation.Location = new Point(0, 0);
            pnlAccountInformation.Name = "pnlAccountInformation";
            pnlAccountInformation.Padding = new Padding(0, 0, 0, 10);
            pnlAccountInformation.Size = new Size(1214, 250);
            pnlAccountInformation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 15);
            label1.Name = "label1";
            label1.Size = new Size(315, 38);
            label1.TabIndex = 15;
            label1.Text = "Te dhenat e llogarise";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Times New Roman", 12F);
            btnSave.Location = new Point(320, 174);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 54);
            btnSave.TabIndex = 14;
            btnSave.Text = "Ruaj";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(217, 231, 225);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Times New Roman", 12F);
            txtEmail.Location = new Point(290, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 30);
            txtEmail.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(217, 231, 225);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Times New Roman", 12F);
            txtUsername.Location = new Point(290, 74);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(198, 30);
            txtUsername.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 12F);
            lblEmail.Location = new Point(58, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 22);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 12F);
            lblName.Location = new Point(58, 77);
            lblName.Name = "lblName";
            lblName.Size = new Size(161, 22);
            lblName.TabIndex = 0;
            lblName.Text = "Emri i perdoruesit:";
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 853);
            Controls.Add(pnlSettings);
            Controls.Add(pnlSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAccount";
            Text = "FrmAccount";
            Load += FrmAccount_Load;
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlSettings.ResumeLayout(false);
            pnlChangeData.ResumeLayout(false);
            pnlChangeData.PerformLayout();
            pnlAccountInformation.ResumeLayout(false);
            pnlAccountInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Panel pnlSearch;
        private Panel pnlSettings;
        private Panel pnlAccountInformation;
        private Panel pnlChangeData;
        private Label lblName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private TextBox txtRepeat;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Button btnSavePassword;
        private Label label6;
        private Button btnDelete;
        private Button btnShowRepeat;
        private Button btnShowNew;
        private Button btnShowOld;
    }
}