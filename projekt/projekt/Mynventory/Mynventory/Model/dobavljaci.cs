using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynventory.Model
{
    public class Dobavljaci
    {
        public string Naziv { get; set; }
        public Int32 Telefon {get; set; }
        public string Email { get; set; }
        public string Adresa {get; set; }
        public string Oib { get; set; }

        public Dobavljaci(string Naziv, Int32 Telefon, string Email, string Adresa, string Oib)
        {
            this.Naziv = Naziv;
            this.Telefon = Telefon;
            this.Email = Email;
            this.Adresa = Adresa;
            this.Oib = Oib;
        }

        public Dobavljaci()
        {
        }

    }
}
