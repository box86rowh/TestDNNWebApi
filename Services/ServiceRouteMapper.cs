﻿
using DotNetNuke.Web.Api;
using System.Web.Http;

namespace AAModules.EnhancedContactFormEnhancedContactForm.Services
{

    /// <summary>
    /// The ServiceRouteMapper tells the DNN Web API Framework what routes this module uses
    /// </summary>
    public class ServiceRouteMapper : IServiceRouteMapper
    {
        /// <summary>
        /// RegisterRoutes is used to register the module's routes
        /// </summary>
        /// <param name="mapRouteManager"></param>
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
                moduleFolderName: "EnhancedContactForm",
                routeName: "default",
                url: "{controller}/{action}/{itemId}",
                defaults: new { itemId = RouteParameter.Optional },
                namespaces: new[] { "AAModules.EnhancedContactFormEnhancedContactForm.Services" });
        }
    }

}