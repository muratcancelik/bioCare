
namespace bioCare2.PanelEkranlari
{
    partial class personelGoster
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelGoster));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_PersonelSil = new System.Windows.Forms.Button();
            this.btn_PersonelEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 580);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 10);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 556);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 24);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(975, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 546);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.btnYenile);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btn_PersonelSil);
            this.panel5.Controls.Add(this.btn_PersonelEkle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(965, 63);
            this.panel5.TabIndex = 12;
            // 
            // btnYenile
            // 
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(388, 0);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(155, 63);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "      Yenile";
            this.btnYenile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(613, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Personeller";
            // 
            // btn_PersonelSil
            // 
            this.btn_PersonelSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PersonelSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_PersonelSil.FlatAppearance.BorderSize = 0;
            this.btn_PersonelSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_PersonelSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PersonelSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PersonelSil.ForeColor = System.Drawing.Color.White;
            this.btn_PersonelSil.Image = ((System.Drawing.Image)(resources.GetObject("btn_PersonelSil.Image")));
            this.btn_PersonelSil.Location = new System.Drawing.Point(233, 0);
            this.btn_PersonelSil.Name = "btn_PersonelSil";
            this.btn_PersonelSil.Size = new System.Drawing.Size(155, 63);
            this.btn_PersonelSil.TabIndex = 1;
            this.btn_PersonelSil.Text = "      Sil";
            this.btn_PersonelSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PersonelSil.UseVisualStyleBackColor = true;
            this.btn_PersonelSil.Click += new System.EventHandler(this.btn_PersonelSil_Click);
            // 
            // btn_PersonelEkle
            // 
            this.btn_PersonelEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PersonelEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_PersonelEkle.FlatAppearance.BorderSize = 0;
            this.btn_PersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PersonelEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PersonelEkle.ForeColor = System.Drawing.Color.White;
            this.btn_PersonelEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_PersonelEkle.Image")));
            this.btn_PersonelEkle.Location = new System.Drawing.Point(0, 0);
            this.btn_PersonelEkle.Name = "btn_PersonelEkle";
            this.btn_PersonelEkle.Size = new System.Drawing.Size(233, 63);
            this.btn_PersonelEkle.TabIndex = 0;
            this.btn_PersonelEkle.Text = "       Personel Ekle";
            this.btn_PersonelEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PersonelEkle.UseVisualStyleBackColor = true;
            this.btn_PersonelEkle.Click += new System.EventHandler(this.btn_PersonelEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 483);
            this.dataGridView1.TabIndex = 13;
            // 
            // personelGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "personelGoster";
            this.Size = new System.Drawing.Size(985, 580);
            this.Load += new System.EventHandler(this.personelGoster_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_PersonelSil;
        private System.Windows.Forms.Button btn_PersonelEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
