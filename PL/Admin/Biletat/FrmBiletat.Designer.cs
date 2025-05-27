namespace FlightManagement.PL.Admin.Biletat
{
    partial class FrmBiletat
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
            dgvBiletat = new DataGridView();
            btnPranoZgjedhje = new Button();
            btnAnuloZgjedhje = new Button();
            cmbKlasaFilter = new ComboBox();
            lblTitulli = new Label();
            label2 = new Label();
            panelTitulli = new Panel();
            txtKerko = new TextBox();
            label1 = new Label();
            btnFresko = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBiletat).BeginInit();
            panelTitulli.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBiletat
            // 
            dgvBiletat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBiletat.Location = new Point(12, 106);
            dgvBiletat.Name = "dgvBiletat";
            dgvBiletat.ReadOnly = true;
            dgvBiletat.RowHeadersWidth = 51;
            dgvBiletat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBiletat.Size = new Size(1147, 626);
            dgvBiletat.TabIndex = 0;
            dgvBiletat.CellContentClick += dgvBiletat_CellContentClick;
            dgvBiletat.CellFormatting += dgvBiletat_CellFormatting;
            // 
            // btnPranoZgjedhje
            // 
            btnPranoZgjedhje.BackColor = SystemColors.ButtonFace;
            btnPranoZgjedhje.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPranoZgjedhje.ForeColor = Color.Green;
            btnPranoZgjedhje.Location = new Point(607, 750);
            btnPranoZgjedhje.Name = "btnPranoZgjedhje";
            btnPranoZgjedhje.Size = new Size(273, 60);
            btnPranoZgjedhje.TabIndex = 1;
            btnPranoZgjedhje.Text = "Prano";
            btnPranoZgjedhje.UseVisualStyleBackColor = false;
            btnPranoZgjedhje.Click += btnPranoZgjedhje_Click;
            // 
            // btnAnuloZgjedhje
            // 
            btnAnuloZgjedhje.BackColor = SystemColors.ButtonFace;
            btnAnuloZgjedhje.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnuloZgjedhje.ForeColor = Color.Red;
            btnAnuloZgjedhje.Location = new Point(886, 750);
            btnAnuloZgjedhje.Name = "btnAnuloZgjedhje";
            btnAnuloZgjedhje.Size = new Size(273, 60);
            btnAnuloZgjedhje.TabIndex = 2;
            btnAnuloZgjedhje.Text = "Anulo";
            btnAnuloZgjedhje.UseVisualStyleBackColor = false;
            btnAnuloZgjedhje.Click += btnAnuloZgjedhje_Click;
            // 
            // cmbKlasaFilter
            // 
            cmbKlasaFilter.BackColor = SystemColors.Window;
            cmbKlasaFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKlasaFilter.FormattingEnabled = true;
            cmbKlasaFilter.Location = new Point(209, 782);
            cmbKlasaFilter.Name = "cmbKlasaFilter";
            cmbKlasaFilter.Size = new Size(151, 28);
            cmbKlasaFilter.TabIndex = 3;
            // 
            // lblTitulli
            // 
            lblTitulli.BackColor = Color.Teal;
            lblTitulli.Dock = DockStyle.Fill;
            lblTitulli.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulli.ForeColor = Color.WhiteSmoke;
            lblTitulli.Location = new Point(0, 0);
            lblTitulli.Name = "lblTitulli";
            lblTitulli.Size = new Size(1171, 100);
            lblTitulli.TabIndex = 4;
            lblTitulli.Text = "Menaxhimi i Biletave";
            lblTitulli.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 750);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 5;
            label2.Text = "Filtrimi i Biletave";
            // 
            // panelTitulli
            // 
            panelTitulli.BackColor = Color.SteelBlue;
            panelTitulli.Controls.Add(lblTitulli);
            panelTitulli.Dock = DockStyle.Top;
            panelTitulli.Location = new Point(0, 0);
            panelTitulli.Name = "panelTitulli";
            panelTitulli.Size = new Size(1171, 100);
            panelTitulli.TabIndex = 6;
            // 
            // txtKerko
            // 
            txtKerko.Location = new Point(383, 783);
            txtKerko.Name = "txtKerko";
            txtKerko.Size = new Size(151, 27);
            txtKerko.TabIndex = 7;
            txtKerko.TextChanged += txtKerko_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(383, 750);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 8;
            label1.Text = "Emri i Pasagjerit";
            // 
            // btnFresko
            // 
            btnFresko.BackColor = SystemColors.ButtonFace;
            btnFresko.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFresko.Location = new Point(12, 750);
            btnFresko.Name = "btnFresko";
            btnFresko.Size = new Size(151, 60);
            btnFresko.TabIndex = 9;
            btnFresko.Text = "Fresko";
            btnFresko.UseVisualStyleBackColor = false;
            btnFresko.Click += FrmBiletat_Click;
            // 
            // FrmBiletat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1171, 853);
            Controls.Add(btnFresko);
            Controls.Add(label1);
            Controls.Add(txtKerko);
            Controls.Add(panelTitulli);
            Controls.Add(label2);
            Controls.Add(cmbKlasaFilter);
            Controls.Add(btnAnuloZgjedhje);
            Controls.Add(btnPranoZgjedhje);
            Controls.Add(dgvBiletat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBiletat";
            Text = "FrmBiletat";
            Click += FrmBiletat_Click;
            ((System.ComponentModel.ISupportInitialize)dgvBiletat).EndInit();
            panelTitulli.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBiletat;
        private Button btnPranoZgjedhje;
        private Button btnAnuloZgjedhje;
        private ComboBox cmbKlasaFilter;
        private Label lblTitulli;
        private Label label2;
        private Panel panelTitulli;
        private TextBox txtKerko;
        private Label label1;
        private Button btnFresko;
    }
}