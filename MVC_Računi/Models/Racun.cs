using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace MVC_Računi.Models
{
    public class Racun
    {
        [DisplayName("Broj racuna")]
        public int BrojRacuna { get; set; }

        [DisplayName("Datum izdavanja")]
        public DateTime DatumIzdavanja { get; set; }

        public List<StavkaRacuna> Stavke { get; set; }

        public Racun()
        {
            Stavke = new List<StavkaRacuna>();
        }
        public Racun(int zadnji_izdani_broj)
        {
            BrojRacuna = zadnji_izdani_broj + 1;
            Stavke = new List<StavkaRacuna>();
        }

        public decimal Ukupno()
        {
            decimal ukupno = 0;
            foreach(var item in Stavke)
            {
                ukupno += item.UkupnaCijena();
            }
            return ukupno;
        }


    }
}
