using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Ext.Net;
using Ext.Net.Core;

namespace Company.WebApplication.Pages
{
    public class DirectEventsModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPostButtonClick()
        {
            this.X().Toast($"Server Time is { DateTime.Now.ToString("H:mm:ss tt") } 👍");

            return this.Direct();
        }
    }
}