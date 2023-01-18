using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UretimTakip.Business.Concrete;
using UretimTakip.Entities;

namespace UretimTakip
{
    public partial class UserSettings : Form
    {
        SqlRepository<User> repoUser = new SqlRepository<User>();
        public UserSettings()
        {
            InitializeComponent();
            txt_newpassword.Text = null;
            txt_newusername.Text = null;
            txt_oldpassword.Text = null;
            txt_oldusername.Text = null;
        }

        private bool IsValid()
        {
            if (txt_oldpassword.Text == null || txt_oldusername.Text == null || txt_newusername.Text == null || txt_newpassword.Text == null)
            {
                return false;
            }
            return true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            User user = repoUser.GetBy(x => x.UserName == txt_oldusername.Text.Trim());

            if (IsValid())
            {
                if (user != null)
                {
                    if (user.UserName == txt_newusername.Text.Trim()) MessageBox.Show("Aynı bilileri tekrar girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (user.UserName == txt_oldusername.Text.Trim() && user.Password == txt_oldpassword.Text.Trim())
                    {
                        user.UserName = txt_newusername.Text.Trim();
                        user.Password = txt_newpassword.Text.Trim();
                        repoUser.Update(user);
                        MessageBox.Show("Başarılı bir şekilde güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_newpassword.Text = null;
                        txt_newusername.Text = null;
                        txt_oldpassword.Text = null;
                        txt_oldusername.Text = null;
                    }

                }

                else if (user == null) {  MessageBox.Show("Bilgilerin doğru olduğundan emin olum!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                else MessageBox.Show("Doldurulması gereken yerlerin dolu olduğundan emin olum!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
