namespace Latihan_UTS_PBO_Terakhir
{
    partial class Login
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
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login1 = new System.Windows.Forms.Button();
            this.notif = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(267, 168);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(239, 26);
            this.username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // Login1
            // 
            this.Login1.Location = new System.Drawing.Point(267, 355);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(239, 49);
            this.Login1.TabIndex = 5;
            this.Login1.Text = "Login";
            this.Login1.UseVisualStyleBackColor = true;
            this.Login1.Click += new System.EventHandler(this.Login1_Click);
            // 
            // notif
            // 
            this.notif.AutoSize = true;
            this.notif.Location = new System.Drawing.Point(271, 324);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(0, 20);
            this.notif.TabIndex = 7;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(267, 272);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(239, 26);
            this.password1.TabIndex = 8;
            this.password1.TextChanged += new System.EventHandler(this.password1_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.notif);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login1;
        private System.Windows.Forms.Label notif;
        private System.Windows.Forms.TextBox password1;
    }
}