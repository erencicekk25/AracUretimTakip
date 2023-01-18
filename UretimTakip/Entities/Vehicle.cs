using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimTakip.Entities
{
    public class Vehicle
    {
        [Key]
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Cost { get; set; } //maliyet
        public double Price { get; set; }
        public bool IsSold { get; set; }
        public string VehiclePlate { get; set; } //plaka


        public int TypeID { get; set; }
        public Type? Type { get; set; }
    }
}
