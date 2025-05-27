namespace FlightManagement.PL.User.FluturimetPerdorues
{
    partial class UcFlightCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuy = new Button();
            pnlBuy = new Panel();
            pnlInformation = new Panel();
            pnlBuy.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.Teal;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(59, 52);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(132, 46);
            btnBuy.TabIndex = 5;
            btnBuy.Text = "Bli";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // pnlBuy
            // 
            pnlBuy.BackColor = Color.PowderBlue;
            pnlBuy.Controls.Add(btnBuy);
            pnlBuy.Dock = DockStyle.Left;
            pnlBuy.Location = new Point(0, 0);
            pnlBuy.Name = "pnlBuy";
            pnlBuy.Size = new Size(250, 151);
            pnlBuy.TabIndex = 6;
            // 
            // pnlInformation
            // 
            pnlInformation.Dock = DockStyle.Fill;
            pnlInformation.Location = new Point(250, 0);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(964, 151);
            pnlInformation.TabIndex = 7;
            // 
            // UcFlightCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlInformation);
            Controls.Add(pnlBuy);
            DoubleBuffered = true;
            Name = "UcFlightCard";
            Size = new Size(1214, 151);
            Load += UcFlightCard_Load;
            pnlBuy.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnBuy;
        private Panel pnlBuy;
        private Panel pnlInformation;
    }
}
