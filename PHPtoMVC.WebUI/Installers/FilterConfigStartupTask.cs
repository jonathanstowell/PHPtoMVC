namespace PHPtoMVC.WebUI.Installers
{
    using System.Web.Mvc;

    using Bootstrap.Extensions.StartupTasks;

    public class FilterConfigStartupTask : IStartupTask
    {
        public void Run()
        {
            GlobalFilters.Filters.Add(new HandleErrorAttribute());
        }

        public void Reset()
        {
        }
    }
}