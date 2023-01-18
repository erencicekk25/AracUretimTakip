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
    public partial class MainMenu : Form
    {
        SqlRepository<Vehicle> repoVehicle = new SqlRepository<Vehicle>();
        SqlRepository<User> repoUser = new SqlRepository<User>();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_viewcars_Click(object sender, EventArgs e)
        {
            Form viewcars = new ViewCars();
            viewcars.ShowDialog();
        }

        private void Btn_addcar_Click(object sender, EventArgs e)
        {
            Form addcar = new AddCar();
            addcar.ShowDialog();
        }

        private void Btn_usersettings_Click(object sender, EventArgs e)
        {
            Form usersettings = new UserSettings();
            usersettings.ShowDialog();
        }

        private void Btn_adminsettings_Click(object sender, EventArgs e)
        {
            Form adminsettings = new AdminSettings();
            adminsettings.ShowDialog();
        }



        private void lbl_TotalProduced_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TotalProduced_Click_1(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void lbl_TodayProduced_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            IEnumerable<Vehicle> vehicles = repoVehicle.GetAll();
            IEnumerable<Vehicle> vehicles2 = repoVehicle.GetAll(x => x.IsSold == true);
            IEnumerable<User> users = repoUser.GetAll();

            double totalAmount = 0;
            foreach (Vehicle vehicle in vehicles2)
            {
                totalAmount += vehicle.Price;
            }
            lbl_Price.Text = totalAmount.ToString() + " TL";

            double total = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                total += vehicle.Cost;
            }
            lbl_Cost.Text = total.ToString() + " TL";

            lbl_TotalProduced.Text = vehicles.Count().ToString();
            lbl_Users.Text = users.Count().ToString();
        }
    }
}
