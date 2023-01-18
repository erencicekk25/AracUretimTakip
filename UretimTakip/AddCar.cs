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
using Type = UretimTakip.Entities.Type;

namespace UretimTakip
{
    public partial class AddCar : Form
    {
        //Database ile ilişkimizi sağlayacağımız bir kere yazdığımız Generic sınıfımızın nesnesini örnekledik.
        SqlRepository<Vehicle> repoVehicle = new SqlRepository<Vehicle>();
        SqlRepository<Type> repoType = new SqlRepository<Type>();


        private void TUMUNU_ARA() 
        {
            SqlConnection BaglantiAdresi = new SqlConnection(); //Yeni bağlantı
            // Connection string
            BaglantiAdresi.ConnectionString = "Data Source =LAPTOP-DAF3DSF2\\SQLEXPRESS; Initial Catalog = UretimProje; Integrated Security = True";
            //Bağlantıyı açtık
            BaglantiAdresi.Open();
            //Komut oluşturduk
            SqlCommand cmd = new SqlCommand("select * from Vehicles");

            cmd.Connection = BaglantiAdresi;

            DataSet ds = new DataSet("Vehicles");
            ds.Clear();
            DataTable dt = new DataTable("Vehicles");

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(dt);
            ds.Tables.Add(dt);

            dataGridView1.DataSource = ds.Tables["Vehicles"]; //gride kaynak olarak Araç tablomuzu verdik

            BaglantiAdresi.Close();

            //Griddeki hücre boyutlarını düzenledik

            dataGridView1.Columns[0].Width = 30;  //id
            dataGridView1.Columns[1].Width = 100; //brand
            dataGridView1.Columns[2].Width = 100; //model
            dataGridView1.Columns[3].Width = 100; //fueltype
            dataGridView1.Columns[4].Width = 100; //startdate
            dataGridView1.Columns[5].Width = 100; //enddate
            dataGridView1.Columns[6].Width = 75;  //cost
            dataGridView1.Columns[7].Width = 75;  //price
            dataGridView1.Columns[8].Width = 75;  //IsSold
            dataGridView1.Columns[9].Width = 75;  //VehiclePlate
            dataGridView1.Columns[10].Width = 30; //TypeId

            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//startdate
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//enddate
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//cost
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//price
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//IsSold
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//VehiclePlate

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                if (dataGridView1.Rows[i].Cells[10].Value.ToString().Trim() == "1")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (dataGridView1.Rows[i].Cells[10].Value.ToString().Trim() == "2")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (dataGridView1.Rows[i].Cells[10].Value.ToString().Trim() == "3")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }

            }
        }


        public AddCar()
        {
            InitializeComponent();

            // Tüm kategorileri getirdik.
            IEnumerable<Type> types = repoType.GetAll();

            foreach (Type type in types) //getirdiğimiz kategorilerde foreach ile döndük ve her birini combobox'ın item'ına ekledik.
            {
                cmb_type.Items.Add(type.TypeName);
            }
            cmb_type.Text = "";
            txt_brand.Text = "";
            txt_cost.Text = "";
            txt_fuel.Text = "";
            txt_model.Text = "";
            txt_plate.Text = "";
            txt_price.Text = "";


        }

        private bool IsValid() // Form üzerindeki nesneler dolu mu boş mu?
        {
            if (txt_plate.Text == "" || txt_model.Text == "" || txt_brand.Text == "" || txt_fuel.Text == "" || cmb_type.Text == "" || txt_price.Text == "" || txt_cost.Text == "")
            {
                return false;
            }
            return true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongTimeString(); // Form üzerinde anlık saati aldığımız yer.
        }


        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            IEnumerable<Vehicle> vehicles = repoVehicle.GetAll(); //Veri tabanındaki tüm araçları çektik.
            Type type = repoType.GetBy(x => x.TypeName == cmb_type.Text); //cmb_type.Text koşuluna göre veri tabanından kategoriyi çektik.
            Vehicle vehicle = new Vehicle(); //Araç nesnesi oluşturduk.


            if (IsValid()) // Form üzerindeki nesnelerin boş olup olmadığını kontrol ettik
            {
                // Örneklediğimiz nesnenin propertilerine Form üzerindeki nesnelerden aldığımız verileri atadık.

                vehicle.VehiclePlate = txt_plate.Text;
                vehicle.Model = txt_model.Text;
                vehicle.Brand = txt_brand.Text;
                vehicle.FuelType = txt_fuel.Text;
                vehicle.TypeID = type.ID;
                vehicle.Price = Convert.ToDouble(txt_price.Text);
                vehicle.Cost = Convert.ToDouble(txt_cost.Text);
                vehicle.StartDate = Convert.ToDateTime(dte_start.Text);
                vehicle.EndDate = Convert.ToDateTime(dte_end.Text);
                vehicle.IsSold = false;
            }



            if (vehicle != null) //Eğer form üzerindeki verilerde boşluk yoksa yani girilenlerin hepsi tamsa.
            {
                foreach (Vehicle v in vehicles) // Veri tabanından çektiğimiz tüm araçlarda foreach ile döndük.
                {
                    if (v == vehicle)
                    {
                        // Eğer böyle bir araç zaten varsa diye bir if denetimi yaptık.
                        MessageBox.Show("Girdiğiniz araç zaten sisteme kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                repoVehicle.Add(vehicle); // Repository class'ımızda ki Add methodu ile entitymizi database'e ekledik

                MessageBox.Show("Araç başarıyla sisteme eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TUMUNU_ARA();
            }
            else MessageBox.Show("Bilgilerinizi girerken boş girmiş olabilirsiniz. Lütfen tekrar kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }



        private void AddCar_Load(object sender, EventArgs e)
        {
            TUMUNU_ARA();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gridde herhangi bir satırın herhangi bir hücresine tıkladığımızda ilgili veriler nesnelere doluyor.

            txt_brand.Text = dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
            txt_cost.Text = dataGridView1.CurrentRow.Cells["Cost"].Value.ToString();
            txt_fuel.Text = dataGridView1.CurrentRow.Cells["FuelType"].Value.ToString();
            txt_model.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            txt_plate.Text = dataGridView1.CurrentRow.Cells["VehiclePlate"].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            cmb_type.Text = dataGridView1.CurrentRow.Cells["TypeId"].Value.ToString();
            dte_start.Text = dataGridView1.CurrentRow.Cells["StartDate"].Value.ToString();
            dte_end.Text = dataGridView1.CurrentRow.Cells["EndDate"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

