using Data_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_UTS_PBO_Terakhir
{
    public partial class Halaman_Movie : Form
    {
        public Halaman_Movie()
        {
            InitializeComponent();
            AmbilData();
        }
        private void AmbilData()
        {
            DataTable dt = DataBase.readeData_();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void hapusFilm_Click(object sender, EventArgs e)
        {
            HapusFilm hapus = new HapusFilm();
            hapus.Show();
            this.Hide();
        }

        private void tambahFilm_Click(object sender, EventArgs e)
        {
            Tambah_Film tambah = new Tambah_Film();
            tambah.Show();
            this.Hide();
        }
    }
}
 