﻿using ContactsManagerWebApi.App_Start;
using System.Web.Http;
using System.Web.Mvc;

namespace ContactsManagerWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            MapperInitializator.Initializate();
        }
    }
}
