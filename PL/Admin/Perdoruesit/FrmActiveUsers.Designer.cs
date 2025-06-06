namespace FlightManagement.PL.Admin.Perdoruesit
{
    partial class FrmActiveUsers
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
            dgActiveUsers = new DataGridView();
            lblTitleRouteInput = new Label();
            pnlActiveUsers = new Panel();
            lblTitleRoute = new Label();
            btnExcelExport = new Button();
            pnlOptions = new Panel();
            label3 = new Label();
            cbChangeRole = new ComboBox();
            btnChangeRole = new Button();
            label2 = new Label();
            cbFilterRoles = new ComboBox();
            label1 = new Label();
            txtFilterId = new TextBox();
            btnDelete = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgActiveUsers).BeginInit();
            pnlActiveUsers.SuspendLayout();
            pnlOptions.SuspendLayout();
            SuspendLayout();
            // 
            // dgActiveUsers
            // 
            dgActiveUsers.AllowUserToAddRows = false;
            dgActiveUsers.AllowUserToDeleteRows = false;
            dgActiveUsers.AllowUserToResizeColumns = false;
            dgActiveUsers.AllowUserToResizeRows = false;
            dgActiveUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgActiveUsers.Location = new Point(64, 81);
            dgActiveUsers.Name = "dgActiveUsers";
            dgActiveUsers.ReadOnly = true;
            dgActiveUsers.RowHeadersWidth = 51;
            dgActiveUsers.Size = new Size(1080, 447);
            dgActiveUsers.TabIndex = 3;
            dgActiveUsers.CellClick += dgActiveUsers_CellClick;
            // 
            // lblTitleRouteInput
            // 
            lblTitleRouteInput.AutoSize = true;
            lblTitleRouteInput.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleRouteInput.Location = new Point(64, 26);
            lblTitleRouteInput.Name = "lblTitleRouteInput";
            lblTitleRouteInput.Size = new Size(463, 33);
            lblTitleRouteInput.TabIndex = 2;
            lblTitleRouteInput.Text = "👤 Lista e perdorueseve aktivë në sistem";
            // 
            // pnlActiveUsers
            // 
            pnlActiveUsers.BackColor = Color.FromArgb(202, 209, 193);
            pnlActiveUsers.Controls.Add(dgActiveUsers);
            pnlActiveUsers.Controls.Add(lblTitleRouteInput);
            pnlActiveUsers.Dock = DockStyle.Fill;
            pnlActiveUsers.Location = new Point(0, 0);
            pnlActiveUsers.Name = "pnlActiveUsers";
            pnlActiveUsers.Size = new Size(1214, 576);
            pnlActiveUsers.TabIndex = 11;
            // 
            // lblTitleRoute
            // 
            lblTitleRoute.AutoSize = true;
            lblTitleRoute.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleRoute.ForeColor = Color.Teal;
            lblTitleRoute.Location = new Point(294, 16);
            lblTitleRoute.Name = "lblTitleRoute";
            lblTitleRoute.Size = new Size(641, 33);
            lblTitleRoute.TabIndex = 0;
            lblTitleRoute.Text = "📌 Opsione të disponueshme për personin e përzgjedhur";
            // 
            // btnExcelExport
            // 
            btnExcelExport.BackColor = Color.Teal;
            btnExcelExport.FlatStyle = FlatStyle.Popup;
            btnExcelExport.Font = new Font("Times New Roman", 12F);
            btnExcelExport.Location = new Point(119, 66);
            btnExcelExport.Name = "btnExcelExport";
            btnExcelExport.Size = new Size(228, 80);
            btnExcelExport.TabIndex = 13;
            btnExcelExport.Text = "📊 Eksporto në Excel";
            btnExcelExport.UseVisualStyleBackColor = false;
            btnExcelExport.Click += btnExcelExport_Click;
            // 
            // pnlOptions
            // 
            pnlOptions.BackColor = Color.FromArgb(170, 190, 180);
            pnlOptions.Controls.Add(label3);
            pnlOptions.Controls.Add(cbChangeRole);
            pnlOptions.Controls.Add(btnChangeRole);
            pnlOptions.Controls.Add(label2);
            pnlOptions.Controls.Add(cbFilterRoles);
            pnlOptions.Controls.Add(label1);
            pnlOptions.Controls.Add(txtFilterId);
            pnlOptions.Controls.Add(btnDelete);
            pnlOptions.Controls.Add(btnExcelExport);
            pnlOptions.Controls.Add(lblTitleRoute);
            pnlOptions.Dock = DockStyle.Bottom;
            pnlOptions.Location = new Point(0, 576);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(1214, 277);
            pnlOptions.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.Location = new Point(464, 178);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 24;
            label3.Text = "Ndrysho rolin ne:";
            // 
            // cbChangeRole
            // 
            cbChangeRole.Enabled = false;
            cbChangeRole.Font = new Font("Times New Roman", 10.2F);
            cbChangeRole.FormattingEnabled = true;
            cbChangeRole.Items.AddRange(new object[] { "User", "Admin" });
            cbChangeRole.Location = new Point(464, 214);
            cbChangeRole.Name = "cbChangeRole";
            cbChangeRole.Size = new Size(151, 27);
            cbChangeRole.TabIndex = 23;
            // 
            // btnChangeRole
            // 
            btnChangeRole.BackColor = Color.OrangeRed;
            btnChangeRole.Enabled = false;
            btnChangeRole.FlatStyle = FlatStyle.Popup;
            btnChangeRole.Font = new Font("Times New Roman", 12F);
            btnChangeRole.Location = new Point(716, 199);
            btnChangeRole.Name = "btnChangeRole";
            btnChangeRole.Size = new Size(141, 54);
            btnChangeRole.TabIndex = 22;
            btnChangeRole.Text = "Ndrysho";
            btnChangeRole.UseVisualStyleBackColor = false;
            btnChangeRole.Click += btnChangeRole_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(464, 66);
            label2.Name = "label2";
            label2.Size = new Size(138, 19);
            label2.TabIndex = 21;
            label2.Text = "Filtroni sipas rolit:";
            // 
            // cbFilterRoles
            // 
            cbFilterRoles.Font = new Font("Times New Roman", 10.2F);
            cbFilterRoles.FormattingEnabled = true;
            cbFilterRoles.Items.AddRange(new object[] { "All", "User", "Admin" });
            cbFilterRoles.Location = new Point(464, 105);
            cbFilterRoles.Name = "cbFilterRoles";
            cbFilterRoles.Size = new Size(151, 27);
            cbFilterRoles.TabIndex = 20;
            cbFilterRoles.SelectedIndexChanged += cbFilterRoles_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(716, 66);
            label1.Name = "label1";
            label1.Size = new Size(211, 19);
            label1.TabIndex = 19;
            label1.Text = "Filtro sipas ID të përdoruesit:";
            // 
            // txtFilterId
            // 
            txtFilterId.Font = new Font("Times New Roman", 10.2F);
            txtFilterId.Location = new Point(716, 106);
            txtFilterId.Name = "txtFilterId";
            txtFilterId.Size = new Size(151, 27);
            txtFilterId.TabIndex = 18;
            txtFilterId.TextChanged += txtFilterId_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Times New Roman", 12F);
            btnDelete.Location = new Point(955, 199);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 54);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Fshi";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmActiveUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 853);
            Controls.Add(pnlActiveUsers);
            Controls.Add(pnlOptions);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmActiveUsers";
            Text = "FrmActiveUsers";
            Load += FrmActiveUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgActiveUsers).EndInit();
            pnlActiveUsers.ResumeLayout(false);
            pnlActiveUsers.PerformLayout();
            pnlOptions.ResumeLayout(false);
            pnlOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgActiveUsers;
        private Label lblTitleRouteInput;
        private Panel pnlActiveUsers;
        private Label lblTitleRoute;
        private Button btnExcelExport;
        private Panel pnlOptions;
        private Button btnDelete;
        private Label label2;
        private ComboBox cbFilterRoles;
        private Label label1;
        private TextBox txtFilterId;
        private Button btnChangeRole;
        private Label label3;
        private ComboBox cbChangeRole;
        private SaveFileDialog saveFileDialog1;
    }
}