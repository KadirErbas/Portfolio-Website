using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolioProject.Models;
using portfolioProject.Repository;

namespace portfolioProject.Pages;

public class ExperienceModel : PageModel
{
    public IEnumerable<Experience> ExperienceList = new List<Experience>();
    private readonly IExperienceRepository _experienceRepository;
    public ExperienceModel(IExperienceRepository experienceRepository){
        _experienceRepository = experienceRepository;
    }

    public void OnGet()
    {
        ExperienceList = _experienceRepository.GetAll();
    }
}
