namespace FlightManagement.PL.User.Flights
{
    partial class FrmBrowseFlights
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
            pnlSearch = new Panel();
            lblPeople = new Label();
            numPasangers = new NumericUpDown();
            btnSearch = new Button();
            rbOneWay = new RadioButton();
            rbReturn = new RadioButton();
            chkDirect = new CheckBox();
            dtReturn = new DateTimePicker();
            lblReturn = new Label();
            dtDepart = new DateTimePicker();
            cbTo = new ComboBox();
            cbFrom = new ComboBox();
            lblDepart = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            lblHeader = new Label();
            flpTickets = new FlowLayoutPanel();
            label1 = new Label();
            btnClear = new Button();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPasangers).BeginInit();
            flpTickets.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(170, 190, 180);
            pnlSearch.Controls.Add(btnClear);
            pnlSearch.Controls.Add(lblPeople);
            pnlSearch.Controls.Add(numPasangers);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(rbOneWay);
            pnlSearch.Controls.Add(rbReturn);
            pnlSearch.Controls.Add(chkDirect);
            pnlSearch.Controls.Add(dtReturn);
            pnlSearch.Controls.Add(lblReturn);
            pnlSearch.Controls.Add(dtDepart);
            pnlSearch.Controls.Add(cbTo);
            pnlSearch.Controls.Add(cbFrom);
            pnlSearch.Controls.Add(lblDepart);
            pnlSearch.Controls.Add(lblTo);
            pnlSearch.Controls.Add(lblFrom);
            pnlSearch.Controls.Add(lblHeader);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1214, 233);
            pnlSearch.TabIndex = 0;
            // 
            // lblPeople
            // 
            lblPeople.AutoSize = true;
            lblPeople.Font = new Font("Times New Roman", 12F);
            lblPeople.Location = new Point(410, 96);
            lblPeople.Name = "lblPeople";
            lblPeople.Size = new Size(157, 22);
            lblPeople.TabIndex = 16;
            lblPeople.Text = "Numri i personave";
            // 
            // numPasangers
            // 
            numPasangers.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPasangers.Location = new Point(410, 121);
            numPasangers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPasangers.Name = "numPasangers";
            numPasangers.Size = new Size(127, 30);
            numPasangers.TabIndex = 15;
            numPasangers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Times New Roman", 12F);
            btnSearch.Location = new Point(827, 110);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(156, 41);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Kerko";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // rbOneWay
            // 
            rbOneWay.AutoSize = true;
            rbOneWay.Font = new Font("Times New Roman", 12F);
            rbOneWay.Location = new Point(182, 64);
            rbOneWay.Name = "rbOneWay";
            rbOneWay.Size = new Size(101, 26);
            rbOneWay.TabIndex = 11;
            rbOneWay.TabStop = true;
            rbOneWay.Text = "One way";
            rbOneWay.UseVisualStyleBackColor = true;
            rbOneWay.CheckedChanged += rbOneWay_CheckedChanged;
            // 
            // rbReturn
            // 
            rbReturn.AutoSize = true;
            rbReturn.Font = new Font("Times New Roman", 12F);
            rbReturn.Location = new Point(44, 64);
            rbReturn.Name = "rbReturn";
            rbReturn.Size = new Size(116, 26);
            rbReturn.TabIndex = 10;
            rbReturn.TabStop = true;
            rbReturn.Text = "Return trip";
            rbReturn.UseVisualStyleBackColor = true;
            rbReturn.CheckedChanged += rbReturn_CheckedChanged;
            // 
            // chkDirect
            // 
            chkDirect.AutoSize = true;
            chkDirect.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDirect.Location = new Point(43, 169);
            chkDirect.Name = "chkDirect";
            chkDirect.Size = new Size(175, 26);
            chkDirect.TabIndex = 9;
            chkDirect.Text = "Direct flights only";
            chkDirect.UseVisualStyleBackColor = true;
            chkDirect.CheckedChanged += chkDirect_CheckedChanged;
            // 
            // dtReturn
            // 
            dtReturn.CustomFormat = "dd/MM/yyyy";
            dtReturn.Font = new Font("Times New Roman", 12F);
            dtReturn.Format = DateTimePickerFormat.Custom;
            dtReturn.Location = new Point(605, 185);
            dtReturn.MinDate = new DateTime(2025, 5, 27, 0, 0, 0, 0);
            dtReturn.Name = "dtReturn";
            dtReturn.Size = new Size(189, 30);
            dtReturn.TabIndex = 8;
            dtReturn.Value = new DateTime(2025, 5, 27, 0, 0, 0, 0);
            // 
            // lblReturn
            // 
            lblReturn.AutoSize = true;
            lblReturn.Font = new Font("Times New Roman", 12F);
            lblReturn.Location = new Point(605, 160);
            lblReturn.Name = "lblReturn";
            lblReturn.Size = new Size(83, 22);
            lblReturn.TabIndex = 7;
            lblReturn.Text = "📅Return";
            // 
            // dtDepart
            // 
            dtDepart.CustomFormat = "dd/MM/yyyy";
            dtDepart.Font = new Font("Times New Roman", 12F);
            dtDepart.Format = DateTimePickerFormat.Custom;
            dtDepart.Location = new Point(605, 121);
            dtDepart.MinDate = new DateTime(2025, 5, 29, 0, 0, 0, 0);
            dtDepart.Name = "dtDepart";
            dtDepart.Size = new Size(189, 30);
            dtDepart.TabIndex = 6;
            dtDepart.Value = new DateTime(2025, 5, 29, 0, 0, 0, 0);
            dtDepart.ValueChanged += dtDepart_ValueChanged;
            // 
            // cbTo
            // 
            cbTo.Font = new Font("Times New Roman", 12F);
            cbTo.FormattingEnabled = true;
            cbTo.Location = new Point(214, 121);
            cbTo.Name = "cbTo";
            cbTo.Size = new Size(162, 30);
            cbTo.TabIndex = 5;
            cbTo.SelectedIndexChanged += cbTo_SelectedIndexChanged;
            // 
            // cbFrom
            // 
            cbFrom.Font = new Font("Times New Roman", 12F);
            cbFrom.FormattingEnabled = true;
            cbFrom.Location = new Point(43, 121);
            cbFrom.Name = "cbFrom";
            cbFrom.Size = new Size(162, 30);
            cbFrom.TabIndex = 4;
            cbFrom.SelectedIndexChanged += cbFrom_SelectedIndexChanged;
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Times New Roman", 12F);
            lblDepart.Location = new Point(605, 96);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(85, 22);
            lblDepart.TabIndex = 3;
            lblDepart.Text = "📅Depart";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Times New Roman", 12F);
            lblTo.Location = new Point(214, 96);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(31, 22);
            lblTo.TabIndex = 2;
            lblTo.Text = "To";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Times New Roman", 12F);
            lblFrom.Location = new Point(43, 96);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(52, 22);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "From";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(35, 13);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(230, 34);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "✈ Browse Flights";
            // 
            // flpTickets
            // 
            flpTickets.AutoScroll = true;
            flpTickets.BackColor = Color.FromArgb(202, 209, 193);
            flpTickets.Controls.Add(label1);
            flpTickets.Dock = DockStyle.Fill;
            flpTickets.FlowDirection = FlowDirection.TopDown;
            flpTickets.Location = new Point(0, 233);
            flpTickets.Name = "flpTickets";
            flpTickets.Padding = new Padding(10, 3, 10, 0);
            flpTickets.Size = new Size(1214, 620);
            flpTickets.TabIndex = 1;
            flpTickets.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 3);
            label1.Name = "label1";
            label1.Size = new Size(341, 35);
            label1.TabIndex = 0;
            label1.Text = "Nuk u gjet asnjë fluturim.";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Times New Roman", 12F);
            btnClear.Location = new Point(1010, 110);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 41);
            btnClear.TabIndex = 17;
            btnClear.Text = "Pastro";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // FrmBrowseFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 853);
            Controls.Add(flpTickets);
            Controls.Add(pnlSearch);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBrowseFlights";
            Text = "FrmBrowseFlights";
            Load += FrmBrowseFlights_Load;
            Shown += FrmBrowseFlights_Shown;
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPasangers).EndInit();
            flpTickets.ResumeLayout(false);
            flpTickets.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSearch;
        private FlowLayoutPanel flpTickets;
        private Label lblHeader;
        private Label lblDepart;
        private Label lblTo;
        private Label lblFrom;
        private ComboBox cbTo;
        private ComboBox cbFrom;
        private DateTimePicker dtDepart;
        private DateTimePicker dtReturn;
        private Label lblReturn;
        private RadioButton rbOneWay;
        private RadioButton rbReturn;
        private CheckBox chkDirect;
        private Button btnSearch;
        private Label lblPeople;
        private NumericUpDown numPasangers;
        private Label label1;
        private Button btnClear;
    }
}