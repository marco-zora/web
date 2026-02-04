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

        [JsonPropertyName("nome")]
        public string Nome { get; set; } = "";

        // Nel codice userai .Items; nel JSON la chiave sarà "items"
        [JsonPropertyName("items")]
        public List<PlaylistItem> Items { get; set; } = new();
    }

    public class PlaylistItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        // "video" | "image"
        [JsonPropertyName("tipo")]
        public string Tipo { get; set; } = "video";

        // URL o path all’asset (per ora placeholder)
        [JsonPropertyName("url")]
        public string Url { get; set; } = "";

        // Durata in secondi (per immagini); per video puoi lasciarlo 0
        [JsonPropertyName("durata")]
        public int Durata { get; set; } = 10;
    }
}