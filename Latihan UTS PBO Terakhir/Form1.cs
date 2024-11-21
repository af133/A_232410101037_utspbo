using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_UTS_PBO_Terakhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {Login login= new Login();
            login.Show();
            this.Hide();
        }

        private void registrasi_Click(object sender, EventArgs e)
        {
            label4 register = new label4();
            register.Show();
            this.Hide();
        }

    }
}
