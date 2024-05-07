using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolioProject.Models;
using portfolioProject.Repository;
namespace portfolioProject.Pages;

public class IndexModel : PageModel
{
    public IEnumerable<AboutMe> AboutMeList = new List<AboutMe>();
    public IEnumerable<Experience> ExperienceList = new List<Experience>();

    private readonly IExperienceRepository _experienceRepository;
    private readonly IAboutMeRepository _aboutMeRepository;

    public IEnumerable<Education> EducationList = new List<Education>();
    private readonly IEducationRepository _educationRepository;

    public IEnumerable<Reference> ReferenceList = new List<Reference>();
    private readonly IReferenceRepository _referenceRepository;

    public IEnumerable<Skills> SkillsList = new List<Skills>();
    private readonly ISkillsRepository _skillsRepository;
    
    public IEnumerable<Hobbies> HobbiesList = new List<Hobbies>();
    private readonly IHobbiesRepository _hobbiesRepository;

    public IEnumerable<Workflow> WorkflowList = new List<Workflow>();
    private readonly IWorkflowRepository _workflowRepository;

    public IndexModel(IAboutMeRepository aboutMeRepository, IExperienceRepository experienceRepository, IEducationRepository educationRepository,IReferenceRepository referenceRepository,ISkillsRepository SkillsRepository, IHobbiesRepository hobbiesRepository, IWorkflowRepository workflowRepository){
        _aboutMeRepository = aboutMeRepository;
        _experienceRepository = experienceRepository;
        _educationRepository = educationRepository;
        _referenceRepository = referenceRepository;
        _skillsRepository = SkillsRepository;
        _hobbiesRepository = hobbiesRepository;
        _workflowRepository = workflowRepository;
    }

    public void OnGet()
    {
        AboutMeList = _aboutMeRepository.GetAll();
        ExperienceList = _experienceRepository.GetAll();
        EducationList = _educationRepository.GetAll();
        ReferenceList = _referenceRepository.GetAll();
        SkillsList = _skillsRepository.GetAll();
        HobbiesList = _hobbiesRepository.GetAll();
        WorkflowList = _workflowRepository.GetAll();

    }


}
