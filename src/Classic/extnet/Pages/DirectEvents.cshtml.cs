using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Ext.Net;
using Ext.Net.Core;

namespace test.Pages
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
            this.X().Toast("Button Clicked 👍");

            return this.Direct();
        }
    }
}