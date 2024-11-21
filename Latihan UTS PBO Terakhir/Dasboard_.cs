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
    public partial class Dasboard : Form
    {
        public Dasboard()
        {
            InitializeComponent();
            ambilData();
        }
        public void ambilData()
        {
            DataTable dt = DataBase.readeData();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ubah_Click(object sender, EventArgs e)
        {
            
        }
    }
}
