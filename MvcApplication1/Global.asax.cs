﻿using System;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MvcApplication1.Core.Interfaces;
using MvcApplication1.Data;
using MvcApplication1.Data.Repositories;
using Microsoft.Practices.Unity;

namespace MvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication //, IContainerAccessor
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PersonContext>());

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            Bootstrapper.Initialise();
        }
    }
}
