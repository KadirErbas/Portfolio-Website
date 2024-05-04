using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace portfolioProject.Pages
{
    public class Reference : PageModel
    {
        private readonly ILogger<Reference> _logger;

        public Reference(ILogger<Reference> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}