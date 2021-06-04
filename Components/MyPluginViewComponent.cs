using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Services.Localization;
using Nop.Web.Framework.Components;


namespace Nop.Plugin.Misc.MyPlugin.Components
{
    [ViewComponent(Name = "MyPluginOrder")]
    public class MyPluginViewComponent : NopViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("~/Plugins/MyPlugin/Views/TestView.cshtml");
        }
    }
}
