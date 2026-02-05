namespace BlazorApp1.Models
{
    public class UserRecord
    {
        public string user { get; set; } = "";      // il nome dell'utente - user name
        public string hash { get; set; } = "";      // la password viene memorizzaza con hash codificata
        public string role { get; set; } = "user";  // "user" | "admin"
    }
}
