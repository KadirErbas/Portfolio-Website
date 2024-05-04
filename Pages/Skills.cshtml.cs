using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace portfolioProject.Pages
{
    public class Skills : PageModel
    {
        private readonly ILogger<Skills> _logger;

        public Skills(ILogger<Skills> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}