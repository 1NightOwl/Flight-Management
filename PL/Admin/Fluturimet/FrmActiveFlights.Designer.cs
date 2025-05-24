namespace FlightManagement.PL.Admin.Fluturimet
{
    partial class FrmActiveFlights
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
            btnRouteSwitch = new Button();
            btnActivePlaneSwtich = new Button();
            btnPdfExport = new Button();
            btnWeekly = new Button();
            btnExcelExport = new Button();
            lblTitleRoute = new Label();
            lblTitleRouteInput = new Label();
            pnlActivePlanes = new Panel();
            dgActivePlanes = new DataGridView();
            lbTitleRouteList = new Label();
            dgSelectedPlaneRoute = new DataGridView();
            pnlOptions = new Panel();
            pnlRouteList = new Panel();
            pnlActivePlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgActivePlanes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSelectedPlaneRoute).BeginInit();
            pnlOptions.SuspendLayout();
            pnlRouteList.SuspendLayout();
            SuspendLayout();
            // 
            // btnRouteSwitch
            // 
            btnRouteSwitch.BackColor = Color.FromArgb(130, 180, 175);
            btnRouteSwitch.Enabled = false;
            btnRouteSwitch.FlatStyle = FlatStyle.Flat;
            btnRouteSwitch.Font = new Font("Times New Roman", 12F);
            btnRouteSwitch.Location = new Point(1010, 3);
            btnRouteSwitch.Name = "btnRouteSwitch";
            btnRouteSwitch.Size = new Size(196, 33);
            btnRouteSwitch.TabIndex = 18;
            btnRouteSwitch.Text = "🗺️ Shiko Itenerarin";
            btnRouteSwitch.UseVisualStyleBackColor = false;
            btnRouteSwitch.Click += btnRouteSwitch_Click;
            // 
            // btnActivePlaneSwtich
            // 
            btnActivePlaneSwtich.BackColor = Color.FromArgb(130, 180, 175);
            btnActivePlaneSwtich.FlatStyle = FlatStyle.Flat;
            btnActivePlaneSwtich.Font = new Font("Times New Roman", 12F);
            btnActivePlaneSwtich.Location = new Point(997, 3);
            btnActivePlaneSwtich.Name = "btnActivePlaneSwtich";
            btnActivePlaneSwtich.Size = new Size(209, 33);
            btnActivePlaneSwtich.TabIndex = 17;
            btnActivePlaneSwtich.Text = "📝 Shiko Avionet Aktiv";
            btnActivePlaneSwtich.UseVisualStyleBackColor = false;
            btnActivePlaneSwtich.Visible = false;
            btnActivePlaneSwtich.Click += btnActivePlaneSwtich_Click;
            // 
            // btnPdfExport
            // 
            btnPdfExport.BackColor = Color.Teal;
            btnPdfExport.FlatStyle = FlatStyle.Popup;
            btnPdfExport.Font = new Font("Times New Roman", 12F);
            btnPdfExport.Location = new Point(103, 173);
            btnPdfExport.Name = "btnPdfExport";
            btnPdfExport.Size = new Size(228, 80);
            btnPdfExport.TabIndex = 16;
            btnPdfExport.Text = "📄 Eksport në PDF";
            btnPdfExport.UseVisualStyleBackColor = false;
            // 
            // btnWeekly
            // 
            btnWeekly.BackColor = Color.Teal;
            btnWeekly.FlatStyle = FlatStyle.Popup;
            btnWeekly.Font = new Font("Times New Roman", 12F);
            btnWeekly.Location = new Point(614, 119);
            btnWeekly.Name = "btnWeekly";
            btnWeekly.Size = new Size(228, 80);
            btnWeekly.TabIndex = 15;
            btnWeekly.Text = "🗓️Shfaq Orarin Javor";
            btnWeekly.UseVisualStyleBackColor = false;
            // 
            // btnExcelExport
            // 
            btnExcelExport.BackColor = Color.Teal;
            btnExcelExport.FlatStyle = FlatStyle.Popup;
            btnExcelExport.Font = new Font("Times New Roman", 12F);
            btnExcelExport.Location = new Point(103, 68);
            btnExcelExport.Name = "btnExcelExport";
            btnExcelExport.Size = new Size(228, 80);
            btnExcelExport.TabIndex = 13;
            btnExcelExport.Text = "📊 Eksporto në Excel";
            btnExcelExport.UseVisualStyleBackColor = false;
            // 
            // lblTitleRoute
            // 
            lblTitleRoute.AutoSize = true;
            lblTitleRoute.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleRoute.ForeColor = Color.Teal;
            lblTitleRoute.Location = new Point(294, 16);
            lblTitleRoute.Name = "lblTitleRoute";
            lblTitleRoute.Size = new Size(627, 33);
            lblTitleRoute.TabIndex = 0;
            lblTitleRoute.Text = "📌 Opsione të disponueshme për avionin e përzgjedhur";
            // 
            // lblTitleRouteInput
            // 
            lblTitleRouteInput.AutoSize = true;
            lblTitleRouteInput.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleRouteInput.Location = new Point(64, 26);
            lblTitleRouteInput.Name = "lblTitleRouteInput";
            lblTitleRouteInput.Size = new Size(414, 33);
            lblTitleRouteInput.TabIndex = 2;
            lblTitleRouteInput.Text = "✈️ Lista e avionëve aktivë në sistem";
            // 
            // pnlActivePlanes
            // 
            pnlActivePlanes.BackColor = Color.FromArgb(202, 209, 193);
            pnlActivePlanes.Controls.Add(dgActivePlanes);
            pnlActivePlanes.Controls.Add(lblTitleRouteInput);
            pnlActivePlanes.Dock = DockStyle.Fill;
            pnlActivePlanes.Location = new Point(0, 0);
            pnlActivePlanes.Name = "pnlActivePlanes";
            pnlActivePlanes.Size = new Size(1214, 853);
            pnlActivePlanes.TabIndex = 8;
            // 
            // dgActivePlanes
            // 
            dgActivePlanes.AllowUserToAddRows = false;
            dgActivePlanes.AllowUserToDeleteRows = false;
            dgActivePlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgActivePlanes.Location = new Point(64, 81);
            dgActivePlanes.Name = "dgActivePlanes";
            dgActivePlanes.ReadOnly = true;
            dgActivePlanes.RowHeadersWidth = 51;
            dgActivePlanes.Size = new Size(1080, 447);
            dgActivePlanes.TabIndex = 3;
            dgActivePlanes.CellClick += dgActivePlanes_CellClick;
            // 
            // lbTitleRouteList
            // 
            lbTitleRouteList.AutoSize = true;
            lbTitleRouteList.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitleRouteList.Location = new Point(64, 26);
            lbTitleRouteList.Name = "lbTitleRouteList";
            lbTitleRouteList.Size = new Size(421, 33);
            lbTitleRouteList.TabIndex = 3;
            lbTitleRouteList.Text = "🛫 Itinerarët e avionit të përzgjedhur";
            // 
            // dgSelectedPlaneRoute
            // 
            dgSelectedPlaneRoute.AllowUserToAddRows = false;
            dgSelectedPlaneRoute.AllowUserToDeleteRows = false;
            dgSelectedPlaneRoute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSelectedPlaneRoute.Location = new Point(64, 81);
            dgSelectedPlaneRoute.Name = "dgSelectedPlaneRoute";
            dgSelectedPlaneRoute.ReadOnly = true;
            dgSelectedPlaneRoute.RowHeadersWidth = 51;
            dgSelectedPlaneRoute.Size = new Size(1080, 447);
            dgSelectedPlaneRoute.TabIndex = 2;
            // 
            // pnlOptions
            // 
            pnlOptions.BackColor = Color.FromArgb(170, 190, 180);
            pnlOptions.Controls.Add(btnRouteSwitch);
            pnlOptions.Controls.Add(btnActivePlaneSwtich);
            pnlOptions.Controls.Add(btnPdfExport);
            pnlOptions.Controls.Add(btnWeekly);
            pnlOptions.Controls.Add(btnExcelExport);
            pnlOptions.Controls.Add(lblTitleRoute);
            pnlOptions.Dock = DockStyle.Bottom;
            pnlOptions.Location = new Point(0, 576);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(1214, 277);
            pnlOptions.TabIndex = 6;
            // 
            // pnlRouteList
            // 
            pnlRouteList.BackColor = Color.FromArgb(202, 209, 193);
            pnlRouteList.Controls.Add(lbTitleRouteList);
            pnlRouteList.Controls.Add(dgSelectedPlaneRoute);
            pnlRouteList.Dock = DockStyle.Fill;
            pnlRouteList.Location = new Point(0, 0);
            pnlRouteList.Name = "pnlRouteList";
            pnlRouteList.Size = new Size(1214, 853);
            pnlRouteList.TabIndex = 7;
            pnlRouteList.Visible = false;
            // 
            // FrmActiveFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 853);
            Controls.Add(pnlOptions);
            Controls.Add(pnlActivePlanes);
            Controls.Add(pnlRouteList);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmActiveFlights";
            Text = "FrmActiveFlights";
            Load += FrmActiveFlights_Load;
            pnlActivePlanes.ResumeLayout(false);
            pnlActivePlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgActivePlanes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSelectedPlaneRoute).EndInit();
            pnlOptions.ResumeLayout(false);
            pnlOptions.PerformLayout();
            pnlRouteList.ResumeLayout(false);
            pnlRouteList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRouteSwitch;
        private Button btnActivePlaneSwtich;
        private Button btnPdfExport;
        private Button btnWeekly;
        private Button btnExcelExport;
        private Label lblTitleRoute;
        private Label lblTitleRouteInput;
        private Panel pnlActivePlanes;
        private Label lbTitleRouteList;
        private DataGridView dgSelectedPlaneRoute;
        private Panel pnlOptions;
        private Panel pnlRouteList;
        private DataGridView dgActivePlanes;
    }
}