namespace Programmierer.Models
{
    public enum Geschlecht
    {
        Männlich,
        Weiblich,
        
    }
    public class Programmer
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public Geschlecht Geschlecht { get; set; }
        public List<string> Aufgaben { get; set; }
        public List<string> Projekte { get; set;}

        public Programmer()
        {
            Aufgaben = new List<string>();
            Projekte = new List<string>();
        }

        
        
    }

}
