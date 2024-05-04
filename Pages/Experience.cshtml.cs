using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace portfolioProject.Pages
{
    public class Experience : PageModel
    {
        private readonly ILogger<Experience> _logger;

        public Experience(ILogger<Experience> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}