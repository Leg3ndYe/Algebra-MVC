namespace MVC_Računi.Models
{
    public class StavkaRacuna
    {
        public string Naziv { get; set; }
        public decimal Kolicina { get; set; }
        public decimal JedinicnaCijena { get; set; }
        public decimal UkupnaCijena() { 
            return Kolicina * JedinicnaCijena;
        }
    }
}
