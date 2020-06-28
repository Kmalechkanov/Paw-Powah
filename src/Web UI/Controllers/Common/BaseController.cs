﻿namespace Paw_Powah.Controllers.Common
{
    using Domain.Identity;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;

    public class BaseController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        protected UserManager<AppUser> UserManager => this.userManager ??= this.HttpContext.RequestServices.GetService<UserManager<AppUser>>();

        protected SignInManager<AppUser> SignInManager => this.signInManager ??= this.HttpContext.RequestServices.GetService<SignInManager<AppUser>>();
    }
}
