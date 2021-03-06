using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Autofac;
using A8UI.Data.Domain;
using A8UI.Data.IRepositories;
using A8UI.Data.Repositories;
using A8UI.Data.IServices;
using A8UI.Data.Services;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace A8_UI
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
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}");
            });
        }

        public ILifetimeScope AutofacContainer { get; private set; }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            // Register your own things directly with Autofac here. Don't
            // call builder.Populate(), that happens in AutofacServiceProviderFactory
            // for you.
            
            builder.RegisterType<UserRepository>().As<IUsersRepository>();
            builder.RegisterType<UsersService>().As<IUsersService>();
            builder.RegisterType<PacienteRepository>().As<IPacienteRepository>();
            builder.RegisterType<PacienteService>().As<IPacienteService>();
            //builder.RegisterType<MemberRepository>().As<IMemberRepository>();
            //builder.RegisterType<Npgsql.NpgsqlConnection>().As<IDbConnection>();
            //builder.Register(c => new Npgsql.NpgsqlConnection(Configuration.GetSection("AppConfiguration")["DBConnection"])).As<IDbConnection>();
            //builder.Register(c=> new System.Data)
            //builder.RegisterType<IConfiguration>().AsSelf();
            //builder.RegisterType<SqlConnection>().As<IDbConnection>();
            builder.Register(c => new SqlConnection(Configuration.GetSection("AppConfiguration")["DBConnection"])).As<IDbConnection>();
        }
    }
}
