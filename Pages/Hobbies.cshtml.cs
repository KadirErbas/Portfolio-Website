using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolioProject.Models;
using portfolioProject.Repository;

namespace portfolioProject.Pages;

public class HobbiesModel : PageModel
{
    public IEnumerable<Hobbies> HobbiesList = new List<Hobbies>();
    private readonly IHobbiesRepository _hobbiesRepository;
    public HobbiesModel(IHobbiesRepository hobbiesRepository){
        _hobbiesRepository = hobbiesRepository;
    }

    public void OnGet()
    {
        HobbiesList = _hobbiesRepository.GetAll();
    }
}
