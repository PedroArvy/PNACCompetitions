using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;
using Competitions.Entities;
using System;

namespace PNACCompetitions
{
  public class Startup
  {
    #region *********************** Constants ************************
    #endregion


    #region *********************** Fields ***************************
    #endregion


    #region *********************** Properties ***********************

    public IConfiguration Configuration { get; set; }

    #endregion


    #region *********************** Initialisation *******************

    public Startup()
    {
      var builder = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json");

      Configuration = builder.Build();
    }

    #endregion


    #region *********************** Methods **************************


    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();

      services.AddEntityFramework()
        .AddSqlServer()
        .AddDbContext<CompetitionDbContext>(options => options.UseSqlServer(Configuration["database:connection"]));

      services.AddInstance<CompetitionDbContext>(services.BuildServiceProvider().GetService<CompetitionDbContext>());
    }



    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.UseIISPlatformHandler();

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        //...
      }

      app.UseRuntimeInfoPage();
      app.UseDefaultFiles();
      app.UseStaticFiles();

      app.UseMvc(ConfigureRoute);

      //app.Run(async (context) =>
      //{
      //  await context.Response.WriteAsync("Hello World!");
      //});
    }


    private void ConfigureRoute(IRouteBuilder routeBuilder)
    {
      routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
    }



    // Entry point for the application.
    public static void Main(string[] args) => WebApplication.Run<Startup>(args);

    #endregion


    #region *********************** Interfaces ***********************
    #endregion

  }
}
