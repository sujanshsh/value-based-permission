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

        public AuthenticationService(IJSRuntime jSRuntime)
        {
            _JSRuntime = jSRuntime;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            

            var state = new AuthenticationState(new ClaimsPrincipal());
            string userData = "";
            try
            {
                Console.WriteLine("GetAuthenticationiStateAsync");
                userData = await _JSRuntime.InvokeAsync<string>("blazor_methods.getCookie", "loginCookie");
                Console.Write(userData == "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write(userData);
            if (userData != null && userData != "")
            {
                var user = System.Text.Json.JsonSerializer.Deserialize<Models.User>(userData);
                Console.WriteLine(user.name);
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.name)
                }, "test authentication type");

                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }
    }
}