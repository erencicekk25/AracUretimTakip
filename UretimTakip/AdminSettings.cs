using Microsoft.Data.SqlClient;
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
    public partial class AdminSettings : Form
    {
        SqlRepository<User> repoUser = new SqlRepository<User>();
        public AdminSettings()
        {
            InitializeComponent();
            txt_namesurname.Text = null;
            txt_username.Text = null;
            txt_userpassword.Text = null;
        }

        private void Update()
        {
            User user = repoUser.GetBy(x => x.UserName == dataGridView1.CurrentRow.Cells["UserName"].Value.ToString());
            User user1 = repoUser.GetBy(x => x.UserName == txt_username.Text);
            if (user1 != null)
            {
                MessageBox.Show("Böyle bir kullanıcı adı zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user.UserName = txt_username.Text;
                user.Password = txt_userpassword.Text;
                repoUser.Update(user);
                MessageBox.Show("Kullanıcı başarılı bir şekilde güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_namesurname.Text = null;
                txt_username.Text = null;
                txt_userpassword.Text = null;
                TUMUNU_ARA();
            }
        }

        private void Sil()
        {
            User user = repoUser.GetBy(x => x.UserName == txt_username.Text);
            repoUser.Delete(user);
            MessageBox.Show("Kullanıcı başarılı bir şekilde silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TUMUNU_ARA();
        }

        private void TUMUNU_ARA()
        {
            SqlConnection BaglantiAdresi = new SqlConnection();
            BaglantiAdresi.ConnectionString = "Data Source =LAPTOP-DAF3DSF2\\SQLEXPRESS; Initial Catalog = UretimProje; Integrated Security = True";
            BaglantiAdresi.Open();
            SqlCommand cmd = new SqlCommand("select * from Users");

            cmd.Connection = BaglantiAdresi;

            DataSet ds = new DataSet("Users");
            ds.Clear();
            DataTable dt = new DataTable("Users");

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(dt);
            ds.Tables.Add(dt);

            dataGridView1.DataSource = ds.Tables["Users"];

            BaglantiAdresi.Close();

            dataGridView1.Columns[0].Width = 30;  //id
            dataGridView1.Columns[1].Width = 100; //name
            dataGridView1.Columns[2].Width = 100; //username
            dataGridView1.Columns[3].Width = 100; //password

        }

        private bool IsValid()
        {
            if (txt_namesurname.Text == null || txt_username.Text == null || txt_userpassword.Text == null)
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
            User user = new User();
            User userr = repoUser.GetBy(x => x.UserName == txt_username.Text.Trim());


            if (IsValid())
            {
                if (userr != null)
                {
                    if (userr.UserName == txt_username.Text.Trim())
                    {
                        MessageBox.Show("Bu kullanıcı adında bir kullanıcı zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (txt_namesurname.Text.Trim().Length > 4 && txt_username.Text.Trim().Length > 4 && txt_userpassword.Text.Trim().Length > 8)
                {
                    user.NameSurname = txt_namesurname.Text;
                    user.UserName = txt_username.Text;
                    user.Password = txt_userpassword.Text;
                    repoUser.Add(user);
                    MessageBox.Show("Kullanıcı başarılı bir şekilde kayıt edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TUMUNU_ARA();
                    txt_namesurname.Text = null;
                    txt_username.Text = null;
                    txt_userpassword.Text = null;
                }
                else MessageBox.Show("Kullanıcı eklenirken doldurulması gereken alanları doldurduğunuzdan emin olun. Lütfen tekrar kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_namesurname.Text = dataGridView1.CurrentRow.Cells["NameSurname"].Value.ToString();
            txt_username.Text = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();
            txt_userpassword.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            TUMUNU_ARA();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
