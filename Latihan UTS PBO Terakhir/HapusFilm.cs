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
    public partial class HapusFilm : Form
    {
        public HapusFilm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Halaman_Movie halaman = new Halaman_Movie();
            halaman.Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(hapus_.Text)) 
            {
                string id = hapus_.Text ;
                int id_ = Convert.ToInt32(id);
                DataBase.hapusFilm(id_);
                Halaman_Movie halaman = new Halaman_Movie();
                halaman.Show();
                this.Hide();

            }
            else
            {
                notif.Text = "Isi id";
                notif.Visible = true;
            }
        }
    }
}
