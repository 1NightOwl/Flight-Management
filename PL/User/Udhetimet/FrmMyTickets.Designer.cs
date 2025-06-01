namespace FlightManagement.PL.User.Udhetimet
{
    partial class FrmMyTickets
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
            label1 = new Label();
            lblTicketCount = new Label();
            flpTickets = new FlowLayoutPanel();
            pnlSearch = new Panel();
            lblTotalPrice = new Label();
            flpTickets.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 3);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 0;
            // 
            // lblTicketCount
            // 
            lblTicketCount.AutoSize = true;
            lblTicketCount.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTicketCount.Location = new Point(34, 22);
            lblTicketCount.Name = "lblTicketCount";
            lblTicketCount.Size = new Size(386, 42);
            lblTicketCount.TabIndex = 0;
            lblTicketCount.Text = "🎫 Ju keni 3 bileta aktive";
            // 
            // flpTickets
            // 
            flpTickets.AutoScroll = true;
            flpTickets.BackColor = Color.FromArgb(202, 209, 193);
            flpTickets.Controls.Add(label1);
            flpTickets.Dock = DockStyle.Fill;
            flpTickets.FlowDirection = FlowDirection.TopDown;
            flpTickets.Location = new Point(0, 143);
            flpTickets.Name = "flpTickets";
            flpTickets.Padding = new Padding(10, 3, 10, 0);
            flpTickets.Size = new Size(1214, 710);
            flpTickets.TabIndex = 3;
            flpTickets.WrapContents = false;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(170, 190, 180);
            pnlSearch.Controls.Add(lblTotalPrice);
            pnlSearch.Controls.Add(lblTicketCount);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1214, 143);
            pnlSearch.TabIndex = 2;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(34, 76);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(263, 34);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "💰Totali i shpenzuar:";
            // 
            // FrmMyTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 853);
            Controls.Add(flpTickets);
            Controls.Add(pnlSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMyTickets";
            Text = "FrmMyTickets";
            Shown += FrmMyTickets_Shown;
            flpTickets.ResumeLayout(false);
            flpTickets.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblTicketCount;
        private FlowLayoutPanel flpTickets;
        private Panel pnlSearch;
        private Label lblTotalPrice;
    }
}