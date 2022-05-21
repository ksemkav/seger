﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using MccSoft.AdminService.ComponentTests.Infrastructure;
using Seger.App;
using Seger.Persistence;
using MccSoft.Testing.SqliteUtils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Seger.ComponentTests.Infrastructure
{
    public class TestStartup : Startup
    {
        private readonly Guid _dbId = Guid.NewGuid();

        public TestStartup(
            IConfiguration configuration,
            IWebHostEnvironment env,
            ILogger<Startup> logger
        ) : base(configuration, env, logger) { }

        protected override void UseHangfire(IApplicationBuilder app) { }

        protected override void RunMigration(IApplicationBuilder container)
        {
            if (Configuration.GetValue<bool>("DisableSeed"))
                return;

            base.RunMigration(container);
        }

        protected override void UseSignOutLockedUser(IApplicationBuilder app) { }

        protected override void ConfigureAuth(IServiceCollection services)
        {
            base.ConfigureAuth(services);

            services
                .AddAuthentication(
                    options =>
                    {
                        options.DefaultAuthenticateScheme = TestAuthenticationOptions.Scheme;
                        options.DefaultChallengeScheme = TestAuthenticationOptions.Scheme;
                    }
                )
                .AddTestAuthentication(options => { });
        }

        protected override void ConfigureDatabase(IServiceCollection services) { }
    }
}
