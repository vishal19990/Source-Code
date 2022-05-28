using ChildCare.MonitoringSystem.Common;
using ChildCare.MonitoringSystem.Web.BackgroundWorker;
using ChildCare.MonitoringSystem.Web.Infrastructure;
using ChildCare.MonitoringSystem.Web.Middlewares;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ChildCare.MonitoringSystem.Web
{
    public class Startup
    {
        public AppSettings AppSettings { get; } = new AppSettings();

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var configRoot = new
            {
                AppSettings = new AppSettings()
            };

            this.Configuration.Bind(configRoot);

            this.AppSettings = configRoot.AppSettings;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.RegisterDependency(this.AppSettings);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddCors(action => action
               .AddPolicy("CPaaSPolicy", policy => policy
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .AllowAnyOrigin()
                   .AllowCredentials()
               ));

            services.AddSignalR();

            services.AddHttpContextAccessor();

            services.AddHostedService<LocationUpdateService>();
            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(options =>
            {
                options.LoginPath = "/Account/LogIn";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseApplicationMiddleware();

            app.UseCookiePolicy();

            app.UseEndpoints(routes =>
            {
                routes.MapControllerRoute(
                   name:  "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
             
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            AutoMapperConfig.Bootstrap();
        }
    }
}
