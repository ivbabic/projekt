using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mynventory.Model
{
    public class Racun
    {
        
        public int Broj { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumPlacanja { get; set; }
        public Boolean Potvrda { get; set; }

      


        public Racun(int Broj, DateTime DatumIzdavanja, DateTime DatumPlacanja, Boolean Potvrda)
        {

            
            this.Broj = Broj;
            this.DatumIzdavanja = DatumIzdavanja;
            this.DatumPlacanja = DatumPlacanja;
            this.Potvrda = Potvrda;

        }

        public Racun()
            {
            }

       

    }
}
