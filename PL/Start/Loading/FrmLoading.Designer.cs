namespace FlightManagement.PL.Start.Loading
{
    partial class FrmLoading
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
            components = new System.ComponentModel.Container();
            pbLogo = new PictureBox();
            pnlBottom = new Panel();
            pnlLoad = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.BackgroundImage = Properties.Resources.Logo;
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo.Location = new Point(480, 91);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(522, 561);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.Transparent;
            pnlBottom.Controls.Add(pnlLoad);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 796);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1482, 57);
            pnlBottom.TabIndex = 1;
            // 
            // pnlLoad
            // 
            pnlLoad.BackColor = Color.LightSeaGreen;
            pnlLoad.Location = new Point(3, 3);
            pnlLoad.Name = "pnlLoad";
            pnlLoad.Size = new Size(50, 51);
            pnlLoad.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // FrmLoading
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.FotoBackLoading;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 853);
            Controls.Add(pnlBottom);
            Controls.Add(pbLogo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoading";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnlBottom;
        private Panel pnlLoad;
        private System.Windows.Forms.Timer timer1;
    }
}