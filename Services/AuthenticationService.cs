using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Infrastructure;


namespace AccessControlAdmin.Services
{
    public class AuthenticationService : AuthenticationStateProvider
    {
        public static bool isLoggedIn { get; set; } = false;

        public static Models.User user { get; set; } = new Models.User();

        
        private readonly IJSRuntime _JSRuntime;

        private readonly NavigationManager _NavigationManager;

        public AuthenticationService(IJSRuntime jSRuntime, NavigationManager navigationManager)
        {
            _JSRuntime = jSRuntime;
            _NavigationManager = navigationManager;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            

            var state = new AuthenticationState(new ClaimsPrincipal());
            var userData = "";
            try
            {
                Console.WriteLine("Reading cookie data...");
                userData = await _JSRuntime.InvokeAsync<string>("blazor_methods.getCookie", "loginCookie");
                Console.WriteLine(userData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            if (userData != null && userData != "")
            {
                var user = System.Text.Json.JsonSerializer.Deserialize<Models.User>(userData);
                Console.WriteLine(user.name);
                Console.WriteLine(user.role);
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.name)
                }, "test authentication type");
                identity.AddClaim(new Claim(ClaimTypes.Role, user.role));
                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }
            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;
        }
    }
}