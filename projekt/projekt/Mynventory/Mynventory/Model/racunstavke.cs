using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynventory.Model
{
    public class RacunStavke
    {
        
        public int BrojRacuna { get; set; }
        public string NazivProizvoda { get; set; }
        public decimal Kolicina { get; set; }
        public double Cijena { get; set; }


        public RacunStavke(int BrojRacuna, string NazivProizvoda, decimal Kolicina, double Cijena)
        {

            
            this.BrojRacuna = BrojRacuna;
            this.NazivProizvoda = NazivProizvoda;
            this.Kolicina = Kolicina;
            this.Cijena = Cijena;
            

        }

        public RacunStavke()
        {
        }

   


        


    }
}



