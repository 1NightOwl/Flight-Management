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
            numMaxRange = new NumericUpDown();
            numSeatNr = new NumericUpDown();
            btnSwitchPanelSeatMap = new Button();
            btnSwitchPanelData = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            cbPlaneStatus = new ComboBox();
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
            lblTitleData = new Label();
            dgData = new DataGridView();
            pnlSeatMap = new Panel();
            lblTitleSeatMap = new Label();
            pbSeatMap = new PictureBox();
            pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSeatNr).BeginInit();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            pnlSeatMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSeatMap).BeginInit();
            SuspendLayout();
            // 
            // pnlCrud
            // 
            pnlCrud.BackColor = Color.FromArgb(170, 190, 180);
            pnlCrud.Controls.Add(numMaxRange);
            pnlCrud.Controls.Add(numSeatNr);
            pnlCrud.Controls.Add(btnSwitchPanelSeatMap);
            pnlCrud.Controls.Add(btnSwitchPanelData);
            pnlCrud.Controls.Add(btnDelete);
            pnlCrud.Controls.Add(btnClear);
            pnlCrud.Controls.Add(btnEdit);
            pnlCrud.Controls.Add(btnAdd);
            pnlCrud.Controls.Add(cbPlaneStatus);
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
            pnlCrud.Location = new Point(0, 448);
            pnlCrud.Name = "pnlCrud";
            pnlCrud.Size = new Size(1214, 405);
            pnlCrud.TabIndex = 0;
            // 
            // numMaxRange
            // 
            numMaxRange.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numMaxRange.Location = new Point(857, 111);
            numMaxRange.Maximum = new decimal(new int[] { 18000, 0, 0, 0 });
            numMaxRange.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numMaxRange.Name = "numMaxRange";
            numMaxRange.Size = new Size(174, 27);
            numMaxRange.TabIndex = 20;
            numMaxRange.ThousandsSeparator = true;
            numMaxRange.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // numSeatNr
            // 
            numSeatNr.Location = new Point(505, 202);
            numSeatNr.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numSeatNr.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numSeatNr.Name = "numSeatNr";
            numSeatNr.Size = new Size(174, 27);
            numSeatNr.TabIndex = 19;
            numSeatNr.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // btnSwitchPanelSeatMap
            // 
            btnSwitchPanelSeatMap.BackColor = Color.FromArgb(130, 180, 175);
            btnSwitchPanelSeatMap.FlatStyle = FlatStyle.Flat;
            btnSwitchPanelSeatMap.Font = new Font("Times New Roman", 12F);
            btnSwitchPanelSeatMap.Location = new Point(1021, 3);
            btnSwitchPanelSeatMap.Name = "btnSwitchPanelSeatMap";
            btnSwitchPanelSeatMap.Size = new Size(185, 33);
            btnSwitchPanelSeatMap.TabIndex = 18;
            btnSwitchPanelSeatMap.Text = "💺 Pamje e vendeve";
            btnSwitchPanelSeatMap.UseVisualStyleBackColor = false;
            btnSwitchPanelSeatMap.Visible = false;
            btnSwitchPanelSeatMap.Click += btnSwitchPanelData_Click;
            // 
            // btnSwitchPanelData
            // 
            btnSwitchPanelData.BackColor = Color.FromArgb(130, 180, 175);
            btnSwitchPanelData.FlatStyle = FlatStyle.Flat;
            btnSwitchPanelData.Font = new Font("Times New Roman", 12F);
            btnSwitchPanelData.Location = new Point(990, 3);
            btnSwitchPanelData.Name = "btnSwitchPanelData";
            btnSwitchPanelData.Size = new Size(216, 33);
            btnSwitchPanelData.TabIndex = 17;
            btnSwitchPanelData.Text = "📝 Të dhënat e avionave";
            btnSwitchPanelData.UseVisualStyleBackColor = false;
            btnSwitchPanelData.Click += btnSwitchPanelSeatMap_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Times New Roman", 12F);
            btnDelete.Location = new Point(829, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 54);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Fshi";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Times New Roman", 12F);
            btnClear.Location = new Point(635, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 54);
            btnClear.TabIndex = 15;
            btnClear.Text = "Pastro";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Teal;
            btnEdit.Enabled = false;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Times New Roman", 12F);
            btnEdit.Location = new Point(441, 330);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(138, 54);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Nrdysho";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Times New Roman", 12F);
            btnAdd.Location = new Point(247, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 54);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Shto";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbPlaneStatus
            // 
            cbPlaneStatus.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPlaneStatus.FormattingEnabled = true;
            cbPlaneStatus.Location = new Point(857, 202);
            cbPlaneStatus.Name = "cbPlaneStatus";
            cbPlaneStatus.Size = new Size(174, 30);
            cbPlaneStatus.TabIndex = 12;
            // 
            // txtPlaneRegistration
            // 
            txtPlaneRegistration.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaneRegistration.Location = new Point(506, 108);
            txtPlaneRegistration.Name = "txtPlaneRegistration";
            txtPlaneRegistration.Size = new Size(174, 30);
            txtPlaneRegistration.TabIndex = 9;
            // 
            // txtPlaneId
            // 
            txtPlaneId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaneId.Location = new Point(147, 202);
            txtPlaneId.Name = "txtPlaneId";
            txtPlaneId.Size = new Size(174, 30);
            txtPlaneId.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(857, 176);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 23);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Statusi";
            // 
            // lblNrSeats
            // 
            lblNrSeats.AutoSize = true;
            lblNrSeats.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNrSeats.Location = new Point(502, 176);
            lblNrSeats.Name = "lblNrSeats";
            lblNrSeats.Size = new Size(149, 23);
            lblNrSeats.TabIndex = 6;
            lblNrSeats.Text = "Numri i Vendeve";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(147, 176);
            lblId.Name = "lblId";
            lblId.Size = new Size(139, 23);
            lblId.TabIndex = 5;
            lblId.Text = "ID e Aeroplanit";
            // 
            // lblMaxTravel
            // 
            lblMaxTravel.AutoSize = true;
            lblMaxTravel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxTravel.Location = new Point(857, 82);
            lblMaxTravel.Name = "lblMaxTravel";
            lblMaxTravel.Size = new Size(211, 23);
            lblMaxTravel.TabIndex = 4;
            lblMaxTravel.Text = "Rrezja Maksimale (km)";
            // 
            // lblNrID
            // 
            lblNrID.AutoSize = true;
            lblNrID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNrID.Location = new Point(502, 82);
            lblNrID.Name = "lblNrID";
            lblNrID.Size = new Size(178, 23);
            lblNrID.TabIndex = 3;
            lblNrID.Text = "Numri i Regjistrimit";
            // 
            // cbPlaneType
            // 
            cbPlaneType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPlaneType.FormattingEnabled = true;
            cbPlaneType.Location = new Point(147, 108);
            cbPlaneType.Name = "cbPlaneType";
            cbPlaneType.Size = new Size(174, 30);
            cbPlaneType.TabIndex = 2;
            cbPlaneType.SelectedIndexChanged += cbPlaneType_SelectedIndexChanged;
            // 
            // lblModeli
            // 
            lblModeli.AutoSize = true;
            lblModeli.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeli.Location = new Point(147, 82);
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
            pnlData.Controls.Add(lblTitleData);
            pnlData.Controls.Add(dgData);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(0, 0);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(1214, 853);
            pnlData.TabIndex = 1;
            pnlData.Visible = false;
            // 
            // lblTitleData
            // 
            lblTitleData.AutoSize = true;
            lblTitleData.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleData.Location = new Point(112, 26);
            lblTitleData.Name = "lblTitleData";
            lblTitleData.Size = new Size(273, 33);
            lblTitleData.TabIndex = 3;
            lblTitleData.Text = "✈️Avione te shtuar me:";
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
            dgData.CellClick += dgData_CellClick;
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
            lblTitleSeatMap.Size = new Size(475, 33);
            lblTitleSeatMap.TabIndex = 2;
            lblTitleSeatMap.Text = "💺Paraqitja vizuale e avionit te selektuar:";
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
            Controls.Add(pnlData);
            Controls.Add(pnlSeatMap);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrud";
            Text = "FrmCrud";
            Load += FrmCrud_Load;
            pnlCrud.ResumeLayout(false);
            pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSeatNr).EndInit();
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
        private Label lblTitleData;
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
        private ComboBox cbPlaneStatus;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnEdit;
        private Button btnSwitchPanelData;
        private Button btnSwitchPanelSeatMap;
        private NumericUpDown numSeatNr;
        private NumericUpDown numMaxRange;
    }
}