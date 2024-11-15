namespace Latihan_UTS_PBO_Terakhir
{
    partial class label4
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
            this.label1 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nohp = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Registrasi_ = new System.Windows.Forms.Button();
            this.notif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrasi";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(231, 164);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(292, 26);
            this.nama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nomor HP";
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(231, 251);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(292, 26);
            this.nohp.TabIndex = 4;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(231, 340);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(292, 26);
            this.username.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(231, 439);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(292, 26);
            this.password.TabIndex = 8;
            // 
            // Registrasi_
            // 
            this.Registrasi_.Location = new System.Drawing.Point(229, 515);
            this.Registrasi_.Name = "Registrasi_";
            this.Registrasi_.Size = new System.Drawing.Size(292, 52);
            this.Registrasi_.TabIndex = 9;
            this.Registrasi_.Text = "Registrasi";
            this.Registrasi_.UseVisualStyleBackColor = true;
            this.Registrasi_.Click += new System.EventHandler(this.Registrasi__Click);
            // 
            // notif
            // 
            this.notif.AutoSize = true;
            this.notif.Location = new System.Drawing.Point(235, 484);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(0, 20);
            this.notif.TabIndex = 10;
            // 
            // label4
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.notif);
            this.Controls.Add(this.Registrasi_);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.username);
            this.Controls.Add(this.nohp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label1);
            this.Name = "label4";
            this.Text = "Registrasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Registrasi_;
        private System.Windows.Forms.Label notif;
    }
}