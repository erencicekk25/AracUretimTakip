using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimTakip.Entities
{
    public class User : Person
    {
        [Display(Name = "Son Giriş Tarihi")]
        public DateTime LastLoginDate { get; set; }
    }
}
