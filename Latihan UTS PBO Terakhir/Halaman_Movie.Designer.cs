namespace Latihan_UTS_PBO_Terakhir
{
    partial class Halaman_Movie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tambahFilm = new System.Windows.Forms.Button();
            this.ubahFilm = new System.Windows.Forms.Button();
            this.hapusFilm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tambahFilm
            // 
            this.tambahFilm.Location = new System.Drawing.Point(99, 365);
            this.tambahFilm.Name = "tambahFilm";
            this.tambahFilm.Size = new System.Drawing.Size(148, 60);
            this.tambahFilm.TabIndex = 1;
            this.tambahFilm.Text = "Tambah Film";
            this.tambahFilm.UseVisualStyleBackColor = true;
            this.tambahFilm.Click += new System.EventHandler(this.tambahFilm_Click);
            // 
            // ubahFilm
            // 
            this.ubahFilm.Location = new System.Drawing.Point(540, 365);
            this.ubahFilm.Name = "ubahFilm";
            this.ubahFilm.Size = new System.Drawing.Size(149, 60);
            this.ubahFilm.TabIndex = 2;
            this.ubahFilm.Text = "Ubah Film";
            this.ubahFilm.UseVisualStyleBackColor = true;
            // 
            // hapusFilm
            // 
            this.hapusFilm.Location = new System.Drawing.Point(300, 365);
            this.hapusFilm.Name = "hapusFilm";
            this.hapusFilm.Size = new System.Drawing.Size(162, 60);
            this.hapusFilm.TabIndex = 3;
            this.hapusFilm.Text = "Hapus Film\r\n";
            this.hapusFilm.UseVisualStyleBackColor = true;
            this.hapusFilm.Click += new System.EventHandler(this.hapusFilm_Click);
            // 
            // Halaman_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hapusFilm);
            this.Controls.Add(this.ubahFilm);
            this.Controls.Add(this.tambahFilm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Halaman_Movie";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tambahFilm;
        private System.Windows.Forms.Button ubahFilm;
        private System.Windows.Forms.Button hapusFilm;
    }
}