namespace FlightManagement.PL.Admin.Fluturimet
{
    partial class FrmFlightRoutes
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
            dgPlaneRouteList = new DataGridView();
            btnSwitchPanelInput = new Button();
            btnSwitchPanelList = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lbTitleRouteList = new Label();
            pnlRouteList = new Panel();
            txtPlaneId = new TextBox();
            lblArrivalTime = new Label();
            lblId = new Label();
            lblDepartTime = new Label();
            lblDepartureAirport = new Label();
            cbPlaneType = new ComboBox();
            lblModeli = new Label();
            lblTitleRoute = new Label();
            lblTitleRouteInput = new Label();
            pnlCrud = new Panel();
            cbStatus = new ComboBox();
            lblStatus = new Label();
            numPrice = new NumericUpDown();
            btnShowClasses = new Button();
            cbDepartDay = new ComboBox();
            dtArrival = new DateTimePicker();
            dtDeparture = new DateTimePicker();
            cbDestination = new ComboBox();
            cbOrigin = new ComboBox();
            lblDepartureDay = new Label();
            lblSeatPrice = new Label();
            lblArrivalAirport = new Label();
            pnlRouteInput = new Panel();
            dgAviablePlanes = new DataGridView();
            pnlPlaneClasses = new Panel();
            lblFirstClass = new Label();
            lblBusiness = new Label();
            lblEconomy = new Label();
            lblPlaneClasses = new Label();
            ((System.ComponentModel.ISupportInitialize)dgPlaneRouteList).BeginInit();
            pnlRouteList.SuspendLayout();
            pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            pnlRouteInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAviablePlanes).BeginInit();
            pnlPlaneClasses.SuspendLayout();
            SuspendLayout();
            // 
            // dgPlaneRouteList
            // 
            dgPlaneRouteList.AllowUserToAddRows = false;
            dgPlaneRouteList.AllowUserToDeleteRows = false;
            dgPlaneRouteList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPlaneRouteList.Location = new Point(112, 81);
            dgPlaneRouteList.Name = "dgPlaneRouteList";
            dgPlaneRouteList.ReadOnly = true;
            dgPlaneRouteList.RowHeadersWidth = 51;
            dgPlaneRouteList.Size = new Size(991, 330);
            dgPlaneRouteList.TabIndex = 2;
            dgPlaneRouteList.CellClick += dgPlaneRouteList_CellClick;
            // 
            // btnSwitchPanelInput
            // 
            btnSwitchPanelInput.BackColor = Color.FromArgb(130, 180, 175);
            btnSwitchPanelInput.FlatStyle = FlatStyle.Flat;
            btnSwitchPanelInput.Font = new Font("Times New Roman", 12F);
            btnSwitchPanelInput.Location = new Point(1010, 3);
            btnSwitchPanelInput.Name = "btnSwitchPanelInput";
            btnSwitchPanelInput.Size = new Size(196, 33);
            btnSwitchPanelInput.TabIndex = 18;
            btnSwitchPanelInput.Text = "📋 Itinerarët ekzistues";
            btnSwitchPanelInput.UseVisualStyleBackColor = false;
            btnSwitchPanelInput.Click += btnSwitchPanelInput_Click;
            // 
            // btnSwitchPanelList
            // 
            btnSwitchPanelList.BackColor = Color.FromArgb(130, 180, 175);
            btnSwitchPanelList.FlatStyle = FlatStyle.Flat;
            btnSwitchPanelList.Font = new Font("Times New Roman", 12F);
            btnSwitchPanelList.Location = new Point(1056, 3);
            btnSwitchPanelList.Name = "btnSwitchPanelList";
            btnSwitchPanelList.Size = new Size(150, 33);
            btnSwitchPanelList.TabIndex = 17;
            btnSwitchPanelList.Text = "📝 Shto itinerar";
            btnSwitchPanelList.UseVisualStyleBackColor = false;
            btnSwitchPanelList.Click += btnSwitchPanelList_Click;
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
            // lbTitleRouteList
            // 
            lbTitleRouteList.AutoSize = true;
            lbTitleRouteList.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitleRouteList.Location = new Point(112, 26);
            lbTitleRouteList.Name = "lbTitleRouteList";
            lbTitleRouteList.Size = new Size(467, 33);
            lbTitleRouteList.TabIndex = 3;
            lbTitleRouteList.Text = "🛫Fluturime aktive për avionët ekzistues";
            // 
            // pnlRouteList
            // 
            pnlRouteList.BackColor = Color.FromArgb(202, 209, 193);
            pnlRouteList.Controls.Add(lbTitleRouteList);
            pnlRouteList.Controls.Add(dgPlaneRouteList);
            pnlRouteList.Dock = DockStyle.Fill;
            pnlRouteList.Location = new Point(0, 0);
            pnlRouteList.Name = "pnlRouteList";
            pnlRouteList.Size = new Size(1214, 853);
            pnlRouteList.TabIndex = 4;
            pnlRouteList.Visible = false;
            // 
            // txtPlaneId
            // 
            txtPlaneId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaneId.Location = new Point(62, 217);
            txtPlaneId.Name = "txtPlaneId";
            txtPlaneId.Size = new Size(174, 30);
            txtPlaneId.TabIndex = 8;
            // 
            // lblArrivalTime
            // 
            lblArrivalTime.AutoSize = true;
            lblArrivalTime.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrivalTime.Location = new Point(562, 191);
            lblArrivalTime.Name = "lblArrivalTime";
            lblArrivalTime.Size = new Size(154, 23);
            lblArrivalTime.TabIndex = 7;
            lblArrivalTime.Text = "Ora e Mbërritjes";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(56, 191);
            lblId.Name = "lblId";
            lblId.Size = new Size(139, 23);
            lblId.TabIndex = 5;
            lblId.Text = "ID e Aeroplanit";
            // 
            // lblDepartTime
            // 
            lblDepartTime.AutoSize = true;
            lblDepartTime.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartTime.Location = new Point(558, 97);
            lblDepartTime.Name = "lblDepartTime";
            lblDepartTime.Size = new Size(116, 23);
            lblDepartTime.TabIndex = 4;
            lblDepartTime.Text = "Ora e Nisjes";
            // 
            // lblDepartureAirport
            // 
            lblDepartureAirport.AutoSize = true;
            lblDepartureAirport.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartureAirport.Location = new Point(319, 97);
            lblDepartureAirport.Name = "lblDepartureAirport";
            lblDepartureAirport.Size = new Size(159, 23);
            lblDepartureAirport.TabIndex = 3;
            lblDepartureAirport.Text = "Aeroporti i Nisjes";
            // 
            // cbPlaneType
            // 
            cbPlaneType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPlaneType.FormattingEnabled = true;
            cbPlaneType.Location = new Point(61, 123);
            cbPlaneType.Name = "cbPlaneType";
            cbPlaneType.Size = new Size(174, 30);
            cbPlaneType.TabIndex = 2;
            cbPlaneType.SelectedIndexChanged += cbPlaneType_SelectedIndexChanged;
            // 
            // lblModeli
            // 
            lblModeli.AutoSize = true;
            lblModeli.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModeli.Location = new Point(59, 97);
            lblModeli.Name = "lblModeli";
            lblModeli.Size = new Size(227, 23);
            lblModeli.TabIndex = 1;
            lblModeli.Text = "Modeli / Lloji i Aeroplanit";
            // 
            // lblTitleRoute
            // 
            lblTitleRoute.AutoSize = true;
            lblTitleRoute.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleRoute.ForeColor = Color.Teal;
            lblTitleRoute.Location = new Point(391, 16);
            lblTitleRoute.Name = "lblTitleRoute";
            lblTitleRoute.Size = new Size(432, 33);
            lblTitleRoute.TabIndex = 0;
            lblTitleRoute.Text = "📍 Caktimi i Itinerarit për Aeroplanin";
            // 
            // lblTitleRouteInput
            // 
            lblTitleRouteInput.AutoSize = true;
            lblTitleRouteInput.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleRouteInput.Location = new Point(112, 26);
            lblTitleRouteInput.Name = "lblTitleRouteInput";
            lblTitleRouteInput.Size = new Size(466, 33);
            lblTitleRouteInput.TabIndex = 2;
            lblTitleRouteInput.Text = "✈️Avionë të gatshëm për caktim itinerari";
            // 
            // pnlCrud
            // 
            pnlCrud.BackColor = Color.FromArgb(170, 190, 180);
            pnlCrud.Controls.Add(cbStatus);
            pnlCrud.Controls.Add(lblStatus);
            pnlCrud.Controls.Add(numPrice);
            pnlCrud.Controls.Add(btnShowClasses);
            pnlCrud.Controls.Add(cbDepartDay);
            pnlCrud.Controls.Add(dtArrival);
            pnlCrud.Controls.Add(dtDeparture);
            pnlCrud.Controls.Add(cbDestination);
            pnlCrud.Controls.Add(cbOrigin);
            pnlCrud.Controls.Add(lblDepartureDay);
            pnlCrud.Controls.Add(lblSeatPrice);
            pnlCrud.Controls.Add(btnSwitchPanelInput);
            pnlCrud.Controls.Add(btnSwitchPanelList);
            pnlCrud.Controls.Add(btnDelete);
            pnlCrud.Controls.Add(btnClear);
            pnlCrud.Controls.Add(btnEdit);
            pnlCrud.Controls.Add(btnAdd);
            pnlCrud.Controls.Add(txtPlaneId);
            pnlCrud.Controls.Add(lblArrivalTime);
            pnlCrud.Controls.Add(lblArrivalAirport);
            pnlCrud.Controls.Add(lblId);
            pnlCrud.Controls.Add(lblDepartTime);
            pnlCrud.Controls.Add(lblDepartureAirport);
            pnlCrud.Controls.Add(cbPlaneType);
            pnlCrud.Controls.Add(lblModeli);
            pnlCrud.Controls.Add(lblTitleRoute);
            pnlCrud.Dock = DockStyle.Bottom;
            pnlCrud.Location = new Point(0, 448);
            pnlCrud.Name = "pnlCrud";
            pnlCrud.Size = new Size(1214, 405);
            pnlCrud.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(1010, 174);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(174, 30);
            cbStatus.TabIndex = 38;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(1010, 148);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 23);
            lblStatus.TabIndex = 37;
            lblStatus.Text = "Statusi";
            // 
            // numPrice
            // 
            numPrice.Location = new Point(791, 126);
            numPrice.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numPrice.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(175, 27);
            numPrice.TabIndex = 36;
            numPrice.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnShowClasses
            // 
            btnShowClasses.BackColor = Color.FromArgb(130, 180, 175);
            btnShowClasses.FlatStyle = FlatStyle.Flat;
            btnShowClasses.Font = new Font("Times New Roman", 12F);
            btnShowClasses.Location = new Point(1056, 42);
            btnShowClasses.Name = "btnShowClasses";
            btnShowClasses.Size = new Size(150, 36);
            btnShowClasses.TabIndex = 35;
            btnShowClasses.Text = "📋 Shfaq klasat";
            btnShowClasses.UseVisualStyleBackColor = false;
            btnShowClasses.Click += btnShowClasses_Click;
            // 
            // cbDepartDay
            // 
            cbDepartDay.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDepartDay.FormattingEnabled = true;
            cbDepartDay.Location = new Point(792, 217);
            cbDepartDay.Name = "cbDepartDay";
            cbDepartDay.Size = new Size(174, 30);
            cbDepartDay.TabIndex = 34;
            // 
            // dtArrival
            // 
            dtArrival.CustomFormat = "HH:mm";
            dtArrival.Format = DateTimePickerFormat.Custom;
            dtArrival.Location = new Point(562, 220);
            dtArrival.Name = "dtArrival";
            dtArrival.ShowUpDown = true;
            dtArrival.Size = new Size(164, 27);
            dtArrival.TabIndex = 26;
            // 
            // dtDeparture
            // 
            dtDeparture.CustomFormat = "HH:mm";
            dtDeparture.Format = DateTimePickerFormat.Custom;
            dtDeparture.Location = new Point(558, 126);
            dtDeparture.Name = "dtDeparture";
            dtDeparture.ShowUpDown = true;
            dtDeparture.Size = new Size(168, 27);
            dtDeparture.TabIndex = 25;
            dtDeparture.Value = new DateTime(2025, 5, 17, 22, 32, 0, 0);
            // 
            // cbDestination
            // 
            cbDestination.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDestination.FormattingEnabled = true;
            cbDestination.Location = new Point(321, 217);
            cbDestination.Name = "cbDestination";
            cbDestination.Size = new Size(174, 30);
            cbDestination.TabIndex = 24;
            cbDestination.SelectedIndexChanged += cbDestination_SelectedIndexChanged;
            // 
            // cbOrigin
            // 
            cbOrigin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOrigin.FormattingEnabled = true;
            cbOrigin.Location = new Point(321, 123);
            cbOrigin.Name = "cbOrigin";
            cbOrigin.Size = new Size(174, 30);
            cbOrigin.TabIndex = 23;
            cbOrigin.SelectedIndexChanged += cbOrigin_SelectedIndexChanged;
            // 
            // lblDepartureDay
            // 
            lblDepartureDay.AutoSize = true;
            lblDepartureDay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartureDay.Location = new Point(792, 191);
            lblDepartureDay.Name = "lblDepartureDay";
            lblDepartureDay.Size = new Size(153, 23);
            lblDepartureDay.TabIndex = 20;
            lblDepartureDay.Text = "Dita e Aktivitetit";
            // 
            // lblSeatPrice
            // 
            lblSeatPrice.AutoSize = true;
            lblSeatPrice.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeatPrice.Location = new Point(792, 97);
            lblSeatPrice.Name = "lblSeatPrice";
            lblSeatPrice.Size = new Size(203, 23);
            lblSeatPrice.TabIndex = 19;
            lblSeatPrice.Text = "Çmimi për Vend (EUR)";
            // 
            // lblArrivalAirport
            // 
            lblArrivalAirport.AutoSize = true;
            lblArrivalAirport.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArrivalAirport.Location = new Point(321, 191);
            lblArrivalAirport.Name = "lblArrivalAirport";
            lblArrivalAirport.Size = new Size(197, 23);
            lblArrivalAirport.TabIndex = 6;
            lblArrivalAirport.Text = "Aeroporti i Mbërritjes";
            // 
            // pnlRouteInput
            // 
            pnlRouteInput.BackColor = Color.FromArgb(202, 209, 193);
            pnlRouteInput.Controls.Add(dgAviablePlanes);
            pnlRouteInput.Controls.Add(lblTitleRouteInput);
            pnlRouteInput.Dock = DockStyle.Fill;
            pnlRouteInput.Location = new Point(0, 0);
            pnlRouteInput.Name = "pnlRouteInput";
            pnlRouteInput.Size = new Size(1214, 853);
            pnlRouteInput.TabIndex = 5;
            // 
            // dgAviablePlanes
            // 
            dgAviablePlanes.AllowUserToAddRows = false;
            dgAviablePlanes.AllowUserToDeleteRows = false;
            dgAviablePlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAviablePlanes.Location = new Point(112, 81);
            dgAviablePlanes.Name = "dgAviablePlanes";
            dgAviablePlanes.ReadOnly = true;
            dgAviablePlanes.RowHeadersWidth = 51;
            dgAviablePlanes.Size = new Size(991, 330);
            dgAviablePlanes.TabIndex = 3;
            dgAviablePlanes.CellClick += dgAviablePlanes_CellClick;
            // 
            // pnlPlaneClasses
            // 
            pnlPlaneClasses.BackColor = Color.FromArgb(202, 209, 193);
            pnlPlaneClasses.Controls.Add(lblFirstClass);
            pnlPlaneClasses.Controls.Add(lblBusiness);
            pnlPlaneClasses.Controls.Add(lblEconomy);
            pnlPlaneClasses.Controls.Add(lblPlaneClasses);
            pnlPlaneClasses.Dock = DockStyle.Fill;
            pnlPlaneClasses.Location = new Point(0, 0);
            pnlPlaneClasses.Name = "pnlPlaneClasses";
            pnlPlaneClasses.Size = new Size(1214, 853);
            pnlPlaneClasses.TabIndex = 6;
            pnlPlaneClasses.Visible = false;
            // 
            // lblFirstClass
            // 
            lblFirstClass.AutoSize = true;
            lblFirstClass.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstClass.Location = new Point(112, 318);
            lblFirstClass.Name = "lblFirstClass";
            lblFirstClass.Size = new Size(135, 23);
            lblFirstClass.TabIndex = 6;
            lblFirstClass.Text = "👑 Klasa First:";
            // 
            // lblBusiness
            // 
            lblBusiness.AutoSize = true;
            lblBusiness.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusiness.Location = new Point(112, 209);
            lblBusiness.Name = "lblBusiness";
            lblBusiness.Size = new Size(168, 23);
            lblBusiness.TabIndex = 5;
            lblBusiness.Text = "💼 Klasa Business:";
            // 
            // lblEconomy
            // 
            lblEconomy.AutoSize = true;
            lblEconomy.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEconomy.Location = new Point(112, 100);
            lblEconomy.Name = "lblEconomy";
            lblEconomy.Size = new Size(116, 23);
            lblEconomy.TabIndex = 4;
            lblEconomy.Text = "💺Economy:";
            // 
            // lblPlaneClasses
            // 
            lblPlaneClasses.AutoSize = true;
            lblPlaneClasses.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlaneClasses.Location = new Point(112, 26);
            lblPlaneClasses.Name = "lblPlaneClasses";
            lblPlaneClasses.Size = new Size(241, 33);
            lblPlaneClasses.TabIndex = 3;
            lblPlaneClasses.Text = "🎫Klaset e avionit:  ";
            // 
            // FrmFlightRoutes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 853);
            Controls.Add(pnlCrud);
            Controls.Add(pnlRouteInput);
            Controls.Add(pnlPlaneClasses);
            Controls.Add(pnlRouteList);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFlightRoutes";
            Text = "FrmFlightRoutes";
            Load += FrmFlightRoutes_Load;
            ((System.ComponentModel.ISupportInitialize)dgPlaneRouteList).EndInit();
            pnlRouteList.ResumeLayout(false);
            pnlRouteList.PerformLayout();
            pnlCrud.ResumeLayout(false);
            pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            pnlRouteInput.ResumeLayout(false);
            pnlRouteInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAviablePlanes).EndInit();
            pnlPlaneClasses.ResumeLayout(false);
            pnlPlaneClasses.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgPlaneRouteList;
        private Button btnSwitchPanelInput;
        private Button btnSwitchPanelList;
        private Button btnDelete;
        private Button btnClear;
        private Button btnEdit;
        private Button btnAdd;
        private Label lbTitleRouteList;
        private Panel pnlRouteList;
        private TextBox txtPlaneId;
        private Label lblArrivalTime;
        private Label lblId;
        private Label lblDepartTime;
        private Label lblDepartureAirport;
        private ComboBox cbPlaneType;
        private Label lblModeli;
        private Label lblTitleRoute;
        private Label lblTitleRouteInput;
        private Panel pnlCrud;
        private Label lblArrivalAirport;
        private Panel pnlRouteInput;
        private Label lblDepartureDay;
        private Label lblSeatPrice;
        private DateTimePicker dtArrival;
        private DateTimePicker dtDeparture;
        private ComboBox cbDestination;
        private ComboBox cbOrigin;
        private DataGridView dgAviablePlanes;
        private ComboBox cbDepartDay;
        private Panel pnlPlaneClasses;
        private Label lblPlaneClasses;
        private Label lblFirstClass;
        private Label lblBusiness;
        private Label lblEconomy;
        private Button btnShowClasses;
        private NumericUpDown numPrice;
        private ComboBox cbStatus;
        private Label lblStatus;
    }
}