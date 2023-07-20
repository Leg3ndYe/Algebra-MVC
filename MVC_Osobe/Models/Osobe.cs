namespace MVC_Osobe.Models
{
    public class Osobe
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godine { get; set; }
        public bool JePolaznik { get; set; } = true;
        
    }
}
