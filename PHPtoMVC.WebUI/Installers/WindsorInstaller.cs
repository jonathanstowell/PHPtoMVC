namespace PHPtoMVC.WebUI.Installers
{
    using System.Web.Mvc;

    using Bootstrap.Windsor;

    using Castle.Core;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    public class WindsorInstaller : IWindsorRegistration
    {
        public void Register(IWindsorContainer container)
        {
            container.Register(
                AllTypes.FromThisAssembly().BasedOn<IController>().Configure(
                    component =>
                    {
                        component.Named(component.Implementation.Name);
                        component.LifeStyle.Is(LifestyleType.Transient);
                    }).WithService.Base());
        }
    }
}