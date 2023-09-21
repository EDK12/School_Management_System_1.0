namespace Eokul
{
    partial class TchLogin
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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Pwsee = new System.Windows.Forms.Label();
            this.tchPw = new System.Windows.Forms.TextBox();
            this.tchAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(316, 156);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(47, 20);
            this.ErrorLabel.TabIndex = 24;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.Visible = false;
            // 
            // Pwsee
            // 
            this.Pwsee.AutoSize = true;
            this.Pwsee.Location = new System.Drawing.Point(454, 127);
            this.Pwsee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pwsee.Name = "Pwsee";
            this.Pwsee.Size = new System.Drawing.Size(108, 20);
            this.Pwsee.TabIndex = 23;
            this.Pwsee.Text = "Şifreyi göster";
            this.Pwsee.Click += new System.EventHandler(this.Pwsee_Click);
            // 
            // tchPw
            // 
            this.tchPw.Location = new System.Drawing.Point(321, 118);
            this.tchPw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tchPw.Name = "tchPw";
            this.tchPw.Size = new System.Drawing.Size(124, 27);
            this.tchPw.TabIndex = 22;
            this.tchPw.UseSystemPasswordChar = true;
            // 
            // tchAd
            // 
            this.tchAd.Location = new System.Drawing.Point(321, 77);
            this.tchAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tchAd.Name = "tchAd";
            this.tchAd.Size = new System.Drawing.Size(124, 27);
            this.tchAd.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(321, 184);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(115, 39);
            this.loginbutton.TabIndex = 18;
            this.loginbutton.Text = "Giriş Yap";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // TchLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 287);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Pwsee);
            this.Controls.Add(this.tchPw);
            this.Controls.Add(this.tchAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TchLogin";
            this.Text = "Öğretmen Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label Pwsee;
        private System.Windows.Forms.TextBox tchPw;
        private System.Windows.Forms.TextBox tchAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbutton;
    }
}