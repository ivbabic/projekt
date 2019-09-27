using System;

namespace Mynventory.Model
{
    public class Proizvodi
    {

        
        public string Naziv { get; set; }
        public string MjernaJedinica { get; set; }
        public double Cijena { get; set; }
        public decimal Kolicina { get; set; }
        public decimal PoreznaStopa { get; set; }
        public DateTime DatumZadnjeProdaje { get; set; }
        public Int32 Dobavljac { get; set; }


        public Proizvodi(string Naziv, string MjernaJedinica, double Cijena, decimal Kolicina, decimal PoreznaStopa, DateTime DatumZadnjeProdaje, Int32 Dobavljac)
        {
            
            this.Naziv = Naziv;
            this.MjernaJedinica = MjernaJedinica;
            this.Cijena = Cijena;
            this.Kolicina = Kolicina;
            this.PoreznaStopa = PoreznaStopa;
            this.DatumZadnjeProdaje = DatumZadnjeProdaje;
            this.Dobavljac = Dobavljac;
        }

        public Proizvodi()
        {
        }

    }

   
}
