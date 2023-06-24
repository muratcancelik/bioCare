
namespace bioCare2.PanelEkranlari
{
    partial class logGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logGoster));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_SatisLog = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UrunLog = new System.Windows.Forms.Button();
            this.btn_MusteriLog = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 580);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 10);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 556);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 24);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(975, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 546);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.btn_SatisLog);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btn_UrunLog);
            this.panel5.Controls.Add(this.btn_MusteriLog);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(965, 63);
            this.panel5.TabIndex = 13;
            // 
            // btn_SatisLog
            // 
            this.btn_SatisLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SatisLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_SatisLog.FlatAppearance.BorderSize = 0;
            this.btn_SatisLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SatisLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SatisLog.ForeColor = System.Drawing.Color.White;
            this.btn_SatisLog.Image = ((System.Drawing.Image)(resources.GetObject("btn_SatisLog.Image")));
            this.btn_SatisLog.Location = new System.Drawing.Point(428, 0);
            this.btn_SatisLog.Name = "btn_SatisLog";
            this.btn_SatisLog.Size = new System.Drawing.Size(203, 63);
            this.btn_SatisLog.TabIndex = 5;
            this.btn_SatisLog.Text = "      Satis Loglari";
            this.btn_SatisLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SatisLog.UseVisualStyleBackColor = true;
            this.btn_SatisLog.Click += new System.EventHandler(this.btn_SatisLog_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(708, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loglar";
            // 
            // btn_UrunLog
            // 
            this.btn_UrunLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UrunLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_UrunLog.FlatAppearance.BorderSize = 0;
            this.btn_UrunLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_UrunLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UrunLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UrunLog.ForeColor = System.Drawing.Color.White;
            this.btn_UrunLog.Image = ((System.Drawing.Image)(resources.GetObject("btn_UrunLog.Image")));
            this.btn_UrunLog.Location = new System.Drawing.Point(233, 0);
            this.btn_UrunLog.Name = "btn_UrunLog";
            this.btn_UrunLog.Size = new System.Drawing.Size(195, 63);
            this.btn_UrunLog.TabIndex = 1;
            this.btn_UrunLog.Text = "      Urun Loglari";
            this.btn_UrunLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UrunLog.UseVisualStyleBackColor = true;
            this.btn_UrunLog.Click += new System.EventHandler(this.btn_UrunLog_Click);
            // 
            // btn_MusteriLog
            // 
            this.btn_MusteriLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MusteriLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_MusteriLog.FlatAppearance.BorderSize = 0;
            this.btn_MusteriLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MusteriLog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MusteriLog.ForeColor = System.Drawing.Color.White;
            this.btn_MusteriLog.Image = ((System.Drawing.Image)(resources.GetObject("btn_MusteriLog.Image")));
            this.btn_MusteriLog.Location = new System.Drawing.Point(0, 0);
            this.btn_MusteriLog.Name = "btn_MusteriLog";
            this.btn_MusteriLog.Size = new System.Drawing.Size(233, 63);
            this.btn_MusteriLog.TabIndex = 0;
            this.btn_MusteriLog.Text = "       Musteri Loglari";
            this.btn_MusteriLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MusteriLog.UseVisualStyleBackColor = true;
            this.btn_MusteriLog.Click += new System.EventHandler(this.btn_MusteriLog_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(965, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 73);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(965, 483);
            this.panel7.TabIndex = 15;
            // 
            // logGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "logGoster";
            this.Size = new System.Drawing.Size(985, 580);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_SatisLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UrunLog;
        private System.Windows.Forms.Button btn_MusteriLog;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}
