using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UretimTakip.Entities
{
    public abstract class Person
    {
        private string _password;

        [Key]
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string UserName { get; set; }
        public string Password {
            get { return _password; } 
            set {
                if(value.Length > 8)
                    _password = value;
                else MessageBox.Show("Şifreniz en az 8 karakterli olmalıdır!");
            } 
        }
    }
}
