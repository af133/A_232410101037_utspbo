using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Base;
namespace Latihan_UTS_PBO_Terakhir
{
    public partial class label4 : Form
    {
        public label4()
        {
            InitializeComponent();
        }

        private void Registrasi__Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nama.Text)) 
            {
                if (!string.IsNullOrEmpty(nohp.Text)) 
                {
                    if (!string.IsNullOrEmpty(username.Text)) 
                    {
                        if (!string.IsNullOrEmpty(password.Text)) 
                        {
                            DataBase.registrasi_(nama.Text,nohp.Text, username.Text,password.Text);
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else { notif.Text = "Password harus didddddisi"; notif.Visible = true; }
                    }
                    else { notif.Text = "Username harus diisirrrr"; notif.Visible = true; }
                }
                else { notif.Text = "No HP harus diisi"; notif.Visible = true; }
            }
            else { notif.Text = "Nama harus diisi";notif.Visible= true; }
        }
    }
}
