namespace BlazorApp1.Models
{
    public class UserRecord
    {
        public string user { get; set; } = "";
        public string hash { get; set; } = "";
        public string role { get; set; } = "user";  // "user" | "admin"
    }
}
