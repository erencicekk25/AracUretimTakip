using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UretimTakip.Business;
using UretimTakip.Business.Concrete;
using UretimTakip.Entities;

namespace UretimTakip
{
    public partial class Login : Form
    {
        SqlRepository<Admin> repoAdmin = new SqlRepository<Admin>();

        public Login()
        {
            InitializeComponent();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string pass = txt_password.Text;

            Admin admin = repoAdmin.GetBy(x=>x.UserName == name && x.Password == pass);

            if(admin != null)
            {
                MainMenu menu = new MainMenu();
                menu.ShowDialog();
            }
            else MessageBox.Show("Girdiğiniz kullanıcı adı veya parola hatalı!");
        }
    }
}
