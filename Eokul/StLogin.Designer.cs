namespace Eokul
{
    partial class StLogin
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Pwsee = new System.Windows.Forms.Label();
            this.stPw = new System.Windows.Forms.TextBox();
            this.stAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.stID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(306, 158);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(47, 20);
            this.ErrorLabel.TabIndex = 17;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.Visible = false;
            this.ErrorLabel.Click += new System.EventHandler(this.ErrorLabel_Click);
            // 
            // Pwsee
            // 
            this.Pwsee.AutoSize = true;
            this.Pwsee.Location = new System.Drawing.Point(416, 97);
            this.Pwsee.Name = "Pwsee";
            this.Pwsee.Size = new System.Drawing.Size(108, 20);
            this.Pwsee.TabIndex = 16;
            this.Pwsee.Text = "Şifreyi göster";
            this.Pwsee.Click += new System.EventHandler(this.Pwsee_Click);
            // 
            // stPw
            // 
            this.stPw.Location = new System.Drawing.Point(310, 90);
            this.stPw.Name = "stPw";
            this.stPw.Size = new System.Drawing.Size(100, 27);
            this.stPw.TabIndex = 14;
            this.stPw.UseSystemPasswordChar = true;
            // 
            // stAd
            // 
            this.stAd.Location = new System.Drawing.Point(310, 57);
            this.stAd.Name = "stAd";
            this.stAd.Size = new System.Drawing.Size(100, 27);
            this.stAd.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(310, 181);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(92, 31);
            this.loginbutton.TabIndex = 10;
            this.loginbutton.Text = "Giriş Yap";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // stID
            // 
            this.stID.AutoSize = true;
            this.stID.Location = new System.Drawing.Point(273, 135);
            this.stID.Name = "stID";
            this.stID.Size = new System.Drawing.Size(31, 20);
            this.stID.TabIndex = 18;
            this.stID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(310, 128);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 27);
            this.txtID.TabIndex = 19;
            // 
            // StLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 302);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.stID);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Pwsee);
            this.Controls.Add(this.stPw);
            this.Controls.Add(this.stAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StLogin";
            this.Text = "Öğrenci Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label Pwsee;
        private System.Windows.Forms.TextBox stPw;
        private System.Windows.Forms.TextBox stAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label stID;
        private System.Windows.Forms.TextBox txtID;
    }
}

