
using Microsoft.JSInterop;
using System.Text.RegularExpressions;

namespace BlazorApp1.Models
{
    public class GlobalService
    {

        public string ProxyBase = "https://first.marcomaria-zora.workers.dev/api/dav/UPLOADS/";
        public string UsersFileName = "users.json";
        public string InstallationFileName = "impianti.json";
        public string PlaylistsFileName = "playlists.json";
        public string User = "?";
        public string Role = "?";


        private readonly IJSRuntime JS;

        public GlobalService(IJSRuntime js) => JS = js;

        public async Task<string?> LoggedUser() 
        {            
            return  User = await JS.InvokeAsync<string>("sessionStorage.getItem", "loggedUser");
        }
        public async Task<string?> LoggedRole()
        {
            return Role = await JS.InvokeAsync<string>("sessionStorage.getItem", "loggedRole");
        }
        public async Task LoggedUser(string user)
        {           
            await JS.InvokeVoidAsync("sessionStorage.setItem", "loggedUser", user);
            User = user;
        }
        public async Task LoggedRole(string role)
        {
            await JS.InvokeVoidAsync("sessionStorage.setItem", "loggedRole", role);
            Role = role;
        }

        public string Sha256(string input)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
            return Convert.ToHexString(bytes).ToLowerInvariant();
        }
    }
}
