using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portfolioProject.Repository;
using portfolioProject.Models;


namespace portfolioProject.Pages.Admins;

public class IndexModel : PageModel
{

    public IEnumerable<Admin> AdminList = new List<Admin>();
    private readonly IAdminRepository _adminRepository;
    public IndexModel(IAdminRepository adminRepository){
        _adminRepository = adminRepository;
    }

    public void OnGet()
    {

        AdminList= _adminRepository.GetAll();
    }
}
