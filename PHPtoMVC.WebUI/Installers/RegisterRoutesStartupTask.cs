namespace PHPtoMVC.WebUI.Installers
{
    using System;
    using System.Web.Routing;

    using Bootstrap.Extensions.StartupTasks;

    using System.Web.Mvc;
    using System.Web.Http;

    public class RegisterRoutesStartupTask : IStartupTask
    {
        public void Run()
        {
            this.RegisterDefaults();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private void RegisterDefaults()
        {
            this.RegisterMvcDefaults();
            this.RegisterApiDefaults();
        }

        private void RegisterMvcDefaults()
        {
            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            RouteTable.Routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        private void RegisterApiDefaults()
        {
            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}