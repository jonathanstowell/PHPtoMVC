namespace PHPtoMVC.WebUI.Installers
{
    using System;
    using System.Web.Mvc;

    using Bootstrap;
    using Bootstrap.Extensions.StartupTasks;

    using Castle.Windsor;

    using PHPtoMVC.Infrastructure.MVC.Controllers.Factories;

    public class WindsorControllerFactoryStartupTask : IStartupTask
    {
        public void Run()
        {
            var controllerFactory = new WindsorControllerFactory((IWindsorContainer)Bootstrapper.Container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}