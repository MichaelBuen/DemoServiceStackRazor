//The entire C# code for the stand-alone RazorRockstars demo.
namespace ﻿BillionaireServiceStackRazorSelfHosting
{
    public class AppHost : ServiceStack.WebHost.Endpoints.AppHostHttpListenerBase
    {

        public AppHost() : base("Test Razor", typeof(AppHost).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            // ServiceStack.Logging.LogManager.LogFactory = new ServiceStack.Logging.Support.Logging.ConsoleLogFactory();

            Plugins.Add(new ServiceStack.Razor.RazorFormat());
			// Plugins.Add(new ServiceStack.WebHost.Endpoints.Formats.HtmlFormat());


            Routes.Add<Rockstars>("/rockstars");

            SetConfig(new ServiceStack.WebHost.Endpoints.EndpointHostConfig
            {
                CustomHttpHandlers = {
                    { System.Net.HttpStatusCode.NotFound, new ServiceStack.Razor.RazorHandler("/notfound") },
                }
				,DebugMode = true
            });
        }
    }
}

