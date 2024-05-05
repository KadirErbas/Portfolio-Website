using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolioProject.Models;
using portfolioProject.Repository;

namespace portfolioProject.Pages;

public class EducationModel : PageModel
{
    public IEnumerable<Education> EducationList = new List<Education>();
    private readonly IEducationRepository _educationRepository;
    public EducationModel(IEducationRepository educationRepository){
        _educationRepository = educationRepository;
    }

    public void OnGet()
    {
        EducationList = _educationRepository.GetAll();
    }
}
