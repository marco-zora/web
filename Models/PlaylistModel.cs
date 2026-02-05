using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    /// <summary>
    /// Dizionario: user -> raccolta playlist di quell'utente
    /// Esempio JSON:
    /// { "marco": { "playlists": [ { "id":"...", "nome":"...", "items":[...] } ] } }
    /// </summary>
    public class PlaylistsRoot : Dictionary<string, UserPlaylists> { }

    public class UserPlaylists
    {
        [JsonPropertyName("playlists")]
        public List<Playlist> Playlists { get; set; } = new();
    }

    public class Playlist
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        // Nel codice userai .Items; nel JSON la chiave sarà "items"
        [JsonPropertyName("items")]
        public List<PlaylistItem> Items { get; set; } = new();
    }


    // forse non PlaylistItem NON serve 
    public class PlaylistItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        // "video" | "image"
        [JsonPropertyName("type")]
        public string Type { get; set; } = "video";

        // URL o path all’asset (per ora placeholder)
        [JsonPropertyName("url")]
        public string Url { get; set; } = "";

        // Durata in secondi (per immagini); per video puoi lasciarlo 0
        [JsonPropertyName("duration")]
        public int Duration { get; set; } = 10;
    }


    public class MediaItem
    {
        public string id { get; set; } = "";
        public string type { get; set; } = "";     // "image" | "video"
        public string path { get; set; } = "";     // URL media
        public double start { get; set; } = 0;     // seconds
        public double duration { get; set; } = 5;  // seconds
    }
}