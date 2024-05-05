using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolioProject.Models;
using portfolioProject.Repository;

namespace portfolioProject.Pages;

public class ReferenceModel : PageModel
{
    public IEnumerable<Reference> ReferenceList = new List<Reference>();
    private readonly IReferenceRepository _referenceRepository;
    public ReferenceModel(IReferenceRepository referenceRepository){
        _referenceRepository = referenceRepository;
    }

    public void OnGet()
    {
        ReferenceList = _referenceRepository.GetAll();
    }
}
