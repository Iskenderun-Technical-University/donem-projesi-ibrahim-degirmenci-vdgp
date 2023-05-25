namespace KayıpEşyaOtomasyonu
{
    partial class Form2
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
            this.esyaismi = new System.Windows.Forms.TextBox();
            this.bulundugutarih = new System.Windows.Forms.TextBox();
            this.bulundugukonum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.düzenle = new System.Windows.Forms.Button();
            this.esyaarama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ara = new System.Windows.Forms.Button();
            this.yenile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // esyaismi
            // 
            this.esyaismi.Location = new System.Drawing.Point(12, 42);
            this.esyaismi.Name = "esyaismi";
            this.esyaismi.Size = new System.Drawing.Size(166, 23);
            this.esyaismi.TabIndex = 0;
            this.esyaismi.Text = "Eşya İsmi";
            this.esyaismi.TextChanged += new System.EventHandler(this.esyaismi_TextChanged);
            // 
            // bulundugutarih
            // 
            this.bulundugutarih.Location = new System.Drawing.Point(12, 82);
            this.bulundugutarih.Name = "bulundugutarih";
            this.bulundugutarih.Size = new System.Drawing.Size(166, 23);
            this.bulundugutarih.TabIndex = 1;
            this.bulundugutarih.Text = "Bulunduğu Tarih";
            this.bulundugutarih.TextChanged += new System.EventHandler(this.bulundugutarih_TextChanged);
            // 
            // bulundugukonum
            // 
            this.bulundugukonum.Location = new System.Drawing.Point(12, 122);
            this.bulundugukonum.Name = "bulundugukonum";
            this.bulundugukonum.Size = new System.Drawing.Size(166, 23);
            this.bulundugukonum.TabIndex = 2;
            this.bulundugukonum.Text = "Bulunduğu Konum";
            this.bulundugukonum.TextChanged += new System.EventHandler(this.bulundugukonum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bulunan eşya hakkında bilgi girin.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(284, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 353);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Veriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(499, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(12, 166);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 5;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(12, 195);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 6;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // düzenle
            // 
            this.düzenle.Location = new System.Drawing.Point(12, 224);
            this.düzenle.Name = "düzenle";
            this.düzenle.Size = new System.Drawing.Size(75, 23);
            this.düzenle.TabIndex = 7;
            this.düzenle.Text = "Düzenle";
            this.düzenle.UseVisualStyleBackColor = true;
            this.düzenle.Click += new System.EventHandler(this.düzenle_Click);
            // 
            // esyaarama
            // 
            this.esyaarama.Location = new System.Drawing.Point(12, 301);
            this.esyaarama.Name = "esyaarama";
            this.esyaarama.Size = new System.Drawing.Size(166, 23);
            this.esyaarama.TabIndex = 8;
            this.esyaarama.TextChanged += new System.EventHandler(this.esyaarama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Eşya Arama";
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(12, 339);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(75, 23);
            this.ara.TabIndex = 10;
            this.ara.Text = "Ara";
            this.ara.UseVisualStyleBackColor = true;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(469, 364);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(168, 23);
            this.yenile.TabIndex = 12;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.esyaarama);
            this.Controls.Add(this.düzenle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bulundugukonum);
            this.Controls.Add(this.bulundugutarih);
            this.Controls.Add(this.esyaismi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox esyaismi;
        private TextBox bulundugutarih;
        private TextBox bulundugukonum;
        private Label label1;
        private TabControl tabControl1;
        private Button ekle;
        private Button sil;
        private Button düzenle;
        private TextBox esyaarama;
        private Label label2;
        private Button ara;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button yenile;
    }
}