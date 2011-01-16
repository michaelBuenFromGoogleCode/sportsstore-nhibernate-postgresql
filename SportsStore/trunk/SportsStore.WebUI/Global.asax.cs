using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes (RouteCollection routes)
		{
			routes.IgnoreRoute ("{resource}.axd/{*pathInfo}");
			
			routes.MapRoute ("Default", "{controller}/{action}/{id}", 
			                 
			                 new { controller = "Products", 
								action = "List", id = UrlParameter.Optional });
			 
		}

		protected void Application_Start ()
		{
			
			AreaRegistration.RegisterAllAreas();
			
			RegisterRoutes (RouteTable.Routes);
			
			ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
		}
	}
}

