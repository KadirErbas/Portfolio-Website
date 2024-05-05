using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolioProject.Models;
using portfolioProject.Repository;

namespace portfolioProject.Pages;

public class SkillsModel : PageModel
{
    public IEnumerable<Skills> SkillsList = new List<Skills>();
    private readonly ISkillsRepository _skillsRepository;
    public SkillsModel(ISkillsRepository SkillsRepository){
        _skillsRepository = SkillsRepository;
    }

    public void OnGet()
    {
        SkillsList = _skillsRepository.GetAll();
    }
}
