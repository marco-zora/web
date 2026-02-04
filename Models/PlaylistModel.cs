namespace BlazorApp1.Models
{
    public class PlaylistsRoot : Dictionary<string, UserPlaylists> { }

    public class UserPlaylists
    {
        public List<Playlist> playlists { get; set; } = new();
    }

    public class Playlist
    {
        public string id { get; set; } = "";
        public string name { get; set; } = "";
        public string? description { get; set; }
        public bool loop { get; set; } = true;
        public double defaultDuration { get; set; } = 10; // secondi per immagini (fallback)
        public DateTimeOffset updatedAt { get; set; } = DateTimeOffset.UtcNow;
        public List<PlaylistItem> items { get; set; } = new();
    }

    public class PlaylistItem
    {
        public string id { get; set; } = "";
        public string type { get; set; } = "";              // "video" | "image"
        public string name { get; set; } = "";
        public string path { get; set; } = "";              // relativo al worker (UPLOADS/<user>/...)
        public string contentType { get; set; } = "";

        public string startTime { get; set; } = ""; // HH:mm
        public double duration { get; set; } = 10;          // immagini: durata; video: opz., se 0 usa durata reale
    }






}
