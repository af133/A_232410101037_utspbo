namespace Latihan_UTS_PBO_Terakhir
{
    partial class Form1
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
            this.kontak = new System.Windows.Forms.Button();
            this.registrasi = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang";
            // 
            // kontak
            // 
            this.kontak.AutoSize = true;
            this.kontak.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kontak.Location = new System.Drawing.Point(157, 253);
            this.kontak.Name = "kontak";
            this.kontak.Size = new System.Drawing.Size(122, 57);
            this.kontak.TabIndex = 1;
            this.kontak.Text = "Kontak";
            this.kontak.UseVisualStyleBackColor = false;
            this.kontak.Click += new System.EventHandler(this.kontak_Click);
            // 
            // registrasi
            // 
            this.registrasi.Location = new System.Drawing.Point(322, 253);
            this.registrasi.Name = "registrasi";
            this.registrasi.Size = new System.Drawing.Size(119, 57);
            this.registrasi.TabIndex = 2;
            this.registrasi.Text = "Registrasi";
            this.registrasi.UseVisualStyleBackColor = true;
            this.registrasi.Click += new System.EventHandler(this.registrasi_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(493, 253);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(110, 57);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.registrasi);
            this.Controls.Add(this.kontak);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kontak;
        private System.Windows.Forms.Button registrasi;
        private System.Windows.Forms.Button login;
    }
}

