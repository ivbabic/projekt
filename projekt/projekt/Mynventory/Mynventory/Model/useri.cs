using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynventory.Model
{
    public class Useri
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Rola { get; set; }
        public Int32 Tel { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Useri(string Ime, string Prezime, string Rola, Int32 Tel, string Email, string Password)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Rola = Rola;
            this.Tel = Tel;
            this.Email = Email;
            this.Password = Password;
        }

        public Useri()
        {
        }
    }
}
