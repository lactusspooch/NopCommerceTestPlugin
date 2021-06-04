using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Misc.MyPlugin.Controllers
{
    [ViewComponent(Name = "MyPluginController")]
    public class MyPluginController : BasePluginController
    {
        public async Task<IActionResult> Configure()
        {
            return View("~/Plugins/MyPlugin/Views/Configure.cshtml", null);
        }
    }
}
