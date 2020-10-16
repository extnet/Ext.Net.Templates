using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Ext.Net;
using Ext.Net.Core;

using Company.MvcApplication.Models;

namespace Company.MvcApplication.Controllers
{
    public class GridPanelController : Controller
    {
        public IActionResult Index()
        {
            return View(new GridPanelModel());
        }
    }
}