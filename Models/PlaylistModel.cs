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
        public string nome { get; set; } = "";
        public List<PlaylistItem> items { get; set; } = new();
    }

    public class PlaylistItem
    {
        public string tipo { get; set; } = "";   // "video" o "image"
        public string path { get; set; } = "";   // relativo a /web/
        public int durata { get; set; } = 5;     // solo per immagini
    }
}