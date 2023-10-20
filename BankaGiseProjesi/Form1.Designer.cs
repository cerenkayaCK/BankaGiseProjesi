namespace BankaGiseProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBekleyenler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            cmbMusteriler = new ComboBox();
            label3 = new Label();
            txtTcNo = new TextBox();
            btnEkle = new Button();
            btnSiradaki = new Button();
            lblIslem = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBekleyenler).BeginInit();
            SuspendLayout();
            // 
            // dgvBekleyenler
            // 
            dgvBekleyenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBekleyenler.Location = new Point(235, 44);
            dgvBekleyenler.Name = "dgvBekleyenler";
            dgvBekleyenler.RowTemplate.Height = 25;
            dgvBekleyenler.Size = new Size(256, 219);
            dgvBekleyenler.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("STIXNonUnicode", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(212, 18);
            label1.Name = "label1";
            label1.Size = new Size(313, 23);
            label1.TabIndex = 1;
            label1.Text = "BEKLEYEN MÜŞTERİLER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 54);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Müşteri Türü";
            // 
            // cmbMusteriler
            // 
            cmbMusteriler.FormattingEnabled = true;
            cmbMusteriler.Location = new Point(39, 72);
            cmbMusteriler.Name = "cmbMusteriler";
            cmbMusteriler.Size = new Size(175, 23);
            cmbMusteriler.TabIndex = 4;
            cmbMusteriler.SelectedIndexChanged += cmbMusteriler_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 98);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 5;
            label3.Text = "T.C. Kimlik Numarası";
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(39, 116);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(175, 23);
            txtTcNo.TabIndex = 6;
            // 
            // btnEkle
            // 
            btnEkle.Enabled = false;
            btnEkle.Location = new Point(39, 174);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(175, 25);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE VE SIRAYA GİR";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSiradaki
            // 
            btnSiradaki.Enabled = false;
            btnSiradaki.Location = new Point(39, 205);
            btnSiradaki.Name = "btnSiradaki";
            btnSiradaki.Size = new Size(175, 58);
            btnSiradaki.TabIndex = 8;
            btnSiradaki.Text = "SIRADAKİ";
            btnSiradaki.UseVisualStyleBackColor = true;
            btnSiradaki.Click += btnSiradaki_Click;
            // 
            // lblIslem
            // 
            lblIslem.BorderStyle = BorderStyle.Fixed3D;
            lblIslem.Location = new Point(157, 319);
            lblIslem.Name = "lblIslem";
            lblIslem.Size = new Size(334, 63);
            lblIslem.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 338);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 10;
            label4.Text = "İŞLEMDEKİ MÜŞTERİ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 407);
            Controls.Add(label4);
            Controls.Add(lblIslem);
            Controls.Add(btnSiradaki);
            Controls.Add(btnEkle);
            Controls.Add(txtTcNo);
            Controls.Add(label3);
            Controls.Add(cmbMusteriler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBekleyenler);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvBekleyenler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBekleyenler;
        private Label label1;
        private Label label2;
        private ComboBox cmbMusteriler;
        private Label label3;
        private TextBox txtTcNo;
        private Button btnEkle;
        private Button btnSiradaki;
        private Label lblIslem;
        private Label label4;
    }
}