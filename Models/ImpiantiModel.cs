namespace BlazorApp1.Models
{
    public class ImpiantiRoot : Dictionary<string, UserImpianti> { }

    public class UserImpianti
    {
        public List<Impianto> impianti { get; set; } = new();
    }

    public class Impianto
    {
        public string id { get; set; } = "";
        public string nome { get; set; } = "";
        public string? indirizzo { get; set; }


        // ✅ nuovo campo per lo sfondo card
        public string? colore { get; set; } = "#e3f2fd";


        public List<MonitorItem> monitors { get; set; } = new();
    }

    public class MonitorItem
    {
        public string id { get; set; } = "";
        public string nome { get; set; } = "";
        public string tipo { get; set; } = "";
    }

}
