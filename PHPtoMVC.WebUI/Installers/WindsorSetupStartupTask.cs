namespace PHPtoMVC.WebUI.Installers
{
    using System;

    using Bootstrap;
    using Bootstrap.Extensions.StartupTasks;

    using Castle.MicroKernel.Resolvers.SpecializedResolvers;
    using Castle.Windsor;

    using PHPtoMVC.Infrastructure.Windsor;

    public class WindsorSetupStartupTask : IStartupTask
    {
        public void Run()
        {
            ((IWindsorContainer)Bootstrapper.Container).Kernel.Resolver.AddSubResolver(new CollectionResolver(((IWindsorContainer)Bootstrapper.Container).Kernel, true));
            ((IWindsorContainer)Bootstrapper.Container).Kernel.Resolver.AddSubResolver(new AutoFactoryResolver(((IWindsorContainer)Bootstrapper.Container).Kernel));
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}