using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Misc.MyPlugin
{
    public partial class RouteProvider : IRouteProvider
    {
        public int Priority => -1;

        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
           endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PayPalStandard.PDTHandler",
                                                   "Plugins/PaymentPayPalStandard/PDTHandler",
                                                   "Plugins/Nop.Plugin.Misc.MyPlugin/Views/TestView.cshtml",
           new { controller = "PaymentPayPalStandard", action = "PDTHandler" });
        }
    }
}
