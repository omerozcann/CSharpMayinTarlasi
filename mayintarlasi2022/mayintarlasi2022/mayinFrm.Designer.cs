
namespace mayintarlasi2022
{
    partial class mayinFrm
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yenioyunbtn = new System.Windows.Forms.Button();
            this.mesajLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyun Alanı";
            // 
            // yenioyunbtn
            // 
            this.yenioyunbtn.Location = new System.Drawing.Point(229, 22);
            this.yenioyunbtn.Name = "yenioyunbtn";
            this.yenioyunbtn.Size = new System.Drawing.Size(117, 33);
            this.yenioyunbtn.TabIndex = 1;
            this.yenioyunbtn.Text = "Yeni Oyun";
            this.yenioyunbtn.UseVisualStyleBackColor = true;
            this.yenioyunbtn.Click += new System.EventHandler(this.yenioyunbtn_Click);
            // 
            // mesajLbl
            // 
            this.mesajLbl.AutoSize = true;
            this.mesajLbl.Location = new System.Drawing.Point(9, 30);
            this.mesajLbl.Name = "mesajLbl";
            this.mesajLbl.Size = new System.Drawing.Size(0, 17);
            this.mesajLbl.TabIndex = 2;
            // 
            // mayinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 370);
            this.Controls.Add(this.mesajLbl);
            this.Controls.Add(this.yenioyunbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "mayinFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yenioyunbtn;
        private System.Windows.Forms.Label mesajLbl;
    }
}

