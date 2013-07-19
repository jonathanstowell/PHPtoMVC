namespace PHPtoMVC.WebUI.Installers
{
    using Bootstrap.Extensions.StartupTasks;

    using System.Web.Optimization;

    using BundleTransformer.Core.Orderers;
    using BundleTransformer.Core.Transformers;

    public class BundleStartupTask : IStartupTask
    {
        public void Run()
        {
            var bundles = BundleTable.Bundles;

            var cssTransformer = new CssTransformer();
            var jsTransformer = new JsTransformer();
            var nullOrderer = new NullOrderer();

            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                        "~/js/libs/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/js/all").Include(
                        "~/js/libs/bootstrap.js",
                        "~/js/libs/knockout-2.1.0.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/js/modernizr").Include(
                        "~/js/libs/modernizr-*"));

            var bootstrapBundle = new Bundle("~/css/bootstrap")
                .Include("~/css/less/libs/bootstrap/bootstrap.less",
                         "~/css/less/libs/bootstrap/responsive.less");

            bootstrapBundle.Transforms.Add(cssTransformer);
            bootstrapBundle.Orderer = nullOrderer;

            bundles.Add(bootstrapBundle);

            var styleBundle = new Bundle("~/css/styles")
                .Include("~/css/less/mylibs/site.less",
                         "~/css/less/mylibs/site-responsive.less",
                         "~/css/less/plugins/registration.less");

            styleBundle.Transforms.Add(cssTransformer);
            styleBundle.Orderer = nullOrderer;

            bundles.Add(styleBundle);

            bundles.Add(new StyleBundle("~/css/fontawesome")
                .Include("~/css/font-awesome.css"));
        }

        public void Reset()
        {
        }
    }
}