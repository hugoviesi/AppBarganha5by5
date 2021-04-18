using AppBarganha.Services;
using AppBarganhaWEB.Hubs;
using AppBarganhaWEB.Middlewares;
using AppBarganhaWEB.Services;
using AppBarganhaWEB.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;

namespace AppBarganhaWEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<BarganhaDatabaseSettings>(
                Configuration.GetSection(nameof(BarganhaDatabaseSettings)));

            services.AddSingleton<IBarganhaDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<BarganhaDatabaseSettings>>().Value);

            services.AddSingleton<OfertaService>();
            services.AddSingleton<UsuarioService>();
            services.AddSingleton<PessoaFisicaService>();
            services.AddSingleton<PessoaJuridicaService>();
            services.AddSingleton<AnuncioService>();
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();

            services.AddSession(Options =>
            {
                Options.Cookie.Name = "SessionID";
                Options.IdleTimeout = TimeSpan.FromSeconds(300); //limita o tempo da sessão do usuário
            });

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Login/Index");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseMiddleware<LoginMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
