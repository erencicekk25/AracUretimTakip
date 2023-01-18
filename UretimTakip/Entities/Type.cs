using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimTakip.Entities
{
    public class Type
    {
        public int ID { get; set; }
        public string TypeName { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
