using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Nop.Services.Cms;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.MyPlugin
{
    public class MyPluginWidget : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false;

        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>к
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "MyPluginWidget";
            routeValues = new RouteValueDictionary { { "Namespaces", "Nop.Plugin.Misc.MyPlugin.Controllers" }, { "area", null } };
        }

        /// <summary>
        /// Gets a route for displaying widget
        /// </summary>
        /// <param name="widgetZone">Widget zone where it's displayed</param>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetDisplayWidgetRoute(string widgetZone, out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "PublicInfo";
            controllerName = "PaymentMethodController";
            routeValues = new RouteValueDictionary
            {
                {"Namespaces", "Nop.Plugin.Misc.MyPlugin.Controllers"},
                {"area", null},
                {"widgetZone", widgetZone}
            };
        }

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "MyPluginWidget";
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string> { "home_page_before_categories" });
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }
    }
}
