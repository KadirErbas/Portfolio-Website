using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolioProject.Models;
using portfolioProject.Repository;

namespace portfolioProject.Pages;

public class AboutMeModel : PageModel
{
    public IEnumerable<AboutMe> AboutMeList = new List<AboutMe>();
    private readonly IAboutMeRepository _aboutMeRepository;
    public AboutMeModel(IAboutMeRepository aboutMeRepository){
        _aboutMeRepository = aboutMeRepository;
    }

    public void OnGet()
    {
        AboutMeList = _aboutMeRepository.GetAll();
    }
}
