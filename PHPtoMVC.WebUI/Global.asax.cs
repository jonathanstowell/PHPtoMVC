﻿using System.Web.Mvc;
using Bootstrap;
using Bootstrap.Extensions.StartupTasks;
using Bootstrap.Windsor;

namespace PHPtoMVC.WebUI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Bootstrapper.With.Windsor().And.StartupTasks()
                .Start();

            AreaRegistration.RegisterAllAreas();
        }
    }
}