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
    public partial class ViewCars : Form
    {
        SqlRepository<Vehicle> repoVehicle = new SqlRepository<Vehicle>();
        public ViewCars()
        {
            InitializeComponent();
        }

        private void Update()
        {
            Vehicle vehicle = repoVehicle.GetById(Convert.ToInt32(lblid.Text));

            vehicle.Brand = txt_brand.Text;
            vehicle.Price = Convert.ToDouble(txt_price.Text);
            vehicle.Cost = Convert.ToDouble(txt_cost.Text);
            vehicle.IsSold = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsSold"].Value);
            vehicle.VehiclePlate = txt_plate.Text;
            vehicle.FuelType = cmb_fueltype.Text;
            vehicle.Model = txt_model.Text;

            repoVehicle.Update(vehicle);
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TUMUNU_ARA();
            txt_brand.Text = null;
            txt_price.Text = null;
            txt_model.Text = null;
            txt_plate.Text = null;
            txt_price.Text = null;
            cmb_fueltype.Text = null;
            cmb_status.Text = null;
            cmb_type.Text = null;
            txt_cost.Text = null;
        }
        private void SIL()
        {
            SqlConnection BaglantiAdresi = new SqlConnection();
            BaglantiAdresi.ConnectionString = "Data Source =LAPTOP-DAF3DSF2\\SQLEXPRESS; Initial Catalog = UretimProje; Integrated Security = True";
            BaglantiAdresi.Open();

            SqlCommand cmd_Ekle = new SqlCommand();
            cmd_Ekle.Connection = BaglantiAdresi;
            cmd_Ekle.CommandText = "DELETE FROM Vehicles WHERE ID = @ID";

            cmd_Ekle.Parameters.AddWithValue("@ID", Convert.ToInt32(lblid.Text));

            if (cmd_Ekle.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Silme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TUMUNU_ARA();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BaglantiAdresi.Close();
        }
        private void TUMUNU_ARA()
        {

            SqlConnection BaglantiAdresi = new SqlConnection();
            BaglantiAdresi.ConnectionString = "Data Source =LAPTOP-DAF3DSF2\\SQLEXPRESS; Initial Catalog = UretimProje; Integrated Security = True";
            BaglantiAdresi.Open();
            SqlCommand cmd = new SqlCommand("select * from Vehicles");

            cmd.Connection = BaglantiAdresi;

            DataSet ds = new DataSet("Vehicles");
            ds.Clear();
            DataTable dt = new DataTable("Vehicles");

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(dt);
            ds.Tables.Add(dt);

            dataGridView1.DataSource = ds.Tables["Vehicles"];

            BaglantiAdresi.Close();


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
                else if(dataGridView1.Rows[i].Cells[10].Value.ToString().Trim() == "3")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }

            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_brand.Text = dataGridView1.CurrentRow.Cells["Brand"].Value.ToString();
            txt_cost.Text = dataGridView1.CurrentRow.Cells["Cost"].Value.ToString();
            cmb_fueltype.Text = dataGridView1.CurrentRow.Cells["FuelType"].Value.ToString();
            txt_model.Text = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
            txt_plate.Text = dataGridView1.CurrentRow.Cells["VehiclePlate"].Value.ToString();
            txt_price.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
            cmb_type.Text = dataGridView1.CurrentRow.Cells["TypeID"].Value.ToString();
            dte_start.Text = dataGridView1.CurrentRow.Cells["StartDate"].Value.ToString();
            dte_end.Text = dataGridView1.CurrentRow.Cells["EndDate"].Value.ToString();
            cmb_status.Text = dataGridView1.CurrentRow.Cells["IsSold"].Value.ToString();
            lblid.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void ViewCars_Load(object sender, EventArgs e)
        {
            TUMUNU_ARA();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SIL();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
