using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Ext.Net;
using Ext.Net.Core;
using MojeeIO;

using Company.MvcApplication.Models;

namespace Company.MvcApplication.Controllers
{
    public class DirectEventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ButtonClick()
        {
            var msg = $"Server Time is { DateTime.Now.ToString("H:mm:ss tt") } :+1:";

            this.X().Toast(Mojee.Replace(msg));

            return this.Direct();
        }
    }
}