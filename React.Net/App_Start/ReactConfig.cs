using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(React.Net.ReactConfig), "Configure")]

namespace React.Net
{
	public static class ReactConfig
	{
		public static void Configure()
		{

   
            // Forces files to be combined and minified in debug mode
            // Only used here to demonstrate how combination/minification works
            // Normally you would use unminified versions in debug mode.
            //BundleTable.EnableOptimizations = true;

            // If you want to use server-side rendering of React components, 
            // add all the necessary JavaScript files here. This includes 
            // your components as well as all of their dependencies.
            // See http://reactjs.net/ for more information. Example:
            ReactSiteConfiguration.Configuration
              .AddScript("~/src/showdown.min.js")
              .AddScript("~/src/index.jsx");

            //	.AddScript("~/Scripts/Second.jsx");

            // If you use an external build too (for example, Babel, Webpack,
            // Browserify or Gulp), you can improve performance by disabling 
            // ReactJS.NET's version of Babel and loading the pre-transpiled 
            // scripts. Example:
            //ReactSiteConfiguration.Configuration
            //	.SetLoadBabel(false)
            //	.AddScriptWithoutTransform("~/Scripts/bundle.server.js")
        }
	}
}