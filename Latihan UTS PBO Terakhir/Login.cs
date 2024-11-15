using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Data_Base;
namespace Latihan_UTS_PBO_Terakhir
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(password1.Text))
                {
                    bool hasilAkun = DataBase.cekLogin(username.Text,password1.Text);
                    if (hasilAkun == true)
                    {
                       Dasboard db= new Dasboard();
                        db.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        notif.Text = "Tidak ditemukan";
                        notif.Visible = true;
                    }
                }
                else
                {
                    notif.Text = "User dan pw harus diisi";
                    notif.Visible = true;
                }
            }
            catch (Exception ex) 
            { 
                notif.Text= "Error: "+ex.Message;
                notif.Visible = true;
            }
            }

        private void password1_TextChanged(object sender, EventArgs e)
        {
            password1.PasswordChar = '*';

        }
    }
    }

