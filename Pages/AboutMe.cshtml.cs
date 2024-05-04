using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using portfolioProject.Repository;


namespace portfolioProject.Pages
{
    public class AboutMe : PageModel
    {
        public IEnumerable<Models.AboutMe> aboutMeList = new List<Models.AboutMe>();
        private readonly IAboutMeRepository _aboutMeRepository;

        public AboutMe(IAboutMeRepository aboutMeRepository){
            _aboutMeRepository = aboutMeRepository;
        }
        
        public void OnGet()
        {
            aboutMeList = _aboutMeRepository.GetAll();
        }
    }
}