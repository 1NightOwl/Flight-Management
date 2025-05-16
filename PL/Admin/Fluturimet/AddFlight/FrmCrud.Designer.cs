namespace FlightManagement.PL.Admin.Fluturimet.AddFlight
{
    partial class FrmCrud
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
            pnlCrud = new Panel();
            btnSwitchPanelData = new Button();
            btnSwitchPanelSeatMap = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            cbPlaneStatus = new ComboBox();
            txtMaxRange = new TextBox();
            txtSeatNr = new TextBox();
            txtPlaneRegistration = new TextBox();
            txtPlaneId = new TextBox();
            lblStatus = new Label();
            lblNrSeats = new Label();
            lblId = new Label();
            lblMaxTravel = new Label();
            lblNrID = new Label();
            cbPlaneType = new ComboBox();
            lblModeli = new Label();
            lblTitullCrud = new Label();
            pnlData = new Panel();
            lbTitleData = new Label();
            dgData = new DataGridView();
            pnlSeatMap = new Panel();
            lblTitleSeatMap = new Label();
            pbSeatMap = new PictureBox();
            pnlCrud.SuspendLayout();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            pnlSeatMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSeatMap).BeginInit();
            SuspendLayout();
            // 
            // pnlCrud
            // 
            pnlCrud.BackColor = Color.FromArgb(170, 190, 180);
            pnlCrud.Controls.Add(btnSwitchPanelData);
            pnlCrud.Controls.Add(btnSwitchPanelSeatMap);
            pnlCrud.Controls.Add(btnDelete);
            pnlCrud.Controls.Add(btnClear);
            pnlCrud.Controls.Add(btnEdit);
            pnlCrud.Controls.Add(btnAdd);
            pnlCrud.Controls.Add(cbPlaneStatus);
            pnlCrud.Controls.Add(txtMaxRange);
            pnlCrud.Controls.Add(txtSeatNr);
            pnlCrud.Controls.Add(txtPlaneRegistration);
            pnlCrud.Controls.Add(txtPlaneId);
            pnlCrud.Controls.Add(lblStatus);
            pnlCrud.Controls.Add(lblNrSeats);
            pnlCrud.Controls.Add(lblId);
            pnlCrud.Controls.Add(lblMaxTravel);
            pnlCrud.Controls.Add(lblNrID);
            pnlCrud.Controls.Add(cbPlaneType);
            pnlCrud.Controls.Add(lblModeli);
            pnlCrud.Controls.Add(lblTitullCrud);
            pnlCrud.Dock = DockStyle.Bottom;
            pnlCrud.Location = new Point(0, 477);
            pnlCrud.Name = "pnlCrud";
            pnlCrud.Size = new Size(1214, 376);
            pnlCrud.TabIndex = 0;
            // 
            // btnSwitchPanelData
            // 
            btnSwitchPanelData.BackColor = Color.FromArgb(130, 180, 175);
            btnSwitchPanelData.FlatStyle = FlatStyle.Flat;
            btnSwitchPanelData.Font = new Font("Times New Roman", 12F);
            btnSwitchPanelData.Location = new Point(1073, 3);
            btnSwitchPanelData.Name = "btnSwitchPanelData";
            btnSwitchPanelData.Size = new Size(133, 33);
            btnSwitchPanelData.TabIndex = 18;
            btnSwitchPanelData.Text = "Data View →";
            btnSwitchPanelData.UseVisualStyleBackColor = false;
            btnSwitchPanelData.Click += btnSwitchPanelData_Click;
            // 
            // btnSwitchPanelSeatMap
            // 
            btnSwitchPanelSeatMap.BackColor = Color.FromArgb(130, 180, 175);
            btnSwitchPanelSeatMap.FlatStyle = FlatStyle.Flat;
            btnSwitchPanelSeatMap.Font = new Font("Times New Roman", 12F);
            btnSwitchPanelSeatMap.Location = new Point(1035, 3);
            btnSwitchPanelSeatMap.Name = "btnSwitchPanelSeatMap";
            btnSwitchPanelSeatMap.Size = new Size(171, 33);
            btnSwitchPanelSeatMap.TabIndex = 17;
            btnSwitchPanelSeatMap.Text = "Seat Map View →";
            btnSwitchPanelSeatMap.UseVisualStyleBackColor = false;
            btnSwitchPanelSeatMap.Visible = false;
            btnSwitchPanelSeatMap.Click += btnSwitchPanelSeatMap_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Times New Roman", 12F);
            btnDelete.Location = new Point(829, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 54);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Fshi";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Times New Roman", 12F);
            btnClear.Location = new Point(635, 298);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 54);
            btnClear.TabIndex = 15;
            btnClear.Text = "Pastro";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Teal;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Times New Roman", 12F);
            btnEdit.Location = new Point(441, 298);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 54);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Nrdysho";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Times New Roman", 12F);
            btnAdd.Location = new Point(247, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 54);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Shto";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // cbPlaneStatus
            // 
            cbPlaneStatus.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPlaneStatus.FormattingEnabled = true;
            cbPlaneStatus.Location = new Point(857, 192);
            cbPlaneStatus.Name = "cbPlaneStatus";
            cbPlaneStatus.Size = new Size(174, 30);
            cbPlaneStatus.TabIndex = 12;
            // 
            // txtMaxRange
            // 
            txtMaxRange.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaxRange.Location = new Point(857, 98);
            txtMaxRange.Name = "txtMaxRange";
            txtMaxRange.Size = new Size(174, 30);
            txtMaxRange.TabIndex = 11;
            // 
            // txtSeatNr
            // 
            txtSeatNr.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSeatNr.Location = new Point(506, 192);
            txtSeatNr.Name = "txtSeatNr";
            txtSeatNr.Size = new Size(174, 30);
            txtSeatNr.TabIndex = 10;
            // 
            // txtPlaneRegistration
            // 
            txtPlaneRegistration.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaneRegistration.Location = new Point(506, 98);
            txtPlaneRegistration.Name = "txtPlaneRegistration";
            txtPlaneRegistration.Size = new Size(174, 30);
            txtPlaneRegistration.TabIndex = 9;
            // 
            // txtPlaneId
            // 
            txtPlaneId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaneId.Location = new Point(147, 192);
            txtPlaneId.Name = "txtPlaneId";
            txtPlaneId.Size = new Size(174, 30);
            txtPlaneId.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(857, 166);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 23);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Statusi";
            // 
            // lblNrSeats
            // 
            lblNrSeats.AutoSize = true;
            lblNrSeats.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNrSeats.Location = new Point(502, 166);
            lblNrSeats.Name = "lblNrSeats";
            lblNrSeats.Size = new Size(149, 23);
            lblNrSeats.TabIndex = 6;
            lblNrSeats.Text = "Numri i Vendeve";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(147, 166);
            lblId.Name = "lblId";
            lblId.Size = new Size(139, 23);
            lblId.TabIndex = 5;
            lblId.Text = "ID e Aeroplanit";
            // 
            // lblMaxTravel
            // 
            lblMaxTravel.AutoSize = true;
            lblMaxTravel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxTravel.Location = new Point(857, 72);
            lblMaxTravel.Name = "lblMaxTravel";
            lblMaxTravel.Size = new Size(211, 23);
            lblMaxTravel.TabIndex = 4;
            lblMaxTravel.Text = "Rrezja Maksimale (km)";
            // 
            // lblNrID
            // 
            lblNrID.AutoSize = true;
            lblNrID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNrID.Location = new Point(502, 72);
            lblNrID.Name = "lblNrID";
            lblNrID.Size = new Size(178, 23);
            lblNrID.TabIndex = 3;
            lblNrID.Text = "Numri i Regjistrimit";
            // 
            // cbPlaneType
            // 
            cbPlaneType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPlaneType.FormattingEnabled = true;
            cbPlaneType.Location = new Point(147, 98);
            cbPlaneType.Name = "cbPlaneType";
            cbPlaneType.Size = new Size(174, 30);
            cbPlaneType.TabIndex = 2;
            cbPlaneType.SelectedIndexChanged += cbPlaneType_SelectedIndexChanged;
            // 
            // lblModeli
            // 
            lblModeli.AutoSize = true;
            lblModeli.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeli.Location = new Point(147, 72);
            lblModeli.Name = "lblModeli";
            lblModeli.Size = new Size(227, 23);
            lblModeli.TabIndex = 1;
            lblModeli.Text = "Modeli / Lloji i Aeroplanit";
            // 
            // lblTitullCrud
            // 
            lblTitullCrud.AutoSize = true;
            lblTitullCrud.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitullCrud.ForeColor = Color.Teal;
            lblTitullCrud.Location = new Point(449, 16);
            lblTitullCrud.Name = "lblTitullCrud";
            lblTitullCrud.Size = new Size(316, 33);
            lblTitullCrud.TabIndex = 0;
            lblTitullCrud.Text = "📋Regjistrimi i Aeroplanit ";
            // 
            // pnlData
            // 
            pnlData.BackColor = Color.FromArgb(202, 209, 193);
            pnlData.Controls.Add(lbTitleData);
            pnlData.Controls.Add(dgData);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(0, 0);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(1214, 853);
            pnlData.TabIndex = 1;
            pnlData.Visible = false;
            // 
            // lbTitleData
            // 
            lbTitleData.AutoSize = true;
            lbTitleData.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitleData.Location = new Point(112, 26);
            lbTitleData.Name = "lbTitleData";
            lbTitleData.Size = new Size(273, 33);
            lbTitleData.TabIndex = 3;
            lbTitleData.Text = "Aviona te shtuar sot ✈️";
            // 
            // dgData
            // 
            dgData.AllowUserToAddRows = false;
            dgData.AllowUserToDeleteRows = false;
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Location = new Point(112, 81);
            dgData.Name = "dgData";
            dgData.ReadOnly = true;
            dgData.RowHeadersWidth = 51;
            dgData.Size = new Size(991, 330);
            dgData.TabIndex = 2;
            // 
            // pnlSeatMap
            // 
            pnlSeatMap.BackColor = Color.FromArgb(202, 209, 193);
            pnlSeatMap.Controls.Add(lblTitleSeatMap);
            pnlSeatMap.Controls.Add(pbSeatMap);
            pnlSeatMap.Dock = DockStyle.Fill;
            pnlSeatMap.Location = new Point(0, 0);
            pnlSeatMap.Name = "pnlSeatMap";
            pnlSeatMap.Size = new Size(1214, 853);
            pnlSeatMap.TabIndex = 2;
            // 
            // lblTitleSeatMap
            // 
            lblTitleSeatMap.AutoSize = true;
            lblTitleSeatMap.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleSeatMap.Location = new Point(112, 26);
            lblTitleSeatMap.Name = "lblTitleSeatMap";
            lblTitleSeatMap.Size = new Size(443, 33);
            lblTitleSeatMap.TabIndex = 2;
            lblTitleSeatMap.Text = "Paraqitja vizuale e avionit te selektuar:";
            // 
            // pbSeatMap
            // 
            pbSeatMap.BackgroundImage = Properties.Resources.FotoPreviewSeats;
            pbSeatMap.BackgroundImageLayout = ImageLayout.Stretch;
            pbSeatMap.Location = new Point(112, 81);
            pbSeatMap.Name = "pbSeatMap";
            pbSeatMap.Size = new Size(991, 330);
            pbSeatMap.TabIndex = 1;
            pbSeatMap.TabStop = false;
            // 
            // FrmCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1214, 853);
            Controls.Add(pnlCrud);
            Controls.Add(pnlSeatMap);
            Controls.Add(pnlData);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrud";
            Text = "FrmCrud";
            Load += FrmCrud_Load;
            pnlCrud.ResumeLayout(false);
            pnlCrud.PerformLayout();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            pnlSeatMap.ResumeLayout(false);
            pnlSeatMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSeatMap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCrud;
        private Panel pnlData;
        private Panel pnlSeatMap;
        private PictureBox pbSeatMap;
        private Label lbTitleData;
        private DataGridView dgData;
        private Label lblTitullCrud;
        private Label lblModeli;
        private Label lblTitleSeatMap;
        private ComboBox cbPlaneType;
        private Label lblMaxTravel;
        private Label lblNrID;
        private Label lblStatus;
        private Label lblNrSeats;
        private Label lblId;
        private TextBox txtPlaneId;
        private TextBox txtPlaneRegistration;
        private TextBox txtSeatNr;
        private TextBox txtMaxRange;
        private ComboBox cbPlaneStatus;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnEdit;
        private Button btnSwitchPanelSeatMap;
        private Button btnSwitchPanelData;
    }
}