﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.WebUtilities;
using MudCowV2.Models.SignInEntities;
using MudCowV2.Services.AuthServices;

namespace MudCowV2.Components.Pages.Account
{
    public partial class Login : ComponentBase
    {
        [Inject] private NavigationManager NavigationManager { get; set; }
        [Inject] private IAuthService AuthService { get; set; }
        [Inject] private IAuthDataService AuthDataService { get; set; }

        protected SignInModel loginModel = new();

        protected string DisplayError { get; set; } = "none;";
        public bool showPassword { get; set; }
        public string? passwordType { get; set; }
        public string errorMessage { get; set; }
        protected InputText? inputTextFocus;
        string returnUrl;

        protected override void OnInitialized()
        {
            passwordType = "password";
            showPassword = false;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //Parse the query string for the return URL, so we can go there after login
            if (string.IsNullOrEmpty(returnUrl))
            {
                var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
                if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("returnUrl", out var url))
                {
                    returnUrl = url;
                }
            }

            //A hard reset was performed or the session was lost, try to restore the state and redirect back to the returnUrl
            if (firstRender && !AuthService.IsLoggedIn)
            {
                var restoredFromState = await AuthService.GetStateFromTokenAsync();
                if (restoredFromState)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        NavigationManager.NavigateTo(returnUrl);
                        returnUrl = string.Empty;
                    }
                }
            }
        }

        protected void HandlePassword()
        {
            if (showPassword)
            {
                passwordType = "password";
                showPassword = false;
            }
            else
            {
                passwordType = "text";
                showPassword = true;
            }
        }

        protected async Task HandleLogin()
        {
            var loginResult = AuthDataService.Login(loginModel.Email, loginModel.Password);

            if (!loginResult.Success)
            {
                errorMessage = loginResult.Message;
                DisplayError = "block;";

                if (inputTextFocus?.Element != null)
                {
                    await inputTextFocus.Element.Value.FocusAsync();
                }
            }
            else
            {
                await AuthService.Login(loginResult.Data);

                if (!string.IsNullOrEmpty(returnUrl))
                {
                    // Verwende forceLoad: true, um einen vollständigen Seiten-Reload zu erzwingen
                    // Dies verhindert Probleme mit dem Blazor-Circuit nach dem Login
                    NavigationManager.NavigateTo(returnUrl, forceLoad: true);
                    returnUrl = string.Empty;
                }
                else
                {
                    // Verwende forceLoad: true, um einen vollständigen Seiten-Reload zu erzwingen
                    NavigationManager.NavigateTo("/", forceLoad: true);
                }
            }
        }
    }
}
