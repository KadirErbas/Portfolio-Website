using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace portfolioProject.Pages
{
    public class Education : PageModel
    {
        private readonly ILogger<Education> _logger;

        public Education(ILogger<Education> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}