using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuleCalculatorWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        //Reminder button
        public void OnPostSubmit(string name)
        {
            ViewData["Message"] = string.Format("Module: {0}.\\nDate to Start from Learning: {1}", name, DateTime.Now.ToString());
        }
    }
}
