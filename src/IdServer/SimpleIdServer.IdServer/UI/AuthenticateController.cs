﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using MassTransit;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SimpleIdServer.IdServer.Helpers;
using SimpleIdServer.IdServer.Jwt;
using SimpleIdServer.IdServer.Options;
using SimpleIdServer.IdServer.Store;
using SimpleIdServer.IdServer.UI.Services;
using SimpleIdServer.IdServer.UI.ViewModels;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.IdServer.UI
{
    [Area(Constants.Areas.Password)]
    public class AuthenticateController : BaseAuthenticationMethodController<AuthenticatePasswordViewModel>
    {
        public AuthenticateController(
            IPasswordAuthenticationService userAuthenticationService, 
            IAuthenticationSchemeProvider authenticationSchemeProvider,
            IOptions<IdServerHostOptions> options,
            IDataProtectionProvider dataProtectionProvider,
            ITokenRepository tokenRepository,
            IJwtBuilder jwtBuilder,
            IAuthenticationHelper authenticationHelper, 
            IClientRepository clientRepository, 
            IAmrHelper amrHelper, 
            IUserRepository userRepository,
            IUserSessionResitory userSessionRepository,
            IUserTransformer userTransformer,
            IBusControl busControl) : base(options, authenticationSchemeProvider, userAuthenticationService, dataProtectionProvider, tokenRepository, jwtBuilder, authenticationHelper, clientRepository, amrHelper, userRepository, userSessionRepository, userTransformer, busControl)
        {
        }

        protected override string Amr => Constants.Areas.Password;

        protected override bool IsExternalIdProvidersDisplayed => true;

        #region Send password reset link

        [HttpGet]
        public IActionResult SendPasswordReset([FromRoute] string prefix)
        {
            // If the user is authenticated then display a message.
            // If the user is not authenticated the display an another message.
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendPasswordReset([FromRoute] string prefix, SendPasswordResetViewModel viewModel)
        {
            return null;
        }

        #endregion

        #region Reset the password

        [HttpGet]
        public IActionResult Reset([FromRoute] string prefix, string resetCode)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reset([FromRoute] string prefix, ResetPasswordViewModel viewModel)
        {
            return null;
        }

        #endregion

        protected override Task<UserAuthenticationResult> CustomAuthenticate(string prefix, string authenticatedUserId, AuthenticatePasswordViewModel viewModel, CancellationToken cancellationToken)
        {
            return Task.FromResult(UserAuthenticationResult.Ok());
        }

        protected override bool TryGetLogin(AmrAuthInfo amrInfo, out string login)
        {
            login = amrInfo.Login;
            return true;
        }

        protected override void EnrichViewModel(AuthenticatePasswordViewModel viewModel)
        {

        }
    }
}
