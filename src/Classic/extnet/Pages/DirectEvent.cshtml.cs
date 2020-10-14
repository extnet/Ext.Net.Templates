using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Ext.Net;
using Ext.Net.Core;
using System;

namespace Company.WebApplication.Pages
{
    [DirectModel]
    public class DirectEventsModel : PageModel
    {
        public void OnGet()
        {

        }

        [Direct]
        public IActionResult OnPostButtonClick()
        {
            this.X().Toast($"Server Time is { DateTime.Now.ToString("H:mm:ss tt") } 👍");

            return this.Direct();
        }
    }
}