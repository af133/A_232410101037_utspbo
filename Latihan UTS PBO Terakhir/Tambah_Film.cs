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
    public partial class Tambah_Film : Form
    {
        public Tambah_Film()
        {
            InitializeComponent();
            AmbilData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Halaman_Movie halaman = new Halaman_Movie();
            halaman.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void AmbilData()
        {
            DataTable dt = DataBase.readGenre();
            dataGridView1.DataSource = dt;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string id = id_genre.Text;
            int id_ = Convert.ToInt32(id);
            DataBase.addMovie(nama.Text, tahun_rilis.Text, id_);
            Halaman_Movie movie = new Halaman_Movie();
            movie.Show();
            this.Hide();
        }
    }
}
