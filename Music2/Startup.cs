using Microsoft.Owin;
using Owin;
using System;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;

using Music2.Models;

[assembly: OwinStartupAttribute(typeof(Music2.Startup))]
namespace Music2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

       
    }
}
