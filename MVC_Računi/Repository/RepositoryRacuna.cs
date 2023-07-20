using MVC_Računi.Models;
using System.Data;

namespace MVC_Računi.Repository
{
    public class RepositoryRacuna
    {
        private static List<Racun> racuni;

        public RepositoryRacuna()
        {
            if(racuni == null)
            {
                racuni = new List<Racun>();
                SimulirajBazu();
            }
        }

        private void SimulirajBazu()
        {
            //Prvi racun
            StavkaRacuna s1 = new StavkaRacuna()
            {
                Naziv = "Mlijeko",
                Kolicina = 2,
                JedinicnaCijena = 0.76m
            };
            StavkaRacuna s2 = new StavkaRacuna()
            {
                Naziv = "Banane",
                Kolicina = 2,
                JedinicnaCijena = 1.40m
            };

            Racun r1 = new Racun(0)
            {
                DatumIzdavanja = DateTime.Now
            };

            r1.Stavke.Add(s1);
            r1.Stavke.Add(s2);

            //Drugi racun
            StavkaRacuna s3 = new StavkaRacuna()
            {
                Naziv = "Lubenica",
                Kolicina = 13,
                JedinicnaCijena = 0.7m
            };
            StavkaRacuna s4 = new StavkaRacuna()
            {
                Naziv = "Sunka",
                Kolicina = 0.5m,
                JedinicnaCijena = 14m
            };
            StavkaRacuna s5 = new StavkaRacuna()
            {
                Naziv = "Sir",
                Kolicina = 0.5m,
                JedinicnaCijena = 4m
            };

            Racun r2 = new Racun(1)
            {
                DatumIzdavanja = DateTime.Now
            };

            r2.Stavke.Add(s3);
            r2.Stavke.Add(s4);
            r2.Stavke.Add(s5);

            racuni.Add(r1);
            racuni.Add(r2);
        }

        public List<Racun> DohvatiSveRacune()
        {
            return racuni;
        }

        public Racun DohvatiRacunPoBroju(int brojRacuna)
        {
            return racuni.FirstOrDefault(r => r.BrojRacuna == brojRacuna);
        }

        public void KreirajNoviRacun(Racun racun)
        {
            racuni.Add(racun);
        }

        public void ObrisiRacun(int broj_racuna)
        {
            racuni.Remove(DohvatiRacunPoBroju(broj_racuna));
        }
    }
}
